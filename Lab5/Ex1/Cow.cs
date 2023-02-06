namespace Ex1
{
    internal class Cow : Animal, ICanRun
    {
        public Cow(string name) : base(name)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("Cow eats grass.");
        }

        public void Run()
        {
            Console.WriteLine("Cow can run slowly.");
        }
    }
}
