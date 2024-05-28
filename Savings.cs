using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModelsSamples.Pies.Gauge1;
using LiveChartsCore;
using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore.SkiaSharpView.Extensions;
using System.Net.NetworkInformation;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Drawing;
using LiveChartsCore.Drawing;
using SkiaSharp;
using LiveChartsCore.Kernel;
using LiveChartsCore.Defaults;
using System.Drawing.Drawing2D;


namespace BUDGY_2._0
{
    public partial class Savings : UserControl
    {
        decimal savings;
        decimal totalGoals;
        decimal savingGoals;

        public Savings()
        {
            InitializeComponent();
            pnlSavings.Paint += Panel_Paint;
            loadSavings();
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

        public void loadSavings()
        {
            int ID = GlobalVariables.UserID;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string queryHistory = "SELECT Savings, Date FROM SavingsHistory WHERE ID = @UserID"; // Replace ExpensesName with the actual column name used for ordering
            string queryGoals = "SELECT Name, Price, SavingGoalsID FROM SavingGoals WHERE ID = @UserID";
            string querySavings = "SELECT Savings FROM Savings WHERE ID = @UserID";
            string querySGValue = "SELECT SavingGoals FROM Savings WHERE ID = @UserID";

            GetTotalGoals();

            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                myConn.Open();

                using (OleDbCommand command = new OleDbCommand(querySavings, myConn))
                {
                    command.Parameters.AddWithValue("@UserID", ID);

                    object result = command.ExecuteScalar();


                    if (result != null)
                    {
                        lblSavings.Text = Convert.ToDecimal(result).ToString("C");
                        savings = (decimal)result;
                    }
                    else
                    {
                        lblSavings.Text = "₱ 0";
                        savings = 0;
                    }
                }
                using (OleDbCommand command = new OleDbCommand(querySGValue, myConn))
                {
                    command.Parameters.AddWithValue("@UserID", ID);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        lblSG.Text = Convert.ToDecimal(result).ToString("C") + "/" + totalGoals.ToString("C");
                        savingGoals = (decimal)result;
                    }
                    else
                    {
                        lblSG.Text = "₱ 0/" + totalGoals.ToString("C");
                        savingGoals = 0;
                    }
                }
                using (OleDbDataAdapter da = new OleDbDataAdapter(queryHistory, myConn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@UserID", ID);

                    DataSet ds = new DataSet();

                    da.Fill(ds, "Savings");

                    // Clear existing columns before binding data
                    dgvHistory.Columns.Clear();

                    // Bind data to DataGridView
                    dgvHistory.DataSource = ds.Tables["Savings"];

                    // Optionally, you can also set other properties such as AutoResizeColumnsMode
                    dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dgvHistory.Columns["Savings"].DefaultCellStyle.Format = "C";
                }

                using (OleDbDataAdapter da = new OleDbDataAdapter(queryGoals, myConn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@UserID", ID);

                    DataSet ds = new DataSet();

                    da.Fill(ds, "SavingGoals");

                    // Clear existing columns before binding data
                    dgvGoals.Columns.Clear();

                    // Bind data to DataGridView
                    dgvGoals.DataSource = ds.Tables["SavingGoals"];

                    // Optionally, you can also set other properties such as AutoResizeColumnsModel
                    dgvGoals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    //format
                    dgvGoals.Columns["Price"].DefaultCellStyle.Format = "C";
                    dgvGoals.Columns["SavingGoalsID"].Visible = false;


                }
                myConn.Close();
            }

            if (totalGoals <= 0)
                GlobalVariables.percentage = 0;
            else
                GlobalVariables.percentage = Convert.ToInt32((savingGoals / totalGoals) * 100);


            pieChart1_Load_2(this, EventArgs.Empty);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetSavings savings = new SetSavings();
            savings.ShowDialog();
            loadSavings();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the value?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                int ID = GlobalVariables.UserID;
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
                string query = "DELETE FROM Savings WHERE ID = @UserID";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", ID);
                        command.ExecuteNonQuery();
                    }
                }

            }

            loadSavings();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSavings savings = new EditSavings();
            savings.ShowDialog();
            loadSavings();
        }

        private void btnAddSG_Click(object sender, EventArgs e)
        {
            AddSG savings = new AddSG();
            savings.ShowDialog();
            loadSavings();
        }

        private void btnDeleteSG_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the value?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
                string query = "DELETE FROM SavingGoals WHERE SavingGoalsID = @ID";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", dgvGoals.CurrentRow.Cells[2].Value);
                        command.ExecuteNonQuery();
                    }
                }
            }

            loadSavings();
        }

        private void dgvGoals_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditSG_Click(object sender, EventArgs e)
        {
            EditGoals goals = new EditGoals();
            goals.ShowDialog();
            loadSavings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the value?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                int ID = GlobalVariables.UserID;
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
                string query = "DELETE FROM SavingGoals WHERE ID = @UserID";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", ID);
                        command.ExecuteNonQuery();
                    }
                }

            }

            loadSavings();
        }

        private void btnSGAdd_Click(object sender, EventArgs e)
        {
            SGAdd sGAdd = new SGAdd();
            sGAdd.savings = savings;
            sGAdd.ShowDialog();
            loadSavings();
        }

        private void btnSGEdit_Click(object sender, EventArgs e)
        {

        }

        private void GetTotalGoals()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "SELECT Price FROM SavingGoals WHERE ID = @ID";
            totalGoals = 0;

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
                        decimal goalsPrice = reader.GetDecimal(0); // Assuming ExpensesPrice is stored as a Decimal in the database
                        totalGoals += goalsPrice;
                    }

                    reader.Close();
                }
            }
        }

        private void pieChart1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pieChart1_Load_1(object sender, EventArgs e)
        {

        }

        private void gauge1_Load(object sender, EventArgs e)
        {

        }

        private void pieChart1_Load_2(object sender, EventArgs e)
        {
            // Define the background color
            var backgroundColor = new SKColor(24, 30, 54);

            // Create a SolidColorPaint with the background color
            var backgroundPaint = new SolidColorPaint { Color = backgroundColor };

            // Define the white color
            var whiteColor = new SKColor(255, 255, 255);

            // Set up the pie chart with the background color and label color
            pieChart1.InitialRotation = -90;
            pieChart1.MaxValue = 100;
            pieChart1.Series = new GaugeBuilder()
                .WithLabelsSize(40)
                .WithInnerRadius(50)
                .WithBackgroundInnerRadius(50)
                .WithBackground(backgroundPaint)
                .WithOffsetRadius(10)
                .WithLabelFormatter(chartPoint => $"{GlobalVariables.percentage}%")
                .AddValue(GlobalVariables.percentage)
                .BuildSeries();

            // Set the label color to white for the created series
            foreach (var series in pieChart1.Series)
            {
                if (series is PieSeries<ObservableValue> pieSeries)
                {
                    pieSeries.DataLabelsPaint = new SolidColorPaint { Color = whiteColor };
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
