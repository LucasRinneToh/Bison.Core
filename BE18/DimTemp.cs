using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18
{
    [ModelAttribute(ElementName = "DIM_TEMP")]
    public class DimTemp : BeElement
    {
        public DimTemp(string name = null, double temperature = 60)
        {
            this.id = name;
            this.Temperature = temperature;
        }

        // Temperature [*C]
        [FieldAttribute(XmlElementName = "temp", ValueType = Attributes.ValueType.Double)]
        public double Temperature { get; set; }
    }
}
