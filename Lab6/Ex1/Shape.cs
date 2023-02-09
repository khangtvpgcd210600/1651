namespace Ex1
{
    internal abstract class Shape
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return "*";
        }
    }

    internal class Rectangle : Shape
    {
        double width;
        double height;

        public double Width { get { return width; } set { width = value; } }
        public double Height { get { return height; } set { height = value; } }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculatePerimeter()
        {
            return (Width + Height) * 2;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override string Draw()
        {
            string result = "";
            result += DrawLine(Width, "*", "*");
            for (int i = 0; i < Height; i++)
            {
                result += DrawLine(Width, "*", " ");
            }
            result += DrawLine(Width, "*", "*");
            return result;
        }

        public string DrawLine(double width, string end, string mid)
        {
            string result = "";
            result += end;
            for (int i = 1; i < width; i++)
            {
                result += mid;
            }
            result += (end + "\n");
            return result;
        }
    }

    internal class Circle : Shape
    {
        double radius;

        public double Radius { get { return radius; } set { radius = value; } }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return Radius * 2 * 3.14;
        }

        public override double CalculateArea()
        {
            return Radius * Radius * 3.14;
        }

        public override string Draw()
        {
            string result = "";
            double rIn = Radius - 0.314;
            double rOut = Radius + 0.314;
            for (double y = Radius; y >= -Radius; y--)
            {
                for (double x = -Radius; x < rOut; x++)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        result += "*";
                    }
                    else result += " ";
                }
                result += "\n";
            }
            return result;

        }
    }
}
