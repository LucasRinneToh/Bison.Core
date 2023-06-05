using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "VECTOR3D")]
    public class Vector3D : BSimElement
    {
        public Vector3D(string name, double x, double y, double z)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        [BSimXmlModelProperty(Name = "x", Type = BSimValueType.Double)]
        public double X { get; set; }

        [BSimXmlModelProperty(Name = "y", Type = BSimValueType.Double)]
        public double Y { get; set; }

        [BSimXmlModelProperty(Name = "z", Type = BSimValueType.Double)]
        public double Z { get; set; }
    }
}
