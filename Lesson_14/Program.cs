using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // явное приведение
            int a = 10;
            object obj = a; // упаковка данных
            int b = (int)obj; // распаковка данных

            int d = 10;
            double num = d; // неявное приведение
            //Example1(2);
            //Example1("sewrwerew");
            //Example1('&');
            //Example1(true);
            ArrayList array = new ArrayList(); //медленнее
            List<int> ints = new List<int>(); // создан массив с числами  быстрее
            //List<string> strings = new List<string>(); // создан массив со строками
            //Example2(4);
            //Example2("dsgsdg");
            //Example2('&');
            //Example2(false);
            //Example2(obj);

            //Position<int, int> pos1 = new Position<int, int>(6, 10);
            //pos1.x = 0;
            //pos1.y = 0;

            //Console.WriteLine("x: " + pos1.x.GetType() + ". y: " + pos1.y.GetType());

            //Position<double, double> pos2 = new Position<double, double>(45.3, 6.8);
            //pos2.x = 0;
            //pos2.y = 0;

            //Console.WriteLine("x: " + pos2.x.GetType() + ". y: " + pos2.y.GetType());

            Car<int> car1 = new Car<int>();
            Car<int>.Engine<double> engine1 = new Car<int>.Engine<double>();
        }

        static void Example1(object n)
        {
            Console.WriteLine(n);
        }

        static void Example1(int n)
        {
            Console.WriteLine(n);
        }

        static T Example2<T>(T a) 
        {
            return a;
        }
    }

    public class Position<T, P>
    {
        public T x;
        public P y;

        public Position(T x, P y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Car<T>
    { 
        public class Engine<P>
        {

        }
    }
}
