using System;
using System.Linq;

namespace Task5
{
    class Program
    {
        private static Worker[] workers = new[] {new Worker
        {
            name = "Ivan", secondName = "Ivanov", otchestvo = "Ivanovich", doljnost = Doljnosti.electric, family = Family.Maried,
            yearBeginWork = 2003, gender = Gender.Famale, oklad = 15000, isChildrens = true
        }};

        static void Main(string[] args)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Name\tSecondName\tOtchestvo\tDoljnost\tFamily\tYearBeginWork\tGender\tOklad");
            Console.ForegroundColor = color;

            foreach (var w in workers)
            {
                Console.WriteLine($"{w.name}\t{w.secondName}\t\t{w.otchestvo}\t{w.doljnost}\t{w.family}\t{w.yearBeginWork}\t\t{w.gender}\t{w.CalculateVedomost()}");
            }
        }
    }

    class Worker
    {
        public string name;
        public string secondName;
        public string otchestvo;
        public Doljnosti doljnost;
        public UInt32 yearBeginWork;
        public Gender gender;
        public Int32 oklad;
        public Family family;
        public bool isChildrens;

        public string CalculateVedomost()
        {
            float nalog = oklad * 0.18f;
            float nalogNaBezdetnost = (isChildrens && gender == Gender.Famale) ? oklad * 0.1f : 0;
            return (oklad - nalog - nalogNaBezdetnost).ToString();
        }
    }

    enum Doljnosti
    {
        engeiner,
        driver,
        electric
    }

    enum Gender
    {
        Male,
        Famale
    }

    enum Family
    {
        NotMaried,
        Maried,
        Razveden
    }
}
