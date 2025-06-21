using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (StreamWriter sw = new StreamWriter("file.txt", true))
            //{
            //    sw.WriteLine("Привет");
            //}

            //using (StreamReader sr = new StreamReader("file.txt"))
            //{
            //    byte[] buffer = new byte[100];
            //    for (int i = 0; !sr.EndOfStream; i++) 
            //    {
            //        buffer[i] = (byte)sr.Read();
            //    }

            //    string message = Encoding.UTF8.GetString(buffer);
            //    Console.WriteLine(message);
            //}

            //StreamReader
            //StreamWriter
            //File FileInfo
            //Directory DirectoryInfo


            //if (!File.Exists(filepath))
            //{
            //    using (StreamWriter sr = new StreamWriter("errors.txt", true))
            //    {
            //        sr.WriteLine(DateTime.Now);
            //        sr.WriteLine("File not exists");
            //        sr.WriteLine("");
            //    }


            //}

            string filepath = "file.tx";

            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (FileNotFoundException e)
            {
                using (StreamWriter sr = new StreamWriter("errors.txt", true))
                {
                    sr.WriteLine(DateTime.Now);
                    sr.WriteLine(e.Message);
                    sr.WriteLine(e.StackTrace);
                    sr.WriteLine();
                }
            }


        }
    }
}
