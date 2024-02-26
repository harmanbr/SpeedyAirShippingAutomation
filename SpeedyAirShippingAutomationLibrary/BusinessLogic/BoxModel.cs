using SpeedyAirDeliveryAutomation.Box;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace SpeedyAirShippingAutomationLibrary.BusinessLogic
{
    public class BoxModelConverter : JsonConverter<BoxModel>
    {
        public override BoxModel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;
                var orderNo = root.GetProperty(root.EnumerateObject().First().Name).GetString();
                var destination = root.GetProperty("destination").GetString();
                return new BoxModel { OrderNo = orderNo, Destination = destination };
            }
        }

        public override void Write(Utf8JsonWriter writer, BoxModel value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
