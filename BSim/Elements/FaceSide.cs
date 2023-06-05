using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "FACE_SIDE")]
    public class FaceSide : BSimElement
    {
        [BSimXmlModelProperty(Name = "locked", Type = BSimValueType.Int)]
        public int Locked { get; set; }

        [BSimXmlModelProperty(Name = "has_normal", Type = BSimValueType.OneToOne)]
        public Vector3D Normal { get; set; }

        [BSimXmlModelProperty(Name = "faces_cell", Type = BSimValueType.OneToOne)]
        public Cell Cell { get; set; }

        [BSimXmlModelProperty(Name = "has_face", Type = BSimValueType.OneToOne)]
        public Face Face { get; set; }
    }
}
