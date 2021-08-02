using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements.HeatingSystems
{
    [ModelAttribute(ElementName = "HEATING_SYSTEMS")]
    public class HeatingSystems : BeElement
    {
        public HeatingSystems()
        {
            this.id = null;
            this.has_solar_collector = null;
            this.PvCells = new List<PhotovoltaicCell>();
            this.Boilers = new List<Boiler>();
        }

        public SolarCollector has_solar_collector { get; set; }

        [FieldAttribute(XmlElementName = "has_pv_cell", ValueType = Attributes.ValueType.OneToMany)]
        public List<PhotovoltaicCell> PvCells { get; set; }

        [FieldAttribute(XmlElementName = "has_boiler", ValueType = Attributes.ValueType.OneToMany)]
        public List<Boiler> Boilers { get; set; }
    }
}
