using library_management_system.UserControls;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
            txt_password.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_invalidpassword.Hide();
            panel_invalidusername.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-8OSKBF8\\SQLEXPRESS;Initial Catalog=\"library management system\";Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string username = txt_username.Text;
                    string password = txt_password.Text;

                    string query = "SELECT COUNT(*) FROM login WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            
                            string roleQuery = "SELECT Role FROM login WHERE Username = @Username";
                            using (SqlCommand roleCmd = new SqlCommand(roleQuery, conn))
                            {
                                roleCmd.Parameters.AddWithValue("@Username", username);
                                string userRole = roleCmd.ExecuteScalar()?.ToString();

                               
                                if (userRole == "Admin")
                                {
                                    MessageBox.Show("Login successful! ");
                                    
                                    Library lms = new Library();
                                    lms.Show();
                                    this.Hide();
                                    Clear_txt();
                                }
                                else if (userRole == "User")
                                {
                                    MessageBox.Show("Login successful! ");

                                    UserForm userForm = new UserForm(username);
                                    
                                    userForm.Show();
                                    this.Hide();
                                    Clear_txt();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid user role.");
                                }
                            }
                        }
                        else
                        {
                            panel_invalidpassword.Show();
                            panel_invalidusername.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void panel_invalidusername_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Clear_txt()
        {
            txt_username.Clear();
            txt_password.Clear();
        }
    }
}
