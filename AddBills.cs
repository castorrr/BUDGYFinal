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
    public partial class AddBills : Form
    {
        public AddBills()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ID = GlobalVariables.UserID;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "INSERT INTO Bills (ID, Name, Price, [Date]) VALUES (@ID, @Name, @Price, @DueDate)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID); // Add the parameter for UserID
                    command.Parameters.AddWithValue("@Name", tbxName.Text); // Add the parameter for bill's name
                    command.Parameters.AddWithValue("@Price", Convert.ToDouble(tbxPrice.Text)); // Convert price to double
                    command.Parameters.AddWithValue("@DueDate", dtpDue.Value.Date); // Use only date part

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

            this.Close();

        }
    }
}
