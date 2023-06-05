using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "CELL")]
    public class Cell : BSimElement
    {
        public Cell(
            string name = "New cell",
            double volume = 0
            )
        {
            this.Name = name;
            this.Volume = volume;
            this.BoundedBy = new List<FaceSide>();
        }

        [BSimXmlModelProperty(Name = "volume", Type = BSimValueType.Double)]
        public double Volume { get; set; }

        [BSimXmlModelProperty(Name = "bounded_by", Type = BSimValueType.OneToMany)]
        public List<FaceSide> BoundedBy { get; set; }
    }
}
