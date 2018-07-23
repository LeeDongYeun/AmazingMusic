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
    public partial class Share : Form
    {
        public Share()
        {
            InitializeComponent();
            label2.Text = Main.selected;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Request.Request.upload

            String message = Request.Request.upload(Form1.correctUID, label2.Text);
            if (message.Equals("VALIDATE SUCCESS")){
                MessageBox.Show("File Successfully Uploaded!");

            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}
