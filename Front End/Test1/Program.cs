using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ret = test_cut(10, 20, "2.wav", "2_cut.wav");
            Console.WriteLine(ret);

            ret = test_cut(1, 2, "3.wav", "3_cut.wav");
            Console.WriteLine(ret);

            bool rett = test_tempo(1, "2.wav", "2_tempo.wav");
            Console.WriteLine(rett);

            rett = test_tempo(888, "3.wav", "3_tempo.wav");
            Console.WriteLine(rett);

            bool retp = test_pitch(2, "2.wav", "2_tempo.wav");
            Console.WriteLine(retp);

            retp = test_pitch(0.5, "3.wav", "3_tempo.wav");
            Console.WriteLine(retp);
        }

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

        static public bool test_tempo(double tempo, string input_file, string output_file)
        {
            AudioProcess process = new AudioProcess();
            output_file = input_file.Replace(".wav", "_tempo.wav");
            process.adjust_tempo(tempo, input_file, output_file);

            bool rett = true;
            try
            {
                FileStream file = File.Open(output_file, FileMode.Open);
                if (file.Length == 0)
                {
                    rett = false;
                }

                file.Close();
            }
            catch (IOException e)
            {
                rett = false;
            }

            return rett;
        }

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
