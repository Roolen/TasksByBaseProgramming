using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver Oleg = new Driver();

            Oleg.OutputDayViolation();
        }
    }

    class Driver
    {
        private static bool[] days = new bool[30];
        private Random rand = new Random();
        private int dayFirstViolation;

        public Driver()
        {
            for (int i = 0; i < days.Length; i++)
            {
                days[i] = Convert.ToBoolean(rand.Next(0, 2));
            }

            DefenitionViolations();
        }

        private int DefenitionViolations()
        {
            
            for (int i = 0; i < days.Length; i++)
            {
                if (days[i])
                {
                    dayFirstViolation = i + 1;
                    break;
                }
            }

            return dayFirstViolation;
        }

        public void OutputDayViolation()
        {
            Console.WriteLine(dayFirstViolation > 0 ? $"{dayFirstViolation} Day" : "No violations");
        }
    }
}
