using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface_AM
{

    public partial class Form1 : Form
    {
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
            this.Hide();
            Main main = new Main();
            main.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sign == null)
            {
                sign = new SignUp();
            }
            sign.Show(this);
            Hide();
        }

        void sign_FormClosed(object sender, FormClosedEventArgs e)
        {
            sign = null;
            Show();
        }
    }
}
