using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private Borrowers borrowersForm;

        private void Library_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Borrowers br = new Borrowers();
            br.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            borrowersForm = new Borrowers();
            if (borrowersForm != null)
            {
                borrowersForm.Show(); // Show the Borrowers form if not already shown

                // Select the Borrowers tab
                borrowersForm.SelectTabByName("tabPage2"); // Replace with the actual name of your tab
            }

        }
    }
}
