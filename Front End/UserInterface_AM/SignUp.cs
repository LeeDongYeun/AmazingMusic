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

        /*
     * purpose: Allows the user to create an account by registering email and password with the server
     * input: Email and Password text in RegisterEmail textbox and CreatePassword textbox, Buttonclick on CreateAccount button
     * output: if register is unsuccessful, MessageBox prints "Register Failed"
     */
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


            String rMessage = (Request.Request.register(email, pw));//calls register function of server code inputting email and pw from user
            
            if (rMessage.Equals("UPS"))//if register is successful, close SignUp form and return to SignIn form
            {
                Owner.Show();
                Close();
            }
            else
            {
                MessageBox.Show(rMessage);//if register is unsuccessful, show error message
            }

            
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

        /*
     * purpose: Returns user to SignIn form (Form1)
     * input: Buttonclick on Back button
     * output: none
     */
        private void BackToSignIn(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
            RegisterEmail.Text = CreatePassword.Text = "";
        }
    }
}
