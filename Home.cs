using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BUDGY_2._0.Expenses;
using static SkiaSharp.HarfBuzz.SKShaper;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using LiveChartsCore.Defaults;

namespace BUDGY_2._0
{
    public partial class Home : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        decimal totalExpense;



        private int userID = GlobalVariables.UserID;


        public Home()
        {
            InitializeComponent();
            pnlBudget.Paint += Panel_Paint;
            pnlSavings.Paint += Panel_Paint;
            pnlExpenses.Paint += Panel_Paint;
            LoadHome();
            Savings savings = new Savings();
            savings.loadSavings();
        }
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Get the rectangle representing the bounds of the panel
                Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);

                // Set the radius for rounded corners based on the panel's size
                int radius = Math.Min(panel.Width, panel.Height) / 4; // Adjust the divisor for different corner roundness

                // Create a graphics path for rounded cornersl
                GraphicsPath path = new GraphicsPath();
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                // Apply the graphics path to the panel's region
                panel.Region = new Region(path);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void LoadHome()
        {
            GetTotalExpenses();
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string queryBudget = "SELECT Budget FROM Budget WHERE ID = @UserID";
            string querySavings = "SELECT Savings FROM Savings WHERE ID = @UserID";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(queryBudget, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    object result = command.ExecuteScalar();
                    decimal totalBudget = result != DBNull.Value ? Convert.ToDecimal(result) : 0;//will return 0 if the result is null
                    totalBudget = Convert.ToDecimal(result);
                    GlobalVariables.RemBudget = totalBudget - totalExpense;
                    //For the remBudgett
                    lblRemBudget.Text = GlobalVariables.RemBudget.ToString("C");

                    //for the Budget
                    if (result != null)
                    {
                        lblBudget.Text = Convert.ToDecimal(result).ToString("C");
                    }
                    else
                    {
                        lblBudget.Text = "₱ 0";
                    }

                }

                using (OleDbCommand command = new OleDbCommand(querySavings, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    object result = command.ExecuteScalar();
                    //for the Savings
                    if (result != null)
                    {
                        lblSavings.Text = Convert.ToDecimal(result).ToString("C");
                    }
                    else
                    {
                        lblSavings.Text = "₱ 0";
                    }
                }

                connection.Close();
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pieChart1_Load(object sender, EventArgs e)
        {
            List<Expense> expenses = GetExpenses();

            PieSeries<double>[] pieSeriesArray;

            // Check if there are expenses
            if (expenses.Count > 0)
            {
                pieSeriesArray = new PieSeries<double>[expenses.Count];

                // Populate the PieSeries array with data from expenses
                for (int i = 0; i < expenses.Count; i++)
                {
                    int currentIndex = i;

                    pieSeriesArray[i] = new PieSeries<double>
                    {
                        Name = expenses[currentIndex].Name, // Set the expense name as the series title
                        Values = new double[] { (double)expenses[currentIndex].Price }, // Set the expense price as the series value
                        DataLabelsPaint = new SolidColorPaint(SKColors.GhostWhite),
                        DataLabelsSize = 20,
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsFormatter = point => expenses[currentIndex].Name
                    };
                }
            }
            else
            {
                // Create a placeholder PieSeries indicating "No expenses yet"
                pieSeriesArray = new PieSeries<double>[1];
                pieSeriesArray[0] = new PieSeries<double>
                {
                    Name = "No expenses yet",
                    Values = new double[] { 1 }, // Placeholder value
                    DataLabelsPaint = new SolidColorPaint(SKColors.GhostWhite),
                    DataLabelsSize = 20,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.ChartCenter,
                    DataLabelsFormatter = point => "No Expenses Yet"
                };
            }

            // Assign the PieSeries array to the pie chart series
            pieChart1.Series = pieSeriesArray;

        }

        private void GetTotalExpenses()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "SELECT ExpensesPrice FROM CurrentExpenses WHERE ID = @ID";

            int userID = GlobalVariables.UserID; // Assuming you have a global variable to store the logged-in user's ID

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", userID); // Add the parameter for the user's ID
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        decimal expensePrice = reader.GetDecimal(0); // Assuming ExpensesPrice is stored as a Decimal in the database
                        totalExpense += expensePrice;
                    }

                    reader.Close();
                }
            }


            lblTotal.Text = "Total Expenses: " + totalExpense.ToString("C");


        }

        private List<Expense> GetExpenses()
        {
            List<Expense> expenses = new List<Expense>();

            // Connect to your database and retrieve expenses data
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "SELECT ExpensesName, ExpensesPrice FROM CurrentExpenses WHERE ID = @UserID";

            int userID = GlobalVariables.UserID;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            decimal price = reader.GetDecimal(1);

                            // Create an Expense object and add it to the list
                            expenses.Add(new Expense { Name = name, Price = price });
                        }
                    }
                }

                connection.Close();
            }

            return expenses;
        }

        private void lblSavings_Click(object sender, EventArgs e)
        {

        }

        private void pieChart2_Load(object sender, EventArgs e)
        {
            // Define the background color
            var backgroundColor = new SKColor(43, 48, 72);

            // Create a SolidColorPaint with the background color
            var backgroundPaint = new SolidColorPaint { Color = backgroundColor };

            // Define the white color
            var whiteColor = new SKColor(255, 255, 255);

            // Set up the pie chart with the background color and label color
            pieChart2.InitialRotation = -90;
            pieChart2.MaxValue = 100;
            pieChart2.Series = new GaugeBuilder()
                .WithLabelsSize(30)
                .WithInnerRadius(50)
                .WithBackgroundInnerRadius(50)
                .WithBackground(backgroundPaint)
                .WithOffsetRadius(10)
                .WithLabelFormatter(chartPoint => $"{GlobalVariables.percentage}%")
                .AddValue(GlobalVariables.percentage)
                .BuildSeries();

            // Set the label color to white for the created seriesp
            foreach (var series in pieChart2.Series)
            {
                if (series is PieSeries<ObservableValue> pieSeries)
                {
                    pieSeries.DataLabelsPaint = new SolidColorPaint { Color = whiteColor };
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
