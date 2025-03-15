using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stack and Heap
            //Person person1 = new Person();
            //person1.name = "Test";
            //Person person2 = new Person();
            //person2.name = "Bag";

            //Console.WriteLine(person1.name);
            //Console.WriteLine(person2.name);

            //int a = 5;
            //int b = a;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //a += 10;

            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //Person person1 = new Person();
            //person1.name = "Test";

            //Person person2 = person1;

            //Console.WriteLine(person1.name);
            //Console.WriteLine(person2.name);

            //Console.WriteLine("После изменения: ");

            //person2.name = "Maksim";

            //Console.WriteLine(person1.name);
            //Console.WriteLine(person2.name);

            //Console.WriteLine("-------------------Структура-------------------");

            //PersonStruct personStruct1 = new PersonStruct();
            //personStruct1.name = "Test";

            //PersonStruct personStruct2 = personStruct1;

            //Console.WriteLine(personStruct1.name);
            //Console.WriteLine(personStruct2.name);

            //Console.WriteLine("После изменения: ");

            //personStruct2.name = "Maksim";

            //Console.WriteLine(personStruct1.name);
            //Console.WriteLine(personStruct2.name);

            #endregion

            #region ref, out
            //int a = 10;
            //Inc(ref a);
            //Console.WriteLine("Переменная а в Main равняется " + a);
            //int a;

            //Increment(out a, 4);

            //Console.WriteLine("Переменная a в методе равняется " + a);

            //int.TryParse(Console.ReadLine(), out int result);

            #endregion

            #region Практика
            Person person = new Person();
            person.name = "Maksim";
            Test(ref person);
            Console.WriteLine(person.name);

            int a;
            Increment(out a);
            Inc(ref a);
            #endregion
        }

        public static void Test(ref Person person)
        {
            person = null;
        }

        public static void Increment(out int num)
        {
            num = 10; // 100% нужно сделать
            Console.WriteLine("Переменная num в методе равняется " + num);
        }

        public static void Inc(ref int num)
        {
           
            Console.WriteLine("Переменная num в методе равняется " + num);
        }
    }

    public class Person
    {
        public string name;
    }

    public struct PersonStruct
    {
        public string name;
    }
}
