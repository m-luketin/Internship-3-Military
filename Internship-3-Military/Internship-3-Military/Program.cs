using System;
using Internship_3_Military.Classes;

namespace Internship_3_Military
{
    internal class Program
    {
        private static void Main()
        {
            var exampleTank = new Tank(25000, 40);
            var exampleWarship = new Warship(75000, 50);
            var exampleAmphibian = new Amphibian(10000, 30);

            int tankDistance;
            int warshipDistance;
            int amphibianDriveDistance;
            int amphibianSwimDistance;

            do
            {
                Console.WriteLine("Enter the tank's driving distance:");
                tankDistance = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the warship's swimming distance:");
                warshipDistance = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the amphibian's driving distance:");
                amphibianDriveDistance = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the amphibian swimming distance:");
                amphibianSwimDistance = int.Parse(Console.ReadLine());

                if (amphibianDriveDistance + amphibianSwimDistance > tankDistance ||
                    amphibianDriveDistance + amphibianSwimDistance > warshipDistance)
                {
                    Console.WriteLine("Error! Amphibian needs to have the shortest path!");
                }

            } while (amphibianDriveDistance + amphibianSwimDistance > tankDistance ||
                     amphibianDriveDistance + amphibianSwimDistance > warshipDistance);

            Console.WriteLine("Enter the number of soldiers:");
            var numberOfSoldiers = int.Parse(Console.ReadLine());

            tankDistance = tankDistance * exampleTank.NumberOfDistancesCovered(numberOfSoldiers);
            amphibianDriveDistance = amphibianDriveDistance * exampleTank.NumberOfDistancesCovered(numberOfSoldiers);
            amphibianSwimDistance = amphibianSwimDistance * exampleTank.NumberOfDistancesCovered(numberOfSoldiers);
            warshipDistance = warshipDistance * exampleTank.NumberOfDistancesCovered(numberOfSoldiers);

            exampleTank.Move(ref tankDistance);
            exampleAmphibian.Move(ref amphibianDriveDistance);
            exampleAmphibian.Swim(ref amphibianSwimDistance, exampleAmphibian.AverageSpeed);
            var fullAmphibianDistance = amphibianSwimDistance + amphibianDriveDistance;
            exampleWarship.Swim(ref warshipDistance, exampleWarship.AverageSpeed);

            exampleTank.Print(tankDistance);
            exampleAmphibian.Print(fullAmphibianDistance);
            exampleWarship.Print(warshipDistance);

            var tankFuelConsumed = exampleTank.FuelConsumed(tankDistance);
            var amphibianFuelConsumed = exampleAmphibian.FuelConsumed(fullAmphibianDistance);
            var warshipFuelConsumed = exampleWarship.FuelConsumed(warshipDistance);

            Console.WriteLine();

            if (tankFuelConsumed < amphibianFuelConsumed && tankFuelConsumed < warshipFuelConsumed)
                Console.WriteLine("The optimal vehicle is the tank.");
            else if (amphibianFuelConsumed < tankFuelConsumed && amphibianFuelConsumed < warshipFuelConsumed)
                Console.WriteLine("The optimal vehicle is the amphibian.");
            else if (warshipFuelConsumed < amphibianFuelConsumed && warshipFuelConsumed < tankFuelConsumed)
                Console.WriteLine("The optimal vehicle is the warship.");
        }
    }
}
