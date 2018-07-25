using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserInterface_AM
{
    public partial class Edit : Form
    {
        
        //Initialize the cut audio file variable
        int start_time;
        int final_time;
        string input_file;
        string output_file;
        double tempo;
        double pitch;




        // Initilaze thee form and set the label6 to be file address which which the users choose in the text box
        public Edit()
        {
            InitializeComponent();
            EditFile.Text = Main.selected;
        }
        //call the Audio process class
        private AudioProcess process = new AudioProcess();

        /* Input: click
         * This is a button for the user to go back to the main page
         * output: none
         */
        private void BackToMain(object sender, EventArgs e)
        {
            Owner.Show();
            Close();

        }


        

        private void cutStart_TextChanged(object sender, EventArgs e)
        {
            //The beginning time of the user's cutting
            //https://msdn.microsoft.com/en-us/library/system.windows.forms.control.textchanged(v=vs.110).aspx
            try
            {
                // Convert the text to a Double and determine if it is a negative number.
                if (int.Parse(cutStart.Text) < 0)
                {
                    MessageBox.Show("Enter positive numbers only!");
                    cutStart.Text = "";
                    return;
                }
                else
                {
                    // If the number is not negative, display it in Black.
                    cutStart.ForeColor = Color.Black;
                    start_time = int.Parse(cutStart.Text);
                }
            }
            catch
            {
                // If there is an error, display the text using the system colors.
                cutStart.ForeColor = SystemColors.ControlText;
            }
        }

        private void cutFinish_TextChanged(object sender, EventArgs e)
        {
            //https://msdn.microsoft.com/en-us/library/system.windows.forms.control.textchanged(v=vs.110).aspx
            try
            {
                //The total time of the cutting
                // Convert the text to a Double and determine if it is a negative number.
                if (int.Parse(cutFinish.Text) < 0)
                {
                    MessageBox.Show("Enter positive numbers only!");
                    cutFinish.Text = "";
                    return;
                }
                else
                {
                    // If the number is not negative, display it in Black.
                    cutFinish.ForeColor = Color.Black;
                    final_time = int.Parse(cutFinish.Text);
                }
            }
            catch
            {
                // If there is an error, display the text using the system colors.
                cutFinish.ForeColor = SystemColors.ControlText;
            }
        }

        private void CommitCut_Click(object sender, EventArgs e)
        {
            if (EditFile.Text.Contains(" ") || EditFile.Text.Contains("-"))
            {
                MessageBox.Show("Path cannot contain a space or a \"-\"\nPath: " + input_file);
                return;
            }
            else
            {
                if (cutStart.Text == "")
                {
                    MessageBox.Show("Enter start time");
                    return;
                }
                if (cutFinish.Text == "")
                {
                    MessageBox.Show("Enter final time");
                    return;
                }
                if (start_time<0)
                {
                    MessageBox.Show("Start time cannot be less than zero");
                    return;
                }
                if (final_time <= start_time)
                {
                    MessageBox.Show("Final time cannot be less than start time");
                    return;
                }
                
                else
                {
                    MessageBox.Show("Cutting file from " + start_time.ToString() + " seconds to " + final_time.ToString() + " seconds");
                    process.cut_file(start_time, final_time, EditFile.Text, output_file);
                    MessageBox.Show("Edit complete");
                    Close();
                    new Main().Show();
                }
            }
        }

        private void SavePitch_Click(object sender, EventArgs e)
        {
            double pitchChange = (pitchTrackbar.Value)/10;
            
            if (EditFile.Text.Contains(" ") || EditFile.Text.Contains("-"))
            {
                MessageBox.Show("Path cannot contain a space or a \"-\"\nPath: " + input_file);
                return;
            }
            else
            {
                MessageBox.Show("Scaling pitch by a factor of " + pitchChange.ToString());
                process.adjust_pitch(pitchChange, EditFile.Text, output_file);
                MessageBox.Show("Edit complete");
                Close();
                new Main().Show();
            }
        }

        private void SaveTempo_Click(object sender, EventArgs e)
        {
            double tempoChange = (tempoTrackbar.Value)/10;

            
            if (EditFile.Text.Contains(" ") || EditFile.Text.Contains("-"))
            {
                MessageBox.Show("Path cannot contain a space or a \"-\"\nPath: " + input_file);
                return;
            }
            else
            {
                MessageBox.Show("Scaling tempo by a factor of " + tempoChange.ToString());
                process.adjust_tempo(tempoChange, EditFile.Text, output_file);
                MessageBox.Show("Edit complete");
                Close();
                new Main().Show();
            }
            
        }
    }
}
