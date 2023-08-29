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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;

namespace library_management_system
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            loadDataGridManage_Books();



            btn_delete.Click += btn_delete_Click;
            showRequestedUsers();


        }
        private void loadDataGridManage_Books()
        {
            string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                String query = "select BookName, BookAuthor, Quantity, Available from Book";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }


            datagrid_books.DataSource = dataTable;
            dataGridView_manage.DataSource = dataTable;
        }

        private void showRequestedUsers()
        {
            string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                String query = "Select L.Username, R.FirstName, R.LastName, B.BookName, I.IssueDate, I.DueDate " +
               "from Registration as R, Book as B, IssueBook as I, login as L " +
               "where I.User_ID = R.User_ID and I.Book_ID = B.B_ID and L.ID = I.User_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }


            dataGridView_Issue.DataSource = dataTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_bookname.Text == "" || txt_bookauthor.Text == "" || txt_quantity.Text == "")
            {
                MessageBox.Show("Fill All Required Information");
            }
            else
            {
                try
                {
                    string connectionstring = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                    string bname = txt_bookname.Text;
                    string bauthor = txt_bookauthor.Text;
                    int bquantity = Convert.ToInt32(txt_quantity.Text);
                    string av = "available";
                    string noav = "not available";

                    using (SqlConnection conn = new SqlConnection(connectionstring))
                    {
                        conn.Open();

                        string addbook = "Insert into Book (BookName, BookAuthor, Quantity, Available) " + "VALUES (@BookName, @BookAuthor, @Quantity, @Available)";

                        using (SqlCommand addbookcmd = new SqlCommand(addbook, conn))
                        {
                            addbookcmd.Parameters.AddWithValue("@BookName", bname);
                            addbookcmd.Parameters.AddWithValue("@BookAuthor", bauthor);
                            addbookcmd.Parameters.AddWithValue("@Quantity", bquantity);
                            if (bquantity > 0)
                                addbookcmd.Parameters.AddWithValue("@Available", av);
                            else
                                addbookcmd.Parameters.AddWithValue("@Available", noav);




                            addbookcmd.ExecuteNonQuery();

                            MessageBox.Show("Book Added successfully!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string bname = txt_filtername.Text;

                    string view = "SELECT BookName, BookAuthor, Quantity FROM Book WHERE BookName = @BookName";

                    using (SqlCommand viewbookcmd = new SqlCommand(view, conn))
                    {
                        viewbookcmd.Parameters.AddWithValue("@BookName", bname);

                        SqlDataAdapter adapter = new SqlDataAdapter(viewbookcmd);
                        DataTable dataTable = new DataTable();
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                String query = "select BookName, BookAuthor, Quantity, Available from Book";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }


            datagrid_books.DataSource = dataTable;
        }





        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView_manage.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a book to update.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView_manage.SelectedRows[0];
            string bookName = selectedRow.Cells["BookName"].Value.ToString();

            if (txt_updatename.Text == "" || txt_updateauthor.Text == "" || txt_updateQTY.Text == "")
            {
                MessageBox.Show("Fill all required information.");
                return;
            }

            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();



                    string updateQuery = "UPDATE Book SET BookName = @BookName, BookAuthor = @BookAuthor, Quantity = @Quantity, Available = @Available  WHERE BookName = @OldBookName ";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@BookName", txt_updatename.Text);
                        updateCmd.Parameters.AddWithValue("@BookAuthor", txt_updateauthor.Text);
                        updateCmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txt_updateQTY.Text));
                        updateCmd.Parameters.AddWithValue("@OldBookName", bookName);
                        if (Convert.ToInt32(txt_updateQTY.Text) > 0)
                            updateCmd.Parameters.AddWithValue("@Available", "Available");
                        else
                        {
                            updateCmd.Parameters.AddWithValue("@Available", "unavailable");
                        }


                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book updated successfully!");
                            ClearTextBoxes();
                            loadDataGridManage_Books();


                        }
                        else
                        {
                            MessageBox.Show("Update failed.");
                            loadDataGridManage_Books();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void ClearTextBoxes()
        {
            txt_bookname.Clear();
            txt_bookauthor.Clear();
            txt_quantity.Clear();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_manage.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a book to delete.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView_manage.SelectedRows[0];
            string bookName = selectedRow.Cells["BookName"].Value.ToString();


            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();



                    string deleteQuery = "DELETE FROM Book WHERE BookName = @BookName";

                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@BookName", bookName);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book deleted successfully!");
                            ClearTextBoxes();
                            loadDataGridManage_Books();

                        }
                        else
                        {
                            MessageBox.Show("Deletion failed.");
                            loadDataGridManage_Books();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }



        private void btn_accept_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_Issue.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to approve.");
                    return;
                }

                // Get the selected row from the data grid view
                DataGridViewRow selectedRow = dataGridView_Issue.SelectedRows[0];
                string selectedUsername = selectedRow.Cells["Username"].Value.ToString();
                string selectedBookName = selectedRow.Cells["BookName"].Value.ToString();
                DateTime issueDate = (DateTime)selectedRow.Cells["IssueDate"].Value;

                // Get the User_ID and Book_ID based on the selected username and bookname
                int userID = GetUserID(selectedUsername); // Implement this method
                int bookID = GetBookID(selectedBookName); // Implement this method

                DateTime dueDate = GetDueDateFromIssueTable(userID, bookID);

                // Insert a new record into the BorrowedBooks table
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";
                string insertQuery = "INSERT INTO BorrowedBooks (User_ID, Book_ID, BorrowDate, DueDate) " +
                                     "VALUES (@User_ID, @Book_ID, @BorrowDate, @DueDate)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@User_ID", userID);
                        insertCmd.Parameters.AddWithValue("@Book_ID", bookID);
                        insertCmd.Parameters.AddWithValue("@BorrowDate", issueDate);
                        insertCmd.Parameters.AddWithValue("@DueDate", dueDate);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Delete the issued request from the IssueBook table
                            string deleteQuery = "DELETE FROM IssueBook WHERE User_ID = @User_ID AND Book_ID = @Book_ID";
                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@User_ID", userID);
                                deleteCmd.Parameters.AddWithValue("@Book_ID", bookID);
                                int deleteRowsAffected = deleteCmd.ExecuteNonQuery();

                                if (deleteRowsAffected > 0)
                                {
                                    // Insert a record into the BorrowingHistory table
                                    string historyInsertQuery = "INSERT INTO BorrowingHistory (User_ID, Book_ID, BorrowedDate) " +
                                                               "VALUES (@User_ID, @Book_ID, @BorrowedDate)";
                                    string updatequantity = "UPDATE Book SET Quantity = @Quantity WHERE B_ID = @Book_ID";

                                    using (SqlCommand updatecmd = new SqlCommand(updatequantity, conn))
                                    {
                                        int q = GetQuantity(bookID);

                                        updatecmd.Parameters.AddWithValue("@Quantity", (q - 1)); // Decrease the quantity by 1
                                        updatecmd.Parameters.AddWithValue("@Book_ID", bookID);

                                        int updateRowsAffected = updatecmd.ExecuteNonQuery();

                                        loadDataGridManage_Books();
                                        if (q == 1) // Check if the previous quantity was 1 before decrementing
                                        {
                                            string updateAvailableStatus = "UPDATE Book SET Available = @Available WHERE B_ID = @Book_ID";
                                            using (SqlCommand updateAvailableCmd = new SqlCommand(updateAvailableStatus, conn))
                                            {
                                                updateAvailableCmd.Parameters.AddWithValue("@Available", "not available");
                                                updateAvailableCmd.Parameters.AddWithValue("@Book_ID", bookID);

                                                int updateAvailableRowsAffected = updateAvailableCmd.ExecuteNonQuery();
                                                MessageBox.Show("Book is now unavailable");
                                                loadDataGridManage_Books();
                                            }
                                        }

                                    }
                                    using (SqlCommand historyInsertCmd = new SqlCommand(historyInsertQuery, conn))
                                    {
                                        historyInsertCmd.Parameters.AddWithValue("@User_ID", userID);
                                        historyInsertCmd.Parameters.AddWithValue("@Book_ID", bookID);
                                        historyInsertCmd.Parameters.AddWithValue("@BorrowedDate", issueDate);

                                        int historyRowsAffected = historyInsertCmd.ExecuteNonQuery();

                                        if (historyRowsAffected > 0)
                                        {
                                            MessageBox.Show("Issue request approved and saved to BorrowedBooks and BorrowingHistory. Request deleted.");
                                            // Refresh the data grid view
                                            showRequestedUsers();
                                            loadDataGridManage_Books();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Issue request approved and saved to BorrowedBooks, but insertion into BorrowingHistory failed.");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Insertion into BorrowedBooks succeeded, but deletion from IssueBook failed.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Insertion into BorrowedBooks failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private int GetUserID(string username)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT ID FROM login WHERE Username = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

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

        private int GetBookID(string bookName)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT B_ID FROM Book WHERE BookName = @BookName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookName", bookName);

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
        private DateTime GetDueDateFromIssueTable(int userID, int bookID)
        {
            string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";
            string query = "SELECT DueDate FROM IssueBook WHERE User_ID = @User_ID AND Book_ID = @Book_ID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@User_ID", userID);
                cmd.Parameters.AddWithValue("@Book_ID", bookID);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return (DateTime)result;
                }
                else
                {
                    throw new Exception("Due date not found for the selected request.");
                }
            }
        }

        private void btn_decline_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_Issue.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to decline.");
                    return;
                }

                // Get the selected row from the data grid view
                DataGridViewRow selectedRow = dataGridView_Issue.SelectedRows[0];
                string selectedUsername = selectedRow.Cells["Username"].Value.ToString();
                string selectedBookName = selectedRow.Cells["BookName"].Value.ToString();
                int userID = GetUserID(selectedUsername); // Implement this method
                int bookID = GetBookID(selectedBookName); // Implement this method

                // Delete the issued request from the IssueBook table
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";
                string deleteQuery = "DELETE FROM IssueBook WHERE User_ID = @User_ID AND Book_ID = @Book_ID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                {
                    conn.Open();

                    deleteCmd.Parameters.AddWithValue("@User_ID", userID);
                    deleteCmd.Parameters.AddWithValue("@Book_ID", bookID);
                    int deleteRowsAffected = deleteCmd.ExecuteNonQuery();

                    if (deleteRowsAffected > 0)
                    {
                        MessageBox.Show("Issue request declined successfully.");
                        // Refresh the data grid view
                        showRequestedUsers();
                    }
                    else
                    {
                        MessageBox.Show("Deletion from IssueBook failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
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

        private void txt_updatename_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_Issue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void datagrid_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_manage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_manage_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_manage.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_manage.SelectedRows[0];

                string bookName = selectedRow.Cells["BookName"].Value.ToString();
                string bookAuthor = selectedRow.Cells["BookAuthor"].Value.ToString();
                int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);


                txt_updatename.Text = bookName;
                txt_updateauthor.Text = bookAuthor;
                txt_updateQTY.Text = quantity.ToString();
            }
        }

        private void txt_filtername_TextChanged(object sender, EventArgs e)
        {

            string filterKeyword = txt_filtername.Text.Trim().ToLower(); ;

            string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT BookName, BookAuthor, Quantity FROM Book WHERE LOWER(BookName) LIKE @FilterKeyword";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FilterKeyword", "%" + filterKeyword + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    datagrid_books.DataSource = dataTable;
                }
            }


        }
    }

}