using SpeedyAirDeliveryAutomation.Box;
using SpeedyAirShippingAutomationLibrary.BatchOrder;
using SpeedyAirShippingAutomationLibrary.FlightSchedule;

namespace SpeedyAirShippingAutomationLibrary.BusinessLogic
{
    public interface IGenerateItineraries
    {
        List<IBatchOrderModel> GenerateOrderBatch(Dictionary<string, BoxModel> boxes, List<IFlightScheduleModel> flightSchedules);
    }
}