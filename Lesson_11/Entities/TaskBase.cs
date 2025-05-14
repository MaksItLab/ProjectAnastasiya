using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11.Entities
{
    internal class TaskBase
    {
        //public string Id; // поле (переменная) 
        public string Id { get; set; } // автосвойство ~ свойство

        private string password = "secret123";

        //public string GetPass() => password;

        public string Password
        {
            //возвращает значение
            get
            {
                return password;
            }
            //устанавливает значение
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Ошибка! Пароль пустой");
                    return;
                }
                password = value;

            }
        }

        /// <summary>
        /// Статус задачи
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Название задачи
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание задачи
        /// </summary>
        public string Description { get; set; }

        public int? Order { get; set; }
    }
}