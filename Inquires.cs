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
    public partial class Inquires : UserControl
    {
        public Inquires()
        {
            InitializeComponent();
            dgvInquiry.CellClick += dgvInquiry_CellClick;
            Load();
        }

        private void Load()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "SELECT Email, Message FROM Inquiry";

            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter da = new OleDbDataAdapter(query, myConn))
                {

                    DataSet ds = new DataSet();
                    myConn.Open();
                    da.Fill(ds, "Inquiry");

                    // Clear existing columns before binding datas
                    dgvInquiry.Columns.Clear();

                    // Bind data to DataGridView
                    dgvInquiry.DataSource = ds.Tables["Inquiry"];

                    // Optionally, you can also set other properties such as AutoResizeColumnsMode
                    dgvInquiry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    myConn.Close();
                }
            }


        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void dgvInquiry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if there are any selected rows
            if (dgvInquiry.SelectedRows.Count > 0)
            {
                // Access the values of the selected row
                lblEmail.Text = dgvInquiry.SelectedRows[0].Cells[0].Value?.ToString();
                lblMSG.Text = dgvInquiry.SelectedRows[0].Cells[1].Value?.ToString();
            }
            else
            {
                // Clear the labels if no row is selected
                lblEmail.Text = "";
                lblMSG.Text = "";
            }
        }

        private void dgvInquiry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
