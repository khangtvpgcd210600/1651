namespace Ex1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cat cat1 = new Cat("Cat");

            cat1.Eat();
            cat1.Run();
            cat1.Jump();
            cat1.Climb();

            Cow cow1 = new Cow("Cow");
            cow1.Eat();
            cow1.Run();
        }
    }
}
