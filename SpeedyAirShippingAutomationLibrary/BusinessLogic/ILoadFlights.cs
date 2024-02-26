using SpeedyAirShippingAutomationLibrary.FlightSchedule;

namespace SpeedyAirShippingAutomationLibrary.BusinessLogic
{
    public interface ILoadFlights
    {
        List<IFlightScheduleModel> Load();
    }
}