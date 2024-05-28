using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUDGY_2._0
{
    public partial class SavingsAnalytics : UserControl
    {
        decimal totalSavings;
        public SavingsAnalytics()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "SELECT Savings FROM SavingsHistory WHERE ID = @ID";
            totalSavings = 0;

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
                        totalSavings += expensePrice;
                    }

                    reader.Close();
                }
            }

            lblTotal.Text = "Total Savings: " + totalSavings.ToString("C");
        }

        private void SavingsAnalytics_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
