using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "THERMAL_ZONE")]
    public class ThermalZone
    {
        [BSimXmlModelProperty(Name = "solar_to_air_fact", Type = BSimValueType.Double)]
        public double SolarToAirFact { get; set; }

        [BSimXmlModelProperty(Name = "solar_to_ceil_ratio", Type = BSimValueType.Double)]
        public double SolarToCeilingRatio { get; set; }

        [BSimXmlModelProperty(Name = "solar_to_wall_ratio", Type = BSimValueType.Double)]
        public double SolarToWallRatio { get; set; }

        [BSimXmlModelProperty(Name = "solar_to_floor_ratio", Type = BSimValueType.Double)]
        public double SolarToFloorRatio { get; set; }

        [BSimXmlModelProperty(Name = "solar_lost_fact", Type = BSimValueType.Double)]
        public double SolarLostFactor { get; set; }

        [BSimXmlModelProperty(Name = "kappa", Type = BSimValueType.Double)]
        public double Kappa { get; set; }

        [BSimXmlModelProperty(Name = "top_height", Type = BSimValueType.Double)]
        public double TopHeight { get; set; }

        [BSimXmlModelProperty(Name = "top_frac", Type = BSimValueType.Double)]
        public double TopFrac { get; set; }

        [BSimXmlModelProperty(Name = "composed_of", Type = BSimValueType.OneToMany)]
        public List<Room> Rooms { get; set; }

        // TO-DO: Insert service model
        [BSimXmlModelProperty(Name = "has_service", Type = BSimValueType.OneToOne)]
        public string Systems { get; set; }
    }
}
