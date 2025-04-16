using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 2 3 4
            // 2 1 5 6
            // 3 5 1 7
            // 4 6 7 1
            //int[][] array = new int[4][] 
            //{ 
            //    new int[] { 1, 2, 3, 4, 5, 6, 7 },
            //    new int[] { 2, 1, 5, 6 },
            //    new int[] { 3, 5, 1, 7 },
            //    new int[] { 4, 6, 7, 1 },
            //};

            //Console.WriteLine(SymmetryDiagonal(array));
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            AddToIndex(ref array, 100, 3);

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            AddToIndex(ref array, -6, 3);

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        

        public static void AddToEnd(ref int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[array.Length] = value;

            array = newArray;
        }

        public static void AddToIndex(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];

            for(int i  = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            newArray[index] = value;

            for (int i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            array = newArray;
        }


        public static bool SymmetryDiagonal(int[][] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i + 1; j < array[i].Length; j++)
                {
                    if (array[i][j] != array[j][i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static int[][] Rotate90Angles(int[][] array) //3;4
        {
            int[][] newArray = new int[array[0].Length][]; // Length = 4

            for (int i = 0; i < array[0].Length; i++)
            {
                newArray[i] = new int[array.Length]; // Length = 3
            }

            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array[0].Length; j++)
                {
                    int index = array.Length - 1 - i;
                    newArray[j][index] = array[i][j];
                }
            }

            return newArray;
        }

        public static void Print(int[][] array)
        {
            for (int i = 0; i < array.Length; i++) // цикл проходится по элементам зубчатого массива(т.е. строкам, а строка = массив)
            {
                for (int j = 0; j < array[0].Length; j++) // цикл проходится по элементам строки, т.е. внутреннего массива
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
