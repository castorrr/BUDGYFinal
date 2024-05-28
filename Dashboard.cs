using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUDGY_2._0
{
    public partial class Dashboard : Form
    {

        public string picture;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Dashboard()
        {
            InitializeComponent();
            Home home = new Home();
            pnlDash.Controls.Add(home);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            LoadDash();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlDash.Controls.Clear();
            Expenses expenses = new Expenses();
            pnlDash.Controls.Add(expenses);
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            pnlDash.Controls.Clear();
            Home home = new Home();
            pnlDash.Controls.Add(home);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlDash.Controls.Clear();
            Savings savings = new Savings();
            pnlDash.Controls.Add(savings);
        }

        private void bntBudget_Click(object sender, EventArgs e)
        {
            pnlDash.Controls.Clear();
            Budget budget = new Budget();
            pnlDash.Controls.Add(budget);
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            pnlDash.Controls.Clear();
            Bills bills = new Bills();
            pnlDash.Controls.Add(bills);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        public void LoadDash()
        {
            int ID = GlobalVariables.UserID;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string query = "SELECT NameUser FROM Accounts WHERE ID = @UserID";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", ID);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        lblName1.Text = result.ToString();
                    }
                    else
                    {
                        lblName1.Text = "User";
                    }
                }
            }


            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // SQL command to select the image file path from the database
                string query1 = "SELECT Img FROM Accounts WHERE ID = @id";

                using (OleDbCommand command = new OleDbCommand(query1, connection))
                {
                    // Assuming GlobalVariables.UserID contains the user's ID
                    command.Parameters.AddWithValue("@id", GlobalVariables.UserID);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        // Check if there are any rows returned
                        if (reader.HasRows)
                        {
                            // Read the first row
                            reader.Read();
                            // Assuming you have a PictureBox control named pbUser to display the image
                            pbUser.ImageLocation = reader["Img"].ToString();
                        }
                        else
                        {
                            // No image path found, handle this case accordingly (e.g., display a default image)s
                            // For example:
                            return;
                        }
                    }
                }

                connection.Close();
            }
        }

        private void lblEditAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlDash.Controls.Clear();
            Account account = new Account();
            pnlDash.Controls.Add(account);
        }

        private void lblAnalytics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlDash.Controls.Clear();
            Analytics analytics = new Analytics();
            pnlDash.Controls.Add(analytics);
        }

        private void lblContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnSend contact = new btnSend();  
            contact.ShowDialog();   
        }
    }
}
