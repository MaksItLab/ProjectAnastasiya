using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            Console.WriteLine("Введите заменяемое слово:");
            string oldWord = Console.ReadLine();
            Console.WriteLine("Введите новое слово:");
            string newWord = Console.ReadLine();

            ReplaceWordInFile("words.txt", oldWord, newWord);

            //валидация - проверка на корректность данных
        }

        public static void ReplaceWordInFile(string path, string oldWord, string newWord)
        {
            string message = "null";

            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                message = Encoding.UTF8.GetString(buffer); //input

                //message = message.Replace(oldWord, newWord);

                string pattern = oldWord; // это шаблон
                string replacement = newWord; // это то, на что мы заменяем

                message = Regex.Replace(message, pattern, replacement, RegexOptions.IgnoreCase);
            }

            using (FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[message.Length];
                buffer = Encoding.UTF8.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
            }
        }

    }
}
