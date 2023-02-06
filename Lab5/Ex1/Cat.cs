namespace Ex1
{
    internal class Cat : Animal, ICanRun, ICanClimbJump
    {
        public Cat(string name) : base(name) { }

        public override void Eat()
        {
            Console.WriteLine("Cat can eat.");
        }

        public void Run()
        {
            Console.WriteLine("Cat can run quickly.");
        }

        public void Climb()
        {
            Console.WriteLine("Cat can climb.");
        }

        public void Jump()
        {
            Console.WriteLine("Cat can jump.");
        }
    }
}
