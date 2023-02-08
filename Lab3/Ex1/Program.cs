namespace Ex1;
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter the number of player you want to add.");
        var lines = int.Parse(Console.ReadLine());
        var people = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            Console.WriteLine("Please enter the name, age and salary of the person in one line.");
            var cmdArgs = Console.ReadLine().Split();
            string firstName = cmdArgs[0];
            string lastName = cmdArgs[1];
            int age = int.Parse(cmdArgs[2]);
            decimal salary = decimal.Parse(cmdArgs[3]);
            Person person = new Person();
            person.AddPerson(firstName, lastName, age, salary);
            people.Add(person);
        }

        var sorted = people.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList();
        Console.WriteLine(string.Join(Environment.NewLine, sorted));
        Team team = new Team("Man Utd");
        for (int i = 0; i < people.Count; i++)
        {
            team.AddPlayer(people[i]);
        }
        Console.WriteLine($"The first team size is: {team.FirstTeam.Count}");
        Console.WriteLine($"The reserve team size is: {team.ReserveTeam.Count}");
    }
}