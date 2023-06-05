using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "ROOM")]
    public class Room : BSimElement
    {
        [BSimXmlModelProperty(Name = "represented_by_cell", Type = BSimValueType.OneToOne)]
        public Cell Cell { get; set; }

        [BSimXmlModelProperty(Name = "ref_x", Type = BSimValueType.Double)]
        public double RefX { get; set; }

        [BSimXmlModelProperty(Name = "ref_y", Type = BSimValueType.Double)]
        public double RefY { get; set; }

        [BSimXmlModelProperty(Name = "ref_z", Type = BSimValueType.Double)]
        public double RefZ { get; set; }

        [BSimXmlModelProperty(Name = "has_temp", Type = BSimValueType.OneToOne, NullValue = "$")]
        public string Temp { get; set; }

        [BSimXmlModelProperty(Name = "behave_like", Type = BSimValueType.OneToOne, NullValue = "$")]
        public string BehaveLike { get; set; }

        [BSimXmlModelProperty(Name = "has_type", Type = BSimValueType.String)]
        public string Type { get; set; }

        [BSimXmlModelProperty(Name = "has_inner_shell", Type = BSimValueType.OneToOne)]
        public Cell InnerShell { get; set; }

        [BSimXmlModelProperty(Name = "has_refpoint", Type = BSimValueType.String)]
        public string RefPoint { get; set; }
    }
}
