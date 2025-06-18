using System;

namespace Lesson_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try // код, который может содержать ошибки
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                throw new NegativeValueException("Сообщение");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Было обработано исключение: {e.Message}");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.TargetSite);
            }

            Console.WriteLine("Конец программы");
        }
    }

    public class NegativeValueException : Exception
    {
        public NegativeValueException(string error) : base(error)
        {
            
        }
    }

    public class Fraction
    {
        private int _numerator;
        private int _denomenator;

        public int Denominator
        {
            get 
            {
                return _denomenator;
            }
            set
            {
                if(value == 0)
                {
                    //выбрасываешь исключение
                }
                _denomenator = value;
            }
        }
    }
}
