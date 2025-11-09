using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Button btn = new Button();
            //btn.Click += (Results message) =>
            //{
            //    if (message == Results.Error)
            //    {
            //        Console.WriteLine("Error");
            //    }
            //};

            //btn.Click += (Results message) => 
            //    {
            //        if (message == Results.Success)
            //        {
            //            Console.WriteLine("Кнопка нажата");
            //        }
            //    };

            //btn.Press();

            var apple = new Stock(150, "Apple");

            var investor1 = new Investor("Петя");
            var investor2 = new Investor("Ваня");
            var investor3 = new Investor("Маша");

            investor1.Subscribe(apple);
            investor2.Subscribe(apple);
            investor3.Subscribe(apple);

            apple.Price = 170;
            apple.Price = 100;
        }
    }

    public class Button
    {
        public delegate void MyEventHandler(Results message);

        public event MyEventHandler Click;

        public void Press()
        {
            Click?.Invoke(Results.Success);
        }

        public void PressError()
        {
            Click?.Invoke(Results.Error);
        }
    }

    public enum Results
    {
        Success = 0,
        Error = 1
    }
}
