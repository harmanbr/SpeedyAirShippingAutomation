
namespace SpeedyAirShippingAutomationLibrary.FlightSchedule
{
    public interface IPrintFlightSchedule
    {
        void Print(List<IFlightScheduleModel> flightSchedules);
    }
}