using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements.DomesticHotWater
{
    [ModelAttribute(ElementName = "HEATER_EL")]
    public class DhwElectricHeater : BeElement
    {
        public DhwElectricHeater(
            string name = "Electric water heater",
            double dhwShare = 0,
            double heatLoss = 0,
            double b = 0
            )
        {
            this.id = name;
            this.Sfb = null;
            this.DhwShare = dhwShare;
            this.HeatLoss = heatLoss;
            this.bValue = b;
        }


        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Share of building DHW through the heater
        [FieldAttribute(XmlElementName = "dhw_frac", ValueType = Attributes.ValueType.Double)]
        public double DhwShare { get; set; }

        // Heat loss [W/K]
        [FieldAttribute(XmlElementName = "heat_loss", ValueType = Attributes.ValueType.Double)]
        public double HeatLoss { get; set; }

        // bValue [-]
        [FieldAttribute(XmlElementName = "b", ValueType = Attributes.ValueType.Double)]
        public double bValue { get; set; }

    }
}
