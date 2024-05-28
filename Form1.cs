using System.Data.OleDb;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;

namespace BUDGY_2._0
{
    public partial class LoginPage : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        public int ID;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //so that the user can see the password
            if (cbxShow.Checked)
                tbxPassword.PasswordChar = '\0';//null
            else
                tbxPassword.PasswordChar = '●';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Display a confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);

                // Check the result to determine which button the user clicked
                if (result == DialogResult.No)
                {
                    // User clicked No
                    // Prevent the form from closing
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            
            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                myConn.Open();

                string query = "SELECT ID, Role FROM Accounts WHERE Username = @Username AND Password = @Password";

                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userID = reader.GetInt32(0);
                            string role = reader.GetString(1);

                            GlobalVariables.UserID = userID;
                            string UserRole = role;

                            // Check if the user is an admin
                            if (role == "Admin")
                            {
                                // Redirect to the admin dashboard
                                this.Hide();
                                Admin admin = new Admin();
                                admin.Show();
                            }
                            else
                            {
                                // Redirect to the client dashboard
                                this.Hide();
                                Dashboard dashboard = new Dashboard();
                                dashboard.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong Login or Password!");
                        }
                    }
                }

                myConn.Close();
            }

        }


        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnSend contact = new btnSend();
            contact.ShowDialog();
        }
    }
}

