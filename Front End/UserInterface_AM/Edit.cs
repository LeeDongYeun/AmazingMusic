using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Edit()
        {
            InitializeComponent();
            label6.Text = Main.selected;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double Tempo = trackBar2.Value;
            double DecimalTempo = Tempo / 10;
            adjust_tempo(DecimalTempo, label6.Text, output_file);
            Close();
            Main main = new Main();
            main.Show();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void adjust_tempo(double tempo, string input_file, string output_file)
        {
            string str_tempo = string.Format("{0:G}", tempo);

            Process process = new Process();

            process.StartInfo.FileName = "ffmpeg.exe";
            output_file = input_file.Replace(".wav", "_tempo.wav");
            //used to not displaying interface
            process.StartInfo.CreateNoWindow = true;
            //Start the process without using the operating system shell
            process.StartInfo.UseShellExecute = false;
            string command = " -y -i " + input_file + " -filter:a \"atempo = " + str_tempo + "\" " + output_file;
            process.StartInfo.Arguments = command;

            process.Start();
            process.WaitForExit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //The beginning time of the user's cutting
            //https://msdn.microsoft.com/en-us/library/system.windows.forms.control.textchanged(v=vs.110).aspx
            try
            {
                // Convert the text to a Double and determine if it is a negative number.
                if (int.Parse(textBox1.Text) < 0)
                {
                    // If the number is negative, display it in Red.
                    textBox1.ForeColor = Color.Red;
                }
                else
                {
                    // If the number is not negative, display it in Black.
                    textBox1.ForeColor = Color.Black;
                    start_time = int.Parse(textBox1.Text);
                }
            }
            catch
            {
                // If there is an error, display the text using the system colors.
                textBox1.ForeColor = SystemColors.ControlText;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //https://msdn.microsoft.com/en-us/library/system.windows.forms.control.textchanged(v=vs.110).aspx
            try
            {
                //The total time of the cutting
                // Convert the text to a Double and determine if it is a negative number.
                if (int.Parse(textBox2.Text) < 0)
                {
                    // If the number is negative, display it in Red.
                    textBox2.ForeColor = Color.Red;
                }
                else
                {
                    // If the number is not negative, display it in Black.
                    textBox2.ForeColor = Color.Black;
                    final_time = int.Parse(textBox2.Text);
                }
            }
            catch
            {
                // If there is an error, display the text using the system colors.
                textBox2.ForeColor = SystemColors.ControlText;
            }
        }
        public void cut_file(int start_time, int final_time, string input_file, string output_file)
        {
            int last_time = final_time - start_time;
            string str_start = string.Format("{0:G}:{1:G}:{2:G}", start_time / 3600, start_time / 60 % 60, start_time % 60);
            string str_last = string.Format("{0:G}:{1:G}:{2:G}", last_time / 3600, last_time / 60 % 60, last_time % 60);

            Process process = new Process();

            process.StartInfo.FileName = "ffmpeg.exe";

            //used to not displaying interface
            process.StartInfo.CreateNoWindow = true;
            //Start the process without using the operating system shell
            process.StartInfo.UseShellExecute = false;
            output_file = input_file.Replace(".wav", "_cut.wav");
            string command = " -ss " + str_start + " -t " + str_last + " -y -i " + input_file + " " + output_file;
            process.StartInfo.Arguments = command;

            process.Start();
            process.WaitForExit();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cut_file(start_time, final_time, label6.Text, output_file);
            Close();
            Owner.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //The value which the User want to changes the pitch of the audio file
            //https://msdn.microsoft.com/en-us/library/system.windows.forms.control.textchanged(v=vs.110).aspx
          /*  try
            {
                // Convert the text to a Double and determine if it is a negative number.
                if (double.Parse(textBox3.Text) < 0)
                {
                    // If the number is negative, display it in Red.
                    textBox3.ForeColor = Color.Red;
                }
                else
                {
                    // If the number is not negative, display it in Black.
                    textBox3.ForeColor = Color.Black;
                    pitch = int.Parse(textBox3.Text);
                }
            }
            catch
            {
                // If there is an error, display the text using the system colors.
                textBox3.ForeColor = SystemColors.ControlText;
            }*/
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //The value which the User want to changes the tempo of the audio file
            //https://msdn.microsoft.com/en-us/library/system.windows.forms.control.textchanged(v=vs.110).aspx
           /* try
            {
                // Convert the text to a Double and determine if it is a negative number.
                if (double.Parse(textBox4.Text) < 0)
                {
                    // If the number is negative, display it in Red.
                    textBox4.ForeColor = Color.Red;
                }
                else
                {
                    // If the number is not negative, display it in Black.
                    textBox4.ForeColor = Color.Black;
                    tempo = int.Parse(textBox4.Text);
                }
            }
            catch
            {
                // If there is an error, display the text using the system colors.
                textBox4.ForeColor = SystemColors.ControlText;
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pitchChange = trackBar1.Value;
            double DecimalValue = pitchChange / 10;
            
            
            MessageBox.Show(DecimalValue.ToString());
            adjust_pitch(DecimalValue, label6.Text, output_file);
            Close();
            Main main = new Main();
            main.Show();
        }
        public void adjust_pitch(double pitch, string input_file, string output_file)
        { 
           

            //Get the sample rate of the input file first
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = "ffprobe.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.Arguments = " -v error -show_entries stream=sample_rate -of default=noprint_wrappers=1:nokey=1 " + input_file;
            process.Start();

            string strResult = process.StandardOutput.ReadToEnd();

            int samplerate = int.Parse(strResult);

    

            //Sampling rate × coefficient is converted to (changed)sample rate
            samplerate = (int)(samplerate * pitch);

            //NEW
            double newTempo = (double)(1 / pitch);
 

            process.WaitForExit();
            process.Close();



            //Generate an output file using the (changed)sample rate
            process = new Process();
            process.StartInfo.FileName = "ffmpeg.exe";
            //used to not displaying interface
            process.StartInfo.CreateNoWindow = true;
            //Start the process without using the operating system shell
            process.StartInfo.UseShellExecute = false;
            output_file = input_file.Replace(".wav", "_pitch.wav");

            //NEW
            string command = " -y -i " + input_file + " -filter:a \"asetrate = " + samplerate + ",atempo = " + newTempo + "\" " + output_file;
            process.StartInfo.Arguments = command;

            process.Start();
            process.WaitForExit();

       
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            MessageBox.Show(trackBar1.Value.ToString());
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            MessageBox.Show(trackBar2.Value.ToString());
        }
    }
}
