using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>() {"Lotus", "Lotus", "Red", "calibri", "tupik", "tupik"};
            List<string> filterName = name.Distinct().ToList();

            foreach (var n in filterName)
            {
                Console.WriteLine(n + " ");
            }
        }
    }
}
