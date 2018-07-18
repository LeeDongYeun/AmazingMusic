using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JavaPKG;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        string[] doc;
        string[] path;
        public Form1()
        {
         InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Wav Files|*.wav";
            if (open.ShowDialog() == DialogResult.OK)
            {
                doc = open.SafeFileNames;
                path = open.FileNames;
                for (int i = 0; i<doc.Length; i++)
                {
                    listBox1.Items.Add(doc[i]);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Tester().print();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit edit = new Edit();
            edit.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Share share = new Share();
            share.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Play play = new Play();
            play.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
