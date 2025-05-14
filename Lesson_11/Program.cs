using System;
using Lesson_11.Entities;

namespace Lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskBase task = new TaskBase();
            Console.WriteLine(task.Password); // get
            task.Password = "newsecret123"; // set
            Console.WriteLine(task.Password); // get

            task.Id = "nvt9348yt9874qbtn984t3787HIUH98292"; // set
            Console.WriteLine(task.Id); // get

            // задаем значения свойствам (НЕправильно)
            //task.Status = "В процессе";
            //task.Name = "Добавление сущности User";
            //task.Description = "description";

            //задаем значения свойствам (Правильно)
            TaskBase task2 = new TaskBase()
            {
                Id = "dkjfjksdfhb32gr7867472bgdg",
                Name = "Удалить сущность User",
                Description = "description",
                Status = "Выполнено"
            };
            task2.Password = "";
            Console.WriteLine(task2.Password);
            task2.Status = "Не выполнено";

            // nullable (?)
            // ?? - проверка на null
            // ! - гарантия, что объект не равен null
            
            int? age = 16;
            task2.Order = 10;
            Console.WriteLine(task2.Order ?? 0);
            //if (task2.Order != null)
            //{
            //    Console.WriteLine(task2.Order);
            //}
            //else Console.WriteLine("Пустое значение");
            



        }
    }
}
