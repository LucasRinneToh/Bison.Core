using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "VP_COMP")]
    public class VpComp : BeElement
    {
        public VpComp(
            string name = null,
            double nominalPower = 0,
            double nominalCOP = 0,
            double relativeCOP50 = 0,
            double tempCold = 0,
            double tempWarm = 0,
            double equipment = 0,
            double standby = 0,
            double heatRecovery = 0,
            double inletTemp = 0,
            double airflow = 0,
            string coldType = HeatPumpColdMedium.GroundHose,
            string warmType = HeatPumpWarmMedium.RoomAir
            )
        {
            this.id = name;
            this.NominalPower = nominalPower;
            this.NominalCOP = nominalCOP;
            this.RelativeCOP50 = relativeCOP50;
            this.TempCold = tempCold;
            this.TempWarm = tempWarm;
            this.Equipment = equipment;
            this.Standby = standby;
            this.HeatRecovery = heatRecovery;
            this.InletTemp = inletTemp;
            this.Airflow = airflow;
            this.tdif_cold = 0;
            this.ColdType = coldType;
            this.WarmType = warmType;
        }


        // Nominal power [kW]
        [FieldAttribute(XmlElementName = "nom_eff", ValueType = Attributes.ValueType.Double)]
        public double NominalPower { get; set; }

        // Nominal COP [-]
        [FieldAttribute(XmlElementName = "nom_cop", ValueType = Attributes.ValueType.Double)]
        public double NominalCOP { get; set; }

        // Relative COP at 50% load [-]
        [FieldAttribute(XmlElementName = "rel_cop50", ValueType = Attributes.ValueType.Double)]
        public double RelativeCOP50 { get; set; }

        // Temperature at cold side [*C]
        [FieldAttribute(XmlElementName = "temp_cold", ValueType = Attributes.ValueType.Double)]
        public double TempCold { get; set; }

        // Temperature at warm side [*C]
        [FieldAttribute(XmlElementName = "temp_warm", ValueType = Attributes.ValueType.Double)]
        public double TempWarm { get; set; }

        // Equipment load [W]
        [FieldAttribute(XmlElementName = "equip", ValueType = Attributes.ValueType.Double)]
        public double Equipment { get; set; }

        // Standby [W]
        [FieldAttribute(XmlElementName = "auto_stb", ValueType = Attributes.ValueType.Double)]
        public double Standby { get; set; }

        // Temperature effeciency for heat recovery before heat pump (ventilation) [-]
        [FieldAttribute(XmlElementName = "ny_vgv", ValueType = Attributes.ValueType.Double)]
        public double HeatRecovery { get; set; }

        // Dimensioning inlet temperature (ventilation) [*C]
        [FieldAttribute(XmlElementName = "ny_vgv", ValueType = Attributes.ValueType.Double)]
        public double InletTemp { get; set; }

        // Airflow (ventilation) [m3/s]
        [FieldAttribute(XmlElementName = "air_flow", ValueType = Attributes.ValueType.Double)]
        public double Airflow { get; set; }

        // TO-DO: Figure out what this does
        [FieldAttribute(XmlElementName = "tdif_cold", ValueType = Attributes.ValueType.Double)]
        public double tdif_cold { get; set; }

        // Cold type
        [FieldAttribute(XmlElementName = "has_type_cold", ValueType = Attributes.ValueType.String)]
        public string ColdType { get; set; }

        // Warm type
        [FieldAttribute(XmlElementName = "has_type_warm", ValueType = Attributes.ValueType.String)]
        public string WarmType { get; set; }
    }

    public static class HeatPumpColdMedium
    {
        public const string
            GroundHose = ".VP_J.",
            Exhaust = ".VP_A.",
            OutdoorAir = ".VP_U.",
            Other = ".VP_X.";
    }

    public static class HeatPumpWarmMedium
    {
        public const string
            RoomAir = ".VP_R.",
            SupplyAir = ".VP_I.",
            HeatingSystem = ".VP_V.";
    }
}
