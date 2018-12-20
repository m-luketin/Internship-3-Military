using System;
using Internship_3_Military.Interfaces;

namespace Internship_3_Military.Classes
{
    public class Tank : Vehicle, IDrivable
    {
        public Tank(int weight, int averageSpeed)
            : base(weight, averageSpeed)
        {
            Capacity = 6;
            FuelConsumption = 30;
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

        public override void Print(int distance)
        {
            Console.WriteLine();
            Console.WriteLine(Id);
            Console.WriteLine($"Weight:           {Weight}");
            Console.WriteLine($"Average speed:    {AverageSpeed}");
            Console.WriteLine($"Fuel consumption: {FuelConsumption}");
            Console.WriteLine($"Weight:           {Capacity}");
            Console.WriteLine($"Fuel consumed: {(double) distance / 100 * FuelConsumption}");
        }
    }
}
