namespace SpeedyAirShippingAutomationLibrary.BatchOrder
{
    public interface IBatchOrderModel
    {
        string arrival { get; set; }
        string day { get; set; }
        string Departure { get; set; }
        string FlightNumber { get; set; }
        string Order { get; set; }
    }
}