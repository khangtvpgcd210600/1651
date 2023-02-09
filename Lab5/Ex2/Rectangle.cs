namespace Ex2
{
    internal class Rectangle : IDrawAble
    {
        int width;
        int height;

        public int Width { get { return width; } set { width = value; } }
        public int Height { get { return height; } set { height = value; } }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            DrawLine(Width, '*', '*');
            for (int i = 1; i < width - 1; i++)
            {
                DrawLine(Width, '*', ' ');
            }
            DrawLine(Width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width; i++)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}
