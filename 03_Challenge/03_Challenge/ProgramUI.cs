using System;
using System.Collections.Generic;

namespace _03_Challenge
{
    public class ProgramUI
    {
        EventPlanning_Repository _eventrepo = new EventPlanning_Repository();

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Select which option you'd wish to carry out\n" +
                    "1.View List of Outings\n" +
                    "2.Add Outing to List\n" +
                    "3.View List of total cost of all outings combined\n" +
                    "4.View List of total cost of types of outings\n" +
                    "5.Exit");

                

                string input = Console.ReadLine();
                int choice = int.Parse(input);
                Console.Clear();


                switch (choice)
                {
                    case 1:
                        ViewListofOutings();
                        break;
                    case 2:
                        AddOutingToList();
                        break;
                    case 3:
                        ViewListOfTotalOutingCost();
                        break;
                    case 4:
                        ViewListOfTotalTypesCost();
                        break;
                    case 5:
                        running = false;
                        break;
                }
                
            }
        }

        private void AddOutingToList()
        {
            

            Console.WriteLine("Enter type of event you would like to add\n" +
                "1.Golf\n" +
                "2.Bowling\n" +
                "3.AmusementPark\n" +
                "4.Concert\n");
            int eventType = ParseInput();
            Console.Clear();

            EventType type = EventType.Concert;
            switch (eventType)
            {
                case 1:
                    type = EventType.Golf;
                    break;
                case 2:
                    type = EventType.Bowling;
                    break;
                case 3:
                    type = EventType.AmusementPark;
                    break;
                case 4:
                    type = EventType.Concert;
                    break;
            }
            Console.WriteLine("Enter the number of people that will attend the event");
            int numberOfPeopleThatAttended = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Enter the date and time this event will take place");
            DateTime datetime;
            if (DateTime.TryParse(Console.ReadLine(), out datetime))
            {
                Console.WriteLine("The date entered is:" + datetime);
            }
            else
            {
                Console.WriteLine("You have entered an incorrect value.");
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter the total cost per person for the event");
            decimal totalCostPerPersonForTheEvent = decimal.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Enter the total cost for the event");
            decimal totalCostForEventTheEvent = decimal.Parse(Console.ReadLine());

            Console.Clear();
            EventPlanning eventPlanning = new EventPlanning(numberOfPeopleThatAttended, datetime, totalCostPerPersonForTheEvent, totalCostForEventTheEvent, type);
            _eventrepo.AddEventPlanningList(eventPlanning);

        

            Console.Clear();

        }
        private void ViewListofOutings()
        {
            List<EventPlanning> eventlist = _eventrepo.GetEventPlaningRepositoryList();

            foreach(EventPlanning plan in eventlist)
            {
                Console.WriteLine($"{plan.EventType} {plan.NumberOfPeopleThatAttended} {plan.DateTime} {plan.TotalCostPerPersonForEvent} {plan.TotalCostForTheEvent}");
            }
            Console.ReadKey();
            Console.Clear();
        }
        private void ViewListOfTotalOutingCost()
        {
            decimal Golf = _eventrepo.AddCostOfOneType(EventType.Golf);
            decimal Bowling = _eventrepo.AddCostOfOneType(EventType.Bowling);
            decimal AmusementPark = _eventrepo.AddCostOfOneType(EventType.AmusementPark);
            decimal Concert = _eventrepo.AddCostOfOneType(EventType.Concert);

            decimal totalCost = Golf + Bowling + AmusementPark + Concert;

            Console.WriteLine($"The total cost of all trips is currently {totalCost}");
            Console.ReadKey();

            _eventrepo.GetEventPlaningRepositoryList();


        }
        private void ViewListOfTotalTypesCost()
        {

            Console.WriteLine("Which type would you like to see total costs for?\n" +
                "1.Golf\n" +
                "2.Bowling\n" +
                "3.AmusementPark\n" +
                "4.Concert\n");
            int eventType = ParseInput();

            EventType type = EventType.Golf;
            switch (eventType)
            {
                case 1:
                    type = EventType.Golf;
                    break;
                case 2:
                    type = EventType.Bowling;
                    break;
                case 3:
                    type = EventType.AmusementPark;
                    break;
                case 4:
                    type = EventType.Concert;
                    break;
            }

            decimal totalCost = _eventrepo.AddCostOfOneType(type);
            Console.WriteLine($"The totalCost of {type} is {totalCost}");

            Console.ReadKey();
            Console.Clear();
            
            
          
        }


        





        private int ParseInput()
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 1 || input > 5)
            {
                Console.WriteLine("Your input was invalid please enter valid menu number");
                input = ParseInput();
            }
            return input;
        }
    }
}
    
