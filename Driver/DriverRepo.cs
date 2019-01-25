using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    public class DriverRepo
    {
        List<DriverInfo> _driverData = new List<DriverInfo>();

        public void AddDriverToList(DriverInfo driver)
        {
            _driverData.Add(driver);
        }

        public List<DriverInfo> GetDriverData()
        {
            return _driverData;
        }
       
        public decimal CalculateDriverInsuranceOne(DriverInfo driver)
        {
            decimal speedCharge = 0m;

            if (driver.OverSpeed > 9 && driver.OverSpeed < 20)
                speedCharge = 10m;
            else if (driver.OverSpeed > 19 && driver.OverSpeed < 30)
                speedCharge = 20m;
            else if (driver.OverSpeed > 29)
                speedCharge = 30m;
            else
                speedCharge = 0;
            return speedCharge;
        }

        public decimal CalculateDriverInsuranceTwo(DriverInfo driver)
        {
            decimal sweerveCharge = 0m;

            if (driver.Swerve > 9 && driver.Swerve < 20)
                sweerveCharge = 10m;
            else if (driver.Swerve > 19 && driver.Swerve < 30)
                sweerveCharge = 20m;
            else if (driver.Swerve > 29)
                sweerveCharge = 30m;
            else
                sweerveCharge = 0;
            return sweerveCharge;
        }
        public decimal CalculateDriverInsuranceThree(DriverInfo driver)
        {
            decimal stopCharge = 0m;

            if (driver.MissedStop > 9 && driver.MissedStop < 20)
                stopCharge = 10m;
            else if (driver.MissedStop > 19 && driver.MissedStop < 30)
                stopCharge = 20m;
            else if (driver.MissedStop > 29)
                stopCharge = 30m;
            else
                stopCharge = 0;
            return stopCharge;
            
          
            
        }
        public decimal CalculateDriverInsuranceFour(DriverInfo driver)
        {
            decimal followCharge = 0m;

            if (driver.Following > 9 && driver.Following < 20)
                followCharge = 10m;
            else if (driver.Following > 19 && driver.Following < 30)
                followCharge = 20m;
            else if (driver.Following > 29)
                followCharge = 30m;
            else
                followCharge = 0;
            return followCharge;

        }
        public decimal TotalInsuranceCost(DriverInfo driver)
        {
            decimal Cost = 30m;

            decimal speedCharge = CalculateDriverInsuranceOne(driver);
            decimal sweerveCharge = CalculateDriverInsuranceTwo(driver);
            decimal stopCharge = CalculateDriverInsuranceThree(driver);
            decimal followCharge = CalculateDriverInsuranceFour(driver);

            decimal totalInsuranceCost = speedCharge + sweerveCharge + stopCharge + followCharge + Cost;
            return totalInsuranceCost;

        }
    }
}
