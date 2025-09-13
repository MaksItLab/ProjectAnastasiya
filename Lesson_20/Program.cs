using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandConsole;


namespace Lesson_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File - статический класс, который содержит методы для работы с файлами
            //FileInfo - нестатический класс, который 
            //Directory
            //DirectoryInfo
            //File.OpenText("");
            //FileInfo file2 = new FileInfo("file.txt");
            //FileInfo file3 = new FileInfo("file2.txt");
            //File.WriteAllText(file3.FullName, "Hello World!");
            //File.CreateText
            //ShowAll(@"C:\");

            CommandConsole.CommandConsole console = new CommandConsole.CommandConsole();

            

            while (true)
            {
                console.PrintCurrentPath();
                string command = Console.ReadLine();
                Console.WriteLine();
            }
        }

        public static void ShowAll(string path)
        {
            var directories = Directory.GetDirectories(path);
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var dir in directories) 
            {
                Console.WriteLine(dir);
            }

            var files = Directory.GetFiles(path);
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var file in files) 
            {
                Console.WriteLine(file);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
