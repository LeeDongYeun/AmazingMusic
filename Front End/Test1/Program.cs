using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace Test1
{
    class Program
    {
        /* Input: none
         * Description: Make a int random number
         * Output: int random number
         */
        static public int getRandomNum()
        {
            Random ran = new Random();
            Thread.Sleep(100);
            int on = ran.Next(-2, 10);
            return on;
        }
        /* Input: none
         * Description: Make a double random number
         * Output: double random number
         */
        static public double getRND()
        {
            Random ran = new Random();
            Thread.Sleep(100);
            int on = ran.Next(-10, 30);
            on = on / 10;
            return on;
        }
        static void Main(string[] args)
        {
            //initial the input value
            int o11 = getRandomNum();
            int o21 = getRandomNum();
            int o31 = getRandomNum();
            int o41 = getRandomNum();
            double o51 = getRND();
            double o61 = getRND();
            double o71 = getRND();
            double o81 = getRND();
            // Cut file tester1
            bool ret = test_cut(o11, o21, "2.wav", "2_cut.wav");
            if (o11 < 0 || o21 < 0 || o11 >= o21)
            {
                ret = false;
            }
            Console.WriteLine("Start Input number: " + o11 + "\nEnd Input number: " + o21 + "\nThe result is: " + ret + "\n");
            // Cut file tester2
            ret = test_cut(o31, o41, "3.wav", "3_cut.wav");
            if (o31 < 0 || o41 < 0 || o31 >= o41)
            {
                ret = false;
            }
            Console.WriteLine("Start Input number: " + o31 + "\nEnd Input number: " + o41 + "\nThe result is: " + ret + "\n");

            // tempo tester1
            bool rets = test_tempo(o51, "2.wav", "2_tempo.wav");
            Console.WriteLine("Tempo Input number: " + o51 + "\nThe result is: " + rets + "\n");

            // tempo tester2
            rets = test_tempo(o61, "3.wav", "3_tempo.wav");
            Console.WriteLine("Tempo Input number: " + o61 + "\nThe result is: " + rets + "\n");

            // pitch tester1
            bool retp = test_pitch(o71, "2.wav", "2_pitch.wav");
            Console.WriteLine("Pitch Input number: " + o71 + "\nThe result is: " + retp + "\n");

            // pitch tester2
            retp = test_pitch(o81, "3.wav", "3_pitch.wav");
            Console.WriteLine("Pitch Input number: " + o81 + "\nThe result is: " + retp + "\n");
        }
        /* Input: (int)start time, (int)final time, (string)input file, (string) output_file
         * Description: This is the test function for cutting the file
         * Output: True or False
         */
        static public bool test_cut(int start_time, int final_time, string input_file, string output_file)
        {
            AudioProcess process = new AudioProcess();
            output_file = input_file.Replace(".wav", "_cut.wav");
            process.cut_file(start_time, final_time, input_file, output_file);
            bool ret = true;
            try
            {
                FileStream file = File.Open(output_file, FileMode.Open);
                if (file.Length == 0)
                {
                    ret = false;
                }
                file.Close();
            }
            catch (IOException e)
            {
                ret = false;
            }
            return ret;
        }
        /* Input: (double)tempo value, (string)input file, (string) output_file
         * Description: This is the test function for changing the temp of the file
         * Output: True or False
         */
        static public bool test_tempo(double tempo, string input_file, string output_file)
        {
            AudioProcess process = new AudioProcess();
            output_file = input_file.Replace(".wav", "_tempo.wav");
            process.adjust_tempo(tempo, input_file, output_file);
            bool rets = true;
            try
            {
                FileStream file = File.Open(output_file, FileMode.Open);
                if (file.Length == 0)
                {
                    rets = false;
                }
                file.Close();
            }
            catch (IOException e)
            {
                rets = false;
            }
            return rets;
        }
        /* Input: (double)pitch value, (string)input file, (string) output_file
         * Description: This is the test function for changing the temp of the file
         * Output: True or False
         */
        static public bool test_pitch(double pitch, string input_file, string output_file)
        {
            AudioProcess process = new AudioProcess();
            output_file = input_file.Replace(".wav", "_pitch.wav");
            process.adjust_pitch(pitch, input_file, output_file);
            bool retp = true;
            try
            {
                FileStream file = File.Open(output_file, FileMode.Open);
                if (file.Length == 0)
                {
                    retp = false;
                }
                file.Close();
            }
            catch (IOException e)
            {
                retp = false;
            }
            return retp;
        }
    }
}