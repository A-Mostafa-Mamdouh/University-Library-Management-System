using System;
using System.Collections;
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
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Fname_txt.Text) ||
                string.IsNullOrWhiteSpace(lName_txt.Text) ||
                string.IsNullOrWhiteSpace(password_txt.Text) ||
                string.IsNullOrWhiteSpace(Username_txt.Text) ||
                string.IsNullOrWhiteSpace(phoneNo_txt.Text) ||
                string.IsNullOrWhiteSpace(email_txt.Text) ||
                string.IsNullOrWhiteSpace(faculty_txt.Text) ||
                string.IsNullOrWhiteSpace(level_txt.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection CNN = new SqlConnection("Data Source=DESKTOP-5TODPFA;Initial Catalog=University_Library_Managment_System;Integrated Security=True;Encrypt=False");
                CNN.Open();
                string checkQuery = @"SELECT COUNT(*) FROM [user] WHERE username = @username OR user_email = @user_email";
                SqlCommand checkCommand = new SqlCommand(checkQuery, CNN);
                checkCommand.Parameters.AddWithValue("@username", Username_txt.Text);
                checkCommand.Parameters.AddWithValue("@user_email", email_txt.Text);
                int existingCount = (int)checkCommand.ExecuteScalar();

                if (existingCount > 0)
                {
                    MessageBox.Show("Username or email already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CNN.Close();
                    return;
                }

                string query = @"INSERT INTO [user] (f_name, l_name, username,user_email, password, user_phonenumber, student_Faculty, student_level) 
                         VALUES (@f_name, @l_name,@username, @user_email, @password, @user_phonenumber, @student_Faculty, @student_level)";

                SqlCommand command = new SqlCommand(query, CNN);
                command.Parameters.AddWithValue("@f_name", Fname_txt.Text);
                command.Parameters.AddWithValue("@l_name", lName_txt.Text);
                command.Parameters.AddWithValue("@username", Username_txt.Text);
                command.Parameters.AddWithValue("@user_email", email_txt.Text);
                command.Parameters.AddWithValue("@password", password_txt.Text);
                command.Parameters.AddWithValue("@user_phonenumber", phoneNo_txt.Text);
                command.Parameters.AddWithValue("@student_Faculty", faculty_txt.Text);
                command.Parameters.AddWithValue("@student_level", level_txt.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("User Added Successfully!");
                DateTime transactionDate = DateTime.Now;
                InsertTransaction("Add_User",retreiveID(),transactionDate,Username_txt.Text);
                CNN.Close();
            }
        }

        private int retreiveID()
        {
            SqlConnection CNN = new(ShareData.CON);
            string query2 = "SELECT [user_id] FROM [user] WHERE [username] = @username";
            SqlCommand retreiveID = new SqlCommand(query2, CNN);
            retreiveID.Parameters.AddWithValue("@username", Username_txt.Text);
            CNN.Open();
            object result = retreiveID.ExecuteScalar();
            CNN.Close();
            return Convert.ToInt32(result);
        }
        private void GoBackToLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private bool isDragging = false;
        private Point startPoint;
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point screenPoint = Control.MousePosition;
                Point offset = new Point(screenPoint.X - startPoint.X, screenPoint.Y - startPoint.Y);
                this.Location = new Point(this.Location.X + offset.X, this.Location.Y + offset.Y);
                startPoint = screenPoint; // Update start point
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location;
                startPoint = panel2.PointToScreen(startPoint);
            }
        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
