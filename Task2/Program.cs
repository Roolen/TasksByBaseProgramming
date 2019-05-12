using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commonArray = GetArray();
            OutputNumbers();
            Console.WriteLine();
        }

        private static void OutputNumbers()
        {
            Console.WriteLine();

            
        }

        private static int[] GetArray()
        {
            Console.WriteLine("Enter numbers for one array: ");
            int[] arrayOne = new int[6];
            InsertNumbersInArray(out arrayOne);

            Console.WriteLine("Enter numbers for two array: ");
            int[] arrayTwo = new int[8];
            InsertNumbersInArray(out arrayTwo);

            int[] commonArray = new int[14];
            arrayOne.CopyTo(commonArray, 0);
            arrayTwo.CopyTo(commonArray, 0);

            return commonArray;
        }

        private static void InsertNumbersInArray(out int[] array)
        {
           for (int i = 0; i < array.Length; i++)
           {
                Console.Write($"{i}:");

                int numberTemp = Convert.ToInt32(Console.ReadLine());
                if (i > 0 && numberTemp > array[i-1])
                {
                    Console.WriteLine("You enter invalid number. Enter less number.");
                    i--;
                }
                else
                {
                    array[i] = numberTemp;
                }
           } 
        }
    }
}
