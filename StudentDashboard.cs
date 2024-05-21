using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace University_Library
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }
        private void ButtonColorChangeByClick(Button btn1, Button btn2, Button btn3)
        {
            btn1.BackColor = Color.FromArgb(0, 122, 204);
            btn2.BackColor = Color.FromArgb(28, 28, 28);
            btn3.BackColor = Color.FromArgb(28, 28, 28);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Librarybtn_Click(object sender, EventArgs e)
        {
            loadform(new yourlibrary());
            ButtonColorChangeByClick(Librarybtn, update_btn, browse_btn);
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            SqlConnection CNN = new(ShareData.CON);
            CNN.Open();
            string query = "SELECT [username] FROM [user] WHERE [user_id] = @userID";
            SqlCommand retrieveName = new SqlCommand(query, CNN);
            retrieveName.Parameters.AddWithValue("@userID", ShareData.userID);
            object name = retrieveName.ExecuteScalar();
            if (name != null)
            {
                string userName = name.ToString();
                username_lbl.Text = userName;
                CenterLabelInPanel();
            }
            ButtonColorChangeByClick(Librarybtn, update_btn, browse_btn);
            loadform(new yourlibrary());
            CNN.Close();
        }

        private void CenterLabelInPanel()
        {

            int labelWidth = username_lbl.Width;
            int panelWidth = panel1.Width;

            int x = (panelWidth - labelWidth) / 2;
            int y = username_lbl.Location.Y;

            username_lbl.Location = new Point(x, y);
        }
        private void browse_btn_Click(object sender, EventArgs e)
        {
            loadform(new BrowseLib());
            ButtonColorChangeByClick(browse_btn, Librarybtn, update_btn);


        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            UpdateDetails updateDetails = new UpdateDetails();
            updateDetails.Owner = this; 
            loadform(updateDetails);
            ButtonColorChangeByClick(update_btn, browse_btn, Librarybtn);
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
