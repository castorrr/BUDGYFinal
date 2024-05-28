using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BUDGY_2._0
{
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
            load();

        }

        private void load()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
            if (rb1.Checked)
            {
                GlobalVariables.reset = 1;
            }
            else if (rb15.Checked)
            {
                GlobalVariables.reset = 15;
            }
            else if(rb30.Checked)
            {
                GlobalVariables.reset = 30;
            }
            else
            {
                GlobalVariables.reset = 1;
            }


            string query = "SELECT COUNT(*) FROM Accounts WHERE UserID = @UserID";
            int count;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                // Add parameter
                command.Parameters.AddWithValue("@UserID", GlobalVariables.UserID);

                connection.Open();
                count = (int)command.ExecuteScalar();
            }
            
            if (count > 0)
            {
                string query1 = "UPDATE Accounts SET Reset = @Reset WHERE UserID = @UserID";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                using (OleDbCommand command = new OleDbCommand(query1, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@Reset", GlobalVariables.reset);
                    command.Parameters.AddWithValue("@UserID", GlobalVariables.UserID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                string query2 = "INSERT INTO Accounts (UserID, Reset) VALUES (@UserID, @Reset)";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                using (OleDbCommand command = new OleDbCommand(query2, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@UserID", GlobalVariables.UserID);
                    command.Parameters.AddWithValue("@Reset", GlobalVariables.reset);

                    connection.Open();
                    command.ExecuteNonQuery();
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
                            // No image path found, handle this case accordingly (e.g., display a default image)
                            // For example:
                            MessageBox.Show("hotdog");
                            return;
                        }
                    }
                }

                connection.Close();
            }

            string selectQuery = "SELECT Name, Email, PhoneNumber, Address, Occupation, Gender, Age FROM UserInfo WHERE ID = @ID";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection))
                    {
                        // Add parameter for the user's ID
                        selectCommand.Parameters.AddWithValue("@ID", GlobalVariables.UserID);

                        using (OleDbDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve existing values
                                string currentName = reader["Name"] != DBNull.Value ? reader["Name"].ToString() : string.Empty;
                                string currentEmail = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
                                string currentPhoneNumber = reader["PhoneNumber"] != DBNull.Value ? reader["PhoneNumber"].ToString() : string.Empty;
                                string currentAddress = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty;
                                string currentOccupation = reader["Occupation"] != DBNull.Value ? reader["Occupation"].ToString() : string.Empty;
                                string currentGender = reader["Gender"] != DBNull.Value ? reader["Gender"].ToString() : string.Empty;
                                int? currentAge = reader["Age"] != DBNull.Value ? Convert.ToInt32(reader["Age"]) : (int?)null;

                                // Now you can assign these values to labels or any other controls
                                // For example:
                                lblName.Text = currentName;
                                lblEmail.Text = currentEmail;
                                lblPN.Text = currentPhoneNumber;
                                lblAdd.Text = currentAddress;
                                lblOccu.Text = currentOccupation;
                                lblGender.Text = currentGender;
                                lblAge.Text = currentAge.HasValue ? currentAge.ToString() : string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("User not found in the database.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            tbxName.Text = lblName.Text;
            tbxEmail.Text = lblEmail.Text;
            tbxPN.Text = lblPN.Text;
            tbxAdd.Text = lblAdd.Text;
            tbxOccu.Text = lblOccu.Text;
            tbxGender.Text = lblGender.Text;
            tbxAge.Text = lblAge.Text;

            Dashboard d = new Dashboard();
            d.LoadDash();

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string imageLocation;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png|All Files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pbUser.ImageLocation = imageLocation;

                    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";

                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();

                        // SQL command to update the image file path in the database
                        string query = "UPDATE Accounts SET Img = @ImagePath WHERE ID = @id";

                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            // Add parameters for the image file path and user ID
                            command.Parameters.AddWithValue("@ImagePath", imageLocation);
                            command.Parameters.AddWithValue("@id", GlobalVariables.UserID);
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            load();
        }

        private void pbUser_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";

            // Sample query to check if the user exists
            string checkUserQuery = "SELECT COUNT(*) FROM UserInfo WHERE ID = @ID";

            try
            {
                // Check if the user exists in the database
                int userCount;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand checkUserCommand = new OleDbCommand(checkUserQuery, connection))
                    {
                        // Add parameter for the user's ID
                        checkUserCommand.Parameters.AddWithValue("@ID", GlobalVariables.UserID);

                        // Execute scalar to get the count of users with the provided ID
                        userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());
                    }
                }

                // If user exists, update the information; otherwise, insert new information
                if (userCount > 0)
                {
                    // User exists, update the information
                    string updateQuery = "UPDATE UserInfo SET Name = @Name, Email = @Email, PhoneNumber = @PhoneNumber, Address = @Address, Occupation = @Occupation, Gender = @Gender, Age = @Age WHERE ID = @ID";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();

                        using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                        {
                            // Add parameters for updated values
                            updateCommand.Parameters.AddWithValue("@Name", tbxName.Text);
                            updateCommand.Parameters.AddWithValue("@Email", tbxEmail.Text);
                            updateCommand.Parameters.AddWithValue("@PhoneNumber", tbxPN.Text);
                            updateCommand.Parameters.AddWithValue("@Address", tbxAdd.Text);
                            updateCommand.Parameters.AddWithValue("@Occupation", tbxOccu.Text);
                            updateCommand.Parameters.AddWithValue("@Gender", tbxGender.Text);
                            updateCommand.Parameters.AddWithValue("@Age", tbxAge.Text);
                            updateCommand.Parameters.AddWithValue("@ID", GlobalVariables.UserID);

                            // Execute the update command
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    // User does not exist, insert the information
                    string insertQuery = "INSERT INTO UserInfo (ID, Name, Email, PhoneNumber, Address, Occupation, Gender, Age) VALUES (@ID, @Name, @Email, @PhoneNumber, @Address, @Occupation, @Gender, @Age)";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();

                        using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                        {
                            // Add parameters for insert values
                            insertCommand.Parameters.AddWithValue("@ID", GlobalVariables.UserID);
                            insertCommand.Parameters.AddWithValue("@Name", tbxName.Text);
                            insertCommand.Parameters.AddWithValue("@Email", tbxEmail.Text);
                            insertCommand.Parameters.AddWithValue("@PhoneNumber", tbxPN.Text);
                            insertCommand.Parameters.AddWithValue("@Address", tbxAdd.Text);
                            insertCommand.Parameters.AddWithValue("@Occupation", tbxOccu.Text);
                            insertCommand.Parameters.AddWithValue("@Gender", tbxGender.Text);
                            insertCommand.Parameters.AddWithValue("@Age", tbxAge.Text);

                            // Execute the insert command
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("User information updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            load();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        { 
        }
    }
}
