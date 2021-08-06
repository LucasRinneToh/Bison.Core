using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;
using Bison.Core.BE18.Elements.DomesticHotWater;
using Bison.Core.BE18.Elements.Ventilation;

namespace Bison.Core.BE18
{
    [ModelAttribute(ElementName = "BUILDING")]
    public class Building : BeElement
    {
        public Building()
        {
            id = "New Building";
            HeatedFloorArea = 0;
            SetpointHeating = 20;
            SetpointVenting = 23;
            SetpointNightVent = 24;
            SetpointMechCooling = 25;
            HeatCapacity = 40;
            DimRoomTemp = 20;
            UsagePerWeek = 168;
            StartTime = 0;
            EndTime = 24;
            DimOutdoorTemp = -12;
            mech_cooling = false;
            HasElectricRadiators = false;
            HasSolarHeating = false;
            HasHeatpump = false;
            HasPvPanels = false;
            Rotation = 0;
            AdditionToEnergyFrame = 0;
            HasOven = false;
            HasHeatDistributionSystem = false;
            Dwellings = 1;
            HasWindmill = false;
            th_store = 15;
            dim_store_temp = 15;
            Cooling_Fraction = 0;
            ae2 = 0;
            HeatedBasementArea = 0;
            BuildingType = BuildingTypes.Other;
            HeatSupplyType = HeatSupplyTypes.Boiler;
            CalculationType = CalculationTypes.ActualConditions;
            TransparentConstructions = new List<TransparentConstruction>();
            OpaqueConstructions = new List<OpaqueConstruction>();
            has_unheated_space = "$";
            Ventilation = new List<Ventilation>();
            Usage = null;
            Lighting = null;
            ColdBridges = new List<ColdBridge>();
            has_heating_systems = "$";
            Cooling = null;
            HeatDistribution = new HeatDistribution();
            DhwSystem = new DhwSystem();
            GasHeater = new DhwGasHeater();
            ElectricHeater = new DhwElectricHeater();
            Description = new Description();
            has_comments = "$";
            has_heated_room = "$";
        }

        #region BASIC BUILDING DATA
        // Heated floor area [m2]
        [FieldAttribute(XmlElementName = "ae", ValueType = Attributes.ValueType.Double)]
        public double HeatedFloorArea { get; set; }

        public double ae2 { get; set; }

        // Heated basement area [m2]
        [FieldAttribute(XmlElementName = "ae3", ValueType = Attributes.ValueType.Double)]
        public double HeatedBasementArea { get; set; } 

        // Building Heat Capacity [Wh/m2K]
        [FieldAttribute(XmlElementName = "heat_cap", ValueType = Attributes.ValueType.Double)]
        public double HeatCapacity { get; set; }

        // Usage hours per week [hrs/week]
        [FieldAttribute(XmlElementName = "tb", ValueType = Attributes.ValueType.Int)]
        public int UsagePerWeek { get; set; }

        // Usage start hour of day (0-24) [-]
        [FieldAttribute(XmlElementName = "start_time", ValueType = Attributes.ValueType.Int)]
        public int StartTime { get; set; }

        // Usage end hour of day (0-24) [-]
        [FieldAttribute(XmlElementName = "end_time", ValueType = Attributes.ValueType.Int)]
        public int EndTime { get; set; }

        // Building rotation (clockwise: 0-360) [deg]
        [FieldAttribute(XmlElementName = "rotation", ValueType = Attributes.ValueType.Double)]
        public double Rotation { get; set; }

        // Building Type
        [FieldAttribute(XmlElementName = "has_btype", ValueType = Attributes.ValueType.String)]
        public string BuildingType { get; set; }

        // Number of building units
        [FieldAttribute(XmlElementName = "dwellings", ValueType = Attributes.ValueType.Double)]
        public int Dwellings { get; set; }

        // Description
        [FieldAttribute(XmlElementName = "has_descript", ValueType = Attributes.ValueType.String)]
        public Description Description { get; set; }
        #endregion

        #region TEMPERATURE SETTINGS
        // Room heating setpoint [*C]
        [FieldAttribute(XmlElementName = "th_heat", ValueType = Attributes.ValueType.Double)]
        public double SetpointHeating { get; set; }

        // Venting setpoint [*C]
        [FieldAttribute(XmlElementName = "th_setp", ValueType = Attributes.ValueType.Double)]
        public double SetpointVenting { get; set; }

        // Night ventilation setpoint [*C]
        [FieldAttribute(XmlElementName = "th_nv", ValueType = Attributes.ValueType.Double)]
        public double SetpointNightVent { get; set; }

        // Mechanical cooling setpoint [*C]
        [FieldAttribute(XmlElementName = "th_cool", ValueType = Attributes.ValueType.Double)]
        public double SetpointMechCooling { get; set; }

        // Dimensioning indoor temperature [*C]
        [FieldAttribute(XmlElementName = "dim_room_temp", ValueType = Attributes.ValueType.Double)]
        public double DimRoomTemp { get; set; }
        
        // Dimensioning outdoor temperature [*C]
        [FieldAttribute(XmlElementName = "tu", ValueType = Attributes.ValueType.Double)]
        public double DimOutdoorTemp { get; set; }

        public double th_store { get; set; }
        public double dim_store_temp { get; set; }
        #endregion

        #region HEATING SYSTEM SELECTORS
        // Has electric radiators (1. El-radiator)
        [FieldAttribute(XmlElementName = "sup_heating", ValueType = Attributes.ValueType.Bool)]
        public bool HasElectricRadiators { get; set; }

