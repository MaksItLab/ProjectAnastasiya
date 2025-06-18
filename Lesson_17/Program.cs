using System;
using System.IO;
using System.Text;

namespace Lesson_17
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            // FileStream - класс, которые содержит методы для работы
            // с чтением и записью файлов

            //FileStream stream = new FileStream();

            //stream.Close();

            string filePath = "text.txt";
            //Запись
            //1 - path
            //2 - filemode(режим работы)
            //3 - fileaccess(доступ операций потока к файлу)
            //using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            //{
            //    string message = "Hello!";

            //    byte[] buffer = Encoding.UTF8.GetBytes(message);

            //    stream.Write(buffer, 0, buffer.Length);
            //};

            //Чтение
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[stream.Length];

                stream.Read(buffer, 0, buffer.Length);

                string message = Encoding.UTF8.GetString(buffer);

                Console.WriteLine(message);
            }

            
        }
    }
}
