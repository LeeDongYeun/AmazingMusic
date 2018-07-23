using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Object;
using Request;


namespace UserInterface_AM
{
    public partial class Main : Form
       
    {
        Play play;
        Edit edit;
        Share share;
        Search search;
        

        
        string[] name;
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
                Hide();
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
                Hide();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Wav Files|*.wav";
            if (open.ShowDialog() == DialogResult.OK)
            {
                name = open.FileNames;
                for (int i = 0; i < name.Length; i++)
                {
                    listBox1.Items.Add(name[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a File first!");
            }
            else if (listBox1.SelectedIndex > 1)
            {
                MessageBox.Show("Select Only 1 Item");
            }
            else
            {
                selected = listBox1.SelectedItem.ToString();
                share = new Share();
                share.Show(this);
                Hide();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search = new Search();
            search.Show(this);
            
          
            // Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("List is Empty");

            }
            else
            {
                listBox1.Items.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("List is Empty");

            }
            else if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select a file to remove");
            }
            else
            {
                listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            

        }
        
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

           

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
