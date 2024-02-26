using Microsoft.Extensions.Logging;
using SpeedyAirDeliveryAutomation.Box;
using SpeedyAirShippingAutomationLibrary.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SpeedyAirShippingAutomation
{
    public class AssignmentLoader : IAssignmentLoader
    {
        public readonly ILogger<AssignmentLoader> _logger;

        public AssignmentLoader(ILogger<AssignmentLoader> logger)
        {
            _logger = logger;
        }

        public Dictionary<string, BoxModel> LoadAssignments(string jsonFilePath)
        {
            try
            {
                string json = File.ReadAllText(jsonFilePath);

                Dictionary<string, BoxModel> boxes = JsonSerializer.Deserialize<Dictionary<string, BoxModel>>(json, new JsonSerializerOptions
                {
                    Converters = { new BoxModelConverter() }
                });
                return boxes;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error loading JSON");
                return null;
            }
        }
    }
}
