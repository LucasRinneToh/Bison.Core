using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
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
        [FieldAttribute(XmlElementName = "len", ValueType = ValueType.Double)]
        public double Length { get; set; }

        // Heat loss [W/mK]
        [FieldAttribute(XmlElementName = "psi", ValueType = ValueType.Double)]
        public double HeatLoss { get; set; }

        // b-factor (0-1) [-]
        [FieldAttribute(XmlElementName = "b", ValueType = ValueType.Double)]
        public double b_Value { get; set; }

        // Has outdoor compensation?
        [FieldAttribute(XmlElementName = "outdoor_comp", ValueType = ValueType.Bool)]
        public bool OutdoorComp { get; set; }

        // Is closed during summer?
        [FieldAttribute(XmlElementName = "closed_summer", ValueType = ValueType.Bool)]
        public bool SummerClosed { get; set; }
    }
}
