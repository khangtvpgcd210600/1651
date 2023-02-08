namespace Ex2
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal() { }
        public Animal(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"This is a {GetType().Name}. It's name is {Name}";
        }
    }

    internal class Reptile : Animal
    {
        public Reptile() { }
        public Reptile(string name) : base(name) { }
    }

    internal class Lizard : Reptile
    {
        public Lizard() { }
        public Lizard(string name) : base(name) { }
    }

    internal class Snake : Reptile
    {
        public Snake() { }
        public Snake(string name) : base(name) { }
    }

    internal class Mammal : Animal
    {
        public Mammal() { }
        public Mammal(string name) : base(name) { }
    }

    internal class Gorilla : Mammal
    {
        public Gorilla() { }
        public Gorilla(string name) : base(name) { }
    }

    internal class Bear : Mammal
    {
        public Bear() { }
        public Bear(string name) : base(name) { }
    }
}
