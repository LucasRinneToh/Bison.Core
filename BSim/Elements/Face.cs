using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "FACE")]
    public class Face : BSimElement
    {
        [BSimXmlModelProperty(Name = "area", Type = BSimValueType.Double)]
        public double Area { get; set; }

        [BSimXmlModelProperty(Name = "round", Type = BSimValueType.Double)]
        public double Round { get; set; }

        [BSimXmlModelProperty(Name = "has_edge", Type = BSimValueType.OneToMany)]
        public List<Edge> Edges { get; set; }

        [BSimXmlModelProperty(Name = "has_face_side", Type = BSimValueType.OneToMany)]
        public FaceSide FaceSides { get; set; }
    }
}
