namespace Ex2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
        }

        public static void Exercise1()
        {
            var radius = int.Parse(Console.ReadLine());
            IDrawAble circle = new Circle(radius);
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawAble rect = new Rectangle(width, height);
            circle.Draw();
            rect.Draw();
        }

        public static void Exercise2()
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);
            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
        }

    }
}
