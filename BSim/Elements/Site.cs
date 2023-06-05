using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "SITE")]
    public class Site : BSimElement
    {
        public Site(
            string name = "Site"
            )
        {
            this.Name = name;
        }

        [BSimXmlModelProperty(Name = "weather_file", Type = BSimValueType.String)]
        public string WeatherFile { get; set; }

        [BSimXmlModelProperty(Name = "refl_rad", Type = BSimValueType.Double)]
        public double ReflectedRadiance { get; set; }

        [BSimXmlModelProperty(Name = "refl_light", Type = BSimValueType.Double)]
        public double ReflectedLight { get; set; }

        [BSimXmlModelProperty(Name = "horizon", Type = BSimValueType.Double)]
        public double Horizon { get; set; }

        [BSimXmlModelProperty(Name = "emissivity", Type = BSimValueType.Double)]
        public double Emissivity { get; set; }

        [BSimXmlModelProperty(Name = "co2", Type = BSimValueType.Double)]
        public double CO2 { get; set; }

        [BSimXmlModelProperty(Name = "terrain", Type = BSimValueType.Double)]
        public double Terrain { get; set; }

        [BSimXmlModelProperty(Name = "has_location", Type = BSimValueType.OneToOne)]
        public Location Location { get; set; }

        [BSimXmlModelProperty(Name = "has_ground", Type = BSimValueType.OneToOne)]
        public Ground Ground { get; set; }
    }
}
