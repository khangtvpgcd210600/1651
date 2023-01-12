namespace Ex3
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float Grade { get; set; }

        public Student() { }
        public Student(string name, int age, float grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
}
