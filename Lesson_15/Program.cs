using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ - language integreated query
            List<User> users = new List<User>
            {
                new User(){Id = 1, Name="Jonh", Age = 18 },
                new User(){Id = 2, Name="Maksim", Age = 26 },
                new User(){Id = 3, Name="Alex", Age = 24 },
                new User(){Id = 4, Name="Ivan", Age = 30 },
                new User(){Id = 5, Name="Margo", Age = 28 },
                new User(){Id = 6, Name="Steave", Age = 56 },
                new User(){Id = 7, Name="Hutly", Age = 9 },
                new User(){Id = 8, Name="Gaet", Age = 42 },
                new User(){Id = 9, Name="Boil", Age = 35 },
                new User(){Id = 10, Name="Norm", Age = 49 },
            };


            var list1 = users.Select(u => u).Where(u => u.Age < 30);

            var list2 = users.OrderBy(u => u.Age);

            var list3 = users.OrderByDescending(u => u.Age);
            
            foreach (var u in list1)
            {
                Console.WriteLine(u.Name);
            }
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
