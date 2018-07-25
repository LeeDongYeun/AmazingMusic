using System;
using System.Windows.Forms;

namespace UserInterface_AM
{
    
    public partial class Form1 : Form
    {
        public static String correctUID;
        
       
        public Form1()
        {
            InitializeComponent();
        }

       

      
        private void Login(object sender, EventArgs e)
           
        {
            if(EmailText.Text == "")
            {
                MessageBox.Show("Enter your email");

            }
            else if (PasswordText.Text == "")
            {
                MessageBox.Show("Enter your password");
            }
            
          else
            {

                   MessageBox.Show(eMail + " " + Password);
                    string message = Request.Request.login(eMail, Password);
                    if (message.Contains("INVALIDEMAIL"))
                    {
                        MessageBox.Show("Invalid email");
                    }
                    else if (message.Contains("LOGIN:"))
                    {

                        MessageBox.Show(message);
                        EmailText.Text = "";
                        PasswordText.Text = "";

                    }
                    else
                    {
                        correctUID = message;
                        this.Hide();
                        Main main = new Main();
                        main.Show();
                    } 

               
            }


        }

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
        private void EmailTextChange(object sender, EventArgs e)
        {
            eMail = EmailText.Text;
        }

        private void PasswordTextChange(object sender, EventArgs e)
        {
            Password = PasswordText.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
