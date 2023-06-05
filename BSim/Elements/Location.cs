using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "LOCATION")]
    public class Location : BSimElement
    {
        public Location(
            string name = "nDRY 2013",
            double latitude = 55.793,
            double longitude = 12.16,
            int timeZone = 1,
            double elevation = 10
            )
        {
            this.Name = name;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.TimeZone = timeZone;
            this.Elevation = elevation;
        }

        [BSimXmlModelProperty(Name = "latitude", Type = BSimValueType.Double)]
        public double Latitude { get; set; }

        [BSimXmlModelProperty(Name = "longitude", Type = BSimValueType.Double)]
        public double Longitude { get; set; }

        [BSimXmlModelProperty(Name = "time_zone", Type = BSimValueType.Int)]
        public int TimeZone { get; set; }

        [BSimXmlModelProperty(Name = "elevation", Type = BSimValueType.Double)]
        public double Elevation { get; set; }
    }
}
