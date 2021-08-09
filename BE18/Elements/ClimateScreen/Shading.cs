using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "SHADING")]
    public class Shading : BeElement
    {
        public Shading(
            string name = "New shading",
            double horizon = 10,
            double overhang = 15,
            double SidefinLeft = 0,
            double SidefinRight = 0,
            double opening = 0,
            string sfb = null
            )
        {
            this.id = name;
            this.Horizon = horizon;
            this.Overhang = overhang;
            this.Sidefin_left = SidefinLeft;
            this.Sidefin_right = SidefinRight;
            this.Opening = opening;
            this.Part = 0;
            this.Sfb = sfb;
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Horizon [deg]
        [FieldAttribute(XmlElementName = "horizon", ValueType = Attributes.ValueType.Double)]
        public double Horizon { get; set; }

        // Overhang [deg]
        [FieldAttribute(XmlElementName = "overhang", ValueType = Attributes.ValueType.Double)]
        public double Overhang { get; set; }

        // Sidefin left [deg]
        [FieldAttribute(XmlElementName = "sidefin_left", ValueType = Attributes.ValueType.Double)]
        public double Sidefin_left { get; set; }

        // Sidefin right [deg]
        [FieldAttribute(XmlElementName = "sidefin_right", ValueType = Attributes.ValueType.Double)]
        public double Sidefin_right { get; set; }

        // Opening [deg]
        [FieldAttribute(XmlElementName = "opening", ValueType = Attributes.ValueType.Double)]
        public double Opening { get; set; }

        // Part
        [FieldAttribute(XmlElementName = "part", ValueType = Attributes.ValueType.Double)]
        public double Part { get; set; }
    }
}
