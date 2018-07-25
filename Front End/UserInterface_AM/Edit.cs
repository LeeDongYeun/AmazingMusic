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
        /* Input: number
        * This is a text box for the user to input the start time for cutting
        * output: start time for the cutting
        * Reference: https://msdn.microsoft.com/en-us/library/system.windows.forms.control.textchanged(v=vs.110).aspx
        * for changing the input color if it is not legal
        */
        private void cutStart_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(cutStart.Text) < 0)
                {
                    MessageBox.Show("Enter positive numbers only!");
                    cutStart.Text = "";
                    return;
                }
                else
                {
                    cutStart.ForeColor = Color.Black;
                    start_time = int.Parse(cutStart.Text);
                }
            }
            catch
            {
                cutStart.ForeColor = SystemColors.ControlText;
            }
        }
        /* Input: number
         * This is a text box for the user to input the end time for cutting
         * output: end time for the cutting
         * Reference: https://msdn.microsoft.com/en-us/library/system.windows.forms.control.textchanged(v=vs.110).aspx
         * for changing the input color if it is not legal
         */
        private void cutFinish_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(cutFinish.Text) < 0)
                {
                    MessageBox.Show("Enter positive numbers only!");
                    cutFinish.Text = "";
                    return;
                }
                else
                {
                    cutFinish.ForeColor = Color.Black;
                    final_time = int.Parse(cutFinish.Text);
                }
            }
            catch
            {
                cutFinish.ForeColor = SystemColors.ControlText;
            }
        }
        /* Input: click
         * This is a button for the user to commit the changing of cutting a file
         * output: none
         */
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
                if (start_time < 0)
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
        /* Input: bar position and a click
         * This is a button for the user to commit the changing of the pitch of a file
         * output: none
         */
        private void SavePitch_Click(object sender, EventArgs e)
        {
            double pitchChange = (pitchTrackbar.Value) / 10;
            if (EditFile.Text.Contains(" ") || EditFile.Text.Contains("-"))
            {
                MessageBox.Show("Path cannot contain a space or a \"-\"\nPath: " + input_file);
                return;
            }
            else
            {

                process.adjust_pitch(pitchChange, EditFile.Text, output_file);
                MessageBox.Show("Edit complete");
                Close();
                new Main().Show();
            }
        }
        /* Input: bar position and a click
         * This is a button for the user to commit the changing of the tempo of a file
         * output: none
         */
        private void SaveTempo_Click(object sender, EventArgs e)
        {
            double tempoChange = (tempoTrackbar.Value) / 10;

            if (EditFile.Text.Contains(" ") || EditFile.Text.Contains("-"))
            {
                MessageBox.Show("Path cannot contain a space or a \"-\"\nPath: " + input_file);
                return;
            }
            else
            {
                process.adjust_tempo(tempoChange, EditFile.Text, output_file);
                MessageBox.Show("Edit complete");
                Close();
                new Main().Show();
            }
        }
    }
}