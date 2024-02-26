using Microsoft.Extensions.Logging;
using SpeedyAirShippingAutomation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAirShippingAutomationLibrary.FlightSchedule
{
    public class PrintFlightSchedule : IPrintFlightSchedule
    {
        public readonly ILogger<PrintFlightSchedule> _logger;

        public PrintFlightSchedule(ILogger<PrintFlightSchedule> logger)
        {
            _logger = logger;
        }

        public void Print(List<IFlightScheduleModel> flightSchedules)
        {
            foreach (var flightSchedule in flightSchedules)
            {
                foreach (var flight in flightSchedule.flightModels)
                {
                    _logger.LogInformation("Flight: " + flight.FlightName + ", departure: " + flight.FlightOrigin +
                        ", arrival: " + flight.FlightDestination + ", day: " + flightSchedule.Day, 0);
                }
            }
        }
    }
}
