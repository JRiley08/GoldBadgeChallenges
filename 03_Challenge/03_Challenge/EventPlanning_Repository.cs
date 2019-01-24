using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
     public class EventPlanning_Repository
    {
        List<EventPlanning> _listEventPlanning = new List<EventPlanning>();

        public void AddEventPlanningList(EventPlanning plan)
        {
            _listEventPlanning.Add(plan);
        }

        public List<EventPlanning> GetEventPlaningRepositoryList()
        {
            return _listEventPlanning;
        }

        public decimal AddCostOfOneType(EventType type)
        {
            decimal totalTypeCost = 0m;

            foreach (EventPlanning listEventPlanning in _listEventPlanning)
            {
                if (listEventPlanning.EventType == type)
                    totalTypeCost += listEventPlanning.TotalCostForTheEvent;
            }
            return totalTypeCost;
        }

        
     }
}
