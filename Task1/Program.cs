//Задание:
//Каждый день в течение апреля автомобилист либо нарушал правила дорожного движения, либо – нет. Определить количество дней с начала
//апреля до первого совершенного нарушения или выдать сообщение о том, что нарушений не было вовсе.

using System;

namespace Task1
{
    class Program
    {
        private static Random rand = new Random();

        static void Main(string[] args)
        {
            int driversCount = 1000;
            Driver[] drivers = new Driver[driversCount];

            //Инициализируем Driver'ов
            for (int i = 0; i < drivers.Length; i++)
            {
                drivers[i] = CreateDriver();
            }

            //Выводим на консоль количество нарушений в день для каждого водителя
            Console.WriteLine("Violations in mounth: ");
            foreach (Driver driver in drivers)
            {
                Console.Write($"Driver {driver.GetHashCode():D10}:\t" + GetViolationsInMounth(driver));
            }

            //Выводим на консоль номер дня с первым нарушением в месяце для каждого водителя 
            foreach (Driver driver in drivers)
            {
                int dayFirstViolation = driver.DefinitionFirstViolation();
                Console.Write($"Day of first violation for driver {driver.GetHashCode():D10}:\t");
                
                Console.WriteLine(dayFirstViolation > 0 ? $"{dayFirstViolation} Day" : "No violations");
            }
        }

        /// <summary>
        /// Возвращает проинициализированный экземпляр класса Driver.
        /// </summary>
        /// <returns>Экземпляр класса Driver</returns>
        private static Driver CreateDriver()
        {
            int[] days = new int[30];
            for (int i = 0; i < days.Length; i++)
            {
                days[i] = rand.Next(0, 5);
            }

            return new Driver(days);
        }

        /// <summary>
        /// Возвращает количество нарушений в день для всего месяца, в виде строки.
        /// </summary>
        /// <param name="driver">Экземпляр класса Driver</param>
        /// <returns>Строка, состоящая из количества нарушений в день начиная с первого дня, разделённых пробелами.</returns>
        private static string GetViolationsInMounth(Driver driver)
        {
            string output = "";
            foreach (int day in driver.GetDays())
            {
                output += (day + " ");
            }

            output += Environment.NewLine;
            return output;
        }
    }

    class Driver
    {
        private int[] days;
        private int dayFirstViolation;

        public Driver(int[] days)
        {
            if (days.Length <= 31)
                this.days = days;
        }

        public int[] GetDays() => days;

        /// <summary>
        /// Возвращает первый день в месяце, когда было совершенно преступление.
        /// </summary>
        /// <returns></returns>
        public int DefinitionFirstViolation()
        {
            if (days == null) return 0;

            for (int i = 0; i < days.Length; i++)
            {
                if (days[i] > 0)
                {
                    dayFirstViolation = i + 1;
                    break;
                }
            }

            return dayFirstViolation;
        }

        public void OutputDayViolation()
        {
            
        }
    }
}