        // Has oven heating (2. Brændeovne, gasvarmere etc.)
        [FieldAttribute(XmlElementName = "sup_oven", ValueType = Attributes.ValueType.Bool)]
        public bool HasOven { get; set; }
        
        // Has solar heating (3. Solvarme)
        [FieldAttribute(XmlElementName = "solarpanel", ValueType = Attributes.ValueType.Bool)]
        public bool HasSolarHeating { get; set; }

        // Has heat-pump (4. Varmepumpe)
        [FieldAttribute(XmlElementName = "heatpump", ValueType = Attributes.ValueType.Bool)]
        public bool HasHeatpump { get; set; }

        // Has photovoltaics (5. Solceller)
        [FieldAttribute(XmlElementName = "pv_panel", ValueType = Attributes.ValueType.Bool)]
        public bool HasPvPanels { get; set; }

        [FieldAttribute(XmlElementName = "windmill", ValueType = Attributes.ValueType.Bool)]
        public bool HasWindmill { get; set; }
        #endregion

        #region CALCULATION SETTINGS
        // Addition to energy frame (only applicable to non-residential buildings) [kWh/m2 year]
        [FieldAttribute(XmlElementName = "add_eframe", ValueType = Attributes.ValueType.Double)]
        public double AdditionToEnergyFrame { get; set; }

        // Calculation type
        [FieldAttribute(XmlElementName = "calc_condition", ValueType = Attributes.ValueType.String)]
        public string CalculationType { get; set; }
        #endregion

        #region SYSTEMS SETTINGS
        // Has mechanical cooling
        [FieldAttribute(XmlElementName = "mech_cooling", ValueType = Attributes.ValueType.Bool)]
        public bool mech_cooling { get; set; }

        // Cooling
        [FieldAttribute(XmlElementName = "has_cooling", ValueType = Attributes.ValueType.OneToOne)]
        public Cooling Cooling { get; set; }

        // Mechanical cooling, fraction of net floor area [0-1]
        [FieldAttribute(XmlElementName = "cooling_frac", ValueType = Attributes.ValueType.Double)]
        public double Cooling_Fraction { get; set; }

        // Has heat distribution system (only applicable to electric heating)
        [FieldAttribute(XmlElementName = "heat_dist", ValueType = Attributes.ValueType.Bool)]
        public bool HasHeatDistributionSystem { get; set; }

        // Heat distribution system
        [FieldAttribute(XmlElementName = "has_heat_distribution", ValueType = Attributes.ValueType.OneToOne)]
        public HeatDistribution HeatDistribution { get; set; }

        [FieldAttribute(XmlElementName = "basic_heat_supply", ValueType = Attributes.ValueType.String)]
        public string HeatSupplyType { get; set; }
        #endregion

        #region CLIMATE SCREEN
        // Transparent constructions [windows, doors, glazing units etc..]
        [FieldAttribute(XmlElementName = "has_transp_const", ValueType = Attributes.ValueType.OneToMany)]
        public List<TransparentConstruction> TransparentConstructions { get; set; }

        // Opaque constructions [walls, roofs etc..]
        [FieldAttribute(XmlElementName = "has_opaque_const", ValueType = Attributes.ValueType.OneToMany)]
        public List<OpaqueConstruction> OpaqueConstructions { get; set; }

        // Cold bridges [foundation, windows etc..]
        [FieldAttribute(XmlElementName = "has_cold_bridge", ValueType = Attributes.ValueType.OneToMany)]
        public List<ColdBridge> ColdBridges { get; set; }
        #endregion

        #region BUILDING OCCUPANCY & USAGE
        [FieldAttribute(XmlElementName = "has_lighting", ValueType = Attributes.ValueType.OneToOne)]
        public Lighting Lighting { get; set; }

        [FieldAttribute(XmlElementName = "has_ventilation", ValueType = Attributes.ValueType.OneToMany)]
        public List<Ventilation> Ventilation { get; set; }

        [FieldAttribute(XmlElementName = "has_usage", ValueType = Attributes.ValueType.OneToOne)]
        public Usage Usage { get; set; }
        #endregion

        #region DOMESTIC HOT WATER
        [FieldAttribute(XmlElementName = "has_hot_water", ValueType = Attributes.ValueType.OneToOne)]
        public DhwSystem DhwSystem { get; set; }

        [FieldAttribute(XmlElementName = "has_el_heater", ValueType = Attributes.ValueType.OneToOne)]
        public DhwElectricHeater ElectricHeater { get; set; }

        [FieldAttribute(XmlElementName = "has_gas_heater", ValueType = Attributes.ValueType.OneToOne)]
        public DhwGasHeater GasHeater { get; set; }
        #endregion

        public string has_unheated_space { get; set; }
        public string has_heating_systems { get; set; }
        public string has_comments { get; set; }
        public string has_heated_room { get; set; }
    }

    public static class BuildingTypes
    {
        public const string
            Detached = ".FTYPE.",
            Nondetached = ".STYPE.",
            MultiStorey = ".ETYPE.",
            Store = ".LTYPE.",
            Other = ".ATYPE.";
    }

    public static class CalculationTypes
    {
        public const string
            Certification = ".STANDARD.",
            CertificationReference = ".STDREF.",
            ActualConditions = ".ACTUAL.",
            ReferenceBuilding = ".REF.",
            SavingsProposal = ".SAVINGS.",
            Other = ".OTHER.";
    }

    public static class HeatSupplyTypes
    {
        public const string
            Boiler = ".SUP_BOILER.",
            DistrictHeating = ".SUP_DISTRICT.",
            BlockHeating = ".SUP_BLOCK.",
            Electricity = ".SUP_EL.";
    }
}
