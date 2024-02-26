using SpeedyAirDeliveryAutomation.Flight;

namespace SpeedyAirShippingAutomationLibrary.FlightSchedule
{
    public interface IFlightScheduleModel
    {
        string Day { get; set; }
        List<IFlightModel>? flightModels { get; set; }
    }
}