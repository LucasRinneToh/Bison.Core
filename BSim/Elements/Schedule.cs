using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "SCHEDULE")]
    public class Schedule : BSimElement
    {
        // TO-DO: Insert control here
        [BSimXmlModelProperty(Name = "has_control", Type = BSimValueType.OneToOne)]
        public string Control { get; set; }

        [BSimXmlModelProperty(Name = "has_time_definition", Type = BSimValueType.OneToOne)]
        public TimeDefinition TimeDefinition { get; set; }
    }
}
