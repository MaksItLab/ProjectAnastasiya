using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_23
{
    public delegate void MassageHandler(string message);

    public delegate int Operation(int a, int b);

    internal class Program
    {
        //static void PrintMessage(string msg)
        //{
        //    Console.WriteLine("Напечатано сообщение: " + msg);
        //}

        //static void ShowMessage(string msg)
        //{
        //    Console.WriteLine(msg);
        //}

        static int Add(int a, int b) => a + b;

        static int Sub(int a, int b) => a - b;

        static int Calculate(int a, int b, Operation op)
        {
            return op(a, b);
        }

        static void Main(string[] args)
        {
            ////MassageHandler handler = new MassageHandler(ShowMessage);
            //MassageHandler handler = ShowMessage;
            //handler += PrintMessage;
            ////handler("hello");
            //handler.Invoke("hello");
            //Console.WriteLine(handler.Method);

            int result = Calculate(5, 7, Add);
            Console.WriteLine(result);
            result = Calculate(5, 7, Sub);
            Console.WriteLine(result);

            Func<int, int> square = (a) =>
            {
                Console.Write("Квадрат числа a:");
                int resultSquare = a * a;
                Console.WriteLine(resultSquare);
                return resultSquare;
            };

        }

    }
}
