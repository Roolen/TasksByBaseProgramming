using System;
using System.Collections.Generic;

namespace Task4
{
    enum Sport
    {
        Football,
        Basketball,
        Volleyball,
        Biathlon,
        Hockey
    }

    enum Medal
    {
        Gold,
        Silver,
        Bronze
    }

    class Country
    {
        private readonly string name;
        private Dictionary<Sport, Medal> medals = new Dictionary<Sport, Medal>();

        public string Name => name;

        public Country(string name)
        {
            this.name = name;
        }

        public Medal GetMedal(Sport sport) => medals[sport];

        public int GetAllMedal(Medal typeMedal)
        {
            int sum = 0;

            foreach (var medal in medals.Values)
            {
                if (medal == typeMedal) sum++;
            }

            return sum;
        }

        public void SetMedal(Sport sport, Medal medal) => medals[sport] = medal;
    }
}