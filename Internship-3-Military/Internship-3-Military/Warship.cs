using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_3_Military
{
    class Warship : Vehicle
    {
        public Warship(Guid id, int weight, double averageSpeed)
            : base(id, weight, averageSpeed)
        {
            Capacity = 50;
            FuelConsumption = 200;
        }
    }
}
