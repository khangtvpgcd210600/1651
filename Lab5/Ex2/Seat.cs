namespace Ex2
{
    internal class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Seat(string model, string color)
        {
            Model = model; Color = color;
        }

        public string Start()
        {
            return "Engine Start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            string result = $"{Color} Seat {Model} \n{Start()} \n{Stop()}";
            return result;
        }
    }
}
