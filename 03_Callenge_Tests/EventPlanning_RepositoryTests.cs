using System;
using System.Collections.Generic;
using _03_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Callenge_Tests
{
    [TestClass]
    public class EventPlanning_RepositoryTests
    {
        [TestMethod]
        public void EventPlanning_Repository_AddOutingToList_ShouldBeCorrect()
        {
            //Arrange
            EventPlanning_Repository eventPlanning = new EventPlanning_Repository();
            EventPlanning basktball = new EventPlanning();
            EventPlanning pack = new EventPlanning();
            EventPlanning killa = new EventPlanning();
            eventPlanning.AddEventPlanningList(basktball);
            eventPlanning.AddEventPlanningList(pack);
            eventPlanning.AddEventPlanningList(killa);

            //Act
            int actual = eventPlanning.GetEventPlaningRepositoryList().Count;
            int expected = 3;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EventPlanning_Repository_ViewListOfOutings_ShouldBeAcurate()
        {
            //Arrange
            List<EventPlanning> _eventrep



            //Act
            //Assert
        }
    }
}
