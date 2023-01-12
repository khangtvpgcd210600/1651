namespace Ex3
{
    internal class StudentClass
    {
        List<Student> students = new List<Student>();

        public void AddAStudentToList()
        {
            Console.WriteLine("Enter the information about student");
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Grade: ");
            float grade = float.Parse(Console.ReadLine());
            Student student = new Student(name, age, grade);
            students.Add(student);
        }
        public void FindByName(string studentName)
        {
            foreach (Student student in students)
            {
                if (student.Name == studentName)
                {
                    Console.WriteLine("Name: " + student.Name);
                    Console.WriteLine("Age: " + student.Age);
                    Console.WriteLine("Grade: " + student.Grade);
                }
            }
        }

    }
}
