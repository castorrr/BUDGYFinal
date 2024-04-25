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
    public partial class SGAdd : Form
    {
        public decimal savings {  get; set; }   
        public SGAdd()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = GlobalVariables.UserID;
                int savingsToAdd = Convert.ToInt32(tbxInput.Text);

                if (savingsToAdd > savings)
                {
                    MessageBox.Show("Exceeds savings value!");
                    return;
                }
                

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Check if the user exists
                    string checkQuery = "SELECT COUNT(*) FROM Savings WHERE ID = @ID";
                    using (OleDbCommand checkCommand = new OleDbCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@ID", userID);
                        int userCount = Convert.ToInt32(checkCommand.ExecuteScalar());
                       

                        if (userCount > 0) // User exists, update existing savings
                        {
                            string updateQuery = "UPDATE Savings SET SavingGoals = SavingGoals + @savingsToAdd WHERE ID = @ID";
                            
                            using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@savingsToAdd", savingsToAdd);
                                updateCommand.Parameters.AddWithValue("@ID", userID);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else // User doesn't exist, insert new record
                        {
                            string insertQuery = "INSERT INTO Savings (ID, SavingGoals) VALUES (@ID, @savingsToAdd)";
                            using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@ID", userID);
                                insertCommand.Parameters.AddWithValue("@savingsToAdd", savingsToAdd);
                                insertCommand.ExecuteNonQuery();
                            }

                        }

                        string query = "UPDATE Savings SET Savings = Savings - @savingsToAdd WHERE ID = @ID";
                        using (OleDbCommand updateCommand = new OleDbCommand(query, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@savingsToAdd", savingsToAdd);
                            updateCommand.Parameters.AddWithValue("@ID", userID);
                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    connection.Close();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
