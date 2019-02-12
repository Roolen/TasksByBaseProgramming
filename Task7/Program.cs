using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task7
{
    class Program
    {
        private static FileInfo pathFile = new FileInfo("File.txt");

        static void Main()
        {
            WriteFile(ReadFile().OrderByDescending(ap => ap.price).ToList());

            OutputFileOnConsole(ReadFile());
        }

        /// <summary>
        /// Считывает список бытовой техники из файла.
        /// </summary>
        /// <returns>Динамический массив объектов бытовой техники</returns>
        static List<Appliance> ReadFile()
        {
            List<Appliance> appliances = new List<Appliance>();

            try
            {
                using (StreamReader file = new StreamReader(pathFile.Name, Encoding.UTF8))
                {
                    string line;

                    while ((line = file.ReadLine()) != null)
                    {
                        string[] elementsLine = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                        string nameApl = "";
                        for (int i = 2; i < elementsLine.Length; i++)
                        {
                            nameApl += elementsLine[i] + " ";
                        }

                        appliances.Add(new Appliance(elementsLine[0], Convert.ToInt32(elementsLine[1]), nameApl));
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            return appliances;
        }

        /// <summary>
        /// Записывает список бытовой техники в файл.
        /// </summary>
        /// <param name="appliances">Динамический массив объектов бытовой техники</param>
        static void WriteFile(List<Appliance> appliances)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(pathFile.Name, false, Encoding.UTF8))
                {
                    for (int i = 0; i < appliances.Count - 1; i++)
                    {
                        file.WriteLine($"{appliances[i].iD} {appliances[i].price} {appliances[i].name}");
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        /// <summary>
        /// Выводит список бытовой техники в консоль.
        /// </summary>
        /// <param name="appliances">Динамический массив с объектами бытовой техники</param>
        static void OutputFileOnConsole(List<Appliance> appliances)
        {
            foreach (Appliance appliance in appliances)
            {
                Console.WriteLine($"{appliance.iD} {appliance.price} {appliance.name}");
            }
        }
    }
}
