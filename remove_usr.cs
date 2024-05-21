using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Library
{
    public partial class remove_usr : Form
    {
        public remove_usr()
        {
            InitializeComponent();
        }

        private void retreiveusernames()
        {
            string query = "SELECT [username] FROM [user] where user_type = 0";
            using (SqlConnection cnn = new SqlConnection(ShareData.CON))
            {
                cnn.Open();
                using (SqlCommand retreiveUserNames = new SqlCommand(query, cnn))
                {
                    using (SqlDataReader reader = retreiveUserNames.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string username = reader["username"].ToString();
                            user_list.Items.Add(username);
                        }
                    }
                }
            }

        }

        private void deleteSelectedUser()
        {
            if (user_list.SelectedItem != null)
            {
                string selectedUsername = user_list.SelectedItem.ToString();
                int userId = RetrieveuserId(selectedUsername);

                if (userId != 0)
                {
                    string query = "DELETE FROM [user] WHERE user_id = @userId";
                    using (SqlConnection connection = new SqlConnection(ShareData.CON))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@userId", userId);
                        try
                        {
                            DateTime transactionDate = DateTime.Now;
                            InsertTransaction("Remove_user", userId, transactionDate, selectedUsername);
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("User deleted successfully!");
                            user_list.Items.Clear();
                            retreiveusernames();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting user: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }
        private int RetrieveuserId(string username)
        {
            int userid = 0;

            string query = "SELECT user_id FROM [user] WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(ShareData.CON))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    userid = Convert.ToInt32(result);
                }
            }

            return userid;
        }

        private void remove_usr_Load(object sender, EventArgs e)
        {
            retreiveusernames();
        }

        private void delete_usr_Click(object sender, EventArgs e)
        {
            deleteSelectedUser();

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

        private void user_list_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (user_list.SelectedItem != null)
            {
                FillUserDetails();
            }
        }

        private int retreiveID(string username)
        {
            SqlConnection CNN = new(ShareData.CON);
            string query2 = "SELECT [user_id] FROM [user] WHERE [username] = @username";
            SqlCommand retreiveID = new SqlCommand(query2, CNN);
            retreiveID.Parameters.AddWithValue("@username", username);
            CNN.Open();
            object result = retreiveID.ExecuteScalar();
            CNN.Close();
            return Convert.ToInt32(result);
        }
        private void FillUserDetails()
        {
            string query = "SELECT f_name, l_name, username, password, user_email, user_phonenumber, student_level, student_faculty FROM [user] WHERE username = @USERNAME";

            using (SqlConnection connection = new SqlConnection(ShareData.CON))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@USERNAME", user_list.SelectedItem.ToString());

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

            int userId = retreiveID(newUsername);

            if (userId != 0)
            {
                if (IsUsernameUnique(newUsername, userId))
                {
                    UpdateUserDetails(newFirstName, newLastName, newUsername, newPassword, newEmail, newPhoneNo, newLevel, newFaculty, userId);
                    DateTime transactionDate = DateTime.Now;
                    InsertTransaction("Update_user", userId, transactionDate, newUsername);
                    MessageBox.Show("User details updated successfully.");
                }
                else
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                }
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private bool IsUsernameUnique(string username, int userId)
        {
            string query = "SELECT COUNT(*) FROM [user] WHERE username = @Username AND user_id != @UserID";

            using (SqlConnection connection = new SqlConnection(ShareData.CON))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@UserID", userId);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count == 0;
                }
            }
        }

        private void UpdateUserDetails(string newFirstName, string newLastName, string newUsername, string newPassword, string newEmail, string newPhoneNo, string newLevel, string newFaculty, int userId)
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
                    command.Parameters.AddWithValue("@UserID", userId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

