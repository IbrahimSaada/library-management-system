using library_management_system.UserControls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace library_management_system
{
    public partial class UserForm : Form
    {
        Books books;
        BorrowedBooks borrowedBooks;
        settings settings;
        public UserForm()
        {
            InitializeComponent();
        }
        string loggedInUsername;

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }


        public UserForm(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
            books = new Books(loggedInUsername);
            borrowedBooks = new BorrowedBooks(loggedInUsername);
            settings = new settings(loggedInUsername);


            addUserControl(books);
            addUserControl(borrowedBooks);

            label_username.Text = "Welcome, " + loggedInUsername + "!";

        }
        

        private void txt_welcome_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
           
        }

       

        private void listbox_search_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            
        }
       

        

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView_borrwed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
       

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Books bk = new Books();
            addUserControl(bk);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            BorrowedBooks borrowedBooks = new BorrowedBooks();
            addUserControl(borrowedBooks);
        }

        private void button1_Click_4(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            settings st = new settings();
            addUserControl (st);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
    }
}
