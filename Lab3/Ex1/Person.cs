namespace Ex1
{
    internal class Person
    {
        string firstName;
        string lastName;
        int age;
        decimal salary;

        public string FirstName
        {
            get => firstName; private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("The first name is minimum than 3 letters.");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName; private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("The last name is minimum than 3 letters.");
                }
                lastName = value;
            }
        }
        public int Age
        {
            get => age; private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The age is less than 1.");
                }
                age = value;
            }
        }
        public decimal Salary
        {
            get => salary; private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("The minimum salary is 460.");
                }
                salary = value;
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old and earn {Salary} money per month.";
        }

        public Person() { }
        public void AddPerson(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age > 30)
            {
                Salary += Salary * percentage / 100;
            }
            else { Salary += Salary * percentage / 200; }
        }
    }
}
