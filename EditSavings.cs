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
    public partial class EditSavings : Form
    {
        public EditSavings()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            int ID = GlobalVariables.UserID;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "UPDATE Savings SET Savings = @s WHERE ID = @UserID";

            if (Convert.ToInt32(tbxInput.Text) > GlobalVariables.RemBudget)
            {
                MessageBox.Show("Exceeds Budget Limit!");
                return;
            }
                

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@s", Convert.ToInt32(tbxInput.Text));
                    command.Parameters.AddWithValue("@UserID", ID); // Add the parameter for UserIDs
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
