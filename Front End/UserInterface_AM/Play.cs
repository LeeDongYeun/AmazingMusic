using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace UserInterface_AM
{
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
            PlayFile.Text = Main.selected;//File being played is same that was selected in listbox on Main form
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        /*
     * purpose: Returns user to the Main form
     * input: Buttonclick on Back button
     * output: none
     */
        private void Back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        /*
     * purpose: Opens file the user previously selected in Windows Media Player, allows user to listen to audio file
     * input: none
     * output: none
     */
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Main.selected;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
