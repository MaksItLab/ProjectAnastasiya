using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    internal class Program
    {
        // Циклы (for, while, do while, foreach)
        // break
        // continue
        // Вложенные циклы
        static void Main(string[] args)
        {
            #region Циклы
            //1 секция - инициализация
            //2 секция - условие работы цикла
            //3 секция - действия после одной итерации

            // 1->2->код->3->2->код->3->2->...

            //for (int i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //string login = "unity123";
            //string password = "secret731";
            //bool isDataCorrect = false; // true|false

            //while (!isDataCorrect)
            //{
            //    string userLogin = Console.ReadLine();
            //    string userPassword = Console.ReadLine();

            //    if (userLogin.Equals(login) && userPassword.Equals(password))
            //    {
            //        Console.WriteLine("Вход успешно совершен!");
            //        isDataCorrect = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Данные не совпали");
            //    }

            //}

            //string login = "unity123";
            //string password = "secret731";

            //int a = 0;

            //do
            //{
            //    string userLogin = Console.ReadLine();
            //    string userPassword = Console.ReadLine();
            //    if (userLogin.Equals(login) && userPassword.Equals(password))
            //    {
            //        Console.WriteLine("Вход успешно совершен!");
            //        break;
            //    }
            //    else
            //    {
            //        a++;
            //        Console.WriteLine("Данные не совпали. Осталось попыток: " + (3 - a));
            //    }
            //}
            //while (a < 3);



            //foreach (char symbol in "hello")
            //{
            //    Console.WriteLine(symbol);
            //}

            //for(int i = 0; i < 10; i++)
            //{
            //    if (i % 2 != 0) break;

            //    Console.WriteLine(i);
            //}

            // 1 цикл - O(n) - 5
            // 2 цикла - O(n^2) - 25
            // 3 цикла - O(n^3)  - 125
            int count = 0;

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        Console.WriteLine($"{i};{j};{k}");
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
            
            #endregion
        }
    }
}
