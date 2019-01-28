using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        private static int[] arrayOne = new int[6];
        private static int[] arrayTwo = new int[8];

        static void Main(string[] args)
        {
            EnterNumbers();
            OutputNumbers();
            Console.WriteLine();
        }

        private static void OutputNumbers()
        {
            Console.WriteLine();

            int last = Int32.MinValue;
            while (last < arrayOne[0] || last < arrayTwo[0])
            {
                int min = Int32.MaxValue;

                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i] < min && arrayOne[i] > last)
                    {
                        min = arrayOne[i];
                    }
                }

                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    if (arrayTwo[i] < min && arrayTwo[i] > last)
                    {
                        min = arrayTwo[i];
                    }
                }

                last = min;
                Console.Write(last + " ");
            }
        }

        private static void EnterNumbers()
        {
            Console.WriteLine("Enter numbers for one array: ");

            InsertNumbersInArray(arrayOne);

            Console.WriteLine("Enter numbers for two array: ");
            
            InsertNumbersInArray(arrayTwo);
        }

        private static void InsertNumbersInArray(int[] array)
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
