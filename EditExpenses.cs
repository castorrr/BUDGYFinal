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
    public partial class EditExpenses : Form
    {
        //referencing
        int expenseID;

        public EditExpenses()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            int userID = GlobalVariables.UserID;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "SELECT ExpenseID, ExpensesName, Format(ExpensesPrice, 'Currency') AS ExpensesPrice FROM CurrentExpenses WHERE ID = @UserID";

            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter da = new OleDbDataAdapter(query, myConn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@UserID", userID);

                    DataSet ds = new DataSet();
                    myConn.Open();
                    da.Fill(ds, "CurrentExpenses");

                    // Clear existing columns before binding data
                    dgvExpenses.Columns.Clear();

                    // Bind data to DataGridView
                    dgvExpenses.DataSource = ds.Tables["CurrentExpenses"];

                    // Optionally, you can also set other properties such as AutoResizeColumnsMode
                    dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Formatting the ExpensesPrice column to show currency symbol
                    dgvExpenses.Columns["ExpensesPrice"].DefaultCellStyle.Format = "C";
                    dgvExpenses.Columns["ExpenseID"].Visible = false;

                    myConn.Close();


                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = dgvExpenses.Rows[indexRow];
            expenseID = Convert.ToInt32(row.Cells[0].Value.ToString());
            tbxName.Text = row.Cells[1].Value.ToString();
            tbxPrice.Text = row.Cells[2].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID = GlobalVariables.UserID;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "UPDATE CurrentExpenses SET ExpensesName = @E, ExpensesPrice = @EP WHERE ID = @ID AND ExpenseID = @expenseID";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                decimal remainingBudget = GlobalVariables.RemBudget - Convert.ToInt32(tbxPrice.Text);

                // Check if the inputted price exceeds the remaining budget
                if (remainingBudget < 0)
                {
                    MessageBox.Show("The expense exceeds the remaining budget.");
                    return; // Exit the method without executing the INSERT querys

                }

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@E", tbxName.Text);
                    command.Parameters.AddWithValue("@EP", tbxPrice.Text);
                    command.Parameters.AddWithValue("@ID", ID); // Add the parameter for UserID
                    command.Parameters.AddWithValue("@expenseID", expenseID);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            this.Close();
        }

        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
