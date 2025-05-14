using Lesson_10.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 15;
            string name = "Bob";
            string email = "mail@mail.com";
            string password = "12345";
            string login = "login";

            User user = new User(15, name, email, password, "login");
            User user1 = new User();
           
            Order order = new Order();

            //user = null;
            user1 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            //user.Print("Объект удален");

            Console.WriteLine("Конец программы");
            
        }
    }
}
