using System;
using _02_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Challenge_Tests
{
    [TestClass]
    public class UnitTest1
    {
        ClaimDataRepo claimRepo = new ClaimDataRepo();

        [TestMethod]
        public void ClaimDataRepo_AddClaimToQueue_ShouldAdd()
        {
            //Arrange
            ClaimData whip = new ClaimData();
            ClaimData suv = new ClaimData();
            ClaimData truck = new ClaimData();

            claimRepo.AddClaimToQueue(whip);
            claimRepo.AddClaimToQueue(suv);
            claimRepo.AddClaimToQueue(truck);

            //Act
            int actual = claimRepo.GetClaimInfo().Count;
            int expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ClaimDataRepo_RemoveClaimFromQueue_ShouldWork()
        {
            //Arrange
            ClaimData whip = new ClaimData();
            ClaimData suv = new ClaimData();
            ClaimData truck = new ClaimData();

            claimRepo.AddClaimToQueue(whip);
            claimRepo.AddClaimToQueue(suv);
            claimRepo.AddClaimToQueue(truck);

            claimRepo.RemoveClaimFromQueue();

            //Act
            int actual = claimRepo.GetClaimInfo().Count;
            int expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
