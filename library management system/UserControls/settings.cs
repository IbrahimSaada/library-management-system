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
    public partial class settings : UserControl
    {
        private static string loggedInUsername;
        public settings()
        {
            InitializeComponent();
        }
        public settings(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_fname.Text == "" || txt_lname.Text == "") 
            {
                MessageBox.Show("Fiil Required Information");
            }
            else
            {
                try
                {
                    string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                    using(SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Registration set FirstName = @FirstName, LastName = @LastName where User_ID = @User_ID";
                        string username = loggedInUsername;
                        int userid = GetLoggedInUserID();
                        string fname = txt_fname.Text;
                        string lname = txt_lname.Text;  
                        using(SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@User_ID", userid);
                            command.Parameters.AddWithValue("@FirstName", fname);
                            command.Parameters.AddWithValue("@LastName", lname);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Updated Successfuly!");
                        }
                    }
                    
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("An error occured: " + ex.Message);
                }
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

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            int UserID = GetLoggedInUserID();
            if (txt_oldp.Text == "" || txt_newp.Text == "" || txt_confirmpassword.Text=="")
            {
                MessageBox.Show("Fill Required Information");
            }
            else
            {
                if (txt_oldp.Text == GetUserPass(loggedInUsername))
                {
                    if(txt_newp.Text==txt_confirmpassword.Text)
                    {
                        if (txt_newp.Text == "" || txt_confirmpassword.Text == "")
                        {
                            MessageBox.Show("Fill Required Information");
                        }

                        else
                        {
                            try
                            {
                                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                                using (SqlConnection conn = new SqlConnection(connectionString))
                                {
                                    conn.Open();
                                    string newpassword = txt_newp.Text;

                                    string updatepassword = "UPDATE login set Password = @Password where ID = @ID ";
                                    using (SqlCommand cmdupdate = new SqlCommand(updatepassword, conn))
                                    {
                                        cmdupdate.Parameters.AddWithValue("@ID", UserID);
                                        cmdupdate.Parameters.AddWithValue("@Password", newpassword);
                                        cmdupdate.ExecuteNonQuery();
                                        cleantxtboxes();
                                        MessageBox.Show("Passowrd Changed");
                                        
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occured: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("New Password and Confirm Password are not the same!");
                    }
                }
                else
                {
                    MessageBox.Show("Your Old Password in Incorrect");
                }

            }
        }

        private string GetUserPass(string username)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string query = "SELECT Password FROM login WHERE Username = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        string userPassword = (string)cmd.ExecuteScalar();
                        return userPassword;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null; // Return a default value or handle the error appropriately
            }
        }
        private void cleantxtboxes()
        {
            txt_confirmpassword.Clear();
            txt_newp.Clear();
            txt_oldp.Clear();
        }

        private void txt_oldp_TextChanged(object sender, EventArgs e)
        {
            txt_oldp.PasswordChar = '*';
        }

        private void txt_newp_TextChanged(object sender, EventArgs e)
        {
            txt_newp.PasswordChar = '*';
        }

        private void txt_confirmpassword_TextChanged(object sender, EventArgs e)
        {
            txt_confirmpassword.PasswordChar = '*';
        }
    }

}
