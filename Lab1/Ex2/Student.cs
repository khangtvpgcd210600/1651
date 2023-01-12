namespace Ex2
{
    internal class Student
    {
        private int age;
        private float gpa;
        private String name;

        public int Age { get { return age; } set { age = value; } }
        public float Gpa { get { return gpa; } set { gpa = value; } }
        public String Name { get { return name; } set { name = value; } }

        public Student() { }

        public Student(int age, float gpa, String name)
        {
            this.age = age;
            this.gpa = gpa;
            this.name = name;
        }

        public void DisplayInfomation()
        {
            Console.WriteLine($"Name: {name}\nAge: {age}\nGPA: {gpa}");
        }
    }
}
