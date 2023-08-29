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
using System.Collections;
using System.Linq.Expressions;

namespace library_management_system
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (Check_Register() == false)
            {
                MessageBox.Show("Fill All Required Information");
            }
            else { pnl_login.Show(); }


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pnl_login.Hide();
            loaddatagrid();
        }

        private void loaddatagrid()
        {
            string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT FirstName, LastName, l.Username, Email, Mobile, Address, Gender " +
                   "FROM Registration, login l " +
                   "where l.ID=User_ID and l.Username not like 'admin'";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            // Bind the DataTable to the DataGridView
            dataGridView_edit.DataSource = dataTable;
            dataGridView_view.DataSource = dataTable;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (Check_Register() == false || Check_Login() == false)
            {
                MessageBox.Show("Fill All Required Information");
            }
            else
            {
                try
                {
                    string firstName = txt_fname.Text;
                    string lastName = txt_lname.Text;
                    string email = txt_email.Text;
                    string gender = txt_gender.Text;
                    string mobile = txt_mobile.Text;
                    string address = txt_address.Text;


                    string username = txt_username.Text;
                    string password = txt_password.Text;
                    string role = txt_role.Text;

                    string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Insert into Login table
                        string loginQuery = "INSERT INTO Login (Username, Password, Role) " +
                                            "VALUES (@Username, @Password, @Role)";
                        using (SqlCommand loginCmd = new SqlCommand(loginQuery, conn))
                        {
                            loginCmd.Parameters.AddWithValue("@Username", username);
                            loginCmd.Parameters.AddWithValue("@Password", password);
                            loginCmd.Parameters.AddWithValue("@Role", role);

                            loginCmd.ExecuteNonQuery();
                        }

                        // Insert into Registration table
                        string registrationQuery = "INSERT INTO Registration (FirstName, LastName, Email, Gender, Mobile, Address, User_ID) " +
                                                   "VALUES (@FirstName, @LastName, @Email, @Gender, @Mobile, @Address, @User_ID)";
                        using (SqlCommand registrationCmd = new SqlCommand(registrationQuery, conn))
                        {
                            registrationCmd.Parameters.AddWithValue("@FirstName", firstName);
                            registrationCmd.Parameters.AddWithValue("@LastName", lastName);
                            registrationCmd.Parameters.AddWithValue("@Email", email);
                            registrationCmd.Parameters.AddWithValue("@Gender", gender);
                            registrationCmd.Parameters.AddWithValue("@Mobile", mobile);
                            registrationCmd.Parameters.AddWithValue("@Address", address);

                            // Assuming you are generating the User_ID in your code, otherwise, please replace with the correct value
                            int user_ID = GetNextUserID(); // Replace this with your method to generate User_ID
                            registrationCmd.Parameters.AddWithValue("@User_ID", user_ID);

                            registrationCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Registration information saved");

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private Boolean Check_Register()
        {
            if (txt_fname.Text == "" || txt_lname.Text == "" || txt_mobile.Text == "" || txt_address.Text == "" || txt_email.Text == "" || txt_gender.Text == "")
            { return false; }

            return true;
        }
        private Boolean Check_Login()
        {
            if (txt_username.Text == "" || txt_role.Text == "" || txt_password.Text == "") { return false; }

            return true;
        }
        private int GetNextUserID()
        {
            int nextUserID = 0;

            string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string getMaxUserIdQuery = "SELECT MAX(ID) FROM Login";
                using (SqlCommand cmd = new SqlCommand(getMaxUserIdQuery, conn))
                {
                    nextUserID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return nextUserID;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void View_Click(object sender, EventArgs e)
        {

        }

        private void txt_filter_TextChanged(object sender, EventArgs e)
        {
            string searchUsername = txt_filter.Text.Trim();

            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT FirstName, LastName, l.Username, Email, Mobile, Address, Gender " +
                    "FROM Registration, login l " +
                    "where l.ID=User_ID and l.Username not like 'admin' and l.Username LIKE @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", "%" + searchUsername + "%");

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        dataGridView_edit.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView_edit_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_edit.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_edit.SelectedRows[0];

                string fname = (string)selectedRow.Cells["FirstName"].Value;
                string lname = (string)selectedRow.Cells["LastName"].Value;
                string email = (string)selectedRow.Cells["Email"].Value;
                int mobile = Convert.ToInt32(selectedRow.Cells["Mobile"].Value);
                string address = (string)selectedRow.Cells["Address"].Value;
                string gender = (string)selectedRow.Cells["Gender"].Value;
                Username = (string)selectedRow.Cells["Username"].Value;

                text_fname.Text = fname;
                text_lname.Text = lname;
                text_email.Text = email;
                text_mobile.Text = mobile.ToString();
                text_address.Text = address;
                comboBox_gender.Text = gender;


            }
        }
        private string Username;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(text_lname.Text) && !string.IsNullOrEmpty(text_email.Text) &&
                    !string.IsNullOrEmpty(text_mobile.Text) && !string.IsNullOrEmpty(text_fname.Text) &&
                    !string.IsNullOrEmpty(text_address.Text) && !string.IsNullOrEmpty(comboBox_gender.Text))
                {
                    string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string fname = text_fname.Text;
                        string lname = text_lname.Text;
                        string email = text_email.Text;
                        int mobile = Convert.ToInt32(text_mobile.Text); // Corrected variable name
                        string address = text_address.Text;
                        string gender = comboBox_gender.Text;

                        string updatequery = "UPDATE Registration SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Address = @Address, Gender = @Gender, Mobile = @Mobile " +
                            "WHERE User_ID = @User_ID";

                        using (SqlCommand cmd = new SqlCommand(updatequery, conn))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", fname);
                            cmd.Parameters.AddWithValue("@LastName", lname);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Address", address);
                            cmd.Parameters.AddWithValue("@Gender", gender);
                            cmd.Parameters.AddWithValue("@Mobile", mobile);
                            cmd.Parameters.AddWithValue("@User_ID", GetUsernameID(Username)); // Assuming you have this method implemented

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                loaddatagrid();
                                MessageBox.Show("User information updated successfully.");
                                
                            }
                            else
                            {
                                MessageBox.Show("Failed to update user information.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fill all required information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private int GetUsernameID(string username)
        {
            int UsernameID = 0;
            string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string selectquery = "select ID from login where Username = @Username";

                using (SqlCommand command = new SqlCommand(selectquery, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    UsernameID = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return UsernameID;

        }
    }
}

