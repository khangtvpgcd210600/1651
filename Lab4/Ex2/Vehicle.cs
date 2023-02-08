namespace Ex2
{
    internal class Vehicle
    {
        public double DefaultFuelConsumption = 1.25f;
        public double FuelConsumption { get; set; }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public virtual void Drive(double kilometers)
        {
            FuelConsumption = kilometers * HorsePower * DefaultFuelConsumption;
        }
    }

    internal class Motorcycle : Vehicle
    {
        public Motorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override void Drive(double kilometers)
        {
            base.Drive(kilometers);
        }
    }

    internal class Car : Vehicle
    {
        public double DefaultFuelConsumption = 3f;
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override void Drive(double kilometers)
        {
            base.Drive(kilometers);
        }
    }

    internal class RaceMotorcycle : Motorcycle
    {
        public double DefaultFuelConsumption = 8f;
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }

        public override void Drive(double kilometers)
        {
            base.Drive(kilometers);
        }
    }

    internal class CrossMotorcycle : Motorcycle
    {
        public CrossMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override void Drive(double kilometers)
        {
            base.Drive(kilometers);
        }
    }

    internal class FamilyCar : Car
    {
        public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }

        public override void Drive(double kilometers)
        {
            base.Drive(kilometers);
        }
    }

    internal class SportCar : Car
    {
        public double DefaultFuelConsumption = 10f;
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }

        public override void Drive(double kilometers)
        {
            base.Drive(kilometers);
        }
    }
}
