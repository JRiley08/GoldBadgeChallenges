using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public enum EventType { Golf, Bowling, AmusementPark, Concert }
    public class EventPlanning
    {
        
        public int NumberOfPeopleThatAttended { get; set; }
        public DateTime DateTime { get; set; }
        public decimal TotalCostPerPersonForEvent { get; set; }
        public decimal TotalCostForTheEvent { get; set; }
        public EventType EventType { get; set; }

        public EventPlanning(int numberOfPeopleThatAttended, DateTime dateTime, decimal totalCostPerPersonForEvent, decimal totalCostForTheEvent, EventType eventType)
        {
            NumberOfPeopleThatAttended = numberOfPeopleThatAttended;
            DateTime = dateTime;
            TotalCostPerPersonForEvent = totalCostPerPersonForEvent;
            TotalCostForTheEvent = totalCostForTheEvent;
            EventType= eventType;

        }
        public EventPlanning()
        {

        }

     
        
    }
}
