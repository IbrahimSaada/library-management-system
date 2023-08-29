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


namespace library_management_system.UserControls
{
    public partial class Books : UserControl
    {
        private static string loggedInUsername;

        public Books()
        {
            InitializeComponent();

            dataGridView_Books.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Books.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView_Books.RowPostPaint += dataGridView_Books_RowPostPaint; // Subscribe to the event
            dataGridView_Books.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            LoadBooks();

        }

        public Books(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
           
             LoadBooks();



        }


        private void Books_Load(object sender, EventArgs e)
        {
           


        }

        private void btn_issue_Click(object sender, EventArgs e)
        {
            try
            {
                int loggedInUserID = GetLoggedInUserID(); // Implement this method

                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the user has already borrowed the selected book
                    DataGridViewRow selectedRow = dataGridView_Books.SelectedRows[0];
                    string selectedBookName = selectedRow.Cells["BookName"].Value.ToString();
                    string selectedBookAuthor = selectedRow.Cells["BookAuthor"].Value.ToString();
                    string selectedAvailabilty = selectedRow.Cells["Available"].Value.ToString();


                    int bookID = GetBookID(selectedBookName, selectedBookAuthor); // Implement this method

                    if (selectedAvailabilty != "Available" && selectedAvailabilty != "available")
                    {
                        MessageBox.Show("This Books is unavailable!");
                    }
                    else
                    {

                        string checkQuery = "SELECT COUNT(*) FROM BorrowedBooks WHERE User_ID = @User_ID AND Book_ID = @Book_ID";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@User_ID", loggedInUserID);
                            checkCmd.Parameters.AddWithValue("@Book_ID", bookID);

                            int existingCount = (int)checkCmd.ExecuteScalar();

                            if (existingCount > 0)
                            {
                                MessageBox.Show("You have already borrowed this book.");
                                return;
                            }
                        }

                        // Check the number of books already borrowed by the user from the BorrowedBooks table
                        string countQuery = "SELECT COUNT(*) FROM BorrowedBooks WHERE User_ID = @User_ID";
                        using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                        {
                            countCmd.Parameters.AddWithValue("@User_ID", loggedInUserID);
                            int borrowedBooksCount = (int)countCmd.ExecuteScalar();

                            // Check if the user can borrow another book
                            if (borrowedBooksCount >= 3)
                            {
                                MessageBox.Show("You have already borrowed the maximum allowed books (3).");
                                return;
                            }
                        }


                        DateTime issueDate = DateTime.Now;
                        DateTime dueDate = dateTimePicker2.Value;

                        // Insert a new record into the IssueBook table
                        string insertQuery = "INSERT INTO IssueBook (Book_ID, User_ID, IssueDate, DueDate) " +
                                     "VALUES (@Book_ID, @User_ID, @IssueDate, @DueDate)";

                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Book_ID", bookID);
                            insertCmd.Parameters.AddWithValue("@User_ID", loggedInUserID);
                            insertCmd.Parameters.AddWithValue("@IssueDate", issueDate);
                            insertCmd.Parameters.AddWithValue("@DueDate", dueDate);

                            int rowsAffected = insertCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book issued successfully!");
                                // You can add more code here if needed, like updating the book's availability status.
                            }
                            else
                            {
                                MessageBox.Show("Issuing book failed.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void listbox_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int GetLoggedInUserID()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string username = loggedInUsername; // Assuming you have stored the logged-in username
                    string query = "SELECT ID FROM login WHERE Username = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", loggedInUsername);

                        int userID = (int)cmd.ExecuteScalar();
                        return userID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return -1; // Return a default value or handle the error appropriately
            }
        }

        private int GetBookID(string bookName, string bookAuthor)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT B_ID FROM Book WHERE BookName = @BookName AND BookAuthor = @BookAuthor ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookName", bookName);
                        cmd.Parameters.AddWithValue("@BookAuthor", bookAuthor);


                        int bookID = (int)cmd.ExecuteScalar();
                        return bookID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return -1; // Return a default value or handle the error appropriately
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txt_search.Text.Trim().ToLower();


           

            string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT BookName, BookAuthor, Available FROM Book WHERE LOWER(BookName) LIKE @SearchKeyword";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FilterKeyword", "%" + txt_search + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView_Books.DataSource = dataTable;
                    }
                }
                

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void LoadBooks()
        {
            try
            {
               

                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT B.BookName, B.BookAuthor, B.Available " +
                            "FROM Book B ";
                            

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        dataGridView_Books.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void dataGridView_Books_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
{
    if (e.RowIndex >= 0)
    {
        DataGridViewRow row = dataGridView_Books.Rows[e.RowIndex];
        if (row.DefaultCellStyle.WrapMode != DataGridViewTriState.True)
        {
            row.Height = row.GetPreferredHeight(e.RowIndex, DataGridViewAutoSizeRowMode.AllCells, true);
        }
    }
}
        
    }
}
