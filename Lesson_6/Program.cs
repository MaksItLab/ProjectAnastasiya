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

            //int[] array; //null, объявили массив
            //array = new int[] {  -1055, -6665, -6634, -654, -544, -400, -7710, -556, - 300, -8818, -7645 };

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

            //int[] arr = FindTwoMax(array);

            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 }; //одномерный массив

            int[,] arrayTwoD = new int[3, 5]
            {
                { 1,2,3,4,5},//0
                { 1,2,3,4,5},//1
                { 1,2,3,4,5},//2
            };

            //Console.WriteLine(arrayTwoD.Length);

            //for (int i = 0; i < arrayTwoD.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrayTwoD.GetLength(1); j++)
            //    {
            //        Console.Write(arrayTwoD[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            int[][] arrayTooth = new int[3][] 
            {
                new int[] { 1},
                new int[] { 1,2,3,4,5},
                new int[] { 1,2,3,4},
            }; //зубчатый

            //for(int i = 0;i < arrayTooth.Length; i++)
            //{
            //    for(int j = 0; j < arrayTooth[i].Length; j++)
            //    {
            //        Console.Write(arrayTooth[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(arrayTwoD[0,0]);
            //Console.WriteLine(arrayTwoD[0,1]);
            //Console.WriteLine(arrayTwoD[0,2]);
            //Console.WriteLine(arrayTwoD[0,3]);
            //Console.WriteLine(arrayTwoD[0,4]);
            //Console.WriteLine(arrayTwoD[1,0]);
            //Console.WriteLine(arrayTwoD[1,1]);

            // 1 2 3 
            // 4 5 6
            // 7 8 9

            Console.WriteLine($"Ранг двумерного массива: {arrayTwoD.Rank}");
            Console.WriteLine($"Ранг зубчатого массива: {arrayTooth.Rank}");

            Console.WriteLine($"Длина двумерного массива: {arrayTwoD.Length}");
            Console.WriteLine($"Длина зубчатого массива: {arrayTooth.Length}");

            Console.WriteLine($"Ранг двумерного массива: {arrayTwoD.GetLength(1)}");
            Console.WriteLine($"Ранг зубчатого массива: {arrayTooth.GetLength(1)}");
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
