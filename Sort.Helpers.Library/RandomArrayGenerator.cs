using System;
using Bogus;
using Sort.Helpers.Library;

namespace Sort.Helpers.library
{
    public class RandomArrayGenerator
    {
        public static int[] Generate(int amount = 10, int min = 0, int max = 10, bool unique = false)
        {
            if (unique && amount > max - min)
            {
                throw new ArgumentException();
            }

            int[] result = new int[amount];

            Random rnd = new Random();

            for (int i = 0; i < amount; ++i)
            {
                int newVal = rnd.Next(min, max);

                if (unique == true && amount <= max - min)
                {
                    while (Array.IndexOf(result, newVal) >= 0)
                    {
                        newVal = rnd.Next(min, max);
                    }
                }

                result[i] = newVal;
            }

            return result;
        }

        public static Car[] GenerateCars(int amount)
        {
            var colors = new[] { "Red", "Blue", "Black", "White", "Silver", "Grey", "Green", "Yellow" };

            var carFaker = new Faker<Car>()
                    .RuleFor(c => c.Brand, f => f.Vehicle.Manufacturer())
                    .RuleFor(c => c.Model, f => f.Vehicle.Model())
                    .RuleFor(c => c.Year, f => f.Date.Past(10).Year)
                    .RuleFor(c => c.Kilometers, f => (int)f.Finance.Amount(20000, 150000))
                    .RuleFor(c => c.Color, f => f.PickRandom(colors))
                    .RuleFor(c => c.Fuel, f => f.PickRandom<FuelType>());

            return carFaker.Generate(amount).ToArray();
        }
    }
}
