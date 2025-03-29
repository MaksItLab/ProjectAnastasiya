using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[10];
            //int[] array = new int[4] { 1, 2, 3, 4 };
            //int[] array = new int[] { 1, 2, 3, 4 };
            //int[] array = { 1, 2, 3, 4 };

            int[] array; //null, объявили массив
            array = new int[] {  -1055, -6665, -6634, -654, -544, -400, -7710, -556, - 300, -8818, -7645 };

            //for (int i = 0; i < array.Length; i++) 
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();

            //int max = MaxElement(array); 
            //Console.WriteLine("Max: " + max);

            //int min = MinElement(array);
            //Console.WriteLine("Min: " + min);

            //Sort(ref array);

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();

            int[] arr = FindTwoMax(array);
        }

        public static void Sort(ref int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }


        public static int[] FindTwoMax(int[] arr)
        {
            if (arr.Length < 2)
            {
                Console.WriteLine("Количество элементов меньше 2");
                return null;
            }

            int max1 = arr[0];
            int max2 = arr[1];

            for (int i = 1; i < arr.Length; i++) 
            {
                if (arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
            }

            int[] newArray = { max1, max2 };

            return newArray;
        }



        public static int MaxElement(int[] array)
        {
            //int max = int.MinValue; 
            int max = array[0];

            for (int i = 1; i < array.Length; i++) 
            { 
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int MinElement(int[] array)
        {
            //int min = int.MinValue; 
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
    }
}
