using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualBasic.FileIO;
using SpeedyAirDeliveryAutomation.Box;
using SpeedyAirShippingAutomationLibrary.BatchOrder;
using SpeedyAirShippingAutomationLibrary.FlightSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAirShippingAutomationLibrary.BusinessLogic
{
    public class GenerateItineraries : IGenerateItineraries
    {
        private readonly ILogger<GenerateItineraries> _logger;

        public List<IBatchOrderModel> GenerateOrderBatch(Dictionary<string, BoxModel> boxes, List<IFlightScheduleModel> flightSchedules)
        {
            List<IBatchOrderModel> batchOrders = new List<IBatchOrderModel>();

            foreach (var boxEntry in boxes)
            {
                var box = boxEntry.Value;
                foreach (var flightSchedule in flightSchedules)
                {
                    var matchingFlights = flightSchedule.flightModels
                        .Where(flight => flight.FlightDestination == box.Destination && flight.FlightLoad <= flight.FlightCapacity);

                    foreach (var flight in matchingFlights)
                    {
                        batchOrders.Add(new BatchOrderModel
                        {
                            Order = boxEntry.Key,
                            FlightNumber = flight.FlightName,
                            Departure = flight.FlightOrigin,
                            arrival = flight.FlightDestination,
                            day = flightSchedule.Day
                        });
                        flight.FlightLoad++;
                        boxes.Remove(boxEntry.Key);
                        break; // Exit the inner loop after adding the batch order
                    }
                    if (matchingFlights.Any())
                        break; // Exit the middle loop after finding a matching flight
                }
            }
            foreach(var boxEntry in boxes)
            {
                batchOrders.Add(new BatchOrderModel
                {
                    Order = boxEntry.Key,
                    FlightNumber = "not scheduled"
                });
            }
            return batchOrders;
        }

        private List<IBatchOrderModel> LoadOrders(List<IBatchOrderModel> batchOrders)
        {


            return batchOrders;
        }
    }
}
