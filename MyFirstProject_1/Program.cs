using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ввод и Вывод в консоль
            //Вывод
            //Console.WriteLine("Введите имя: ");
            //Ввод
            //Console.ReadLine();
            // int - число
            // double - дробное число
            // string - текст ("Hello")
            // bool - true/false
            // char - один символ ('e', '1', '&')

            //int number = 10;
            //Console.WriteLine(number);
            // CTRL + K + C - закомментировать
            // CTRL + K + U - раскомментировать

            //string name = Console.ReadLine();
            //string city = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //double height = double.Parse(Console.ReadLine());

            //Console.WriteLine(name);
            //Console.WriteLine(city);
            //Console.WriteLine(age);
            //Console.WriteLine(height);

            ////1.конкатенация
            //Console.WriteLine("Имя: " + name + ". Город: " + city + ". Возраст: " + age + ". Рост: " + height);
            ////2.форматирование (placeholders)
            //Console.WriteLine("Имя: {0}. Город: {1}. Возраст: {2}. Рост: {3}", name, city, age, height);
            ////3.интерполяция
            //Console.WriteLine($"Имя: {name}. Город: {city}. Возраст: {age}. Рост: {height}");
            #endregion
            #region Арифметические операторы
            // + сложение
            // - вычитание
            // * умножение
            // / деление

            //int number1 = 10;
            //int number2 = 6;

            //int resultSum = number1 + number2;
            //Console.WriteLine("Сумма: " + resultSum);
            //int resultSub = number2 - number1;
            //Console.WriteLine("Вычитание: " + resultSub);
            //int resultMulti = number1 * number2;
            //Console.WriteLine("Умножение: " + resultMulti);
            //double resultDiv = number1 / Convert.ToDouble(number2);
            //Console.WriteLine("Деление: " + resultDiv);
            #endregion

            int a = 4;
            int b = 4;
            int c = 9;
            int d = -2;
            int e = -4;

            // 11 / 5 = 2,2

            double avg = (a + b + c + d + e) / 5.0;

            Console.WriteLine("AVG = " + avg);

        }
    }
}
