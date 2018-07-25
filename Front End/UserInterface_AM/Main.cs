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



        string[] filenames;//array used to store imported filenames

        public static string selected;//item selected in FileList listbox

        public Main()
        {
            InitializeComponent();
        }


        /*
       * purpose: Takes user to the Edit form to edit the selected audio file
       * input: Buttonclick, user must have selected FileList item
       * output: none
       */
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
        /*
       * purpose: Allows user to enter Play form to play selected audio file
       * input: Buttonclick, user select item from FileList
       * output: none
       */
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
        /*
       * purpose: Allows user to importfiles from their local disk
       * input: Buttonclick event
       * output: none
       */
        private void ImportFiles(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Wav Files|*.wav";
            if (open.ShowDialog() == DialogResult.OK)
            {
                filenames = open.FileNames;
                for (int i = 0; i < filenames.Length; i++)
                {
                    FileList.Items.Add(filenames[i]);
                }
            }
        }

        /*
     * purpose: Returns users to Form1 
     * input: Buttonclick on SignOut button
     * output: none
     */
        private void SignOut(object sender, EventArgs e)
        {
            new Form1().Show();
            Close();
        }

        /*
     * purpose: Allows users to enter Search form 
     * input: Buttonclick on search button
     * output: none
     */
        private void SearchFiles(object sender, EventArgs e)
        {
            search = new Search();
            search.Show(this);



        }


        /*
     * purpose: Clears the FileList listbox
     * input: Buttonclick on clear button
     * output: none
     */
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


        /*
     * purpose: Allow users to remove selected items in FileList listbox
     * input: select a file in FileList and Buttonclick on Remove button
     * output: none
     */
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

        /*
     * purpose: Allow user to enter Share form to share selected audio file
     * input: select a file from FileList, Buttonclick on Share button
     * output: none
     */
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
