namespace Ex2;

class Program
{
    public static void Main(String[] args)
    {
        Student student1 = new Student();
        student1.Name = "Khang";
        student1.Age = 21;
        student1.Gpa = 2.5f;
        student1.DisplayInfomation();
        Console.WriteLine();
        Student student2 = new Student(21, 5f, "Khang Prime");
        student2.DisplayInfomation();
    }
}