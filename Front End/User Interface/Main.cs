using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicPlayer;

namespace UserInterface_AM
{
    public partial class Main : Form
       
    {
        Play play;
        Edit edit;
        Share share;
        Search search;

        string[] doc;
        string[] path;
        public Main()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
            }
            else if (listBox1.SelectedIndex > 1)
            {
                MessageBox.Show("Select 1 Item Only!");
            }
            else
            {
                selected = listBox1.SelectedItem.ToString();
                edit = new Edit();
                edit.Show(this);
            }
        }
        public static string selected;
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
            }
            else if (listBox1.SelectedIndex > 1)
            {
                MessageBox.Show("Select Only 1 Item");
            }
            else
            {
                selected = listBox1.SelectedItem.ToString();
                play = new Play();
                play.Show(this);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Wav Files|*.wav";
            if (open.ShowDialog() == DialogResult.OK)
            {
                doc = open.FileNames;
                path = open.FileNames;
                for (int i = 0; i < doc.Length; i++)
                {
                    listBox1.Items.Add(doc[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
            }
            else if (listBox1.SelectedIndex > 1)
            {
                MessageBox.Show("Select Only 1 Item");
            }
            else
            {
                selected = listBox1.SelectedItem.ToString();
                play = new Play();
                play.Show(this);
                share = new Share();
                share.Show(this);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search = new Search();
            search.Show(this);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
