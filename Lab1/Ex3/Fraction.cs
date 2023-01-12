namespace Ex3
{
    internal class Fraction
    {
        private int numerator;
        private int denominator;

        public int Numerator { get { return numerator; } set { numerator = value; } }
        public int Denominator { get { return denominator; } set { denominator = value; } }

        public Fraction() { }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            NormalizedFraction();
        }

        public void NormalizedFraction()
        {
            int number;
            if (numerator > denominator)
            {
                number = numerator;
            }
            else
            {
                number = denominator;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                }
            }
        }

        public void Add(Fraction fraction)
        {
            Fraction result = new Fraction();
            result.Numerator = Numerator * fraction.Denominator + fraction.Numerator * Denominator;
            result.Denominator = Denominator * fraction.Denominator;
            result.NormalizedFraction();
            result.DisplayFraction();
        }

        public void Subtract(Fraction fraction)
        {
            Fraction result = new Fraction();
            result.Numerator = Numerator * fraction.Denominator - fraction.Numerator * Denominator;
            result.Denominator = Denominator * fraction.Denominator;
            result.NormalizedFraction();
            result.DisplayFraction();
        }

        public void Multiply(Fraction fraction)
        {
            Fraction result = new Fraction();
            result.Numerator = Numerator * fraction.Numerator;
            result.Denominator = Denominator * fraction.Denominator;
            result.NormalizedFraction();
            result.DisplayFraction();
        }

        public void Divide(Fraction fraction)
        {
            Fraction result = new Fraction();
            result.Numerator = Numerator * fraction.Denominator;
            result.Denominator = Denominator * fraction.Numerator;
            result.NormalizedFraction();
            result.DisplayFraction();
        }

        public void DisplayFraction()
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }

        public void DisplayFractionInDecimal()
        {
            float result = (float)Numerator / Denominator;
            Console.WriteLine(result);
        }
    }
}
