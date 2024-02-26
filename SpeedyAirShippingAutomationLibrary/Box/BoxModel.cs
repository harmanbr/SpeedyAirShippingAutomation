using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAirDeliveryAutomation.Box
{
    public class BoxModel : IBoxModel
    {
        public string OrderNo { get; set; }

        public string Destination { get; set; }
    }
}
