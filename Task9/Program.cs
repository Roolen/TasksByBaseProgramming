using System;

namespace Task9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество чисел: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonachi(i) + " ");
            }
        }

        private static int Fibonachi(int n) => (n >= 2) ? Fibonachi(n - 1) + Fibonachi(n - 2) : (n == 1) ? 1 : 0;
    }
}
