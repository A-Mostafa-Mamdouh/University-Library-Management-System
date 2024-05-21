using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace University_Library
{
    public partial class yourlibrary : Form
    {
        public yourlibrary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public List<int> GetlistBooksID()
        {
            List<int> bookIds = new List<int>();

            string query = @"
    SELECT t.book_id, t.transaction_date, t.transaction_type
    FROM Transactions t
    INNER JOIN (
        SELECT book_id, MAX(transaction_date) AS max_date
        FROM Transactions
        WHERE user_id = @UserId
        GROUP BY book_id
    ) max_dates
    ON t.book_id = max_dates.book_id AND t.transaction_date = max_dates.max_date
    WHERE t.user_id = @UserId
    AND t.transaction_type = 'add';";

            using (SqlConnection connection = new SqlConnection(ShareData.CON))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", ShareData.userID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string transactionType = reader.GetString(reader.GetOrdinal("transaction_type"));

                            if (transactionType == "add")
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal("book_id")))
                                {
                                    int bookId = reader.GetInt32(reader.GetOrdinal("book_id"));
                                    bookIds.Add(bookId);
                                }
                            }
                        }
                    }
                }
            }

            return bookIds;
        }




        public List<string> RetrieveTitles(List<int> bookIds)
        {
            List<string> titles = new List<string>();

            foreach (int bookId in bookIds)
            {
                string title = RetrieveTitleForBookId(bookId);
                titles.Add(title);
            }
            return titles;
        }

        public string RetrieveTitleForBookId(int bookId)
        {
            string title = "";

            string connectionString = ShareData.CON;

            string query = "SELECT title FROM Books WHERE itemid = @BookId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookId", bookId);
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        title = result.ToString();
                    }

                }
            }

            return title;
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

        public struct BookProperties
        {
            public string Title;
            public string Author;
            public string Category;
            public int PublicationYear;
            public string ISBN;
            public string Type;
            public string Narrator;
            public string Duration;
            public string rating;

        }

        public BookProperties RetrieveBookPropertiesForTitle(string title)
        {
            BookProperties properties = new BookProperties();

            string connectionString = ShareData.CON;

            string query = @"SELECT b.title, a.author_name, b.category, b.rating,b.publication_year, b.isbn, b.book_type, b.duration, b.narrator
                     FROM Books b
                     JOIN Author a ON b.author_id = a.author_id
                     WHERE b.title = @Title";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            properties.Title = reader["title"].ToString();
                            properties.Author = reader["author_name"].ToString();
                            properties.Category = reader["category"].ToString();
                            properties.PublicationYear = Convert.ToInt32(reader["publication_year"]);
                            properties.ISBN = reader["isbn"].ToString();
                            properties.rating = reader["rating"].ToString();
                            int bookType = Convert.ToInt32(reader["book_type"]);
                            properties.Type = (bookType == 0) ? "Normal" : "Audio";

                            if (bookType == 0)
                            {
                                properties.Narrator = "N/A";
                                properties.Duration = "N/A";
                            }
                            else
                            {
                                properties.Narrator = reader["narrator"].ToString();
                                properties.Duration = reader["duration"].ToString();
                            }
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error retrieving book properties: " + ex.Message);
                    }
                }
            }

            return properties;
        }


        private void yourlibrary_Load(object sender, EventArgs e)
        {

            authorlabel.Text = "";
            categorylabel.Text = "";
            publicationlabel.Text = "";
            isbnlabel.Text = "";
            typelabel.Text = "";
            ratinglabel.Text = "";
            narratorlabel.Text = "";
            durationlabel.Text = "";
            List<int> bookIds = GetlistBooksID();

            PopulateListBoxWithTitles(bookIds);

        }

        private void PopulateListBoxWithTitles(List<int> bookIds)
        {
            List<string> titles = RetrieveTitles(bookIds);
            listBoxTitles.Items.Clear();
            foreach (string title in titles)
            {
                listBoxTitles.Items.Add(title);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTitles.SelectedItem != null)
            {
                string selectedTitle = listBoxTitles.SelectedItem.ToString();
                string coverUrl = RetrieveCoverUrl(selectedTitle);

                if (!string.IsNullOrEmpty(coverUrl))
                {
                    pictureBox1.Load(coverUrl);
                }
                else
                {
                    pictureBox1.Image = null;
                }

                BookProperties properties = RetrieveBookPropertiesForTitle(selectedTitle);
                authorlabel.Text = properties.Author;
                categorylabel.Text = properties.Category;
                publicationlabel.Text = properties.PublicationYear.ToString();
                isbnlabel.Text = properties.ISBN;
                typelabel.Text = properties.Type;
                ratinglabel.Text = properties.rating;
                narratorlabel.Text = properties.Narrator;
                durationlabel.Text = properties.Duration;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxTitles.SelectedItem == null)
            {
                MessageBox.Show("Please select an item first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedTitle = listBoxTitles.SelectedItem.ToString();
            (int bookId, string lastTransactionType) = RetrieveBookIdAndLastTransactionType(selectedTitle);


            int userId = ShareData.userID;

            bookId = RetrieveBookId(selectedTitle);

            string transactionType = "remove";

            DateTime transactionDate = DateTime.Now;

            InsertTransaction(transactionType, userId, bookId, transactionDate,selectedTitle,getISBN(selectedTitle),getName());

            authorlabel.Text = "";
            categorylabel.Text = "";
            publicationlabel.Text = "";
            isbnlabel.Text = "";
            typelabel.Text = "";
            ratinglabel.Text = "";
            narratorlabel.Text = "";
            durationlabel.Text = "";
            pictureBox1.Image = null;
            List<int> bookIds = GetlistBooksID();
            listBoxTitles.Items.Clear();
            PopulateListBoxWithTitles(bookIds);

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
                    MessageBox.Show("Item Removed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting transaction: " + ex.Message);
                }
            }

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

    }
}

