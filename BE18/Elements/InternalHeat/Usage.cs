using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "USAGE")]
    public class Usage : BeElement
    {
        public Usage(
            double appUse_occupancy = 0,
            double appUse_always = 0
            )
        {
            id = null;
            AppUse_Occupancy = appUse_occupancy;
            AppUse_Always = appUse_always;
            UsageLoads = new List<UsageLoad>();
        }

        // Electricity consumption of utilities including cooling of equipment (during occupancy) [W]
        [FieldAttribute(XmlElementName = "app_use", ValueType = Attributes.ValueType.Double)]
        public double AppUse_Occupancy { get; set; }

        // Electricity consumption of utilities including cooling of equipment (on always) [W]
        [FieldAttribute(XmlElementName = "app_always", ValueType = Attributes.ValueType.Double)]
        public double AppUse_Always { get; set; }

        // Usage loads
        [FieldAttribute(XmlElementName = "has_usage_load", ValueType = Attributes.ValueType.OneToMany)]
        public List<UsageLoad> UsageLoads { get; set; }
    }
}
