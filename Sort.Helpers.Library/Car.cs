namespace Sort.Helpers.Library
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Kilometers { get; set; }
        public FuelType Fuel { get; set; }
    }

    public enum FuelType
    {
        Petrol,
        Diesel,
        Electric,
        Hydrogen
    }
}
