using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements.HeatDistribution
{
    [ModelAttribute(ElementName = "HEAT_TUBE")]
    public class HeatingPipe : BeElement
    {
        public HeatingPipe(
            string name = "New heating pipe",
            double length = 0,
            double heatLoss = 0,
            double b = 0,
            bool outdoorComp = false,
            bool summerClosed = false
            )
        {
            this.id = name;
            this.Length = length;
            this.HeatLoss = heatLoss;
            this.b_Value = b;
            this.OutdoorComp = outdoorComp;
            this.SummerClosed = summerClosed;
        }

        // Pipe length [m]
        [FieldAttribute(XmlElementName = "len", ValueType = Attributes.ValueType.Double)]
        public double Length { get; set; }

        // Heat loss [W/mK]
        [FieldAttribute(XmlElementName = "psi", ValueType = Attributes.ValueType.Double)]
        public double HeatLoss { get; set; }

        // b-factor (0-1) [-]
        [FieldAttribute(XmlElementName = "b", ValueType = Attributes.ValueType.Double)]
        public double b_Value { get; set; }

        // Has outdoor compensation?
        [FieldAttribute(XmlElementName = "outdoor_comp", ValueType = Attributes.ValueType.Bool)]
        public bool OutdoorComp { get; set; }

        // Is closed during summer?
        [FieldAttribute(XmlElementName = "closed_summer", ValueType = Attributes.ValueType.Bool)]
        public bool SummerClosed { get; set; }
    }
}
