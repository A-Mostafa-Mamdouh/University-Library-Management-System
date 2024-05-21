using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Library
{
    public partial class UpdateDetails : Form
    {
        public UpdateDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FillUserDetails()
        {
            string query = "SELECT f_name, l_name, username, password, user_email, user_phonenumber, student_level, student_faculty FROM [user] WHERE user_id = @UserID";

            using (SqlConnection connection = new SqlConnection(ShareData.CON))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", ShareData.userID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            Fname_txt.Text = reader["f_name"].ToString();
                            lName_txt.Text = reader["l_name"].ToString();
                            Username_txt.Text = reader["username"].ToString();
                            password_txt.Text = reader["password"].ToString();
                            email_txt.Text = reader["user_email"].ToString();
                            phoneNo_txt.Text = reader["user_phonenumber"].ToString();
                            level_txt.Text = reader["student_level"].ToString();
                            faculty_txt.Text = reader["student_faculty"].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void UpdateDetails_Load(object sender, EventArgs e)
        {
            FillUserDetails();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string newFirstName = Fname_txt.Text;
            string newLastName = lName_txt.Text;
            string newUsername = Username_txt.Text;
            string newPassword = password_txt.Text;
            string newEmail = email_txt.Text;
            string newPhoneNo = phoneNo_txt.Text;
            string newLevel = level_txt.Text;
            string newFaculty = faculty_txt.Text;

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(newEmail))
            {
                MessageBox.Show("Username, password, and email cannot be empty.");
                return;
            }

            if (IsUsernameUnique(newUsername))
            {
                UpdateUserDetails(newFirstName, newLastName, newUsername, newPassword, newEmail, newPhoneNo, newLevel, newFaculty);
                DateTime transactionDate = DateTime.Now;
                InsertTransaction("Update_user", ShareData.userID, transactionDate, newUsername);
                MessageBox.Show("User details updated successfully.");
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
            }
        }

        private bool IsUsernameUnique(string username)
        {
            string query = "SELECT COUNT(*) FROM [user] WHERE username = @Username AND user_id != @UserID";

            using (SqlConnection connection = new SqlConnection(ShareData.CON))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@UserID", ShareData.userID);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count == 0;
                }
            }
        }

        private void UpdateUserDetails(string newFirstName, string newLastName, string newUsername, string newPassword, string newEmail, string newPhoneNo, string newLevel, string newFaculty)
        {
            string query = "UPDATE [user] SET f_name = @FirstName, l_name = @LastName, username = @Username, password = @Password, user_email = @Email, user_phonenumber = @PhoneNo, student_level = @Level, student_faculty = @Faculty WHERE user_id = @UserID";

            using (SqlConnection connection = new SqlConnection(ShareData.CON))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", newFirstName);
                    command.Parameters.AddWithValue("@LastName", newLastName);
                    command.Parameters.AddWithValue("@Username", newUsername);
                    command.Parameters.AddWithValue("@Password", newPassword);
                    command.Parameters.AddWithValue("@Email", newEmail);
                    command.Parameters.AddWithValue("@PhoneNo", newPhoneNo);
                    command.Parameters.AddWithValue("@Level", newLevel);
                    command.Parameters.AddWithValue("@Faculty", newFaculty);
                    command.Parameters.AddWithValue("@UserID", ShareData.userID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InsertTransaction(string transactionType, int userId, DateTime transactionDate, string username = "")
        {
            string query = "INSERT INTO Transactions (transaction_type, user_id, transaction_date,username) VALUES (@TransactionType, @UserId, @TransactionDate,@username)";

            SqlConnection connection = new SqlConnection(ShareData.CON);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionType", transactionType);
            command.Parameters.AddWithValue("@UserId", userId);
            command.Parameters.AddWithValue("@TransactionDate", transactionDate);
            command.Parameters.AddWithValue("@username", username);
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void GoBackToLog_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteCurrentUser();
            }
        }

        private void DeleteCurrentUser()
        {
            string query = "DELETE FROM [user] WHERE user_id = @UserID";
            FillUserDetails();
            using (SqlConnection connection = new SqlConnection(ShareData.CON))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", ShareData.userID);
                    DateTime transactionDate = DateTime.Now;
                    InsertTransaction("Remove_user", ShareData.userID, transactionDate, Username_txt.Text);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Your account has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            ((StudentDashboard)this.Owner).Hide();
                            Login login = new Login();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete your account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}


    

