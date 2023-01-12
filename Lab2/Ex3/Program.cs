namespace Ex3;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        StudentClass studentClass = new StudentClass();
        do
        {
            Console.WriteLine("Please choose from 1 to 3");
            Console.WriteLine("1. Creates a new student");
            Console.WriteLine("2. Prints information about a student");
            Console.WriteLine("3. Exit");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        studentClass.AddAStudentToList();
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Please enter the student name");
                        string studentName = Console.ReadLine();
                        studentClass.FindByName(studentName);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("The program will exit");
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Wrong syntax!");
                        break;
                    }
            }

        } while (choice != 3);
    }
}