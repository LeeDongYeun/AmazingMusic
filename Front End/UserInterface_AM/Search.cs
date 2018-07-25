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

        private void Back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }
        String downloadFile;

        String downloadURLIndex;



        String url;
        String filename;
        //String[] urlList;
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (ResultList.Items.Count > 0)
            {
                ResultList.Items.Clear();
            }
            if (SearchBar.Text == "")
            {
                MessageBox.Show("Please enter keyword");

            }
            else
            {
                object result = Request.Request.search(searchKeyword);
                if ((result.GetType().Equals((new LinkedList()).GetType())))
                {
                    LinkedList list = (LinkedList)result;
                    while (list.end != null)
                    {
                        SearchResult sr = (SearchResult)list.head.getInfo();
                        url = "file://localhost/C:\\Users\\balis\\Desktop\\AmazingMusic\\Server\\src\\" + sr.getURL();
                        filename = sr.getOriName();

                        filenameToUrl.Add(filename, url);
                        ResultList.Items.Add(url);

                        list.delete(0);
                    }
                }
                else
                {
                    MessageBox.Show("No Results found");
                }


            }
        }
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            searchKeyword = SearchBar.Text;
        }

        String newFileName;
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            if (ResultList.SelectedIndex == -1)
            {
                MessageBox.Show("Select file to download");
            }
            else if (newFileName == "")
            {
                MessageBox.Show("Name the file you want to download");
            }
            else
            {
                String message = Request.Request.download(downloadURLIndex, newFileName);
                MessageBox.Show(message);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResultList.SelectedIndex == -1)
            {

            }
            else
            {
                string mapUrl;
                // ... Use TryGetValue to safely look up a value in the map.
                if (filenameToUrl.TryGetValue(listBox2.SelectedItem.ToString(), out mapUrl))
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

        private void FileSaveAs_TextChanged(object sender, EventArgs e)
        {
            newFileName = FileSaveAs.Text;

        }
    }
}