using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Transport transport = new Transport();
            //Car car = new Car();
            //PassengerCar passengerCar = new PassengerCar();
            //Audi audi = new Audi();

            //transport.Speed = 40;

            //car.Speed = 90;
            //car.CountOfWheels = 8;
            //car.CountOfDoors = 8;

            //passengerCar.Speed = 100;
            //passengerCar.CountOfWheels = 3;
            //passengerCar.CountOfDoors = 5;
            //passengerCar.CountOfPassengers = 7;

            //audi.Speed = 10;
            //audi.CountOfWheels = 4;
            //audi.CountOfDoors = 5;
            //audi.CountOfPassengers = 7;
            //audi.Name = "A3";
            //audi.Year = "2022";

            //Console.WriteLine(transport.Speed);
            //Console.WriteLine(car.Speed);
            //Console.WriteLine(passengerCar.Speed);
            //Console.WriteLine(audi.Speed);

            //audi.Move();

            //Plane plane = new Plane();
            //plane.Move();

            //Transport plane1 = new Car();

            //plane1.Move();

            Plane plane = new Plane();
            Audi audi = new Audi();

            List<IMove> list = new List<IMove>();
            list.Add(audi);
            list.Add(plane);

            foreach (var item in list)
            {
                item.Start();
            }

        }
    }

    public interface IMove
    {
        void Start();
        int Fuel { get; set; }
    }

    public interface IStay
    {
        void Stop();
    }

    // родительский класс
    public class Transport
    {
        public int Speed { get; set; }

        // виртуальный метод
        public virtual void Move()
        {
            Console.WriteLine("Транспорт едет");
        }
    }

    public class Car : Transport
    {
        public int CountOfDoors { get; set; }
        public int CountOfWheels { get; set; }
    }

    public class PassengerCar : Car
    {
        public int CountOfPassengers { get; set; }
    }

    public class Audi : PassengerCar, IMove, IStay
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public int Fuel { get; set; }

        public void Start()
        {
            Console.WriteLine("Машина поехала");
        }

        public void Stop()
        {
            Console.WriteLine("Машина остановилась");
        }
    }

    public class Plane : Transport, IMove, IStay
    {
        public int Fuel { get; set; }

        // переопределение метода
        public override void Move()
        {
            Console.WriteLine("Самолет летит");
        }
        //перегрузка метода
        public void Move(int a)
        {

        }

        //перегрузка метода
        public void Move(string a, int b, bool c)
        {

        }

        public void Start()
        {
            Console.WriteLine("Самолет взлетел");
        }

        public void Stop()
        {
            Console.WriteLine("Самолет примземлился");
        }

        public void Up()
        {

        }
    }
}
