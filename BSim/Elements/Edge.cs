using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "EDGE")]
    public class Edge : BSimElement
    {
        [BSimXmlModelProperty(Name = "edge_length", Type = BSimValueType.Double)]
        public double Length { get; set; }

        [BSimXmlModelProperty(Name = "has_vertex", Type = BSimValueType.OneToMany)]
        public double Vertices { get; set; }
    }
}
