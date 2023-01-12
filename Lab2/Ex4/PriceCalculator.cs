namespace Ex4
{
    internal class PriceCalculator
    {
        public float PricePerDay { get; set; }
        public int Days { get; set; }
        public Season Season { get; set; }
        public Discount Discount { get; set; }

        public float CalculatePrice(float pricePerDay, int days, Season season, Discount discount)
        {
            int mulitplier = (int)season;
            float discountMultiplier = (float)discount / 100;
            float priceBeforeDiscount = days * pricePerDay * mulitplier;
            float discountAmount = priceBeforeDiscount * discountMultiplier;
            return priceBeforeDiscount - discountAmount;
        }
    }

    public enum Season
    {
        Spring = 2,
        Summer = 4,
        Autumn = 1,
        Winter = 3
    }
    public enum Discount
    {
        None = 0,
        SecondVisit = 10,
        VIP = 20
    }
}
