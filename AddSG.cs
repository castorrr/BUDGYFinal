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
    public partial class AddSG : Form
    {
        public AddSG()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ID = GlobalVariables.UserID;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "INSERT INTO SavingGoals (ID, Name, Price) VALUES (@ID, @N, @P)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID); // Add the parameter for UserIDs
                    command.Parameters.AddWithValue("@N", tbxName.Text);
                    command.Parameters.AddWithValue("@P", Convert.ToInt32(tbxPrice.Text));
                    command.ExecuteNonQuery();
                }
                connection.Close();

            }

            this.Close();
        }

        private void AddSG_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
