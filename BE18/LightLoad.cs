using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18
{
    [ModelAttribute(ElementName = "LIGHT_LOAD")]
    public class LightLoad : BeElement
    {
        public LightLoad(
            string Name = "New Lighting",
            double LightingGeneralMin = 2,
            double LightingInstalled = 10,
            double LightingLevel = 200,
            double DaylightFactor = 2,
            string LightingControl = LightingRegulation.None,
            double UsageFactor = 1,
            double LightingWork = 1,
            double LightingOther = 0,
            double LightingStandby = 0,
            double LightingNight = 0
            )
        {
            this.id = Name;
            this.Lighting_General_Min = LightingGeneralMin;
            this.Lighting_Installed = LightingInstalled;
            this.LightingLevel = LightingLevel;
            this.DaylightFactor = DaylightFactor;
            this.LightingControl = LightingControl;
            this.UsageFactor = UsageFactor;
            this.Lighting_Work = LightingWork;
            this.Lighting_Other = LightingOther;
            this.Lighting_Standby = LightingStandby;
            this.Lighting_Night = LightingNight;
        }

        // sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string sfb { get; set; }

        // General lighting (minimum) [W/m2]
        [FieldAttribute(XmlElementName = "gen_min", ValueType = Attributes.ValueType.Double)]
        public double Lighting_General_Min { get; set; }

        // Installed lighting [W/m2]
        [FieldAttribute(XmlElementName = "gen_max", ValueType = Attributes.ValueType.Double)]
        public double Lighting_Installed { get; set; }

        // Lighting level [lux]
        [FieldAttribute(XmlElementName = "light", ValueType = Attributes.ValueType.Double)]
        public double LightingLevel { get; set; }

        // Daylight factor [-]
        [FieldAttribute(XmlElementName = "df", ValueType = Attributes.ValueType.Double)]
        public double DaylightFactor { get; set; }

        // Lighting controls [-]
        [FieldAttribute(XmlElementName = "has_reg", ValueType = Attributes.ValueType.String)]
        public string LightingControl { get; set; }

        // Usage factor (0-1) [-]
        [FieldAttribute(XmlElementName = "fo", ValueType = Attributes.ValueType.Double)]
        public double UsageFactor { get; set; }

        // Work lighting [W/m2]
        [FieldAttribute(XmlElementName = "work", ValueType = Attributes.ValueType.Double)]
        public double Lighting_Work { get; set; }

        // Other lighting [W/m2]
        [FieldAttribute(XmlElementName = "other", ValueType = Attributes.ValueType.Double)]
        public double Lighting_Other { get; set; }

        // Stand-by lighting [W/m2]
        [FieldAttribute(XmlElementName = "stand_by", ValueType = Attributes.ValueType.Double)]
        public double Lighting_Standby { get; set; }

        // Night lighting [W/m2]
        [FieldAttribute(XmlElementName = "night", ValueType = Attributes.ValueType.Double)]
        public double Lighting_Night { get; set; }
    }

    public static class LightingRegulation
    {
        public const string
            None = ".U.",
            Manual = ".M.",
            Automatic = ".A.",
            Continues = ".K.";
    }
}
