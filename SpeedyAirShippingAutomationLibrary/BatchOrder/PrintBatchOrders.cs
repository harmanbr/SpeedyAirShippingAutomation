using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAirShippingAutomationLibrary.BatchOrder
{
    public class PrintBatchOrders : IPrintBatchOrders
    {
        private readonly ILogger<PrintBatchOrders> _logger;

        public void Print(List<IBatchOrderModel> batchOrders)
        {
            foreach (var b in batchOrders)
            {
                if (b.Departure != null)
                {
                    _logger.LogInformation("order: " + b.Order + ", flightNumber: " + b.FlightNumber +
                        ", departure: " + b.Departure + ", arrival: " + b.arrival + ", day: " + b.day);
                }
                else
                {
                    _logger.LogInformation("order: {0}, flightNumber: {1} ", b.Order, b.FlightNumber);
                }
            }

        }

        public PrintBatchOrders(ILogger<PrintBatchOrders> logger)
        {
            _logger = logger;
        }
    }
}
