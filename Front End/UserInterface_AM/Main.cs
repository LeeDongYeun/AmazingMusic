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


        public static string selected;
        private void EditFile(object sender, EventArgs e)
        {
            if (FileList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
            }
            else
            {
                selected = FileList.SelectedItem.ToString();
                edit = new Edit();
                edit.Show(this);
                Hide();
            }
        }

        private void PlayFile(object sender, EventArgs e)
        {
            if (FileList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
            }
            else
            {
                selected = FileList.SelectedItem.ToString();
                play = new Play();
                play.Show(this);
                Hide();
            }

        }

        private void ImportFiles(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Wav Files|*.wav";
            if (open.ShowDialog() == DialogResult.OK)
            {
                name = open.FileNames;
                for (int i = 0; i < name.Length; i++)
                {
                    FileList.Items.Add(name[i]);
                }
            }
        }

        private void SignOut(object sender, EventArgs e)
        {
            new Form1().Show();
            Close();
        }

        private void SearchFiles(object sender, EventArgs e)
        {
            search = new Search();
            search.Show(this);



        }

        private void Clear(object sender, EventArgs e)
        {
            if (FileList.Items.Count == 0)
            {
                MessageBox.Show("List is Empty");

            }
            else
            {
                FileList.Items.Clear();
            }
        }

        private void Remove(object sender, EventArgs e)
        {
            if (FileList.Items.Count == 0)
            {
                MessageBox.Show("List is Empty");

            }
            else if (FileList.SelectedIndex == -1)
            {
                MessageBox.Show("Select a file to remove");
            }
            else
            {
                FileList.Items.Remove(FileList.Items[FileList.SelectedIndex]);
            }
        }

        private void ShareButton_Click(object sender, EventArgs e)
        {
            if (FileList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
            }
            else
            {
                selected = FileList.SelectedItem.ToString();
                share = new Share();
                share.Show(this);
                Hide();
            }

        }

    }
}
