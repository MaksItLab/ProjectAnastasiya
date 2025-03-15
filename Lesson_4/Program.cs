using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    internal class Program
    {
        //o	Определение и вызов методов
        //o Аргументы и возвращаемые значения
        //o Рекурсия

        static void Main(string[] args)
        {
            //Print(); // вызов метода
            //Print(); // вызов метода
            //Print(); // вызов метода
            //Print(); // вызов метода
            //Print(); // вызов метода
            //Print(); // вызов метода
            //Print(); // вызов метода
            //Print(); // вызов метода
            //string str = Print(); // вызов метода


            //Console.WriteLine(Compare(4, 9));
            //Console.WriteLine(Compare(0, -6));
            //Console.WriteLine(Compare(10, 19));
            //Console.WriteLine(Compare(-1, -1));
            //Console.WriteLine(Compare(-1, -1));

            //Console.WriteLine(Summ("dsad", 4, 5, 6, 7, 3, 2, 6, 3, 5, 0, 4));
            //Console.WriteLine(Summ("dsad", 4, 5, 6, 0, 4));

            #region Recursive
            //Rec();
            // Найти факториал числа n
            // 5! = 5 * (4 * 3 * 2 * 1) = 120
            // 5! = 5 * 4! // 120
            // 4! = 4 * 3! // 24
            // 3! = 3 * 2! // 6 
            // 2! = 2 * 1! // 2
            // 1! = 1 * 0! // 1
            // 0! = 1

            // 5!! = 5! * 4! * 3! * 2! * 1!
            // 5!! = 5! * 4!!


            //int num = 5;
            //int fact = Factorial(num);
            //Console.WriteLine("С рекурсией: " + fact);
            //int temp = 1;
            //for (int i = 1; i <= num; i++)
            //{
            //    temp *= i;
            //}

            //Console.WriteLine("С циклом for: " + temp);

            Console.WriteLine(SuperFactorial(5));
            double d = 3.14;
            decimal dec = 3.14M;

            string str = "Hello";

            Rec();
            #endregion

        }
        public static int Factorial(int num)
        {
            if (num == 1) return 1; 
            int fact =  num * Factorial(num - 1);
            return fact;
        }
        public static int SuperFactorial(int num)
        {
            if (num == 1) return 1;
            int superFact = Factorial(num) * SuperFactorial(num - 1);
            return superFact;
        }
        public static void Rec()
        {
            Rec();
        }
        public static string Print() // определение метода
        {
            Console.WriteLine("Работа метода Print!");
            return "Конец метода"; // вернуть значение
        }
        public static bool Compare(int a, int b)
        {
            if (a > b)
            {
                return true;
            }
            else if (a < b)
            {
                return false;
            }
            else if (a == b)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
        public static double Divide(int num1, int num2)
        {
            double result = (double)num1 / Convert.ToDouble(num2);
            return result;
        }

        //params - передача нескольких аргументов в метод, всегда ложен быть в конце
        public static int Summ(string str, params int[] numbers) // последовательность чисел
        {
            return numbers.Sum();
        }
        // 7, 4, 3, 8, 0, -6, 7

        // public static void Print - сигнатура
        // public - модификатор доступа
        // static - это метод/переменная класса
        // void - возвращаемого значения нет

    }

    
}
