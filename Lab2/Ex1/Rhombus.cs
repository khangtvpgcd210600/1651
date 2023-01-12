namespace Ex1
{
    class Rhombus
    {
        public int Size { get; set; }

        public Rhombus() { }
        public Rhombus(int size)
        {
            Size = size;
        }

        private void PrintRow(int size, int starCount)
        {
            for (int i = 0; i <= size - starCount; i++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j < starCount; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("*");
        }

        public void Print()
        {
            for (int starCount = 1; starCount <= Size; starCount++)
            {
                PrintRow(Size, starCount);
            }
            for (int starCount = Size - 1; starCount >= 1; starCount--)
            {
                PrintRow(Size, starCount);
            }
        }
    }
}
