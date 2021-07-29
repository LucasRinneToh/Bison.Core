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
        [FieldAttribute(XmlElementName = "has_building", ValueType = Attributes.ValueType.OneToOne)]
        public Building Building { get; set; }
        public string has_climate { get; set; }

        public BE05()
        {
            id = "Be18, version 9.18.1.4";
            Building = new Building();
            has_climate = "$"; // TO-DO: Insert Climate settings
        }
    }
}
