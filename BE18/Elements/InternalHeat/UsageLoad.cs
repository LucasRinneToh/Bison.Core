using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements.InternalHeat
{
    [ModelAttribute(ElementName = "USAGE_LOAD")]
    public class UsageLoad : BeElement
    {
        public UsageLoad(
            string name = "New zone",
            double area = 0,
            double peopleLoad = 1.5,
            double equipmentLoad_occupancy = 3.5,
            double equipmentLoad_night = 0
            )
        {
            this.id = name;
            this.Sfb = null;
            this.Area = area;
            this.PeopleLoad = peopleLoad;
            this.EquipmentLoad_Occupancy = equipmentLoad_occupancy;
            this.EquipmentLoad_Night = equipmentLoad_night;
            this.part = 0;
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Area [m2]
        [FieldAttribute(XmlElementName = "area", ValueType = Attributes.ValueType.Double)]
        public double Area { get; set; }

        // People load [W/m2]
        [FieldAttribute(XmlElementName = "ppers", ValueType = Attributes.ValueType.Double)]
        public double PeopleLoad { get; set; }

        // Equipment load (during occupancy) [W/m2]
        [FieldAttribute(XmlElementName = "papp", ValueType = Attributes.ValueType.Double)]
        public double EquipmentLoad_Occupancy { get; set; }

        // Equipment load (during occupancy) [W/m2]
        [FieldAttribute(XmlElementName = "papp_night", ValueType = Attributes.ValueType.Double)]
        public double EquipmentLoad_Night { get; set; }

        // Part [-]
        [FieldAttribute(XmlElementName = "part", ValueType = Attributes.ValueType.Double)]
        public double part { get; set; }

    }
}
