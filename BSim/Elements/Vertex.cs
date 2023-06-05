using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "VERTEX")]
    public class Vertex : BSimElement
    {
        [BSimXmlModelProperty(Name = "has_geometry", Type = BSimValueType.OneToOne)]
        public Vector3D Vector { get; set; }
    }
}
