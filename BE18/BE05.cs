using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18
{
    [ModelAttribute(ElementName = "BE05")]
    public class BE05 : BeElement
    {
        public BE05()
        {
            id = "Be18, version 9.18.1.4";
            Building = new Building();
            Climate = "$";
        }

        // Building
        [FieldAttribute(XmlElementName = "has_building", ValueType = Attributes.ValueType.OneToOne)]
        public Building Building { get; set; }

        // Climate // TO-DO: Implement climate
        [FieldAttribute(XmlElementName = "has_climate", ValueType = Attributes.ValueType.String)]
        public string Climate { get; set; }
    }
}
