using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements.DomesticHotWater
{
    [ModelAttribute(ElementName = "HEATER_GAS")]
    public class DhwGasHeater : BeElement
    {
        public DhwGasHeater(
            string name = "Gas heater",
            double dhwShare = 0,
            double heatLoss = 0,
            double b = 0,
            double effeciency = 0,
            double pilotFlame = 0,
            string sfb = null
            )
        {
            this.id = name;
            this.Sfb = sfb;
            this.DhwShare = dhwShare;
            this.HeatLoss = heatLoss;
            this.bValue = b;
            this.Effeciency = effeciency;
            this.PilotFlame = pilotFlame;
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

        // Effeciency [-]
        [FieldAttribute(XmlElementName = "ny", ValueType = Attributes.ValueType.Double)]
        public double Effeciency { get; set; }

        // Pilot flame [W]
        [FieldAttribute(XmlElementName = "pilot_flame", ValueType = Attributes.ValueType.Double)]
        public double PilotFlame { get; set; }
    }
}
