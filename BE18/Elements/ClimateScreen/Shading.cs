using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18
{
    [ModelAttribute(ElementName = "SHADING")]
    public class Shading : BeElement
    {
        public Shading(
            string Name = "New shading",
            double Horizon = 10,
            double Overhang = 15,
            double Sidefin_left = 0,
            double Sidefin_right = 0,
            double Part = 0
            )
        {
            this.id = Name;
            this.Horizon = Horizon;
            this.Overhang = Overhang;
            this.Sidefin_left = Sidefin_left;
            this.Sidefin_right = Sidefin_right;
            this.Part = Part;
        }


        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string sfb { get; set; }

        [FieldAttribute(XmlElementName = "horizon", ValueType = Attributes.ValueType.Double)]
        public double Horizon { get; set; }

        [FieldAttribute(XmlElementName = "overhang", ValueType = Attributes.ValueType.Double)]
        public double Overhang { get; set; }

        [FieldAttribute(XmlElementName = "sidefin_left", ValueType = Attributes.ValueType.Double)]
        public double Sidefin_left { get; set; }

        [FieldAttribute(XmlElementName = "sidefin_right", ValueType = Attributes.ValueType.Double)]
        public double Sidefin_right { get; set; }

        [FieldAttribute(XmlElementName = "opening", ValueType = Attributes.ValueType.Double)]
        public double Opening { get; set; }

        [FieldAttribute(XmlElementName = "part", ValueType = Attributes.ValueType.Double)]
        public double Part { get; set; }
    }
}
