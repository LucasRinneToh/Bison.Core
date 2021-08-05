using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18
{
    [ModelAttribute(ElementName = "OPAQUE_CONST")]
    public class OpaqueConstruction : BeElement
    {
        public OpaqueConstruction(
            string name = "New construction",
            double area = 0,
            double u_value = 0.15,
            double indoorTemp = 20,
            double exteriorTemp = -12,
            double b_value = 1,
            string sfb = null
            )
        {
            this.id = name;
            this.Area = area;
            this.U_Value = u_value;
            this.IndoorTemp = indoorTemp;
            this.ExteriorTemp = exteriorTemp;
            this.b_Value = b_value;
            this.Sfb = sfb;
        }

        // Area [m2]
        [FieldAttribute(XmlElementName = "area", ValueType = Attributes.ValueType.Double)]
        public double Area { get; set; }

        // U-value [W/m2K]
        [FieldAttribute(XmlElementName = "u", ValueType = Attributes.ValueType.Double)]
        public double U_Value { get; set; }

        // Indoor temperature [*C]
        [FieldAttribute(XmlElementName = "td_in", ValueType = Attributes.ValueType.Double)]
        public double IndoorTemp { get; set; }

        // Exterior temperature [*C]
        [FieldAttribute(XmlElementName = "td_out", ValueType = Attributes.ValueType.Double)]
        public double ExteriorTemp { get; set; }

        // b-value [-]
        [FieldAttribute(XmlElementName = "has_b", ValueType = Attributes.ValueType.Double)]
        public double b_Value { get; set; }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }
    }
}
