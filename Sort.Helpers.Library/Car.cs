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


        public static bool operator <(Car c1, Car c2)
        {
            if (c1.Year < c2.Year)
                return false;
            if (c1.Year > c2.Year)
                return true;
            if (c1.Kilometers > c2.Kilometers)
                return false;
            if (c1.Kilometers < c2.Kilometers)
                return true;
            return true;
        }

        public static bool operator >(Car c1, Car c2)
        {
            return !(c1 < c2);
        }
    }


    public enum FuelType
    {
        Petrol,
        Diesel,
        Electric,
        Hydrogen
    }
}
