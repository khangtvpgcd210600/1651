namespace Ex3
{
    internal class Student : Person
    {
        private float gpa;

        public float Gpa { get { return gpa; } set { gpa = value; } }

        public Student() { }
        public Student(string name, int age, float gpa)
        {
            Name = name;
            Age = age;
            Gpa = gpa;
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nGPA: {Gpa}");
        }

        public void Input() { }
    }
}
