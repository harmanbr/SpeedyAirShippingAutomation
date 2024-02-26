using SpeedyAirDeliveryAutomation.Flight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAirShippingAutomationLibrary.FlightSchedule
{
    public class FlightScheduleModel : IFlightScheduleModel
    {
        public FlightScheduleModel(string day, List<IFlightModel>? flightModels)
        {
            Day = day;
            this.flightModels = flightModels;
        }

        public string Day { get; set; }

        public List<IFlightModel>? flightModels { get; set; }

    }
}
