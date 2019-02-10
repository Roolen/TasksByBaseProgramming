using System;
using System.Linq;

namespace Task6
{
    internal class Program
    {
        private static Student[] students = new Student[25];
        private static Random random = new Random();

        private static void Init()
        {
            for (var i = 0; i < students.Length; i++)
            {
                students[i] = new Student();

                for (var j = 0; j < 3; j++) students[i].scores[j] = random.Next(2, 6);

                students[i].name = "Student " + (i+1);
                students[i].iD = random.Next(1111111, 9999999);
            }
        }

        private static void Main()
        {
            Init();

            foreach (var student in students)
            {
                if (student.MiddleScore() >= 4) student.stependia = 2000;

                if (student.MiddleScore() == 5) student.stependia += 500;
            }

            Console.WriteLine("Имя\t\tНомер зачетки\tСредний балл\tСтипендия");

            foreach (var student in students) student.OutputInConsole();
        }
    }

    internal class Student
    {
        public string name;
        public int iD;
        public readonly int[] scores = new int[3];
        public int stependia;

        public int MiddleScore()
        {
            return (int)scores.Average();
        }

        public void OutputInConsole()
        {
            Console.WriteLine($"{name}\t{iD}\t\t{MiddleScore()}\t\t{stependia}");
        }
    }
}