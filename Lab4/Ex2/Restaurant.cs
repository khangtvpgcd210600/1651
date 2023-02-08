namespace Ex2
{
    internal class Product
    {
        string name;
        decimal price;

        public string Name { get { return name; } set { name = value; } }
        public decimal Price { get { return price; } set { price = value; } }

        public Product() { }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public Product(string name)
        {
            Name = name;
        }
    }

    internal class Beverage : Product
    {
        double milliliters;

        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Milliliters { get { return milliliters; } set { milliliters = value; } }

        public Beverage() { }
        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            Milliliters = milliliters;
        }
    }

    internal class HotBeverage : Beverage
    {

        public HotBeverage(string name)
        {
            Name = name;
        }

        public HotBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters) { }

    }

    internal class ColdBeverage : Beverage
    {
        public ColdBeverage() { }
        public ColdBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters) { }
    }

    internal class Coffee : HotBeverage
    {
        public double Caffeine { get; set; }

        public Coffee(string name, double caffeine) : base(name)
        {

            Caffeine = caffeine;
        }
    }

    internal class Tea : HotBeverage
    {
        public Tea(string name, decimal price, double milliliters) : base(name, price, milliliters) { }
    }

    internal class Food : Product
    {
        double grams;

        public double Grams
        {
            get { return grams; }
            set { grams = value; }
        }

        public Food(string name, decimal price, double grams) : base(name, price)
        {
            Grams = grams;
        }

        public Food(string name, decimal price) : base(name, price)
        {
        }

        public Food(string name) : base(name)
        {
        }
    }

    internal class Starter : Food
    {
        public Starter(string name, decimal price, double grams) : base(name, price, grams) { }
    }

    internal class MainDish : Food
    {
        public MainDish(string name, decimal price) : base(name, price) { }

        public MainDish(string name, decimal price, double grams) : base(name, price, grams) { }
    }

    internal class Dessert : Food
    {
        double calories;

        public double Calories { get { return calories; } set { calories = value; } }

        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            Calories = calories;
        }

        public Dessert(string name) : base(name) { }
    }

    internal class Soup : Starter
    {
        public Soup(string name, decimal price, double grams) : base(name, price, grams) { }
    }

    internal class Fish : MainDish
    {
        public Fish(string name, decimal price) : base(name, price)
        {
            Grams = 22;
        }
    }

    internal class Cake : Dessert
    {
        public Cake(string name) : base(name)
        {
            Grams = 250;
            Calories = 1000;
            Price = 5;
        }
    }
}
