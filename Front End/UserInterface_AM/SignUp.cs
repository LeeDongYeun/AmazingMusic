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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Please enter email address");
                return;
            }
            else if(textBox2.Text == "")
            {
                MessageBox.Show("Please enter password");
                return;
            }


            String rMessage = (Request.Request.register(email, pw));
            if (rMessage.Equals("UPS"))
            {
                Owner.Show();
                Close();
            }
            else
            {
                MessageBox.Show(rMessage);
            }
         
            //Owner.Show();
            //Hide();
        }
       static String email;
       static String pw;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            email = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pw = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
            textBox1.Text = textBox2.Text = "";
        }
    }
}
