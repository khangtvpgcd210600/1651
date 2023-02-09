namespace Ex1
{
    internal class Animal
    {
        string name;
        string favouriteFood;

        public string Name { get { return name; } set { name = value; } }
        public string FavouriteFood { get { return favouriteFood; } set { favouriteFood = value; } }

        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"My name is {Name} and my favourite food is {FavouriteFood}";
        }
    }

    internal class Cat : Animal
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {

        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "\nMEOW";
        }
    }

    internal class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood) { }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "\nDJAAF";
        }
    }
}
