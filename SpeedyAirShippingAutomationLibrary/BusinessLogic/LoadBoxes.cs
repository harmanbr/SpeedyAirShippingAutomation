using Microsoft.Extensions.Logging;
using SpeedyAirDeliveryAutomation.Box;
using SpeedyAirDeliveryAutomation.Flight;
using SpeedyAirShippingAutomation;
using SpeedyAirShippingAutomationLibrary.BatchOrder;
using SpeedyAirShippingAutomationLibrary.FlightSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAirShippingAutomationLibrary.BusinessLogic
{
    public class LoadBoxes : ILoadBoxes
    {
        private readonly ILogger<LoadBoxes> _logger;
        private readonly ILoadFlights _loadFlights;
        private readonly IAssignmentLoader _assignmentLoader;
        private readonly IPrintFlightSchedule _printFlightSchedule;
        private readonly IGenerateItineraries _generateItineraries;
        private readonly IPrintBatchOrders _printBatchOrders;

        public LoadBoxes(ILogger<LoadBoxes> logger, ILoadFlights loadFlights, IAssignmentLoader assignmentLoader, IPrintFlightSchedule printFlightSchedule, IGenerateItineraries generateItineraries, IPrintBatchOrders printBatchOrders)
        {
            _logger = logger;
            _loadFlights = loadFlights;
            _assignmentLoader = assignmentLoader;
            _printFlightSchedule = printFlightSchedule;
            _generateItineraries = generateItineraries;
            _printBatchOrders = printBatchOrders;
        }

        public void Run()
        {
            List<IFlightScheduleModel> _flightSchedules = _loadFlights.Load();
            _printFlightSchedule.Print(_flightSchedules);

            Dictionary<string, BoxModel> assignments = _assignmentLoader.LoadAssignments("C:\\Users\\Harry\\source\\repos\\SpeedyAirDeliveryAutomation\\SpeedyAirDeliveryAutomation\\coding-assigment-orders.json");
            _printBatchOrders.Print(_generateItineraries.GenerateOrderBatch(assignments, _flightSchedules));
            
        }
    }
}
