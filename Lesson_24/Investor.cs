using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_24
{
    //класс "подписчик"/"слушатель"
    internal class Investor
    {
        public string Name { get; }

        public Investor(string name)
        {
            Name = name;
        }

        public void OnPriceChanged(double newPrice, string nameOfStock)
        {
            Console.WriteLine($"Инвестор {Name} получил уведомление: новая ценая акции {nameOfStock} = {newPrice}");
        }

        public void Subscribe(Stock stock)
        {
            stock.PriceChanged += OnPriceChanged;
        }
    }
}
