namespace Ex3
{
    internal class Dice
    {
        public int Side { get; set; }

        public Dice() { }

        public int Roll()
        {
            Random rd = new Random();
            return rd.Next(1, Side + 1);
        }
    }
}
