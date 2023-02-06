namespace Ex1
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        protected Animal(string name)
        {
            Name = name;
        }

        public void Sleep()
        {
            Console.WriteLine("Animals want to sleep.");
        }

        public abstract void Eat();


    }
}
