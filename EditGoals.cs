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
    public partial class EditGoals : Form
    {
        int savingGoalsID;
        public EditGoals()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            int userID = GlobalVariables.UserID;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "SELECT SavingGoalsID, Name, Format(Price, 'Currency') AS Price FROM SavingGoals WHERE ID = @UserID";

            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter da = new OleDbDataAdapter(query, myConn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@UserID", userID);

                    DataSet ds = new DataSet();
                    myConn.Open();
                    da.Fill(ds, "SavingGoals");

                    // Clear existing columns before binding data
                    dgvGoals.Columns.Clear();

                    // Bind data to DataGridView
                    dgvGoals.DataSource = ds.Tables["SavingGoals"];

                    // Optionally, you can also set other properties such as AutoResizeColumnsMode
                    dgvGoals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Formatting the ExpensesPrice column to show currency symbol
                    dgvGoals.Columns["Price"].DefaultCellStyle.Format = "C";
                    dgvGoals.Columns["SavingGoalsID"].Visible = false;

                    myConn.Close();


                }
            }
        }
        private void dgvGoals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGoals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = dgvGoals.Rows[indexRow];
            savingGoalsID = Convert.ToInt32(row.Cells[0].Value.ToString());
            tbxName.Text = row.Cells[1].Value.ToString();
            tbxPrice.Text = row.Cells[2].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID = GlobalVariables.UserID;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "UPDATE SavingGoals SET Name = @E, Price = @EP WHERE ID = @ID AND SavingGoalsID = @goalsID";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@E", tbxName.Text);
                    command.Parameters.AddWithValue("@EP", tbxPrice.Text);
                    command.Parameters.AddWithValue("@ID", ID); // Add the parameter for UserIDs
                    command.Parameters.AddWithValue("@goalsID", savingGoalsID);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            this.Close();
        }
    }
}
