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
    public partial class EditBills : Form
    {
        int billID;
        public EditBills()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            int ID = GlobalVariables.UserID;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string queryBills = "SELECT Name, Price, Date, BillID FROM Bills WHERE ID = @UserID"; // Replace ExpensesName with the actual column name used for orderin

            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                myConn.Open();
                using (OleDbDataAdapter da = new OleDbDataAdapter(queryBills, myConn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@UserID", ID);

                    DataSet ds = new DataSet();

                    da.Fill(ds, "Bills");

                    // Clear existing columns before binding data
                    dgvPay.Columns.Clear();

                    // Bind data to DataGridView
                    dgvPay.DataSource = ds.Tables["Bills"];

                    // Optionally, you can also set other properties such as AutoResizeColumnsMode
                    dgvPay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvPay.Columns["Price"].DefaultCellStyle.Format = "C";
                    dgvPay.Columns["BillID"].Visible = false;
                }


                myConn.Close();

            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow >= 0 && indexRow < dgvPay.Rows.Count)
            {
                DataGridViewRow row = dgvPay.Rows[indexRow];
                tbxName.Text = row.Cells[0].Value.ToString();
                tbxPrice.Text = row.Cells[1].Value.ToString();

                // Retrieve and parse the date value
                if (DateTime.TryParse(row.Cells[2].Value?.ToString(), out DateTime date))
                {
                    dtpDate.Value = date;
                }
                else
                {
                    // Handle the case where the date value cannot be parsed
                    MessageBox.Show("Invalid date format in the selected row.");
                }

                // Retrieve the bill ID
                if (int.TryParse(row.Cells[3].Value?.ToString(), out int id))
                {
                    billID = id;
                }
                else
                {
                    // Handle the case where the bill ID cannot be parsed
                    MessageBox.Show("Invalid bill ID format in the selected row.");
                }
            }
            else
            {
                // Handle the case where the selected row index is out of range
                MessageBox.Show("Invalid row selection.");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ID = GlobalVariables.UserID;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "UPDATE Bills SET Name = @N, Price = @P, [Date] = @D WHERE ID = @ID AND BillID = @BID";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@N", tbxName.Text);
                    command.Parameters.AddWithValue("@P", tbxPrice.Text);
                    command.Parameters.AddWithValue("@D", dtpDate.Value.ToString("MM/dd/yyyy"));
                    command.Parameters.AddWithValue("@ID", ID); // Add the parameter for UserIDs
                    command.Parameters.AddWithValue("@BID", billID);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            this.Close();
        }
    }

}
