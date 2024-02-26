namespace SpeedyAirDeliveryAutomation.Flight
{
    public interface IFlightModel
    {
        string FlightDestination { get; set; }
        string FlightName { get; set; }
        string FlightOrigin { get; set; }
        
        int FlightCapacity { get; set; }

        int FlightLoad {  get ; set; }
    }
}