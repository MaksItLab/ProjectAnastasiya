using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Program
    {
        public static int a = 18;
        // public
        // protected
        // internal
        // private
        static void Main(string[] args)
        {
            #region Class Structure
            //Person person1 = new Person();
            //person1.age = 18;
            //person1.login = "login123";
            //person1.password = "secret123";

            //Person person2 = person1;

            //person2.login = "null";

            //Console.WriteLine($"Person1. Login: {person1.login}, Password: {person1.password}");
            //Console.WriteLine($"Person2. Login: {person2.login}, Password: {person2.password}");

            //PersonStruct personStruct1 = new PersonStruct();
            //personStruct1.age = 18;
            //personStruct1.login = "login123";
            //personStruct1.password = "secret123";

            //PersonStruct personStruct2 = personStruct1;

            //personStruct2.login = "null";

            //Console.WriteLine($"PersonStruct1. Login: {personStruct1.login}, Password: {personStruct1.password}");
            //Console.WriteLine($"PersonStruct2. Login: {personStruct2.login}, Password: {personStruct2.password}");
            #endregion

            // Принципы ООП:
            // 1. Инкапсуляция - private
            // 2. Наследование
            // 3. Полиморфизм
            // 4. Абстракция
            Print();
            Person person1 = new Person();

            Console.WriteLine("Логин: " + person1.GetLogin());

            person1.SetLogin("newlogin");

            Console.WriteLine("Логин: " + person1.GetLogin());
        }
        public static void Print()
        {

        }
    }

    /// <summary>
    /// Класс человека
    /// </summary>
    public class Person
    {
        private int age = 18;
        private string login = "login123";
        private string password;

        public string GetLogin() => login;

        public void SetLogin(string log) => login = log;

        public void DisplayInfo()
        {
            Console.WriteLine(age);
        }
        
    }

    /// <summary>
    /// Структура человека
    /// </summary>
    public struct PersonStruct
    {
        public int age;
        public string login;
        public string password;
    }

}
