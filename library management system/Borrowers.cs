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

namespace library_management_system
{
    public partial class Borrowers : Form
    {
        public Borrowers()
        {
            InitializeComponent();
        }

        private void Borrowers_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
            loadAllBorrowes();
        }

        public void SelectTabByName(string tabName)
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                if (tabPage.Name == tabName)
                {
                    tabControl1.SelectedTab = tabPage;
                    break;
                }
            }
        }

        private void LoadBorrowedBooks()
        {
            try
            {


                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT B.BookName, B.BookAuthor, BR.BorrowDate, BR.DueDate, Username " +
                            "FROM Book B, BorrowedBooks BR, login L " +
                            "WHERE B.B_ID = BR.Book_ID AND BR.User_ID = L.ID ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        dataGridView_borrowes.DataSource = dataTable;
                        dataGridView_manage.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {
            string searchUsername = txt_search.Text.Trim();

            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT B.BookName, B.BookAuthor, BR.BorrowDate, BR.DueDate, L.Username " +
                                    "FROM Book B, BorrowedBooks BR, login L " +
                                    "WHERE B.B_ID = BR.Book_ID AND BR.User_ID = L.ID AND L.Username LIKE @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", "%" + searchUsername + "%");

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        dataGridView_borrowes.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchUsername = txt_filter.Text.Trim();

            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT B.BookName, B.BookAuthor, BR.BorrowDate, BR.DueDate, L.Username " +
                                    "FROM Book B, BorrowedBooks BR, login L " +
                                    "WHERE B.B_ID = BR.Book_ID AND BR.User_ID = L.ID AND L.Username LIKE @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", "%" + searchUsername + "%");

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        dataGridView_manage.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView_manage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_manage.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_manage.Rows[e.RowIndex];
                DateTime dueDate = (DateTime)selectedRow.Cells["DueDate"].Value;

                dateTimePicker_extend.Value = dueDate;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView_manage.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_manage.SelectedRows[0];
                string selectedUsername = selectedRow.Cells["Username"].Value.ToString();
                string selectedBookName = selectedRow.Cells["BookName"].Value.ToString();

                // Calculate the new due date from the dateTimePicker_extend control
                DateTime newDueDate = dateTimePicker_extend.Value;

                try
                {
                    string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Get the corresponding User_ID and Book_ID from the database
                        int userID = GetUserID(selectedUsername); // Implement this method
                        int bookID = GetBookID(selectedBookName); // Implement this method

                        string updateQuery = "UPDATE BorrowedBooks SET DueDate = @DueDate WHERE User_ID = @User_ID AND Book_ID = @Book_ID";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@DueDate", newDueDate);
                            updateCmd.Parameters.AddWithValue("@User_ID", userID);
                            updateCmd.Parameters.AddWithValue("@Book_ID", bookID);

                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Due date extended successfully!");
                                LoadBorrowedBooks();
                            }
                            else
                            {
                                MessageBox.Show("Failed to extend due date.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private int GetUserID(string username)
        {
            int userID = -1; // Default value if user not found

            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ID FROM login WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            userID = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while getting UserID: " + ex.Message);
            }

            return userID;
        }

        private int GetBookID(string bookName)
        {
            int bookID = -1; // Default value if book not found

            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT B_ID FROM Book WHERE BookName = @BookName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookName", bookName);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            bookID = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while getting BookID: " + ex.Message);
            }

            return bookID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_manage.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to remove.");
                    return;
                }
                

                DataGridViewRow selectedRow = dataGridView_manage.SelectedRows[0];
                string selectedUsername = selectedRow.Cells["Username"].Value.ToString();
                string selectedBookName = selectedRow.Cells["BookName"].Value.ToString();

                int userID = GetUserID(selectedUsername);
                int bookID = GetBookID(selectedBookName);


                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";
                string deleteQuery = "DELETE FROM BorrowedBooks WHERE User_ID = @User_ID AND Book_ID = @Book_ID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                {
                    conn.Open();

                    deleteCmd.Parameters.AddWithValue("@User_ID", userID);
                    deleteCmd.Parameters.AddWithValue("@Book_ID", bookID);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        
                        dataGridView_manage.Rows.Remove(selectedRow);
                        MessageBox.Show("Borrower removed successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove borrower.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void loadAllBorrowes()
        {
            try
            {


                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT l.Username, B.BookName, B.BookAuthor, BH.BorrowedDate, BH.ReturnedDate, Fees " +
                            "FROM Book B, BorrowingHistory BH, login L " +
                            "WHERE L.ID = BH.User_ID and B.B_ID = BH.Book_ID ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        dataGridView_history.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
    }
