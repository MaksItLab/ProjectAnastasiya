using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11.Entities
{
    // static
    // нужен для обращения к полю/свойству/методу
    // через назание типа данных (класса)

    public static class staticClass
    {
        public static int id; // статическое поле

        public int order; // не статическое поле


        public static string Name { get; set; } // статическое свойство

        public double Price { get; set; } // не статическое свойство


        public static void MethodStatic() // статический метод
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + Name);

        }

        public void MethodNotStatic() // не статический метод
        {
            Console.WriteLine("order: " + order);
            Console.WriteLine("price: " + Price);
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + Name);
        }
    }
}
