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
    public partial class BorrowedBooks : UserControl
    {
        private static string loggedInUsername;

        public BorrowedBooks()
        {
            InitializeComponent();
            
        }

        public BorrowedBooks(string username)
        {
            InitializeComponent();
            loggedInUsername = username;

            
        }

        private void BorrowedBooks_Load(object sender, EventArgs e)
        {
           
            

             LoadBorrowedBooks();

            dataGridView_borrwed.EditingControlShowing += dataGridView_borrwed_EditingControlShowing;
        }

        private void dataGridView_borrwed_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl editingControl = (DataGridViewTextBoxEditingControl)e.Control;
            editingControl.KeyPress -= editingControl_KeyPress;
            editingControl.KeyPress += editingControl_KeyPress;
        }

        private void editingControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Prevent any character input
        }

        private void dataGridView_borrwed_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LoadBorrowedBooks()
        {
            try
            {
                int loggedInUserID = GetLoggedInUserID();

                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT B.BookName, B.BookAuthor, BR.BorrowDate, BR.DueDate " +
                            "FROM Book B, BorrowedBooks BR, login L " +
                            "WHERE B.B_ID = BR.Book_ID AND BR.User_ID = L.ID AND BR.User_ID = @User_ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@User_ID", loggedInUserID);

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        dataGridView_borrwed.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_borrwed.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to return.");
                    return;
                }


                DataGridViewRow selectedRow = dataGridView_borrwed.SelectedRows[0];
                int userID = GetLoggedInUserID();
                string bookname = (string)selectedRow.Cells["BookName"].Value;
                string bookauthor = (string)selectedRow.Cells["BookAuthor"].Value;
                int bookID = GetBookID(bookname, bookauthor);
                DateTime borrowDate = (DateTime)selectedRow.Cells["BorrowDate"].Value;

                DateTime returnDate = dateTimePicker_return.Value;

                TimeSpan timeSpan = returnDate - borrowDate;
                int daysBorrowed = timeSpan.Days;

                decimal fees = (daysBorrowed > 7) ? 10.0m : 0.0m;


                RemoveBorrowedBook(userID, bookID);


                UpdateUserFees(userID, fees, bookID, returnDate);


                LoadBorrowedBooks();

                returnedbook(bookID);

                MessageBox.Show($"Book returned successfully. Fees: ${fees}");


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void RemoveBorrowedBook(int userID, int bookID)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM BorrowedBooks WHERE User_ID = @User_ID AND Book_ID = @Book_ID";

                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@User_ID", userID);
                        deleteCmd.Parameters.AddWithValue("@Book_ID", bookID);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // You can add more code here if needed, like updating the book's availability status.
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove borrowed book.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void UpdateUserFees(int userID, decimal fees, int BookID, DateTime Returndate)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string updateQuery = "UPDATE BorrowingHistory SET Fees = @Fees, ReturnedDate = @ReturnedDate WHERE User_ID = @User_ID and Book_ID = @Book_ID";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@Fees", fees);
                        updateCmd.Parameters.AddWithValue("@User_ID", userID);
                        updateCmd.Parameters.AddWithValue("@Book_ID", BookID);
                        updateCmd.Parameters.AddWithValue("@ReturnedDate", Returndate);


                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Failed to update user's fees.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView_borrwed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void returnedbook(int bookID)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                string returnquery = "Update Book set Quantity = @Quantity where B_ID = @B_ID ";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand updatequantity = new SqlCommand(returnquery, conn))
                    {
                        int total = GetQuantity(bookID);
                        updatequantity.Parameters.AddWithValue("@B_ID", bookID);
                        updatequantity.Parameters.AddWithValue("@Quantity", (total+1));

                        updatequantity.ExecuteNonQuery();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("An Error Occured: " + ex.Message);
            }

                
            }

            private int GetQuantity(int Book_ID)
            {
                int bookQuantity = 0;

                try
                {
                    string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "SELECT Quantity FROM Book WHERE B_ID = @B_ID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@B_ID", Book_ID);

                            object result = cmd.ExecuteScalar();

                            if (result != null && result != DBNull.Value)
                            {
                                bookQuantity = Convert.ToInt32(result); // Retrieve the actual quantity value
                            }
                            else
                            {
                                // Handle the case where the quantity is not found in the database
                                MessageBox.Show("Quantity not found for the selected book.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

                return bookQuantity;
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
