using System;

public class Vehicle
{
	public Vehicle(int weight, double averageSpeed)
	{
	    ID = new Guid();
	    Weight = weight;
	    AverageSpeed = averageSpeed;
	}

    public Guid ID { get; set; }
    public int Weight { get; set; }
    public double AverageSpeed { get; set; }
    public static double FuelConsumption { get; set; }
    public static int Capacity { get; set; }

    
}
