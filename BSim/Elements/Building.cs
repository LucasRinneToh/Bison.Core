using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "BUILDING")]
    public class Building : BSimElement
    {
        [BSimXmlModelProperty(Name = "rotation", Type = BSimValueType.Double)]
        public double Rotation { get; set; }

        [BSimXmlModelProperty(Name = "current", Type = BSimValueType.Double)]
        public double Current { get; set; }

        [BSimXmlModelProperty(Name = "height", Type = BSimValueType.Double)]
        public double Height { get; set; }

        [BSimXmlModelProperty(Name = "composed_of", Type = BSimValueType.OneToMany)]
        public List<Room> Rooms { get; set; }

        [BSimXmlModelProperty(Name = "located_on_site", Type = BSimValueType.OneToOne)]
        public Site Site { get; set; }

        [BSimXmlModelProperty(Name = "has_thermal_zones", Type = BSimValueType.OneToMany)]
        public List<ThermalZone> ThermalZones { get; set; }
    }
}
