using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements.HeatingSystems
{
    public class SolarCollector : BeElement
    {
        public SolarCollector(
            string name = "New solar collector",
            double area = 0,
            double orientation = 0,
            double slope = 0,
            double horizon = 0,
            double heatLossCoefficient = 0,
            double tubeLength = 0,
            double heatLossPipes = 0,
            double heatExchangerEffeciency = 0,
            double initialEffeciency = 0,
            double pumpPower = 0,
            double standbyPower = 0,
            double sidefinLeft = 0,
            double sidefinRight = 0,
            double heatLossCoefficient2 = 0,
            double angleFactor = 0,
            string collectorType = SolarCollectorType.DomesticHotWater
            )
        {
            this.id = name;
            this.Sfb = null;
            this.Area = area;
            this.Orientation = orientation;
            this.Slope = slope;
            this.Horizon = horizon;
            this.HeatLossCoefficient = heatLossCoefficient;
            this.TubeLength = tubeLength;
            this.HeatLossPipes = heatLossPipes;
            this.HeatExchangerEffeciency = heatExchangerEffeciency;
            this.InitialEffeciency = initialEffeciency;
            this.PumpPower = pumpPower;
            this.StandbyPower = standbyPower;
            this.SidefinLeft = sidefinLeft;
            this.SidefinRight = sidefinRight;
            this.HeatLossCoefficient2 = heatLossCoefficient2;
            this.AngleFactor = angleFactor;
            this.CollectorType = collectorType;
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Panel area [m2]
        [FieldAttribute(XmlElementName = "area", ValueType = Attributes.ValueType.Double)]
        public double Area { get; set; }

        // Orientation, horizontal (0-360) [deg]
        [FieldAttribute(XmlElementName = "orient", ValueType = Attributes.ValueType.Double)]
        public double Orientation { get; set; }

        // Slope, vertical [deg]
        [FieldAttribute(XmlElementName = "slope", ValueType = Attributes.ValueType.Double)]
        public double Slope { get; set; }

        // Horizon, vertical shading [deg]
        [FieldAttribute(XmlElementName = "horizon", ValueType = Attributes.ValueType.Double)]
        public double Horizon { get; set; }

        // Heat loss coefficient [W/m2K]
        [FieldAttribute(XmlElementName = "heat_loss_coef", ValueType = Attributes.ValueType.Double)]
        public double HeatLossCoefficient { get; set; }

        // Tube length of circuit [m]
        [FieldAttribute(XmlElementName = "tube_length", ValueType = Attributes.ValueType.Double)]
        public double TubeLength { get; set; }

        // Heat loss from pipe circuit [W/mK]
        [FieldAttribute(XmlElementName = "heat_loss", ValueType = Attributes.ValueType.Double)]
        public double HeatLossPipes { get; set; }

        // Heat exchanger effeciency (0-1) [-]
        [FieldAttribute(XmlElementName = "ny0", ValueType = Attributes.ValueType.Double)]
        public double HeatExchangerEffeciency { get; set; }

        // Heat exchanger effeciency (0-1) [-]
        [FieldAttribute(XmlElementName = "ny_loop", ValueType = Attributes.ValueType.Double)]
        public double InitialEffeciency { get; set; }

        // Pump power [W]
        [FieldAttribute(XmlElementName = "pump", ValueType = Attributes.ValueType.Double)]
        public double PumpPower { get; set; }

        // Standby power [W]
        [FieldAttribute(XmlElementName = "stand_by", ValueType = Attributes.ValueType.Double)]
        public double StandbyPower { get; set; }

        // Sidefin left, horizontal shading [deg]
        [FieldAttribute(XmlElementName = "sidefin_left", ValueType = Attributes.ValueType.Double)]
        public double SidefinLeft { get; set; }

        // Sidefin right, horizontal shading [deg]
        [FieldAttribute(XmlElementName = "sidefin_right", ValueType = Attributes.ValueType.Double)]
        public double SidefinRight { get; set; }

        // 2. order heat loss coefficient
        [FieldAttribute(XmlElementName = "heat_loss_coef2", ValueType = Attributes.ValueType.Double)]
        public double HeatLossCoefficient2 { get; set; }

        // Angle factor
        [FieldAttribute(XmlElementName = "ang_fac", ValueType = Attributes.ValueType.Double)]
        public double AngleFactor { get; set; }

        // Solar collector type
        [FieldAttribute(XmlElementName = "has_type", ValueType = Attributes.ValueType.String)]
        public string CollectorType { get; set; }
    }

    public static class SolarCollectorType
    {
        public const string
            DomesticHotWater = ".B_TYPE.",
            RoomHeating = ".R_TYPE.",
            Combined = ".K_TYPE.";
    }
}
