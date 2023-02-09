namespace Ex2
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string name, int age)
        {
            Name = name;
            if (age < 0) throw new ArgumentException("The age is not available");
            else Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    internal class Child : Person
    {
        public Child() { }
        public Child(string name, int age) : base(name, age)
        {
            Name = name;
            if (age > 15) throw new ArgumentException("Grow up please you mf.");
            else Age = age;
        }
    }
}
