﻿using System;

namespace Internship_3_Military.Classes
{
    public class Vehicle
    {
        public Vehicle(int weight, int averageSpeed)
        {
            Id = Guid.NewGuid();
            Weight = weight;
            AverageSpeed = averageSpeed;
        }

        public Guid Id { get; set; }
        public int Weight { get; set; }
        public int AverageSpeed { get; set; }
        public static double FuelConsumption { get; set; }
        public static int Capacity { get; set; }

        public virtual void Print(int distance)//method not used? Program.cs line: 53,54,55
        {
            Console.WriteLine();
            Console.WriteLine(Id);
            Console.WriteLine($"Weight:           {Weight}");
            Console.WriteLine($"Average speed:    {AverageSpeed}");
            Console.WriteLine($"Fuel consumption: {FuelConsumption}");
            Console.WriteLine($"Weight:           {Capacity}");
        }

        public int NumberOfDistancesCovered(int soldiers)
        {
            var numberOfTrips =  soldiers / Capacity + 1;
            return numberOfTrips * 2 - 1;
        }

        public double FuelConsumed(int distance)
        {
            return (double)distance / 100 * FuelConsumption;
        }
    }
}
