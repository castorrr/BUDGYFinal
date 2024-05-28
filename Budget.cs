using Microsoft.VisualBasic.ApplicationServices;
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

namespace BUDGY_2._0
{
    public partial class Budget : UserControl
    {
        public Budget()
        {
            InitializeComponent();
            pnlBudget.Paint += Panel_Paint;
            LoadBudget();
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

        private void LoadBudget()
        {
            int ID = GlobalVariables.UserID;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "SELECT Budget FROM Budget WHERE ID = @UserID";
            string query1 = "SELECT Budget, DATE FROM BudgetHistory WHERE ID = @UserID";

            lblRemBudget.Text = GlobalVariables.RemBudget.ToString("C");

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", ID);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        lblBudget.Text = Convert.ToDecimal(result).ToString("C");
                    }
                    else
                    {
                        lblBudget.Text = "₱ 0";
                    }
                }

                using (OleDbDataAdapter da = new OleDbDataAdapter(query1, connection))
                {
                    da.SelectCommand.Parameters.AddWithValue("@UserID", ID);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "Budget");

                    // Clear existing columns before binding data
                    dgvBudget.Columns.Clear();

                    // Bind data to DataGridView
                    dgvBudget.DataSource = ds.Tables["Budget"];

                    // Optionally, you can also set other properties such as AutoResizeColumnsMode
                    dgvBudget.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    //formatting in dgv is set in currenct format
                    dgvBudget.Columns["Budget"].DefaultCellStyle.Format = "C";
                }

                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Set set = new Set();
            set.ShowDialog();
            Home home = new Home();
            home.LoadHome();
            LoadBudget();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the value?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                int ID = GlobalVariables.UserID;
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
                string query = "DELETE FROM Budget WHERE ID = @UserID";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", ID);
                        command.ExecuteNonQuery();
                    }
                }

            }

            LoadBudget();
        }

        private void lblBudget_Click(object sender, EventArgs e)
        {
       

        }

        private void show1_Load(object sender, EventArgs e)
        {

        }

        private void Budget_Load(object sender, EventArgs e)
        {

        }

        private void show1_Load_1(object sender, EventArgs e)
        {

        }

        private void show1_Click(object sender, EventArgs e)
        {
         

        }

        private void lblBudget_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.ShowDialog();
            LoadBudget();
        }
    }
}
