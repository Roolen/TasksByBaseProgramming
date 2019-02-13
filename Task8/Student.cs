namespace Task8
{
    class Student
    {
        public readonly string name;
        public readonly string secondName;
        public readonly string othestvo;
        public readonly int school;
        public readonly int score;

        public Student(string secondName, string name, string othestvo, int school, int score)
        {
            this.name = name;
            this.secondName = secondName;
            this.othestvo = othestvo;
            this.school = school;
            this.score = score;
        }
    }
}