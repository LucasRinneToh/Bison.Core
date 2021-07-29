using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18
{
    [ModelAttribute(ElementName = "COLD_BRIDGE")]
    public class ColdBridge : BeElement
    {
        public ColdBridge(
            string name = "New cold bridge",
            double length = 0,
            double heatLossCoefficient = 0,
            double part = 0,
            double td_in = 20,
            double td_out = -12,
            string sfb = null,
            double b_value = 1
            ) 
        {
            this.id = name;
            this.area = length;
            this.u = heatLossCoefficient;
            this.part = part;
            this.td_in = td_in;
            this.td_out = td_out;
            this.sfb = sfb;
            this.has_b = b_value;
        }

        public double area { get; set; } // Length of cold bridge [m]
        public double u { get; set; } // Thermal heat coefficient of cold bridge [W/mK]
        public double part { get; set; } //
        public double td_in { get; set; } // Dimensioning indoor temperature
        public double td_out { get; set; } // Dimensioning outdoor temperature
        public string sfb { get; set; } // sfb-code
        public double has_b { get; set; } // b-value

    }
}
