using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel( Name = "SYSTEM" )]
    public class System : BSimElement
    {
        [BSimXmlModelProperty(Name = "active", Type = BSimValueType.Int)]
        public int Active { get; set; }

        // TO-DO: Insert component
        [BSimXmlModelProperty(Name = "has_component", Type = BSimValueType.OneToOne)]
        public int Component { get; set; }

        // TO-DO: Insert schedule
        [BSimXmlModelProperty(Name = "has_schedule", Type = BSimValueType.OneToOne)]
        public int Schedule { get; set; }

        [BSimXmlModelProperty(Name = "system_type", Type = BSimValueType.String)]
        public string Type { get; set; }
    }
}
