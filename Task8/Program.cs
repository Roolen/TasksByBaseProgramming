using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task8
{
    class Program
    {
        private static FileInfo filePath = new FileInfo("File.txt");

        static void Main(string[] args)
        {
            if (!filePath.Exists)
            {
                Console.WriteLine("File is not find!");
            }
            else
            {
                WriteFile(ReadFile().OrderByDescending(s => s.school).ToList());
            }
        }

        static List<Student> ReadFile()
        {
            List<Student> students = new List<Student>();

            try
            {
                using (StreamReader file = new StreamReader(filePath.Name))
                {
                    string line;

                    while ((line = file.ReadLine()) != null)
                    {
                        string[] elementsLine = line.Split(new char[] {' '}, StringSplitOptions.None);

                        students.Add(new Student(elementsLine[0], elementsLine[1], elementsLine[2],
                                Convert.ToInt32(elementsLine[3]), Convert.ToInt32(elementsLine[4])));
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            return students;
        }

        static void WriteFile(List<Student> students)
        {
            try
            {

                using (StreamWriter fileStream = new StreamWriter(File.Create(Path.Combine(filePath.DirectoryName ?? throw new Exception(), "Output.txt"))))
                {
                    List<List<Student>> schools = new List<List<Student>>();
                    for (int i = 0, s = 0, j = -1; i < students.Count; i++)
                    {
                        if (students[i].school != s)
                        {
                            s = students[i].school;
                            schools.Add(new List<Student>());
                            j++;
                        }
                        schools[j].Add(students[i]);
                    }

                    for (int i = 0; i < schools.Count; i++)
                    {
                        schools[i] = schools[i].OrderByDescending(s => s.score).ToList();
                    }

                    for (int i = 0; i < schools.Count; i++)
                    {
                        fileStream.WriteLine($"Школа №{schools[i].First().school}");
                        for (int j = 0; j < schools[i].Count; j++)
                        {
                            fileStream.WriteLine(schools[i][j].secondName);
                        }
                    }

                    Console.WriteLine("Преобразование файла прошло успешно");

                    OutputFileInConsole(students);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        static void OutputFileInConsole(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.secondName);
            }
        }
    }
}
