using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;
using System.Net.NetworkInformation;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.Drawing.Drawing2D;

namespace BUDGY_2._0
{
    public partial class Expenses : UserControl
    {
        private DataSet dataSet;
        int ID = GlobalVariables.UserID;
        decimal totalExpense = 0;

        public class Expense
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public Expenses()
        {

            InitializeComponent();
            pnlExpenses.Paint += Panel_Paint;
            loadExpenses();
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

                // Create a graphics path for rounded corners
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

        public void loadExpenses()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "SELECT ExpensesName, Format(ExpensesPrice, 'Currency') AS ExpensesPrice FROM CurrentExpenses WHERE ID = @UserID ORDER BY ExpensesName";

            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter da = new OleDbDataAdapter(query, myConn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@UserID", ID);

                    DataSet ds = new DataSet();
                    myConn.Open();
                    da.Fill(ds, "CurrentExpenses");

                    // Clear existing columns before binding data
                    dgvExpenses.Columns.Clear();

                    // Bind data to DataGridView
                    dgvExpenses.DataSource = ds.Tables["CurrentExpenses"];

                    // Optionally, you can also set other properties such as AutoResizeColumnsMode
                    dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Formatting the ExpensesPrice column to show currency symbol
                    dgvExpenses.Columns["ExpensesPrice"].DefaultCellStyle.Format = "C";

                    myConn.Close();
                }
            }

            GetTotalExpenses();
            pieChart1_Load(this, EventArgs.Empty);

        }

        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            EditExpenses expensesEdit = new EditExpenses();
            expensesEdit.ShowDialog();

            loadExpenses();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the expense?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                int ID = GlobalVariables.UserID;
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
                string query = "DELETE FROM CurrentExpenses WHERE ExpensesName = @Name";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", dgvExpenses.CurrentRow.Cells[0].Value);
                        command.ExecuteNonQuery();
                    }
                }
            }

            loadExpenses();
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
            totalExpense = 0;

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

        private void btnTry_Click(object sender, EventArgs e)
        {
            AddExpenses addExpenses = new AddExpenses();
            addExpenses.ShowDialog();
            loadExpenses();
        }
    }
}
