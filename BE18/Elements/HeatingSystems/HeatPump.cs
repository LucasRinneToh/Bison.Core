using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "HEAT_PUMP")]
    public class HeatPump : BeElement
    {
        public HeatPump(
            string name = "New heatpump",
            double shareOfArea = 0,
            string type = HeatPumpType.DomesticWater
            )
        {
            this.id = name;
            this.Sfb = null;
            this.ShareOfArea = shareOfArea;
            this.TempSource = null;
            this.RoomHeating = new VpComp();
            this.DHW = new VpComp();
            this.Type = type;
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Share of heated floor area [-]
        [FieldAttribute(XmlElementName = "a_frac", ValueType = Attributes.ValueType.Double)]
        public double ShareOfArea { get; set; }

        // Temperature source
        [FieldAttribute(XmlElementName = "t_source", ValueType = Attributes.ValueType.String)]
        public string TempSource { get; set; }

        // Room heating data
        [FieldAttribute(XmlElementName = "room_heating", ValueType = Attributes.ValueType.OneToOne)]
        public VpComp RoomHeating { get; set; }

        // DHW data
        [FieldAttribute(XmlElementName = "dhw", ValueType = Attributes.ValueType.OneToOne)]
        public VpComp DHW { get; set; }

        // Type
        [FieldAttribute(XmlElementName = "has_type", ValueType = Attributes.ValueType.String)]
        public string Type { get; set; }
    }

    public static class HeatPumpType
    {
        public const string
            DomesticWater = ".VP_DHW.",
            RoomHeating = ".VP_ROOM.",
            CombinedOnOff = ".VP_COMB.",
            Duo = ".VP_DUO.";
    }
}
