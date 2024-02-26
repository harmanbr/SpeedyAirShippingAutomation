using SpeedyAirDeliveryAutomation.Box;

namespace SpeedyAirShippingAutomation
{
    public interface IAssignmentLoader
    {
        Dictionary<string, BoxModel> LoadAssignments(string filePath);
    }
}