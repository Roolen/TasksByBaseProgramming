using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        private static Sample[] samples = new Sample[20];
        private static Random random = new Random();

        static Program()
        {
            for (int i = 0; i < samples.Length; i++)
            {
                samples[i] = new Sample();
            }
        }

        static void Main()
        {
            InternalSamples();

            Console.WriteLine("Specify which item to sort by:\n" +
                              "1. Lithium\n" +
                              "2. Cobalt\n" +
                              "3. Nickel\n" +
                              "4. Iron\n" +
                              "5. Gold\n" +
                              "6. Mercury\n\n");

            OutputSamples((TypeChimicalElement)Convert.ToInt32(Console.ReadLine())-1);
        }

        static void InternalSamples()
        {
            for (int i = 0; i < samples.Length; i++)
            {
                samples[i].number = i;

                int remainder = 100;
                for (int j = 0; j < 6; j++)
                {
                    samples[i].chimicalElements[j].Name = ((TypeChimicalElement)j).ToString();

                    int procent = random.Next(0, remainder);
                    samples[i].chimicalElements[j].Procent = procent;

                    remainder -= procent;
                }
            }
        }

        static void OutputHeader(TypeChimicalElement type)
        {
            Console.Write("# sample");

            for (int i = 0; i < 6; i++)
            {
                if (i == (int) type)
                {
                    var defCol = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t" + (TypeChimicalElement)i);
                    Console.ForegroundColor = defCol;
                }
                else
                {
                    Console.Write("\t" + (TypeChimicalElement)i);
                }
            }

            Console.WriteLine();
        }

        static void OutputSamples(TypeChimicalElement typeChimical)
        {
            OutputHeader(typeChimical);

            var samplesTemp = samples.ToList().OrderByDescending(s => s.chimicalElements[(int) typeChimical].Procent);

            foreach (var sample in samplesTemp)
            {
                Console.Write(sample.number + "\t");

                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"\t{sample.chimicalElements[j].Procent}");
                }
                Console.WriteLine();
            }
        }
    }
}
