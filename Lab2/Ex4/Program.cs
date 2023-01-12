namespace Ex4;

class Program
{
    public static void Main(string[] args)
    {
        PriceCalculator priceCalculator = new PriceCalculator();
        Console.WriteLine("Please enter the room price");
        priceCalculator.PricePerDay = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the amount of days");
        priceCalculator.Days = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the season");
        string season = Console.ReadLine();
        if (season == "Spring")
        {
            priceCalculator.Season = Season.Spring;
        }
        else if (season == "Summer")
        {
            priceCalculator.Season = Season.Summer;
        }
        else if (season == "Autumn")
        {
            priceCalculator.Season = Season.Autumn;
        }
        else if (season == "Winter")
        {
            priceCalculator.Season = Season.Winter;
        }
        Console.WriteLine("Is the customer second visit or VIP ?");
        string discount = Console.ReadLine();
        if (discount == "Second Visit")
        {
            priceCalculator.Discount = Discount.SecondVisit;
        }
        else if (discount == "VIP")
        {
            priceCalculator.Discount = Discount.VIP;
        }
        else if (discount == "None")
        {
            priceCalculator.Discount = Discount.None;
        }
        float price = priceCalculator.CalculatePrice(priceCalculator.PricePerDay,
                                                     priceCalculator.Days,
                                                     priceCalculator.Season,
                                                     priceCalculator.Discount);
        Console.WriteLine("The total price is: " + price);
    }
}


