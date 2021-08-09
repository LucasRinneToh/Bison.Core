using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "DHW_PUMP_CIRC")]
    public class DhwCirculationPump : BeElement
    {
        public DhwCirculationPump(
            string name = "New DHW circulation pump",
            double reductionFactor = 1,
            double quantity1 = 0,
            double power1 = 0,
            double quantity2 = 0,
            double power2 = 0,
            bool elTracing = false
            )
        {
            this.id = name;
            this.Sfb = null;
            this.ReductionFactor = reductionFactor;
            this.Quantity1 = quantity1;
            this.Power1 = power1;
            this.Quantity2 = quantity2;
            this.Power2 = power2;
            this.ElTracing = elTracing;
            this.Pipes = new List<DhwPipe>();
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Reduction factor (0-1) [-]
        [FieldAttribute(XmlElementName = "r_fac", ValueType = Attributes.ValueType.Double)]
        public double ReductionFactor { get; set; }

        // Quantity [-] (field 1)
        [FieldAttribute(XmlElementName = "n_cp", ValueType = Attributes.ValueType.Double)]
        public double Quantity1 { get; set; }

        // Power [W] (field 1)
        [FieldAttribute(XmlElementName = "p_eff", ValueType = Attributes.ValueType.Double)]
        public double Power1 { get; set; }

        // Quantity [-] (field 2)
        [FieldAttribute(XmlElementName = "n_cp2", ValueType = Attributes.ValueType.Double)]
        public double Quantity2 { get; set; }

        // Power [W] (field 2)
        [FieldAttribute(XmlElementName = "p_eff2", ValueType = Attributes.ValueType.Double)]
        public double Power2 { get; set; }

        // Has electric tracing?
        [FieldAttribute(XmlElementName = "el_tracing", ValueType = Attributes.ValueType.Bool)]
        public bool ElTracing { get; set; }

        // Tubes
        [FieldAttribute(XmlElementName = "has_tube", ValueType = Attributes.ValueType.OneToMany)]
        public List<DhwPipe> Pipes { get; set; }
    }
}
