using System;

namespace Internship_3_Military
{
    internal class Program
    {
        private static void Main()
        {
            var exampleTank = new Tank(25000, 40);
            var exampleWarship = new Warship(75000, 50);
            var exampleAmphibia = new Amphibia(10000, 30);

            var tankDistance = 0;
            var warshipDistance = 0;
            var amphibiaDriveDistance = 0;
            var amphibiaSwimDistance = 0;

            do
            {
                Console.WriteLine("Enter the tank's driving distance:");
                tankDistance = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the warship's swimming distance:");
                warshipDistance = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the amphibia's driving distance:");
                amphibiaDriveDistance = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the amphibia swimming distance:");
                amphibiaSwimDistance = int.Parse(Console.ReadLine());

                if (amphibiaDriveDistance + amphibiaSwimDistance > tankDistance ||
                    amphibiaDriveDistance + amphibiaSwimDistance > warshipDistance)
                {
                    Console.WriteLine("Error! Amphibia needs to have the shortest path!");
                }

            } while (amphibiaDriveDistance + amphibiaSwimDistance > tankDistance ||
                     amphibiaDriveDistance + amphibiaSwimDistance > warshipDistance);

            Console.WriteLine("Enter the number of soldiers:");
            var numberOfSoldiers = int.Parse(Console.ReadLine());

            tankDistance = tankDistance * exampleTank.NumberOfDistancesCovered(numberOfSoldiers);
            amphibiaDriveDistance = amphibiaDriveDistance * exampleTank.NumberOfDistancesCovered(numberOfSoldiers);
            amphibiaSwimDistance = amphibiaSwimDistance * exampleTank.NumberOfDistancesCovered(numberOfSoldiers);
            warshipDistance = warshipDistance * exampleTank.NumberOfDistancesCovered(numberOfSoldiers);

            exampleTank.Move(ref tankDistance);
            exampleAmphibia.Move(ref amphibiaDriveDistance);
            exampleAmphibia.Swim(ref amphibiaSwimDistance, exampleAmphibia.AverageSpeed);
            var fullAmphibiaDistance = amphibiaSwimDistance + amphibiaDriveDistance;
            exampleWarship.Swim(ref warshipDistance, exampleWarship.AverageSpeed);

            exampleTank.Print(tankDistance);
            exampleAmphibia.Print(fullAmphibiaDistance);
            exampleWarship.Print(warshipDistance);

            var tankFuelConsumed = exampleTank.FuelConsumed(tankDistance);
            var amphibiaFuelConsumed = exampleAmphibia.FuelConsumed(fullAmphibiaDistance);
            var warshipFuelConsumed = exampleWarship.FuelConsumed(warshipDistance);

            if (tankFuelConsumed < amphibiaFuelConsumed && tankFuelConsumed < warshipFuelConsumed)
                Console.WriteLine($"The optimal vehicle is the tank.");
            else if (amphibiaFuelConsumed < tankFuelConsumed && amphibiaFuelConsumed < warshipFuelConsumed)
                Console.WriteLine($"The optimal vehicle is the amphibia.");
            else if (warshipFuelConsumed < amphibiaFuelConsumed && warshipFuelConsumed < tankFuelConsumed)
                Console.WriteLine($"The optimal vehicle is the warship.");
        }
    }
}
