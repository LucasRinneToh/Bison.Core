using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements.DomesticHotWater
{
    [ModelAttribute(ElementName = "DHW_PIPE")]
    public class DhwPipe : BeElement
    {
        public DhwPipe(
            string name = "New dhw pipe",
            double length = 0,
            double heatLoss = 0.15,
            double b = 0
            )
        {
            this.id = name;
            this.Sfb = null;
            this.TubeName = null;
            this.Length = length;
            this.HeatLoss = heatLoss;
            this.bValue = b;
            this.part = 0;
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Tube name
        [FieldAttribute(XmlElementName = "tube_name", ValueType = Attributes.ValueType.String)]
        public string TubeName { get; set; }

        // Tube length [m]
        [FieldAttribute(XmlElementName = "tube_len", ValueType = Attributes.ValueType.Double)]
        public double Length { get; set; }

        // Tube heat loss [W/mK]
        [FieldAttribute(XmlElementName = "tube_psi", ValueType = Attributes.ValueType.Double)]
        public double HeatLoss { get; set; }

        // Tube b-value [-]
        [FieldAttribute(XmlElementName = "tube_b", ValueType = Attributes.ValueType.Double)]
        public double bValue { get; set; }

        // Part [-]
        [FieldAttribute(XmlElementName = "part", ValueType = Attributes.ValueType.Double)]
        public double part { get; set; }
    }
}
