using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18
{
    [ModelAttribute(ElementName = "COOLING")]
    public class Cooling : BeElement
    {
        public Cooling(
            string name = "Mechanical cooling",
            double effeciency = 2,
            double additionalCooling = 1.2,
            double loadFactor = 1,
            double electricDemand = 0.5,
            double heatCapacity = 0,
            double heatDemand = 0,
            string documentation = null
            )
        {
            this.id = name;
            this.Sfb = null;
            this.Effeciency = effeciency;
            this.AdditionalCooling = additionalCooling;
            this.Documentation = documentation;
            this.LoadFactor = loadFactor;
            this.ElectricDemand = electricDemand;
            this.HeatCapacity = heatCapacity;
            this.HeatDemand = heatDemand;
        }


        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Effeciency [-]
        [FieldAttribute(XmlElementName = "effeciency", ValueType = Attributes.ValueType.Double)]
        public double Effeciency { get; set; }

        // Additional cooling (forøgelsesfaktor) [-]
        [FieldAttribute(XmlElementName = "additional_cooling", ValueType = Attributes.ValueType.Double)]
        public double AdditionalCooling { get; set; }

        // Documentation
        [FieldAttribute(XmlElementName = "documentation", ValueType = Attributes.ValueType.String)]
        public string Documentation { get; set; }

        // Load factor [-]
        [FieldAttribute(XmlElementName = "load_fac", ValueType = Attributes.ValueType.Double)]
        public double LoadFactor { get; set; }

        // Electric demand [kWh cooling / kWh electricity]
        [FieldAttribute(XmlElementName = "el_dem", ValueType = Attributes.ValueType.Double)]
        public double ElectricDemand { get; set; }

        // Heat capacity, phase change, cooling [Wh/m2]
        [FieldAttribute(XmlElementName = "heat_cap_pc", ValueType = Attributes.ValueType.Double)]
        public double HeatCapacity { get; set; }

        // Heat demand [kWh heating / kWh cooling]
        [FieldAttribute(XmlElementName = "heat_dem", ValueType = Attributes.ValueType.Double)]
        public double HeatDemand { get; set; }
    }
}
