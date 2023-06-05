using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "TIME_DEFINITION")]
    public class TimeDefinition : BSimElement
    {
        [BSimXmlModelProperty(Name = "hour", Type = BSimValueType.String)]
        public string Hour { get; set; }

        [BSimXmlModelProperty(Name = "day", Type = BSimValueType.String)]
        public string Day { get; set; }

        [BSimXmlModelProperty(Name = "week", Type = BSimValueType.String)]
        public string Week { get; set; }

        [BSimXmlModelProperty(Name = "month", Type = BSimValueType.String)]
        public string Month { get; set; }

        [BSimXmlModelProperty(Name = "tariff_class", Type = BSimValueType.Double)]
        public double TariffClass { get; set; }

        [BSimXmlModelProperty(Name = "protect", Type = BSimValueType.Int)]
        public int Protect { get; set; }
    }
}
