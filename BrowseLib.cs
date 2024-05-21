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
    public partial class BrowseLib : Form
    {
        public BrowseLib()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTitle = comboBoxTitles.SelectedItem.ToString();

            string coverUrl = RetrieveCoverUrl(selectedTitle);

            if (!string.IsNullOrEmpty(coverUrl))
            {
                CoverIMG.Load(coverUrl);
            }
            else
            {
                CoverIMG.Image = null;
            }
        }

        private string RetrieveCoverUrl(string selectedTitle)
        {
            string query = "SELECT cover_url FROM Books WHERE title = @title";

            using (SqlConnection connection = new SqlConnection(ShareData.CON))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@title", selectedTitle);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
            }

            return null;
        }
        private void BrowseLib_Load(object sender, EventArgs e)
        {
            LoadBookTitles();
            LoadCategories();
        }

        private void LoadBookTitles()
        {
            comboBoxTitles.Items.Clear();

            SqlConnection connection = new SqlConnection(ShareData.CON);
            string query = "SELECT title FROM books";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string title = reader["title"].ToString();
                comboBoxTitles.Items.Add(title);
            }

            reader.Close();
            connection.Close();
        }
        private void SearchBooks()
        {
            comboBoxTitles.Items.Clear();

            SqlConnection connection = new SqlConnection(ShareData.CON);
            string query = "SELECT title FROM books WHERE 1=1";

            if (radioButtonAudio.Checked)
            {
                query += " AND book_type = 1";
            }
            else if (radioButtonNormal.Checked)
            {
                query += " AND book_type = 0";
            }

            if (comboBoxCategories.SelectedIndex != -1)
            {
                string selectedCategory = comboBoxCategories.SelectedItem.ToString();
                query += $" AND category = '{selectedCategory}'";
            }

            if (!string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                string title = textBoxTitle.Text;
                query += $" AND title LIKE '%{title}%'";
            }
            if (!string.IsNullOrWhiteSpace(textBoxISBN.Text))
            {
                string isbn = textBoxISBN.Text;
                query += $" AND isbn LIKE '%{isbn}%'";
            }
            if (!string.IsNullOrWhiteSpace(textBoxAuthor.Text))
            {
                string author = textBoxAuthor.Text;
                query += $" AND author_id IN (SELECT author_id FROM Author WHERE author_name LIKE '%{author}%')";
            }
            decimal minRating = ratingNumBox.Value;
            query += $" AND rating >= {minRating}";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string title = reader["title"].ToString();
                comboBoxTitles.Items.Add(title);
            }

            reader.Close();
            connection.Close();
        }

        private void LoadCategories()
        {
            comboBoxCategories.Items.Clear();

            SqlConnection connection = new SqlConnection(ShareData.CON);
            string query = "SELECT DISTINCT category FROM books";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string category = reader["category"].ToString();
                comboBoxCategories.Items.Add(category);
            }

            reader.Close();
            connection.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchBooks();
        }

        private void ResetFilterBtn_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }

        private void ResetFilters()
        {
            textBoxTitle.Text = "";
            textBoxISBN.Text = "";
            textBoxAuthor.Text = "";

            radioButtonBoth.Checked = true;

            comboBoxCategories.SelectedIndex = -1;
            ratingNumBox.Value = 0;

            SearchBooks();
        }

        private (int bookId, string lastTransactionType) RetrieveBookIdAndLastTransactionType(string selectedTitle)
        {
            int bookId = 0;
            string lastTransactionType = "";

            string query = @"
  SELECT TOP 1 t.book_id, t.transaction_type
  FROM Transactions t
  JOIN Books b ON t.book_id = b.itemid
  WHERE b.title = @SelectedTitle
  AND t.user_id = @UserId
  ORDER BY t.transaction_date DESC";

            using (SqlConnection connection = new SqlConnection(ShareData.CON))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SelectedTitle", selectedTitle);
                command.Parameters.AddWithValue("@UserId", ShareData.userID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    bookId = reader.GetInt32(0);
                    lastTransactionType = reader.GetString(1);
                }
                reader.Close();
            }

            return (bookId, lastTransactionType);
        }
        private void InsertTransaction(string transactionType, int userId, int bookId, DateTime transactionDate, string booktitle = "", string isbn = "", string username = "")
        {
            string query = "INSERT INTO Transactions (transaction_type, user_id, book_id, transaction_date,book_title,isbn,username) VALUES (@TransactionType, @UserId, @BookId, @TransactionDate,@BookTitle,@ISBN,@username)";

            using (SqlConnection connection = new SqlConnection(ShareData.CON))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransactionType", transactionType);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@BookId", bookId);
                command.Parameters.AddWithValue("@TransactionDate", transactionDate);
                command.Parameters.AddWithValue("@BookTitle", booktitle);
                command.Parameters.AddWithValue("@ISBN", isbn);
                command.Parameters.AddWithValue("@username", username);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Item Added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting transaction: " + ex.Message);
                }
            }

        }
        
private void ratingNumBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (comboBoxTitles.SelectedItem == null)
            {
                MessageBox.Show("Please select an item first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedTitle = comboBoxTitles.SelectedItem.ToString();
            (int bookId, string lastTransactionType) = RetrieveBookIdAndLastTransactionType(selectedTitle);

            if (lastTransactionType == "add")
            {
                MessageBox.Show("Book already exists in your library", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = ShareData.userID;

            bookId = RetrieveBookId(selectedTitle);

            string transactionType = "add";

            DateTime transactionDate = DateTime.Now;

            InsertTransaction(transactionType, userId, bookId, transactionDate,selectedTitle,getISBN(selectedTitle),getName());
        }
        private int RetrieveBookId(string selectedTitle)
        {
            int bookId = 0;

            string query = "SELECT itemid FROM Books WHERE title = @SelectedTitle";

            using (SqlConnection connection = new SqlConnection(ShareData.CON))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SelectedTitle", selectedTitle);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    bookId = Convert.ToInt32(result);
                }
            }

            return bookId;
        }

        private void CoverIMG_Click(object sender, EventArgs e)
        {

        }

        private string getISBN(string title)
        {

            string query = "SELECT isbn FROM books WHERE title = @TITLE";
            SqlConnection CNN = new SqlConnection(ShareData.CON);
            CNN.Open();
            SqlCommand retreive = new SqlCommand(query, CNN);
            retreive.Parameters.AddWithValue("@TITLE", title);
            string result = retreive.ExecuteScalar().ToString();
            CNN.Close();
            return result;
        }
        private string getName()
        {
            SqlConnection CNN = new(ShareData.CON);
            CNN.Open();
            string query = "SELECT [username] FROM [user] WHERE [user_id] = @userID";
            SqlCommand retrieveName = new SqlCommand(query, CNN);
            retrieveName.Parameters.AddWithValue("@userID", ShareData.userID);
            string name = retrieveName.ExecuteScalar().ToString();
            return name;
        }
    }
}
