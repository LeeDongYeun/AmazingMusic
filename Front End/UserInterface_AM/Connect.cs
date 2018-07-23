using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using Client;
using Request;

namespace UserInterface_AM
{
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();
        }

        //string Connection;
        private void button1_Click(object sender, EventArgs e)
        {

            //SocketClient socket = new SocketClient();

            String email;
            String pw;
            email ="bjsoutha@ucsc.edu";
            pw = "Amaze";
            Request.Request.register(email, pw);
           



            

            /*  Connection = "datasource= ;port= ; username= ; password= ;";
              MySqlConnection myCon = new MySqlConnection(Connection);
              MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
              myDataAdapter.SelectCommand = new MySqlCommand(" select * database.edata ;", myCon);
              MySqlCommandBuilder commandBuild = new MySqlCommandBuilder(myDataAdapter);
              myCon.Open();
              DataSet dataSet = new DataSet();
              MessageBox.Show("Connected");
              myCon.Close();*/

           /* Connection = "server=169.233.130.218; database=amazingmusicdb; user=amaMusic; password=password";
           using (MySqlConnection con = new MySqlConnection(Connection))
            {
                con.Open();
                if(con.State == ConnectionState.Open)
                {
                    label1.Text = "Connection established!";
                }
                else
                {
                    label1.Text = "Connection error";
                }
            }*/
            

            }
        String downloadFile;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            downloadFile = textBox1.Text;
            //Request.Request.download();
        }
    }
    }


