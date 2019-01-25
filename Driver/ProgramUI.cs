using System;

namespace Driver
{
    public class ProgramUI
    {
        public void Run()
        {
            DriverRepo _driver = new DriverRepo();


            Console.WriteLine("Enter the driver CarID number");
            int carID = int.Parse(Console.ReadLine());

            Console.WriteLine("How many times did the driver go over the speed limit?");
            int overSpeed = int.Parse(Console.ReadLine());

            Console.WriteLine("How many times did the driver swerve?");
            int swerve = int.Parse(Console.ReadLine());

            Console.WriteLine("How many times did the driver miss a stop sign?");
            int missedStop = int.Parse(Console.ReadLine());

            Console.WriteLine("How many times did the driver follow to close to another driver?");
            int following = int.Parse(Console.ReadLine());

            DriverInfo driver = new DriverInfo(carID, overSpeed, swerve, missedStop, following);
            _driver.AddDriverToList(driver);
            decimal totalCost = _driver.TotalInsuranceCost(driver);

            Console.WriteLine($"The total insurance for this driver is {totalCost}.");
            Console.ReadKey();

            
        }
    }
}