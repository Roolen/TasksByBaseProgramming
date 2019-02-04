using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Program
    {
        private static Country[] countryes = new Country[4];

        static void Main()
        {
            countryes[0] = new Country("Russian");
            countryes[1] = new Country("Germany");
            countryes[2] = new Country("China");
            countryes[3] = new Country("Sweden");
            countryes[0].SetMedal(Sport.Football, Medal.Gold);
            countryes[0].SetMedal(Sport.Basketball, Medal.Gold);
            countryes[2].SetMedal(Sport.Volleyball, Medal.Bronze);
            countryes[1].SetMedal(Sport.Basketball, Medal.Gold);
            countryes[1].SetMedal(Sport.Biathlon, Medal.Silver);
            countryes[2].SetMedal(Sport.Hockey, Medal.Gold);
            countryes[3].SetMedal(Sport.Football, Medal.Silver);
            countryes[3].SetMedal(Sport.Basketball, Medal.Silver);

            SortCountryes();

            foreach (var country in countryes)
            {
                Console.WriteLine($"{country.Name}");
            }

            
        }

        

        private static void SortCountryes()
        {
            for (int i = 0; i < countryes.Length; i++)
            {
                for (int j = i + 1; j < countryes.Length; j++)
                {
                    if (countryes[i].GetAllMedal(Medal.Gold) < countryes[j].GetAllMedal(Medal.Gold))
                    {
                        Swap(i, j);
                    }
                    if (countryes[i].GetAllMedal(Medal.Silver) < countryes[j].GetAllMedal(Medal.Silver))
                    {
                        if (countryes[i].GetAllMedal(Medal.Gold) <= countryes[j].GetAllMedal(Medal.Gold))
                            Swap(i, j);
                    }
                    if (countryes[i].GetAllMedal(Medal.Bronze) < countryes[j].GetAllMedal(Medal.Bronze))
                    {
                        if (countryes[i].GetAllMedal(Medal.Silver) <= countryes[j].GetAllMedal(Medal.Silver))
                            Swap(i, j);
                    }
                }
            }

            void Swap(int num1, int num2)
            {
                Country temp = countryes[num1];
                countryes[num1] = countryes[num2];
                countryes[num2] = temp;
            }
        }
    }
}
