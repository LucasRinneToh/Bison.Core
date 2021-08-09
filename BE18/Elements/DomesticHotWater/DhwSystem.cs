using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "DHW_SYSTEM")]
    public class DhwSystem : BeElement
    {
        public DhwSystem(
            string name = "DHW system",
            double consumption = 100,
            double temperature = 60
            )
        {
            this.id = name;
            this.Consumption = consumption;
            this.Temperature = temperature;
            this.Tanks = new List<DhwTank>();
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Consumption [L/year*m2]
        [FieldAttribute(XmlElementName = "consumption", ValueType = Attributes.ValueType.Double)]
        public double Consumption { get; set; }

        // Temperature [*C]
        [FieldAttribute(XmlElementName = "temp", ValueType = Attributes.ValueType.Double)]
        public double Temperature { get; set; }

        // DHW tanks
        [FieldAttribute(XmlElementName = "has_dhw_tank", ValueType = Attributes.ValueType.OneToMany)]
        public List<DhwTank> Tanks { get; set; }
    }
}
