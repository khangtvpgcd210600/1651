namespace Ex2
{
    internal class Circle : IDrawAble
    {
        int radius;

        public int Radius { get { return radius; } set { radius = value; } }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public void Draw()
        {
            double rIn = Radius - 0.4;
            double rOut = Radius + 0.4;
            for (double y = Radius; y > -Radius; y--)
            {
                for (double x = -Radius; x < Radius; x++)
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
