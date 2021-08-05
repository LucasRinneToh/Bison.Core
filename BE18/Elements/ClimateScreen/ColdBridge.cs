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
            double indoorTemp = 20,
            double exteriorTemp = -12,
            double b_value = 1,
            string sfb = null
            ) 
        {
            this.id = name;
            this.Length = length;
            this.HeatLossCoefficient = heatLossCoefficient;
            this.part = 0;
            this.IndoorTemp = indoorTemp;
            this.ExteriorTemp = exteriorTemp;
            this.Sfb = sfb;
            this.b_Value = b_value;
        }

        // Length of cold bridge [m]
        [FieldAttribute(XmlElementName = "area", ValueType = Attributes.ValueType.Double)]
        public double Length { get; set; }

        // Thermal heat coefficient of cold bridge [W/mK]
        [FieldAttribute(XmlElementName = "u", ValueType = Attributes.ValueType.Double)]
        public double HeatLossCoefficient { get; set; }

        // Part
        [FieldAttribute(XmlElementName = "part", ValueType = Attributes.ValueType.Double)]
        public double part { get; set; }

        // Dimensioning indoor temperature
        [FieldAttribute(XmlElementName = "td_in", ValueType = Attributes.ValueType.Double)]
        public double IndoorTemp { get; set; }

        // Dimensioning outdoor temperature
        [FieldAttribute(XmlElementName = "td_out", ValueType = Attributes.ValueType.Double)]
        public double ExteriorTemp { get; set; }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // b-value
        [FieldAttribute(XmlElementName = "has_b", ValueType = Attributes.ValueType.Double)]
        public double b_Value { get; set; } 
    }
}
