using Microsoft.Extensions.Logging;
using SpeedyAirDeliveryAutomation.Flight;
using SpeedyAirShippingAutomationLibrary.FlightSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAirShippingAutomationLibrary.BusinessLogic
{
    public class LoadFlights : ILoadFlights
    {
        private ILogger<LoadFlights> _logger;

        public LoadFlights(ILogger<LoadFlights> logger)
        {
            _logger = logger;
        }

        public List<IFlightScheduleModel> Load()
        {
            List<IFlightModel> day1Flights = new List<IFlightModel> {
                new FlightModel("1", "YUL", "YYZ", 20, 0),
                new FlightModel("2", "YUL", "YYC", 20, 0),
                new FlightModel("3", "YUL", "YVR", 20, 0)
            };

            List<IFlightModel> day2Flights = new List<IFlightModel> {
                new FlightModel("4", "YUL", "YYZ", 20, 0),
                new FlightModel("5", "YUL", "YYC", 20, 0),
                new FlightModel("6", "YUL", "YVR", 20, 0)
            };

            List<IFlightScheduleModel> flightScheduleModels = new List<IFlightScheduleModel>
            {
                new FlightScheduleModel("1", day1Flights),
                new FlightScheduleModel("2", day2Flights)
            };
           return flightScheduleModels;
        }

    }
}
