using System;
using Lesson_11.Entities;

namespace Lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TaskBase task = new TaskBase();
            //Console.WriteLine(task.Password); // get
            //task.Password = "newsecret123"; // set
            //Console.WriteLine(task.Password); // get
            

            //task.Id = "nvt9348yt9874qbtn984t3787HIUH98292"; // set
            //Console.WriteLine(task.Id); // get

            // задаем значения свойствам (НЕправильно)
            //task.Status = "В процессе";
            //task.Name = "Добавление сущности User";
            //task.Description = "description";

            //задаем значения свойствам (Правильно)
            //TaskBase task2 = new TaskBase()
            //{
            //    Id = "dkjfjksdfhb32gr7867472bgdg",
            //    Name = "Удалить сущность User",
            //    Description = "description",
            //    Status = "Выполнено"
            //};
            //task2.Password = "";
            //Console.WriteLine(task2.Password);
            //task2.Status = "Не выполнено";

            // nullable (?)
            // ?? - проверка на null
            // ! - гарантия, что объект не равен null
            
            //int? age = 16;
            //task2.Order = 10;
            //Console.WriteLine(task2.Order ?? 0);
            //if (task2.Order != null)
            //{
            //    Console.WriteLine(task2.Order);
            //}
            //else Console.WriteLine("Пустое значение");


            //staticClass.MethodStatic();
            //Console.WriteLine(staticClass.id);
            //Console.WriteLine(staticClass.Name);
            //Console.WriteLine(staticClass.order);

            staticClass s1 = new staticClass();
            //s1.Price = 10;
            //s1.order = 3;
            //s1.id = 2;

            Console consol1 = new Console();

            Enemy enemy1 = new Enemy(); // 2км
            Enemy enemy2 = new Enemy(); // 1км
            Enemy enemy3 = new Enemy(); // 3м

            enemy3.Damage(15);
            Console.WriteLine("Enemy3 ");
            enemy3.DisplayHealth();

            Console.WriteLine("Enemy2 ");
            enemy2.DisplayHealth();

            Console.WriteLine("Enemy1 ");
            enemy1.DisplayHealth();
        }
    }
}
