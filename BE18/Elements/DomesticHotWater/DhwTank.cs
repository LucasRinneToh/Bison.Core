using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "DHW_TANK")]
    public class DhwTank : BeElement
    {
        public DhwTank(
            string name = "New DHW tank",
            double units = 1,
            double volume = 150,
            double outletTemp = 60,
            double heatLoss = 1.5,
            double b = 0,
            bool solarHeat = false,
            double dhwShare = 1,
            double circuitChargePower = 10,
            double circuitPumpPower = 0,
            bool circuitPumpRegulated = false,
            string dhwElectricHeatingType = DhwTankElectricHeatingType.None
            )
        {
            this.id = name;
            this.Sfb = null;
            this.Units = units;
            this.Volume = volume;
            this.OutletTemp = outletTemp;
            this.HeatLoss = heatLoss;
            this.bValue = b;
            this.SolarHeat = solarHeat;
            this.DhwShare = dhwShare;
            this.CircuitChargePower = circuitChargePower;
            this.CircuitPumpPower = circuitPumpPower;
            this.CircuitPumpRegulated = circuitPumpRegulated;
            this.DhwElectricHeatingType = dhwElectricHeatingType;
            this.Pipes = new List<DhwPipe>();
            this.CirculationPump = new DhwCirculationPump();
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Number of units [-]
        [FieldAttribute(XmlElementName = "no", ValueType = Attributes.ValueType.Double)]
        public double Units { get; set; }

        // Tank volume [L]
        [FieldAttribute(XmlElementName = "vol", ValueType = Attributes.ValueType.Double)]
        public double Volume { get; set; }

        // Outlet temperature [*C]
        [FieldAttribute(XmlElementName = "outlet_temp", ValueType = Attributes.ValueType.Double)]
        public double OutletTemp { get; set; }

        // Tank heat loss [W/K]
        [FieldAttribute(XmlElementName = "heat_loss", ValueType = Attributes.ValueType.Double)]
        public double HeatLoss { get; set; }

        // Reduction factor (b, 0-1) [-]
        [FieldAttribute(XmlElementName = "b", ValueType = Attributes.ValueType.Double)]
        public double bValue { get; set; }

        // Solar heating tank?
        [FieldAttribute(XmlElementName = "solar_heat", ValueType = Attributes.ValueType.Bool)]
        public bool SolarHeat { get; set; }

        // Share of tank volume used for domestic hot water (0-1) [-]
        [FieldAttribute(XmlElementName = "dhw_part", ValueType = Attributes.ValueType.Double)]
        public double DhwShare { get; set; }

        // Charge power of circuit pump [kW]
        [FieldAttribute(XmlElementName = "eff", ValueType = Attributes.ValueType.Double)]
        public double CircuitChargePower { get; set; }

        // Power of circuit pump [W]
        [FieldAttribute(XmlElementName = "p", ValueType = Attributes.ValueType.Double)]
        public double CircuitPumpPower { get; set; }

        // Circuit pump regulated?
        [FieldAttribute(XmlElementName = "p", ValueType = Attributes.ValueType.Bool)]
        public bool CircuitPumpRegulated { get; set; }

        // Electric heating of domestic hot water
        [FieldAttribute(XmlElementName = "has_el_heat", ValueType = Attributes.ValueType.String)]
        public string DhwElectricHeatingType { get; set; }

        // Dhw pipes
        [FieldAttribute(XmlElementName = "has_dhw_pipe", ValueType = Attributes.ValueType.OneToMany)]
        public List<DhwPipe> Pipes { get; set; }

        // Circulation pump
        [FieldAttribute(XmlElementName = "has_dhw_pump_circ", ValueType = Attributes.ValueType.OneToOne)]
        public DhwCirculationPump CirculationPump { get; set; }
    }

    public static class DhwTankElectricHeatingType
    {
        public const string
            None = ".DHW_N.",
            Summer = ".DHW_S.",
            Always = ".DHW_A.";
    }

}
