namespace Ex1
{
    internal class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person() { }
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}");
        }

        public override string ToString()
        {
            return $"My name is {Name} and I am living at {Address}";
        }
    }
}
