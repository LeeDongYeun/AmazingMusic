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
            ShareFile.Text = Main.selected;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();

        }



        private void Upload_Click(object sender, EventArgs e)
        {


            String message = Request.Request.upload(Form1.correctUID, ShareFile.Text);
            if (message.Equals("VALIDATE SUCCESS"))
            {
                MessageBox.Show("File Successfully Uploaded!");
                Owner.Show();
                Close();

            }
            else
            {
                MessageBox.Show(message);
                Owner.Show();
                Close();
            }
        }
    }
}
