using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Request;

namespace UserInterface_AM
{
    /*This is the SignIn page which the user first sees,
     * This uses Request, part of
     * */
    public partial class Form1 : Form
    {
        public static String correctUID;
        SignUp sign;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
           
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Enter your email");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter your password");
            }
            else
            {
                MessageBox.Show(eMail + " " + Password);
                string uid = Request.Request.login(eMail, Password);
                if (uid.Contains("INVALIDEMAIL"))
                {
                    MessageBox.Show("Invalid email");
                }
                else if (uid.Contains("LOGIN:"))
                {
                    MessageBox.Show("User is not registered or wrong password");
                    textBox1.Text = "";
                    textBox2.Text = "";

                }
                else
                {
                    correctUID = uid;
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sign == null)
            {
                sign = new SignUp();
            }
            sign.Show(this);
            Hide();
            textBox1.Text = textBox2.Text = "";
           
        }

        void sign_FormClosed(object sender, FormClosedEventArgs e)
        {
            sign = null;
            Show();
        }
        String eMail;
        String Password;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            eMail = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Password = textBox2.Text;

        }
    }
}
