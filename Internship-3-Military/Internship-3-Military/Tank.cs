using System;
using Internship_3_Military;

public class Tank : Vehicle, IDriveable
{
	public Tank(int weight, double averageSpeed)
        : base(weight, averageSpeed)
	{
	    Capacity = 6;
	    FuelConsumption = 30;
	}

    public void Move(ref int distance)
    {
        for (var i = 0; i < distance; i += 10)
        {
            var randGen =(new Random()).Next() % 100;
            if (randGen <= 30)
                distance += 5;
        }
    }
}
