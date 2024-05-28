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
    public partial class UserInfo : UserControl
    {
        public UserInfo()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "SELECT ID, Name, Email, PhoneNumber, Address, Occupation, Gender, Age FROM UserInfo ORDER BY ID";

            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter da = new OleDbDataAdapter(query, myConn))
                {

                    DataSet ds = new DataSet();
                    myConn.Open();
                    da.Fill(ds, "UserInfo");

                    // Clear existing columns before binding data
                    dgvUser.Columns.Clear();

                    // Bind data to DataGridView
                    dgvUser.DataSource = ds.Tables["UserInfo"];

                    // Optionally, you can also set other properties such as AutoResizeColumnsMode
                    dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    myConn.Close();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
