using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_24
{
    // класс "издатель"
    internal class Stock
    {
        private double _price;

        public string Name { get; }

        public event Action<double, string> PriceChanged;

        public Stock(double price, string name)
        {
            Price = price;
            Name = name;
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= 0 && value != _price)
                {
                    _price = value;
                    PriceChanged?.Invoke(_price, Name);
                }
            }
        }
    }
}
