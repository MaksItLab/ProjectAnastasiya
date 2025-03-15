using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    // Операторы сравнения
    // Оператор if-else
    // Тернарный оператор
    // Логические операторы 
    // switch-case
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
            #endregion

            #region Операторы сравнения

            // >, <, >=, <=, ==, !=
            //int a = 10;
            //int b = 10;
            //Console.WriteLine(a > b);
            //Console.WriteLine(a < b);
            //Console.WriteLine(a >= b);
            //Console.WriteLine(a <= b);
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);
            #endregion

            #region Условия
            //string str = "Hello, World!";
            //string name = "Maksim";

            //if (name.Length > str.Length)
            //{
            //    Console.WriteLine("Имя длинне, чем строка");
            //}
            //else if (name.Length == str.Length)
            //{
            //    Console.WriteLine("Длина строк одинакова");
            //}
            //else
            //{
            //    Console.WriteLine("Строка длинне, чем имя");
            //}
            #endregion

            #region Тернарный оператор
            // +-*/ - бинарные
            // ++, --, ! - унарные

            //int a = 10;
            //int b = 15;

            //string result = a > b ? a.ToString() : (b > a ? b.ToString() : "Переменные равны");
            //bool isJump = игрок.Прыжок() ? false : true;
            //Console.WriteLine(result);

            #endregion

            #region  Логические операторы
            // && - And
            // || - Or
            // ! - Not
            // & - And (полная проверка)
            // | - Or (полная проверка)

            //int a = 10;
            //int b = 35;

            //int input = int.Parse(Console.ReadLine());

            //if (input >= a && input <= b || !false)
            //{
            //    Console.WriteLine($"{input} находится в диапазоне [{a};{b}] ");
            //}

            //bool correctData = false;

            //if (false)
            //{
            //    Console.WriteLine("Введите данные");
            //}

            #endregion

            #region Switch-case

            //string word = Console.ReadLine().ToLower();

            //switch (word)
            //{
            //    case "cat":
            //        Console.WriteLine("Кот");
            //        break;

            //    case "home":
            //        Console.WriteLine("Дом");
            //        break;

            //    case "car":
            //        Console.WriteLine("Машина");
            //        break;
            //}

            #endregion

            #region Menu
            //Console.WriteLine("Выберите действие: \n" +
            //                  "1 - Сложить\n" +
            //                  "2 - Вычесть\n" +
            //                  "3 - Умножить\n" +
            //                  "4 - Поделить");

            //int action = int.Parse(Console.ReadLine());

            //switch (action)
            //{
            //    case 1:
            //        Console.WriteLine("Идёт сложение чисел");
            //        break;
            //    case 2:
            //        Console.WriteLine("Идёт вычитание чисел");
            //        break;
            //    case 3:
            //        Console.WriteLine("Идёт умножение чисел");
            //        break;
            //    case 4:
            //        Console.WriteLine("Идёт деление чисел");
            //        break;

            //    default:
            //        Console.WriteLine("Такого пункта меню нет");
            //        break;
            //}
            #endregion

            #region Методы
            Print(25);
            Print(10);
            Print(-876);
            Print(0);

            int a = PrintReturn(10);
            int b = PrintReturn(42);
            int c = PrintReturn(-124);
            int d = PrintReturn(44);

            Console.WriteLine($"{a} {b} {c} {d}");
            
            #endregion
        }

        public static void Print(int a, int b)
        {
            Console.WriteLine("Метод Print() работает. Число " + a);
        }

        public static int PrintReturn(int a)
        {
            a += 100;
            return a;
        }



    }
}
