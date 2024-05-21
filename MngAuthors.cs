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
    public partial class MngAuthors : Form
    {
        public MngAuthors()
        {
            InitializeComponent();
        }

        private void AuthorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AuthorList.SelectedIndex != -1) // Check if an item is selected
            {
                string selectedAuthor = AuthorList.SelectedItem.ToString();
                string query = @"
            SELECT A.author_name, COUNT(B.itemid) AS book_count, A.publisher_name
            FROM Author A
            LEFT JOIN Books B ON A.author_ID = B.author_ID
            WHERE A.author_name = @AuthorName
            GROUP BY A.author_name, A.publisher_name";

                using (SqlConnection cnn = new SqlConnection(ShareData.CON))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@AuthorName", selectedAuthor);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string authorName = reader["author_name"].ToString();
                                string publisherName = reader["publisher_name"].ToString();
                                int bookCount = reader["book_count"] == DBNull.Value ? 0 : Convert.ToInt32(reader["book_count"]);

                                publisher_lbl.Text = publisherName;
                                noOfItemsLbl.Text = bookCount.ToString();
                            }
                            else
                            {
                                publisher_lbl.Text = "";
                                noOfItemsLbl.Text = "0";
                            }
                        }
                    }
                }
            }
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
                            AuthorList.Items.Add(authorName);
                        }
                    }
                }
            }

        }

        private void Mngitems_Load(object sender, EventArgs e)
        {
            retreiveAuthorNames();
        }

        private void RemoveAuthorBtn_Click(object sender, EventArgs e)
        {
            if (AuthorList.SelectedIndex != -1)
            {
                if (Convert.ToInt16(noOfItemsLbl.Text) != 0)
                {
                    MessageBox.Show("Can't Remove Author, Author has items", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (Convert.ToInt16(noOfItemsLbl.Text) == 0)
                {
                    string query = "DELETE FROM [Author] WHERE [author_name] = @AuthorName";
                    SqlConnection CNN = new SqlConnection(ShareData.CON);
                    CNN.Open();
                    SqlCommand deleteauthor = new SqlCommand(query, CNN);
                    deleteauthor.Parameters.AddWithValue("@AuthorName", AuthorList.SelectedItem.ToString());
                    deleteauthor.ExecuteNonQuery();
                    AuthorList.Items.Clear();
                    retreiveAuthorNames();
                    CNN.Close();

                }
            }
        }


        private void add_update_btn_Click(object sender, EventArgs e)
        {
            string newAuthorName = author_name_txt.Text.Trim();
            string newPublisherName = publisher_name_txt.Text.Trim();

            if (update_radio_btn.Checked)
            {
                // Update existing author
                if (string.IsNullOrEmpty(newAuthorName) && string.IsNullOrEmpty(newPublisherName))
                {
                    MessageBox.Show("Please enter a new author name or publisher name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string selectedAuthor = AuthorList.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedAuthor))
                {
                    MessageBox.Show("Select an author to edit.");
                    return;
                }

                string query = @"
            UPDATE Author
            SET ";

                if (!string.IsNullOrEmpty(newAuthorName))
                {
                    query += "author_name = @NewAuthorName";
                }

                if (!string.IsNullOrEmpty(newPublisherName))
                {
                    if (!string.IsNullOrEmpty(newAuthorName))
                    {
                        query += ", ";
                    }
                    query += "publisher_name = @NewPublisherName";
                }

                query += " WHERE author_name = @AuthorName";

                using (SqlConnection cnn = new SqlConnection(ShareData.CON))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        if (!string.IsNullOrEmpty(newAuthorName))
                        {
                            cmd.Parameters.AddWithValue("@NewAuthorName", newAuthorName);
                        }
                        if (!string.IsNullOrEmpty(newPublisherName))
                        {
                            cmd.Parameters.AddWithValue("@NewPublisherName", newPublisherName);
                        }
                        cmd.Parameters.AddWithValue("@AuthorName", selectedAuthor);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Author updated successfully.");
                            AuthorList.Items.Clear();
                            retreiveAuthorNames();
                        }
                    }
                }
            }
            else if (add_radio_btn.Checked)
            {
                if (string.IsNullOrEmpty(newAuthorName) && string.IsNullOrEmpty(newPublisherName))
                {
                    MessageBox.Show("Please enter a new author name or publisher name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string query = @"
            INSERT INTO Author (author_name, publisher_name)
            VALUES (@NewAuthorName, @NewPublisherName)";

                using (SqlConnection cnn = new SqlConnection(ShareData.CON))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@NewAuthorName", newAuthorName);
                        cmd.Parameters.AddWithValue("@NewPublisherName", newPublisherName);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("New author added successfully.");
                            AuthorList.Items.Clear();
                            retreiveAuthorNames();
                        }
                    }
                }
            }
        }



        private void author_name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
