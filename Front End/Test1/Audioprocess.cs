using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Test1
{
    class AudioProcess
    {
        public void cut_file(int start_time, int final_time, string input_file, string output_file)
        {
            int last_time = final_time - start_time;
            string str_start = string.Format("{0:G}:{1:G}:{2:G}", start_time / 3600, start_time / 60 % 60, start_time % 60);
            string str_last = string.Format("{0:G}:{1:G}:{2:G}", last_time / 3600, last_time / 60 % 60, last_time % 60);

            output_file = input_file.Replace(".wav", "_cut.wav");
            string command = " -ss " + str_start + " -t " + str_last + " -y -i " + input_file + " " + output_file;
            call_process("ffmpeg.exe", command, false);

            return;
        }

        public void adjust_tempo(double tempo, string input_file, string output_file)
        {
            string str_tempo = string.Format("{0:G}", tempo);

            output_file = input_file.Replace(".wav", "_tempo.wav");
            string command = " -y -i " + input_file + " -filter:a \"atempo = " + str_tempo + "\" " + output_file;
            call_process("ffmpeg.exe", command, false);
        }

        public void adjust_pitch(double pitch, string input_file, string output_file)
        {
            //Get the sample rate of the input file first
            string command = " -v error -show_entries stream=sample_rate -of default=noprint_wrappers=1:nokey=1 " + input_file;
            string strResult = call_process("ffprobe.exe", command, true);

            int samplerate = int.Parse(strResult);

            //Sampling rate × coefficient is converted to (changed)sample rate
            samplerate = (int)(samplerate * pitch);

            //NEW
            double newTempo = (double)(1 / pitch);

            output_file = input_file.Replace(".wav", "_pitch.wav");

            //NEW
            command = " -y -i " + input_file + " -filter:a \"asetrate = " + samplerate + ",atempo = " + newTempo + "\" " + output_file;
            call_process("ffmpeg.exe", command, false);
        }

        public string call_process(string process_name, string param, bool redirect)
        {
            Process process = new Process();
            process.StartInfo.FileName = process_name;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            if (redirect)
            {
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
            }
            process.StartInfo.Arguments = param;

            process.Start();

            string strResult = "";
            if (redirect)
            {
                strResult = process.StandardOutput.ReadToEnd();
            }

            process.WaitForExit();

            return strResult;
        }
    }
}
