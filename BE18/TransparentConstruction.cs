using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18
{
    [ModelAttribute(ElementName = "TRANSP_CONSTR")]
    public class TransparentConstruction : BeElement
    {
        public TransparentConstruction(
            double area = 0, 
            double u = 1.2, 
            double td_in = 20,
            double td_out = -12,
            string sfb = null,
            double has_b = 1,
            double no = 1,
            double orient = 0,
            double slope = 90,
            double ff = 1,
            double g = 0.53,
            double fc = 1,
            bool ot = false,
            Shading Shading = null
            )
        {
            this.Area = area;
            this.U_Value = u;
            this.part = 0;
            this.DimTempIndoor = td_in;
            this.DimTempOutdoor = td_out;
            this.sfb = sfb;
            this.b_Value = has_b;
            this.Units = no;
            this.Orientation = orient;
            this.Slope = slope;
            this.ff = ff;
            this.g = g;
            this.fc = fc;
            this.ot = ot;
            this.Shading = Shading;
        }

        // Area [m2]
        [FieldAttribute(XmlElementName = "area", ValueType = Attributes.ValueType.Double)]
        public double Area { get; set; }

        // U-value [W/m2K]
        [FieldAttribute(XmlElementName = "u", ValueType = Attributes.ValueType.Double)]
        public double U_Value { get; set; }

        // Part [-] // TO-DO: Figure out what this does
        [FieldAttribute(XmlElementName = "part", ValueType = Attributes.ValueType.Double)]
        public double part { get; set; }

        // Dimensioning indoor temperature [*C]
        [FieldAttribute(XmlElementName = "td_in", ValueType = Attributes.ValueType.Double)]
        public double DimTempIndoor { get; set; }

        // Dimensioning outdoor temperature [*C]
        [FieldAttribute(XmlElementName = "td_out", ValueType = Attributes.ValueType.Double)]
        public double DimTempOutdoor { get; set; }

        // sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string sfb { get; set; }

        // b-value (0-1)
        [FieldAttribute(XmlElementName = "has_b", ValueType = Attributes.ValueType.Double)]
        public double b_Value { get; set; }

        // Number of units [-]
        [FieldAttribute(XmlElementName = "no", ValueType = Attributes.ValueType.Double)]
        public double Units { get; set; }

        // Orientation [deg]
        [FieldAttribute(XmlElementName = "orient", ValueType = Attributes.ValueType.Double)]
        public double Orientation { get; set; }

        // Vertical slope [deg]
        [FieldAttribute(XmlElementName = "slope", ValueType = Attributes.ValueType.Double)]
        public double Slope { get; set; } 


        public double ff { get; set; } 
        public double g { get; set; } // g-value
        public double fc { get; set; }
        public bool ot { get; set; } // Flag for use in overtemperature calculation

        [FieldAttribute(XmlElementName = "has_shading", ValueType = Attributes.ValueType.OneToOne)]
        public Shading Shading { get; set; }
    }
}
