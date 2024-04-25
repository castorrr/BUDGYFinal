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
using static BUDGY_2._0.Expenses;
using System.Xml.Linq;

namespace BUDGY_2._0
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "SELECT ID, NameUser, Username, Password, Role FROM Accounts ORDER BY ID";

            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter da = new OleDbDataAdapter(query, myConn))
                {

                    DataSet ds = new DataSet();
                    myConn.Open();
                    da.Fill(ds, "Accounts");

                    // Clear existing columns before binding data
                    dgvAccounts.Columns.Clear();

                    // Bind data to DataGridView
                    dgvAccounts.DataSource = ds.Tables["Accounts"];

                    // Optionally, you can also set other properties such as AutoResizeColumnsMode
                    dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    myConn.Close();
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the expense?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                int ID = GlobalVariables.UserID;
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
                string query = "DELETE FROM Accounts WHERE ID = @id";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", dgvAccounts.CurrentRow.Cells[0].Value);
                        command.ExecuteNonQuery();
                    }
                }
            }
            load();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "UPDATE Accounts SET [Password] = @p WHERE ID = @id";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@p", "123456"); // New password value
                        command.Parameters.AddWithValue("@id", dgvAccounts.CurrentRow.Cells[0].Value); // ID of the user whose password you want to update
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                MessageBox.Show("Account password reset successful!");
                load(); // Reload data after updating
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                MessageBox.Show("Query: " + query); // Add this line
            }

            load();
        }

        private void btnInquires_Click(object sender, EventArgs e)
        {

            Inquires i = new Inquires();
            pnlDGV.Controls.Add(i);
            i.BringToFront();
        }

        private void btnUI_Click(object sender, EventArgs e)
        {
            UserInfo u = new UserInfo();
            pnlDGV.Controls.Add(u);
            u.BringToFront();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin a = new Admin();           
            a.ShowDialog();
        }
    }
}
