using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "LIGHTING")]
    public class Lighting : BeElement
    {
        public Lighting(
            string Name = null,
            double Outdoor = 0,
            double has_light_add = 0
            )
        {
            this.id = Name;
            this.Outdoor = Outdoor;
            this.Zones = new List<LightLoad>();
            this.has_light_add = has_light_add;
        }

        // sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string sfb { get; set; }

        // outdoor // TO-DO: figure out what this does
        [FieldAttribute(XmlElementName = "outdoor", ValueType = Attributes.ValueType.Double)]
        public double Outdoor { get; set; }

        // has_light_load
        [FieldAttribute(XmlElementName = "has_light_load", ValueType = Attributes.ValueType.OneToMany)]
        public List<LightLoad> Zones { get; set; }

        // has_light_add // TO-DO: figure out what this does
        [FieldAttribute(XmlElementName = "has_light_add", ValueType = Attributes.ValueType.Double)]
        public double has_light_add { get; set; }
    }
}
