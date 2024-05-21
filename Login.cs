using System.Data.SqlClient;

namespace University_Library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection CNN = new(ShareData.CON);
            CNN.Open();
            if (Username_txt.Text == "" || password_txt.Text == "")
            {
                MessageBox.Show("Fields are Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "SELECT [password] FROM [user] WHERE [username] = @username";
                string query2 = "SELECT [user_id] FROM [user] WHERE [username] = @username";
                string query3 = "SELECT [user_type] from [user] WHERE [username] = @username";
                SqlCommand Log_in = new SqlCommand(query, CNN);
                SqlCommand retreiveID = new SqlCommand(query2, CNN);
                SqlCommand retreiveType = new SqlCommand(query3, CNN);
                Log_in.Parameters.AddWithValue("@username", Username_txt.Text);
                retreiveID.Parameters.AddWithValue("@username", Username_txt.Text);
                retreiveType.Parameters.AddWithValue("@username", Username_txt.Text);
                object result = Log_in.ExecuteScalar();
                if (result != null && result.ToString().TrimEnd() == password_txt.Text)
                {
                    ShareData.userID = Convert.ToInt32(retreiveID.ExecuteScalar());
                    if (Convert.ToInt32(retreiveType.ExecuteScalar()) == 0)
                    {
                        StudentDashboard studentDashboard = new StudentDashboard();
                        this.Hide();
                        studentDashboard.Show();
                    }
                    else if (Convert.ToInt32(retreiveType.ExecuteScalar()) == 1)
                    {
                        AdminDashboard adminDashboard = new AdminDashboard();
                        this.Hide();
                        adminDashboard.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password Please Try Again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

            CNN.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void LinktoReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterStudent registerStudent = new RegisterStudent();
            this.Hide();
            registerStudent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
                startPoint = screenPoint;
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



        private void password_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                LoginButton.PerformClick();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password_txt.UseSystemPasswordChar = !checkBox1.Checked;

        }
    }
}
