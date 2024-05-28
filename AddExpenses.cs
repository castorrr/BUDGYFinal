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
    public partial class AddExpenses : Form
    {
        public AddExpenses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //adding
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO CurrentExpenses (ID, ExpensesName, ExpensesPrice) VALUES (@ID, @Name, @Price)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", GlobalVariables.UserID);
                        command.Parameters.AddWithValue("@Name", tbxPrice.Text);
                        command.Parameters.AddWithValue("@Price", Convert.ToDecimal(tbxPrice.Text));

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Expense added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the expense: " + ex.Message);
            }

            this.Close();
        }
    }
}
