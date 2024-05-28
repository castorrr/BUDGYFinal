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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BUDGY_2._0
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShow.Checked)
            {
                tbxPass.PasswordChar = '\0';//null
                tbxConfirmPass.PasswordChar = '\0';
            }
            else
            {
                tbxPass.PasswordChar = '●';
                tbxConfirmPass.PasswordChar = '●';
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (tbxPass.Text == tbxConfirmPass.Text)
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
                string queryCheckUsername = "SELECT COUNT(*) FROM Accounts WHERE Username = @UName"; // Query to check if the username exist

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Check if the username already exists
                    using (OleDbCommand commandCheckUsername = new OleDbCommand(queryCheckUsername, connection))
                    {
                        commandCheckUsername.Parameters.AddWithValue("@UName", tbxUserName.Text);
                        int count = (int)commandCheckUsername.ExecuteScalar();

                        if (count > 0)
                        {
                            // Username already exists, show an error message or handle the situation accordingly
                            MessageBox.Show("Username already exists. Please choose a different username.");
                            return; // Exit the method without proceeding with the insertion
                        }
                    }

                    // If the username doesn't exist, proceed with the insertion
                    string queryInsert = "INSERT INTO Accounts (NameUser, Username, [Password], Role) values (@Name, @UName, @Pass, @Role)";
                    using (OleDbCommand commandInsert = new OleDbCommand(queryInsert, connection))
                    {
                        commandInsert.Parameters.AddWithValue("@Name", tbxName.Text);
                        commandInsert.Parameters.AddWithValue("@UName", tbxUserName.Text);
                        commandInsert.Parameters.AddWithValue("@Pass", tbxPass.Text);
                        commandInsert.Parameters.AddWithValue("@Role", "Client");
                        commandInsert.ExecuteNonQuery();
                    }

                    //Getting the ID
                    string query = "SELECT ID FROM Accounts WHERE Username = @Username AND Password = @Password";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", tbxUserName.Text);
                        cmd.Parameters.AddWithValue("@Password", tbxPass.Text);

                        // Execute the command to retrieve the user's ID
                        object result = cmd.ExecuteScalar();

                        GlobalVariables.UserID = Convert.ToInt32(result);
                    }

                    string queryInsertUser = "INSERT INTO UserInfo (ID, Name) values (@id, @UName)";
                    using (OleDbCommand commandInsert = new OleDbCommand(queryInsertUser, connection))
                    {
                        commandInsert.Parameters.AddWithValue("@id", GlobalVariables.UserID);
                        commandInsert.Parameters.AddWithValue("@Name", tbxName.Text);
                        commandInsert.ExecuteNonQuery();
                    }

                    

                    MessageBox.Show("Account Successfully Created!");
                    Dashboard dashboard = new Dashboard();
                    this.Hide();
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Password does not match!");
            }
            
        }
    }
}
