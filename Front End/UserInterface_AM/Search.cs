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
        public Dictionary<string, string> filenameToUrl;

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
            else
            { 
                object result = Request.Request.search(searchKeyword);
                if (result.GetType().Equals("".GetType()))
                {
                    MessageBox.Show("No such file. Try another file."); // changed
                }
                else
                {
                    LinkedList list = (LinkedList)result;
                    while (list.end != null)
                    {
                        SearchResult sr = (SearchResult)list.head.getInfo();
                        url = "file://localhost/C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\AmazingMusic\\Server\\src\\" + sr.getURL(); // changed
                        filename = sr.getOriName();

                        filenameToUrl.Add(filename, url);

                        listBox2.Items.Add(filename);

                        list.delete(0);
                    }
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
                string mapUrl;
                // ... Use TryGetValue to safely look up a value in the map.
                if (filenameToUrl.TryGetValue(listBox2.SelectedItem.ToString(),out mapUrl)) 
                {
                    downloadURLIndex = mapUrl;
                    MessageBox.Show(mapUrl);
                }
                else
                {
                    MessageBox.Show("debug needed");
                }
            }
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            newFileName = textBox2.Text;

        }
    }
}