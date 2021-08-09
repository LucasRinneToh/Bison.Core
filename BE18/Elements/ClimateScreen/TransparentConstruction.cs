using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "TRANSP_CONSTR")]
    public class TransparentConstruction : BeElement
    {
        public TransparentConstruction(
            double area = 0, 
            double u_value = 1.2,
            double b_value = 1,
            double units = 1,
            double orientation = 0,
            double slope = 90,
            double glazingPercentage = 0.73,
            double g_value = 0.53,
            double shadingFactor = 1,
            double td_in = 20,
            double td_out = -12,
            string sfb = null,
            bool ot = false,
            Shading Shading = null
            )
        {
            this.Area = area;
            this.U_Value = u_value;
            this.DimTempIndoor = td_in;
            this.DimTempOutdoor = td_out;
            this.sfb = sfb;
            this.b_Value = b_value;
            this.Units = units;
            this.Orientation = orientation;
            this.Slope = slope;
            this.GlazingPercentage = glazingPercentage;
            this.g_Value = g_value;
            this.ShadingFactor = shadingFactor;
            this.UsedInOverheating = ot;
            this.Shading = Shading;
            this.part = 0;
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

        // b-value (temperature-factor) (0-1)
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

        // Glazing percentage (Ff) (0-1) [-]
        [FieldAttribute(XmlElementName = "ff", ValueType = Attributes.ValueType.Double)]
        public double GlazingPercentage { get; set; }

        // Heat transfer coefficient (g-value) (0-1) [-]
        [FieldAttribute(XmlElementName = "g", ValueType = Attributes.ValueType.Double)]
        public double g_Value { get; set; }

        // Shading factor (Fc) (0-1) [-] // No shading = 1
        [FieldAttribute(XmlElementName = "fc", ValueType = Attributes.ValueType.Double)]
        public double ShadingFactor { get; set; }

        // Use transparent construction in overheating calculation?
        [FieldAttribute(XmlElementName = "ot", ValueType = Attributes.ValueType.Double)]
        public bool UsedInOverheating { get; set; }

        // Shading
        [FieldAttribute(XmlElementName = "has_shading", ValueType = Attributes.ValueType.OneToOne)]
        public Shading Shading { get; set; }
    }
}
