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
            this.has_pv_cell = null;
        }

        public SolarCollector has_solar_collector { get; set; }
        public PhotovoltaicCell has_pv_cell { get; set; }
    }
}
