using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements.HeatingSystems
{
    [ModelAttribute(ElementName = "SUP_ROOM_HEAT")]
    public class SupplementalRoomHeating : BeElement
    {
        public SupplementalRoomHeating(
            string name_El = null,
            double share_El = 0,
            string name_Heat = null,
            double share_Heat = 0,
            double heatEffeciency = 0,
            double airFlow = 0
            )
        {
            this.id = name_El;
            this.Sfb = null;
            this.Share_El = share_El;
            this.Description = name_Heat;
            this.Share_Heat = share_Heat;
            this.Effeciency = heatEffeciency;
            this.AirFlow = airFlow;
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Share of floor area heated by electric heating [-]
        [FieldAttribute(XmlElementName = "a_frac_heat", ValueType = Attributes.ValueType.Double)]
        public double Share_El { get; set; }

        // Description of non-electric heating source
        [FieldAttribute(XmlElementName = "doc", ValueType = Attributes.ValueType.String)]
        public string Description { get; set; }

        // Share of floor area heated by non-electric heating [-]
        [FieldAttribute(XmlElementName = "a_frac", ValueType = Attributes.ValueType.Double)]
        public double Share_Heat { get; set; }

        // Effeciency of non-electric heating [-]
        [FieldAttribute(XmlElementName = "ny", ValueType = Attributes.ValueType.Double)]
        public double Effeciency { get; set; }

        // Air flow [m3/s]
        [FieldAttribute(XmlElementName = "air_flow", ValueType = Attributes.ValueType.Double)]
        public double AirFlow { get; set; }

    }
}
