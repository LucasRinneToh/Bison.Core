using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "WIND_MILL")]
    public class Windmill : BeElement
    {
        public Windmill(
            string name = "New windmill",
            double nominalPower = 0,
            double nominalWindSpeed = 0,
            double initialWindSpeed = 0,
            double height = 0,
            double surroundingsHeight = 0,
            double roughness = 0
            )
        {
            this.id = name;
            this.Sfb = null;
            this.NominalPower = nominalPower;
            this.NominalWindSpeed = nominalWindSpeed;
            this.InitialWindSpeed = initialWindSpeed;
            this.Height = height;
            this.SurroundingsHeight = surroundingsHeight;
            this.Roughness = roughness;
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Nominal power [kW]
        [FieldAttribute(XmlElementName = "nom_eff", ValueType = Attributes.ValueType.Double)]
        public double NominalPower { get; set; }

        // Nominal wind speed [m/s]
        [FieldAttribute(XmlElementName = "nom_wind_speed", ValueType = Attributes.ValueType.Double)]
        public double NominalWindSpeed { get; set; }

        // Initial wind speed [m/s]
        [FieldAttribute(XmlElementName = "start_wind_speed", ValueType = Attributes.ValueType.Double)]
        public double InitialWindSpeed { get; set; }

        // Mill height (z) [m]
        [FieldAttribute(XmlElementName = "height", ValueType = Attributes.ValueType.Double)]
        public double Height { get; set; }

        // Surroundings height (do) [m]
        [FieldAttribute(XmlElementName = "wm_do", ValueType = Attributes.ValueType.Double)]
        public double SurroundingsHeight { get; set; }

        // Roughness (zo) [m]
        [FieldAttribute(XmlElementName = "wm_zo", ValueType = Attributes.ValueType.Double)]
        public double Roughness { get; set; }
    }
}
