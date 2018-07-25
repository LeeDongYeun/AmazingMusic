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
        public static String searchKeyword; //keyword that is used to search files in the postfiles database
        public List<string> urlArray; // urlArray stores urls(the link where user can download the corresponding file) for each file(name)
        String downloadFile; //file user selects to download
        String downloadURLIndex; //URL of download file
        String filename;//Original filename of search result
        String url;//full url corresponding of filename
        String newFileName; //The filename the user gives to their downloaded file
        public Search()
        {
            InitializeComponent();
            urlArray = new List<string>(); // Initialize urlArray when search screen is open
        }

        /*
       * purpose: Returns user to Main form
       * input: Buttonclick on Back button
       * output: none
       */
        private void Back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        //String[] urlList;

        /*
      * purpose: Search action that causes user's keyword to be searched in the database
      * input: User text in SearchBar, Buttonclick on Search button
      * output: none
      */
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (ResultList.Items.Count > 0)
            {
                ResultList.Items.Clear();      // Initialize the result list screen when user click Go button again
                urlArray = new List<string>(); // Initialize urlArray when user click Go button again
            }
            if (SearchBar.Text == "")   
            {
                MessageBox.Show("Please enter keyword");//Prompt user to enter a keyword if their SearchBar textbox is empty

            }
            else
            {
                object result = Request.Request.search(searchKeyword);//calls the Request.search(keyword) server function
                if ((result.GetType().Equals((new LinkedList()).GetType())))
                {
                    LinkedList list = (LinkedList)result;//Creates linked list to hold search results
                    while (list.end != null)
                    {
                        SearchResult sr = (SearchResult)list.head.getInfo();
                        url = "file://localhost/C:\\Users\\인영\\Documents\\GitHub\\AmazingMusic\\Server\\src\\" + sr.getURL();
                        filename = sr.getOriName();

                        /*
                         * Store both url and filename
                         * ResultList is used to display filenames to user,
                         * while urlArray is used to give correspoding url to server
                         */
                        urlArray.Add(url);
                        ResultList.Items.Add(filename);

                        list.delete(0);
                    }
                }
                else
                {
                    MessageBox.Show("No Results found");
                }


            }
        }
        /*
    * purpose: User enters keyword into SearchBar listbox 
    * input: User text
    * output: none (searchKeyword String is stored)
    */
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            searchKeyword = SearchBar.Text;
        }

        

        /*
    * purpose: Download action to download user's selected search result onto their local disk
    * input: User selects ResultList listbox item, Buttonclick on Download button
    * output: none
    */
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
        /*
      * purpose: Returns user to Main form
      * input: User selects ResultList listbox item
      * output: none
      */
        private void ResultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResultList.SelectedIndex == -1)//if click on an empty part of ResultList, do nothing
            {

            }
            else
            {
                downloadURLIndex = urlArray[ResultList.SelectedIndex]; // get the corresponding url
                MessageBox.Show(downloadURLIndex);
            }
        }

        private void FileSaveAs_TextChanged(object sender, EventArgs e)//names the file what user inputs into textbox
        {
            newFileName = FileSaveAs.Text;

        }
    }
}