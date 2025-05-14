using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10.Entities
{
    public class User
    {
        private int _age;
        private string _name;
        private string _email;
        private string _password;
        private string _login;

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="age">Возраст</param>
        /// <param name="name">Имя</param>
        /// <param name="email">Почта</param>
        /// <param name="password">Пароль</param>
        /// <param name="login">Логин</param>
        public User(int age, string name, string email, string password, string login)
        {
            _age = age;
            _name = name;
            _email = email;
            _password = password;
            _login = login;
        }

        public User()
        {

        }

        /// <summary>
        /// Деструктор
        /// </summary>
        ~User()
        {
            Console.WriteLine("Объект удален");
            Console.WriteLine(this._name);
        }




        /// <summary>
        /// Метод, возвращающий значения возраста
        /// </summary>
        /// <returns>Возраст пользователя</returns>
        public int GetAge() => _age;

        public void Print(int age)
        {

        }
        public void Print(string name)
        {

        }
        public void Print(int age, string name)
        {

        }
        public void Print(string name, int age)
        {

        }
    }
}
