using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    public abstract class BSimElement
    {
        [BSimXmlModelProperty(Name = "rid", Type = BSimValueType.PrimaryKey)]
        public int Rid { get; set; }

        [BSimXmlModelProperty(Name = "id", Type = BSimValueType.String)]
        public string Name { get; set; }
    }
}
