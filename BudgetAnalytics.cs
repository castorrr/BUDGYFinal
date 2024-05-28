using LiveChartsCore.Defaults;
using LiveChartsCore;
using System.Collections.ObjectModel;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Data.OleDb;

namespace BUDGY_2._0
{
    public partial class BudgetAnalytics : UserControl
    {
        // Declare the Series and XAxes properties at the class level
        decimal totalBudget;
        public BudgetAnalytics()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "SELECT Budget FROM BudgetHistory WHERE ID = @ID";
            totalBudget = 0;

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
                        decimal expensePrice = reader.GetDecimal(0); // Assuming ExpensesPrice is stored as a Decimal in the databasel
                        totalBudget += expensePrice;
                    }

                    reader.Close();
                }
            }

            lblTotal.Text = "Total Budget: " + totalBudget.ToString("C");
        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {

        }

        private void view1_Load(object sender, EventArgs e)
        {

        }
    }
}
    