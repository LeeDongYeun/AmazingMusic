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


        private void Create(object sender, EventArgs e)
        {
            if (RegisterEmail.Text == "")
            {
                MessageBox.Show("Please enter email address");
                return;
            }
            else if (CreatePassword.Text == "")
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
        private void EmailText(object sender, EventArgs e)
        {
            email = RegisterEmail.Text;
        }

        private void PasswordText(object sender, EventArgs e)
        {
            pw = CreatePassword.Text;
        }

        private void BackToSignIn(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
            RegisterEmail.Text = CreatePassword.Text = "";
        }
    }
}
