using System;
using Driver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        DriverRepo driverRepo = new DriverRepo();

        [TestMethod]
        public void DriverRepo_AddDriverToList_ShouldWork()
        {
            //Arrange
            DriverInfo benz = new DriverInfo();
            DriverInfo beamer = new DriverInfo();
            DriverInfo lambo = new DriverInfo();
            driverRepo.AddDriverToList(benz);
            driverRepo.AddDriverToList(beamer);
            driverRepo.AddDriverToList(lambo);

            //Act
            int actual = driverRepo.GetDriverData().Count;
            int expected = 3;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DriverRepo_CalculateDriverInsuranceOne_ShouldBeCorrect()
        {
            //Arrange
            DriverInfo driver = new DriverInfo();
            driver.OverSpeed = 22;


            //Act
            decimal actual = driverRepo.CalculateDriverInsuranceOne(driver);
            decimal expected = 10m;



            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void DriverRepo_CalculateDriverInsuranceTwo_ShouldBeCorrect()
        {
            //Arrange
            DriverInfo driver = new DriverInfo();
            driver.Swerve= 22;


            //Act
            decimal actual = driverRepo.CalculateDriverInsuranceTwo(driver);
            decimal expected = 10m;



            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void DriverRepo_CalculateDriverInsuranceThree_ShouldBeCorrect()
        {
            //Arrange
            DriverInfo driver = new DriverInfo();
            driver.Following = 22;


            //Act
            decimal actual = driverRepo.CalculateDriverInsuranceThree(driver);
            decimal expected = 10m;



            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void DriverRepo_CalculateDriverInsuranceFour_ShouldBeCorrect()
        {
            //Arrange
            DriverInfo driver = new DriverInfo();
            driver.OverSpeed = 22;


            //Act
            decimal actual = driverRepo.CalculateDriverInsuranceFour(driver);
            decimal expected = 10m;



            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DriverRepo_TotalInsuranceCost_ShouldBeCorrect()
        {
            //Arrange
            DriverInfo driver = new DriverInfo();
            driver.OverSpeed = 22;
            driver.Swerve = 22;
            driver.MissedStop = 22;
            driver.Following = 22;

            driverRepo.TotalInsuranceCost(driver);

            //Act
            decimal actual = driverRepo.TotalInsuranceCost(driver);
            decimal expected = 40;
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
