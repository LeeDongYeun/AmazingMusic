using System;
using System.Windows.Forms;
using Request;

namespace UserInterface_AM
{

    public partial class Form1 : Form
    {
        public static String correctUID;


        public Form1()
        {
            InitializeComponent();
        }



        /*
         * purpose: Allows user to login to main page of app
         * input: correct Email and password in text boxes, button press action
         * output: none
         */
        private void Login(object sender, EventArgs e)

        {
            if (EmailText.Text == "")
            {
                MessageBox.Show("Enter your email");

            }
            else if (PasswordText.Text == "")
            {
                MessageBox.Show("Enter your password");
            }

            else
            {

                
                string message = Request.Request.login(eMail, Password);
                if (message.Contains("INVALIDEMAIL"))// user inputs email not recognized in server
                {
                    MessageBox.Show("Invalid email");
                }
                else if (message.Contains("LOGIN:"))
                {

                    MessageBox.Show(message);//user inputs incorrect password
                    EmailText.Text = "";
                    PasswordText.Text = "";

                }
                else
                {
                    MessageBox.Show("Login Successful!");
                    correctUID = message;
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }


            }


        }
        /*
      * purpose: If user does not have an account, takes them to form to signup
      * input: button press action
      * output: none
      */

        private void GoTo_SignUp(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show(this);
            Hide();

        }
      
        void sign_FormClosed(object sender, FormClosedEventArgs e)
        {

        }



        String eMail;
        String Password;
        /*
      * purpose: assigns String email value to what user inputs in EmailText
      * input: Text typed in text box
      * output: none
      */
        private void EmailTextChange(object sender, EventArgs e)
        {
            eMail = EmailText.Text;
        }
        /*
      * purpose: assigns String password value to what use inputs in PasswordText
      * input: Text typed in text box
      * output: none
      */
        private void PasswordTextChange(object sender, EventArgs e)
        {
            Password = PasswordText.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
