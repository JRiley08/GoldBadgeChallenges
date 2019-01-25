using System;
using System.Collections.Generic;
using _03_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Callenge_Tests
{
    [TestClass]
    public class EventPlanning_RepositoryTests
    {
        EventPlanning_Repository eventrepo = new EventPlanning_Repository();
 
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
        public void EventPlanning_Repository_GetEventList_CountShouldBeCorrect()
        {
            //Arrange
            List<EventPlanning> eventlist = new List<EventPlanning>();

            //Act 
            int actual = eventlist.Count;
            int expected = 4;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EventPlanning_Repository_CalculateCost_ShouldBeCorrect()
        {
            //Arrange
            EventPlanning_Repository eventrepo = new EventPlanning_Repository();
            EventType type = EventType.Bowling;

            //Act
            decimal actual = eventrepo.AddCostOfOneType(type);
            decimal expected = 100.01m;
            //Assert
            Assert.AreEqual(expected, actual);

        }












        [TestMethod]
        public void EventPlanning_Repository_ViewListOfOutings_ShouldBeAcurate()
        {
            //Arrange
            List<EventPlanning> _eventrepo = new List<EventPlanning>();





            //Act
            //Assert
        }
    }
}
