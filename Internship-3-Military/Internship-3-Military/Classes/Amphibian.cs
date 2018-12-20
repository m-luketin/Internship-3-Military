using System;
using Internship_3_Military.Interfaces;

namespace Internship_3_Military.Classes
{
    public class Amphibian : Vehicle, IDrivable, ISwimmable
    {
        public Amphibian(int weight, int averageSpeed)
        : base(weight, averageSpeed)
        {
            Capacity = 20;
            FuelConsumption = 70;
        }

        public void Move(ref int distance)
        {
            for (var i = 0; i < distance; i += 10)
            {
                var randGen = (new Random()).Next() % 100;
                if (randGen <= 30)
                    distance += 5;
            }
        }

        public void Swim(ref int distance, int averageSpeed)
        {
            var swimTime = TimeSpan.FromMinutes((double) distance / averageSpeed);
            var interval = new TimeSpan(0, 10, 0);

            while (swimTime.Minutes > 10)
            {
                var randGen = (new Random()).Next() % 100;
                if (randGen <= 50)
                    distance += 3;
                swimTime = swimTime.Subtract(interval);
            }
        }
        public override void Print(int distance)
        {
            Console.WriteLine();
            Console.WriteLine(Id);
            Console.WriteLine($"Weight:           {Weight}");
            Console.WriteLine($"Average speed:    {AverageSpeed}");
            Console.WriteLine($"Fuel consumption: {FuelConsumption}");
            Console.WriteLine($"Weight:           {Capacity}");
            Console.WriteLine($"Fuel consumed: {(double)distance / 100 * FuelConsumption}");
        }
    }
}
