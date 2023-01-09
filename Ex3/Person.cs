namespace Ex3
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}");
        }

        public void Input() { }

        public void ToString() { }
    }
}
