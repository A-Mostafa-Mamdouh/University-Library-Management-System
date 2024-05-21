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
    public partial class MngItems : Form
    {
        public MngItems()
        {
            InitializeComponent();
        }

        private void MngItems_Load_2(object sender, EventArgs e)
        {

            retreiveBookTitle();
            retreiveAuthorNames();

        }

        public struct BookProperties
        {
            public string Title;
            public string Author;
            public string Category;
            public int PublicationYear;
            public int booktype;
            public string ISBN;
            public string Type;
            public string Narrator;
            public string Duration;
            public string rating;
            public string coverurl;

        }

        public BookProperties RetrieveBookPropertiesForTitle(string title)
        {
            BookProperties properties = new BookProperties();

            string connectionString = ShareData.CON;

            string query = @"SELECT b.title, a.author_name, b.category, b.rating,b.publication_year, b.isbn, b.book_type, b.duration, b.narrator,b.cover_url
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
                            properties.coverurl = reader["cover_url"].ToString();
                            properties.booktype = Convert.ToInt32(reader["book_type"]);
                            properties.Type = (properties.booktype == 0) ? "Normal" : "Audio";

                            if (properties.booktype == 0)
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
        private void open_file_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            openDialog.Title = "Select Cover Art Image";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openDialog.FileName;
                cover_url_txt.Text = selectedFilePath;

            }
        }
        private void RemoveBookBtn_Click(object sender, EventArgs e)
        {

            if (BookList.SelectedIndex != -1)
            {
                string query = "DELETE FROM [books] WHERE [title] = @BookTitle";
                int bookid = RetrieveBookId(BookList.SelectedItem.ToString());
                SqlConnection CNN = new SqlConnection(ShareData.CON);
                DateTime transactionDate = DateTime.Now;
                InsertTransaction("Remove_DB", ShareData.userID, RetrieveBookId(BookList.SelectedItem.ToString()), transactionDate, BookList.SelectedItem.ToString(), getISBN(BookList.SelectedItem.ToString()),getName());
                CNN.Open();
                SqlCommand deleteBook = new SqlCommand(query, CNN);
                deleteBook.Parameters.AddWithValue("@BookTitle", BookList.SelectedItem.ToString());
                deleteBook.ExecuteNonQuery();
                BookList.Items.Clear();
                retreiveBookTitle();
                CNN.Close();
            }
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
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        private void retreiveBookTitle()
        {
            string query = "SELECT [title] FROM [books]";
            using (SqlConnection cnn = new SqlConnection(ShareData.CON))
            {
                cnn.Open();
                using (SqlCommand retreivebookTitle = new SqlCommand(query, cnn))
                {
                    using (SqlDataReader reader = retreivebookTitle.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string authorName = reader["title"].ToString();
                            BookList.Items.Add(authorName);
                        }
                    }
                }
            }

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

        private void retreiveAuthorNames()
        {
            string query = "SELECT [author_name] FROM [Author]";
            using (SqlConnection cnn = new SqlConnection(ShareData.CON))
            {
                cnn.Open();
                using (SqlCommand retrieveAuthor = new SqlCommand(query, cnn))
                {
                    using (SqlDataReader reader = retrieveAuthor.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string authorName = reader["author_name"].ToString();
                            author_combo_box.Items.Add(authorName);
                        }
                    }
                }
            }

        }

        private int getAuthorId(string author_name)
        {
            int authorId = -1;
            string query = "SELECT author_id FROM Author WHERE author_name = @AuthorName";
            SqlConnection CNN = new SqlConnection(ShareData.CON);
            CNN.Open();
            SqlCommand retreive = new SqlCommand(query, CNN);
            retreive.Parameters.AddWithValue("@AuthorName", author_name);
            object result = retreive.ExecuteScalar();
            authorId = Convert.ToInt32(result);
            CNN.Close();
            return authorId;
        }

        private void add_update_btn_Click(object sender, EventArgs e)
        {
            int bookid = -1;
            string selectedBook = "";
            if (BookList.SelectedIndex != -1)
            {
                selectedBook = BookList.SelectedItem.ToString();
                bookid = RetrieveBookId(BookList.SelectedItem.ToString());

            }

            string newTitle = title_txt.Text.Trim();
            string newCategory = category_txt.Text.ToString();
            float newRating = (float)Math.Round(rating_box.Value, 2);
            int newPublicationYear = (int)puc_year.Value;
            string author = author_combo_box.Text.Trim();
            bool newBookType = isaudio_check.Checked;
            string newDuration = duration_txt.Text.Trim();
            string newNarrator = narrator_txt.Text.Trim();
            string newCoverUrl = cover_url_txt.Text.Trim();
            string isbn = isbn_txt.Text.Trim();
            int authorid = getAuthorId(selectedBook);

            if (update_radio_btn.Checked)
            {
                if (BookList.SelectedIndex == -1)
                {
                    MessageBox.Show("Select a book to edit.");
                    return;
                }
                else
                {
                    string query = @"
            UPDATE Books
            SET ";

                    if (!string.IsNullOrEmpty(newTitle))
                    {
                        query += "title = @NewTitle, ";
                    }

                    if (!string.IsNullOrEmpty(newCategory))
                    {
                        query += "category = @NewCategory, ";
                    }

                    if (newRating > 0)
                    {
                        query += "rating = @NewRating, ";
                    }

                    if (newPublicationYear > 0)
                    {
                        query += "publication_year = @NewPublicationYear, ";
                    }

                    if (!string.IsNullOrEmpty(newDuration))
                    {
                        query += "duration = @NewDuration, ";
                    }

                    if (!string.IsNullOrEmpty(newNarrator))
                    {
                        query += "narrator = @NewNarrator, ";
                    }

                    if (!string.IsNullOrEmpty(newCoverUrl))
                    {
                        query += "cover_url = @NewCoverUrl, ";
                    }

                    if (!string.IsNullOrEmpty(isbn))
                    {
                        query += "isbn = @NewIsbn, ";
                    }

                    if (!string.IsNullOrEmpty(author))
                    {
                        authorid = getAuthorId(author);
                        if (authorid != -1)
                        {
                            query += "author_ID = @NewAuthorID, ";
                        }
                        else
                        {
                            MessageBox.Show("Author not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    query = query.TrimEnd(',', ' ');

                    query += " WHERE itemid = @BookID";

                    using (SqlConnection cnn = new SqlConnection(ShareData.CON))
                    {
                        cnn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, cnn))
                        {
                            if (!string.IsNullOrEmpty(newTitle))
                            {
                                cmd.Parameters.AddWithValue("@NewTitle", newTitle);
                            }

                            if (!string.IsNullOrEmpty(newCategory))
                            {
                                cmd.Parameters.AddWithValue("@NewCategory", newCategory);
                            }

                            if (newRating > 0)
                            {
                                cmd.Parameters.AddWithValue("@NewRating", Math.Round(newRating, 2));
                            }

                            if (newPublicationYear > 0)
                            {
                                cmd.Parameters.AddWithValue("@NewPublicationYear", newPublicationYear);
                            }

                            if (!string.IsNullOrEmpty(newDuration))
                            {
                                cmd.Parameters.AddWithValue("@NewDuration", newDuration);
                            }

                            if (!string.IsNullOrEmpty(isbn))
                            {
                                cmd.Parameters.AddWithValue("@NewIsbn", isbn);
                            }

                            if (!string.IsNullOrEmpty(newNarrator))
                            {
                                cmd.Parameters.AddWithValue("@NewNarrator", newNarrator);
                            }

                            if (!string.IsNullOrEmpty(newCoverUrl))
                            {
                                cmd.Parameters.AddWithValue("@NewCoverUrl", newCoverUrl);
                            }

                            if (!string.IsNullOrEmpty(author))
                            {
                                cmd.Parameters.AddWithValue("@NewAuthorID", authorid);
                            }
                            cmd.Parameters.AddWithValue("@BookID", bookid);

                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                DateTime transactionDate = DateTime.Now;
                                InsertTransaction("Update_Book", ShareData.userID, RetrieveBookId(BookList.SelectedItem.ToString()), transactionDate, BookList.SelectedItem.ToString(), getISBN(BookList.SelectedItem.ToString()), getName());
                                MessageBox.Show("Book updated successfully.");
                                BookList.Items.Clear();
                                retreiveBookTitle();
                            }
                        }
                    }
                }
            }

            else if (add_radio_btn.Checked)
            {
                if (string.IsNullOrEmpty(newTitle))
                {
                    MessageBox.Show("Please enter values for title", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"
    INSERT INTO Books (title, isbn,category, rating, publication_year, book_type, duration, narrator, cover_url";

                if (!string.IsNullOrEmpty(author))
                {
                    query += ", author_ID";
                }

                query += @")
    VALUES (@NewTitle, @NewIsbn,@NewCategory, @NewRating, @NewPublicationYear, @NewBookType, @NewDuration, @NewNarrator, @NewCoverUrl";

                if (!string.IsNullOrEmpty(author))
                {
                    query += ", @NewAuthorID";
                }

                query += ")";

                using (SqlConnection cnn = new SqlConnection(ShareData.CON))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@NewTitle", newTitle);
                        cmd.Parameters.AddWithValue("@NewCategory", newCategory);
                        cmd.Parameters.AddWithValue("@NewRating", Math.Round(newRating, 2));
                        cmd.Parameters.AddWithValue("@NewPublicationYear", newPublicationYear);
                        cmd.Parameters.AddWithValue("@NewBookType", newBookType);
                        cmd.Parameters.AddWithValue("@NewDuration", newDuration);
                        cmd.Parameters.AddWithValue("@NewNarrator", newNarrator);
                        cmd.Parameters.AddWithValue("@NewCoverUrl", newCoverUrl);
                        cmd.Parameters.AddWithValue("@NewIsbn", isbn);

                        if (!string.IsNullOrEmpty(author))
                        {
                            authorid = getAuthorId(author);
                            if (authorid != -1)
                            {
                                cmd.Parameters.AddWithValue("@NewAuthorID", authorid);
                            }
                            else
                            {
                                MessageBox.Show("Author not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            DateTime transactionDate = DateTime.Now;
                            InsertTransaction("Add_DB", ShareData.userID, RetrieveBookId(newTitle), transactionDate, newTitle, getISBN(newTitle), getName());
                            MessageBox.Show("New book added successfully.");
                            BookList.Items.Clear();
                            retreiveBookTitle();
                        }
                    }
                }
            }
        }


        private void BookList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (BookList.SelectedItem != null)
            {
                string selectedTitle = BookList.SelectedItem.ToString();
                string coverUrl = RetrieveCoverUrl(selectedTitle);

                if (!string.IsNullOrEmpty(coverUrl))
                {
                    cover_image.Load(coverUrl);
                }
                else
                {
                    cover_image.Image = null;
                }

                BookProperties properties = RetrieveBookPropertiesForTitle(selectedTitle);
                title_txt.Text = properties.Title;
                author_combo_box.Text = properties.Author;
                category_txt.Text = properties.Category;
                puc_year.Text = properties.PublicationYear.ToString();
                isbn_txt.Text = properties.ISBN;
                if (properties.booktype == 1)
                {
                    isaudio_check.Checked = true;
                    narrator_txt.Text = properties.Narrator;
                    duration_txt.Text = properties.Duration;
                }
                else
                {
                    isaudio_check.Checked = false;
                    narrator_txt.Clear();
                    duration_txt.Clear();
                }
                rating_box.Text = properties.rating;
                cover_url_txt.Clear();
            }
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
        private void isaudio_check_CheckedChanged(object sender, EventArgs e)
        {
            if (!isaudio_check.Checked)
            {
                narrator_txt.Clear();
                duration_txt.Clear();
            }
        }
        private string getName() {
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
