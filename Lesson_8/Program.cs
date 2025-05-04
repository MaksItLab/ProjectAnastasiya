using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    internal class Program
    {
        // List<T>
        // Dictionary<T, T>
        // Stack<T>
        // Queue<T>
        static void Main(string[] args)
        {
            #region List

            //int[] array = new int[] { 1, 2, 3 };
            //List<int> list = new List<int>() 
            //{ 
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            //};

            //list.Add(100);
            //list.Remove(100); // значение
            //list.RemoveAt(5); // индекс
            //list.AddRange(new List<int>() { 1,2,3,4,5,6,7 }); // добавление диапазона
            //list.RemoveRange(3, 3);
            //list.IndexOf(6); // поиск индекса числа
            //list.Clear(); // удалить все элементы

            //List<int> list = new List<int>();

            //PrintLenght(list);

            //list.Add(100);

            //PrintLenght(list);

            //list.Add(100);
            //list.Add(100);
            //list.Add(100);
            //list.Add(100);

            //PrintLenght(list);

            //list.Add(100);
            //list.Add(100);
            //list.Add(100);
            //list.Add(100);

            //PrintLenght(list);

            //var list = new List<int>();
            ////var a = 5;
            ////var b = "Hello";

            //for (int i = 0; i < 20; i++)
            //{
            //    Random random = new Random();
            //    int num1 = random.Next(-1000, 1001);
            //    list.Add(num1);
            //}

            //// LINQ

            //List<int> list2 = list.Where(x => x > 0).ToList(); // отобрали положительные числа

            //list2 = list.Where(x => x % 2 == 0).ToList(); // отобрали только четные элементы
            //int num;
            ////int num = list.First(x => x < -1000);
            ////num = list.FirstOrDefault(x => x < -1000);

            //num = list.Find(x => x < 10);
            #endregion
            #region Dictionary
            //// 1 - один
            //// 2 - два
            //// 3 - три
            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //dict.Add(1, "Один");
            ////dict.Add(1, "Первый"); - error
            //dict[2] = "Два";
            //dict[2] = "Второй";

            //foreach (var item in dict)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}

            //foreach (var item in dict.Keys)
            //{

            //}

            //foreach (var item in dict.Values)
            //{

            //}
            #endregion
            #region Stack

            //Stack<int> stack = new Stack<int>();
            //stack.Push(element); - добавление
            //stack.Peek(); - возвращает элемент в начале стэка
            //stack.Pop(); - Peek + удаление этого элемента из стэка

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine();

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine();

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine();

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine();

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack[0]); - error
            //int length = stack.Count;
            //Stack<int> stackTemp = new Stack<int>();
            //for (int i = 0; i < length; i++)
            //{
            //    stackTemp.Push(stack.Peek());
            //    Console.WriteLine(stack.Pop());
            //}

            //length = stackTemp.Count;
            //for (int i = 0; i < length; i++)
            //{
            //    stack.Push(stackTemp.Pop());
            //}

            #endregion

            Recursive();

            Queue<int> queue = new Queue<int>();
            //queue.Enqueue(element) - добавление элемента в конец очереди
            //queue.Peek() - возвращает первый элемент из очереди
            //queue.Dequeue() - Peek + удаление элемента из начала очереди
            
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            var temp = queue.Take(queue.Count).ToList();
            
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine();

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine();

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine();

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine();

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine();

        }

        public static void Recursive()
        {
            Recursive();
        }

        public static void PrintLenght(List<int> list)
        {
            Console.WriteLine($"Длина списка: {list.Count}");
            Console.WriteLine($"Макс. кол-во элементов: {list.Capacity}");
        }
    }
}
