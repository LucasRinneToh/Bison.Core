using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements.HeatDistribution
{
    /// <summary>
    /// HEAT DISTRIBUTION PUMP.
    /// Child of heat distribution.
    /// The operation mode is set by the child of the heat distribution!
    /// </summary>
    [ModelAttribute(ElementName = "DIST_PUMP")]
    public class DistributionPump : BeElement
    {
        public DistributionPump(
            string name = null,
            double nominalEffect = 30,
            double reductionFactor = 1,
            double quantity = 1
            )
        {
            this.id = name;
            this.NominalEffect = nominalEffect;
            this.ReductionFactor = reductionFactor;
            this.Quantity = quantity;
            this.part = 0;
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Nominal effect [W]
        [FieldAttribute(XmlElementName = "pnom", ValueType = Attributes.ValueType.Double)]
        public double NominalEffect { get; set; }

        // Reduction factor (0-1) [-]
        [FieldAttribute(XmlElementName = "fp", ValueType = Attributes.ValueType.Double)]
        public double ReductionFactor { get; set; }

        // Quantity of pumps [-]
        [FieldAttribute(XmlElementName = "no", ValueType = Attributes.ValueType.Double)]
        public double Quantity { get; set; }

        [FieldAttribute(XmlElementName = "part", ValueType = Attributes.ValueType.Double)]
        public double part { get; set; }
    }
}
