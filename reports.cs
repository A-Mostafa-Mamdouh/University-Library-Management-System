using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace University_Library
{
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }

        private void reports_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ShareData.CON);
            cnn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from transactions", cnn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            cnn.Close();

        }

        private void insertReport(string query)
        {
            string cmd = "INSERT INTO report (admin_id, [Date],query) VALUES (@Admin_ID,@DATE,@QUERY)";

            using (SqlConnection connection = new SqlConnection(ShareData.CON))
            {
                DateTime transactionDate = DateTime.Now;
                SqlCommand command = new SqlCommand(cmd, connection);
                command.Parameters.AddWithValue("@DATE", transactionDate);
                command.Parameters.AddWithValue("@Admin_ID", ShareData.userID);
                command.Parameters.AddWithValue("@QUERY", query);
                connection.Open();
                command.ExecuteNonQuery();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ShareData.CON);
            cnn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from books", cnn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            insertReport("select * from books");
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ShareData.CON);
            cnn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from [user]", cnn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            insertReport("select * from [user]");
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ShareData.CON);
            cnn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from [transactions] where [user_id] = " + usr_txt.Text, cnn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            insertReport("select * from [transactions] where [user_id] = " + usr_txt.Text);
            cnn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ShareData.CON);
            cnn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from [transactions] where [book_id] = " + book_txt.Text, cnn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            insertReport("select * from [transactions] where [book_id] = " + book_txt.Text);
            cnn.Close();
        }

        private void book_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
