using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BUDGY_2._0
{
    public partial class Bills : UserControl
    {
        int ID = GlobalVariables.UserID;
        public Bills()
        {
            InitializeComponent();
            pnlBills.Paint += Panel_Paint;
            loadBills();
        }
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Get the rectangle representing the bounds of the panel
                Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);

                // Set the radius for rounded corners based on the panel's size
                int radius = Math.Min(panel.Width, panel.Height) / 4; // Adjust the divisor for different corner roundness

                // Create a graphics path for rounded corners
                GraphicsPath path = new GraphicsPath();
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                // Apply the graphics path to the panel's region
                panel.Region = new Region(path);
            }
        }


        public void loadBills()
        {
            
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string queryBills = "SELECT Name, Price, Date, BillID FROM Bills WHERE ID = @UserID"; // Replace ExpensesName with the actual column name used for orderin
            string queryPaidBills = "SELECT Name, Price, Date FROM PaidBills WHERE ID = @UserID";

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

                using (OleDbDataAdapter da = new OleDbDataAdapter(queryPaidBills, myConn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@UserID", ID);

                    DataSet ds = new DataSet();

                    da.Fill(ds, "PaidBills");

                    // Clear existing columns before binding data
                    dgvPaid.Columns.Clear();

                    // Bind data to DataGridView
                    dgvPaid.DataSource = ds.Tables["PaidBills"];

                    // Optionally, you can also set other properties such as AutoResizeColumnsMode
                    dgvPaid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvPaid.Columns["Price"].DefaultCellStyle.Format = "C";
                }
                myConn.Close();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBills bill = new AddBills();
            bill.ShowDialog();
            loadBills();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditBills bill = new EditBills();
            bill.ShowDialog();
            loadBills();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the bill?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
                string query = "DELETE FROM Bills WHERE BillID = @ID";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", dgvPay.CurrentRow.Cells[3].Value);
                        command.ExecuteNonQuery();
                    }
                }
            }

            loadBills();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("\tPay the bill?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
                string queryGetBill = "SELECT Price FROM Bills WHERE BillID = @BillID"; // Query to get the selected bill's prices
                string queryPay = "INSERT INTO PaidBills (ID, Name, Price, [Date]) VALUES (@ID, @Name, @Price, @DueDate)";
                string queryDeleteBill = "DELETE FROM Bills WHERE BillID = @BillID";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Get the selected bill's price
                    decimal billPrice;
                    using (OleDbCommand command = new OleDbCommand(queryGetBill, connection))
                    {
                        command.Parameters.AddWithValue("@BillID", dgvPay.CurrentRow.Cells[3].Value);
                        billPrice = Convert.ToDecimal(command.ExecuteScalar());
                    }

                    // Check if the bill price exceeds the remaining budget
                    if (billPrice <= GlobalVariables.RemBudget)
                    {
                        // Pay the bill
                        using (OleDbCommand command = new OleDbCommand(queryPay, connection))
                        {
                            command.Parameters.AddWithValue("@ID", ID); // Add the parameter for UserID
                            command.Parameters.AddWithValue("@Name", dgvPay.CurrentRow.Cells[0].Value); // Add the parameter for bill's name
                            command.Parameters.AddWithValue("@Price", dgvPay.CurrentRow.Cells[1].Value); // Convert price to double
                            command.Parameters.AddWithValue("@DueDate", dgvPay.CurrentRow.Cells[2].Value); // Use only date part

                            command.ExecuteNonQuery();
                        }

                        // Delete the paid bill from the Bills table
                        using (OleDbCommand command = new OleDbCommand(queryDeleteBill, connection))
                        {
                            command.Parameters.AddWithValue("@BillID", dgvPay.CurrentRow.Cells[3].Value);
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Bill paid successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Sorry, paying this bill exceeds the remaining budget.");
                    }

                    connection.Close();
                }
            }


            loadBills();
        }
    }
}
