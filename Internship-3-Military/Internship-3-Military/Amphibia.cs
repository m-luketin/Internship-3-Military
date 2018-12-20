using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_3_Military
{
    class Amphibia : Vehicle
    {
        public Amphibia(Guid id, int weight, double averageSpeed)
        : base(id, weight, averageSpeed)
        {
            Capacity = 20;
            FuelConsumption = 70;
        }

    }
}
