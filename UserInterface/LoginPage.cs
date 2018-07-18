using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }
       
        public String email_entry;
        public String password_entry;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = email_entry;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup sign = new Signup();
            sign.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = password_entry;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
