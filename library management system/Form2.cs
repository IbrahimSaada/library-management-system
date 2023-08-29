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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pnl_register.Show();
            pnl_regi1.Hide();
            pnl_cnfrm.Hide();
            pnl_password.Hide();

        }

        private void pnl_next_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_fname.Text) || string.IsNullOrWhiteSpace(txt_lname.Text) ||
                    string.IsNullOrWhiteSpace(txt_email.Text) || combo_gender.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txt_mobile.Text) || string.IsNullOrWhiteSpace(txt_address.Text))
            {
                MessageBox.Show("Fill All required information");
            }
            else
            {
                pnl_register.Hide();
                pnl_regi1.Show();
                Size = new Size(536, 388);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl_register.Show();
            pnl_regi1.Hide();
            Size = new Size(536, 557);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_cnfrmpassword.Text != txt_password.Text)
            {
                pnl_cnfrm.Show();
                pnl_password.Show(); 
            }
            else if( txt_password.Text == "" || txt_cnfrmpassword.Text == "" || txt_username.Text == "" )
            {
                MessageBox.Show("Fill all required informations");
            }

            else 
            {
                pnl_password.Show();
                pnl_cnfrm.Hide();
                try
            {
                // Collect registration data from controls
                string firstName = txt_fname.Text;
                string lastName = txt_lname.Text;
                string email = txt_email.Text;
                string gender = combo_gender.SelectedItem.ToString();
                string mobile = txt_mobile.Text;
                string address = txt_address.Text;

                // Collect login data from controls
                string username = txt_username.Text;
                string password = txt_password.Text;
                string role = "User";

                // Create a connection string
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

                    MessageBox.Show("Registration information saved you can login now");
                        // Optionally, you can navigate to the next step or perform other actions.

                        
                        Form1 form1 = new Form1();
                        Form3 form3 = new Form3();
                        form1.Show();
                        form3.Hide();
                        this.Hide();
                        clear_txt();

                    }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            }
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

        private void pnl_register_Paint(object sender, PaintEventArgs e)
        {

        }




        private void txt_cnfrmpassword_TextChanged(object sender, EventArgs e)
        {
            txt_cnfrmpassword.PasswordChar = '*';
            txt_cnfrmpassword.Focus();
        }

        private void pnl_regi1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_password_TextChanged_1(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
            txt_password.Focus();   
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            txt_username.Focus();
            
        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {
            txt_fname.Focus();
        }

        private void txt_lname_TextChanged(object sender, EventArgs e)
        {
            txt_lname.Focus();
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_email.Focus();
        }

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {
            txt_mobile.Focus();
        }

        private void txt_mobile_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            Form3 form3 = new Form3();
            form1.Show();
            form3.Hide();
            this.Hide();


        }
        private void clear_txt()
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_email.Clear();
            txt_mobile.Clear();
            combo_gender.SelectedIndex = 0;
            txt_username.Clear();
            txt_password.Clear();
            txt_cnfrmpassword.Clear();
 
        }
    }

}
