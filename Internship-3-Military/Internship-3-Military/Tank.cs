using System;

public class Tank : Vehicle
{
	public Tank(Guid id, int weight, double averageSpeed)
        : base(id, weight, averageSpeed)
	{
	    Capacity = 6;
	    FuelConsumption = 30;
	}

    
}
