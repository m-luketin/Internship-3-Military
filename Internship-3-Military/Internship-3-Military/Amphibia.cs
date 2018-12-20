using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_3_Military
{
    public class Amphibia : Vehicle, IDriveable, ISwimmable
    {
        public Amphibia(int weight, double averageSpeed)
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
    }
}
