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
    public partial class Search : Form
    {
        public static String searchKeyword;
        public Search()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }
        String downloadFile;

        String downloadURLIndex;



        String url;
        String filename;
        //String[] urlList;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter keyword");

            }
            else { 
            object result = Request.Request.search(searchKeyword);
            LinkedList list = (LinkedList)result;
            while (list.end != null)
            {
                SearchResult sr = (SearchResult)list.head.getInfo();
                url = "file://localhost/C:\\Users\\balis\\Desktop\\AmazingMusicServer\\Server\\" + sr.getURL();
                filename = sr.getOriName();

                listBox2.Items.Add(url);

                list.delete(0);
            }
        }
    }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchKeyword = textBox1.Text;
        }
        String newFileName;
        private void button1_Click(object sender, EventArgs e)
        {
           if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Select file to download");
            }
           else if(newFileName == "")
            {
                MessageBox.Show("Name the file you want to download");
            }
           else
            {
                String message = Request.Request.download(downloadURLIndex,newFileName);
                MessageBox.Show(message);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {

            }
            else
            {
                downloadURLIndex = listBox2.SelectedItem.ToString();
                MessageBox.Show(downloadURLIndex);
            }
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            newFileName = textBox2.Text;

        }
    }
}