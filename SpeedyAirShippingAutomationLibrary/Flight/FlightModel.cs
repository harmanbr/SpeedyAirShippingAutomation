using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAirDeliveryAutomation.Flight
{
    public class FlightModel : IFlightModel
    {
        public FlightModel(string flightName, string flightOrigin, string flightDestination, int flightCapacity, int flightLoad)
        {
            FlightName = flightName;
            FlightOrigin = flightOrigin;
            FlightDestination = flightDestination;
            FlightCapacity = flightCapacity;
            FlightLoad = flightLoad;
        }

        public string FlightName { get; set; }

        public string FlightOrigin { get; set; }

        public string FlightDestination { get; set; }

        public int FlightCapacity { get; set; }

        public int FlightLoad { get; set; }

        

    }
}
