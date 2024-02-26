using SpeedyAirDeliveryAutomation.Box;
using SpeedyAirDeliveryAutomation.Flight;
using SpeedyAirShippingAutomationLibrary.FlightSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAirShippingAutomationLibrary.BatchOrder
{
    public class BatchOrderModel : IBatchOrderModel
    {
        public string Order { get; set; }

        public string FlightNumber { get; set; }

        public string Departure { get; set; }

        public string arrival { get; set; }

        public string day { get; set; }

    }
}
