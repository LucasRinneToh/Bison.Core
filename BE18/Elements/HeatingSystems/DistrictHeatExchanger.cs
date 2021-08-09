using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "D_H_EXCH")]
    public class DistrictHeatExchanger : BeElement
    {
        public DistrictHeatExchanger(
            string Name = "New district heat exchanger",
            double nominalPower = 0,
            double heatLoss = 0,
            bool DHW = false,
            double minTemp = 0,
            double bFactor = 0,
            double auxPower = 0
            )
        {
            this.id = Name;
            this.Sfb = null;
            this.NominalPower = nominalPower;
            this.HeatLoss = heatLoss;
            this.DHW = DHW;
            this.MinTemp = minTemp;
            this.bFactor = bFactor;
            this.AuxPower = auxPower;
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Nominal power [kW]
        [FieldAttribute(XmlElementName = "nom_eff", ValueType = Attributes.ValueType.Double)]
        public double NominalPower { get; set; }

        // Exchanger heat loss [W/K]
        [FieldAttribute(XmlElementName = "heat_loss", ValueType = Attributes.ValueType.Double)]
        public double HeatLoss { get; set; }

        // Domestic hot water through the exchanger?
        [FieldAttribute(XmlElementName = "dhw", ValueType = Attributes.ValueType.Bool)]
        public bool DHW { get; set; }

        // Minimum exchanger temperature [*C]
        [FieldAttribute(XmlElementName = "min_temp", ValueType = Attributes.ValueType.Double)]
        public double MinTemp { get; set; }

        // b-factor [-]
        [FieldAttribute(XmlElementName = "b_factor", ValueType = Attributes.ValueType.Double)]
        public double bFactor { get; set; }

        // Auxillery power for standby
        [FieldAttribute(XmlElementName = "auto_stb", ValueType = Attributes.ValueType.Double)]
        public double AuxPower { get; set; }
    }
}
