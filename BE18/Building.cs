using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18
{
    [ModelAttribute(ElementName = "BUILDING")]
    public class Building : BeElement
    {
        public Building()
        {
            id = "New Building";
            Heated_Floor_Area = 0;
            Setpoint_Heating = 20;
            Setpoint_Venting = 23;
            Setpoint_Night_Vent = 24;
            Setpoint_Mech_Cooling = 25;
            HeatCapacity = 40;
            Dim_Room_Temp = 20;
            UsagePerWeek = 168;
            StartTime = 0;
            EndTime = 24;
            DimOutdoorTemp = -12;
            mech_cooling = false;
            Has_Electric_Radiators = false;
            Has_Solar_Heating = false;
            Has_Heatpump = false;
            Has_PV_Panels = false;
            Rotation = 0;
            AdditionToEnergyFrame = 0;
            Has_Oven = false;
            HasHeatDistributionSystem = false;
            Dwellings = 1;
            Has_Windmill = false;
            th_store = 15;
            dim_store_temp = 15;
            Cooling_Fraction = 0;
            ae2 = 0;
            Heated_Basement_Area = 0;
            has_btype = BuildingType.AType;
            basic_heat_supply = ".SUP_DISTRICT.";
            calc_condition = ".ACTUAL.";
            TransparentConstructions = new List<TransparentConstruction>();
            OpaqueConstructions = new List<OpaqueConstruction>();
            has_unheated_space = "$";
            Ventilation = new List<Ventilation>();
            Usage = null;
            Lighting = null;
            ColdBridges = new List<ColdBridge>();
            has_heating_systems = "$";
            has_cooling = "$";
            has_heat_distribution = "$";
            has_hot_water = "$";
            has_gas_heater = "$";
            has_el_heater = "$";
            has_descript = "$";
            has_comments = "$";
            has_heated_room = "$";
        }

        // BASIC BUILDING INFO //

        // Heated floor area [m2]
        [FieldAttribute(XmlElementName = "ae", ValueType = Attributes.ValueType.Double)]
        public double Heated_Floor_Area { get; set; }

        public double ae2 { get; set; }

        // Heated basement area [m2]
        [FieldAttribute(XmlElementName = "ae3", ValueType = Attributes.ValueType.Double)]
        public double Heated_Basement_Area { get; set; } 

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
        public string has_btype { get; set; }

        // Number of building units
        [FieldAttribute(XmlElementName = "dwellings", ValueType = Attributes.ValueType.Double)]
        public int Dwellings { get; set; }


        // TEMPERATURE SETTINGS //

        // Room heating setpoint [*C]
        [FieldAttribute(XmlElementName = "th_heat", ValueType = Attributes.ValueType.Double)]
        public double Setpoint_Heating { get; set; }

        // Venting setpoint [*C]
        [FieldAttribute(XmlElementName = "th_setp", ValueType = Attributes.ValueType.Double)]
        public double Setpoint_Venting { get; set; }

        // Night ventilation setpoint [*C]
        [FieldAttribute(XmlElementName = "th_nv", ValueType = Attributes.ValueType.Double)]
        public double Setpoint_Night_Vent { get; set; }

        // Mechanical cooling setpoint [*C]
        [FieldAttribute(XmlElementName = "th_cool", ValueType = Attributes.ValueType.Double)]
        public double Setpoint_Mech_Cooling { get; set; }

        // Dimensioning indoor temperature [*C]
        [FieldAttribute(XmlElementName = "dim_room_temp", ValueType = Attributes.ValueType.Double)]
        public double Dim_Room_Temp { get; set; }
        
        // Dimensioning outdoor temperature [*C]
        [FieldAttribute(XmlElementName = "tu", ValueType = Attributes.ValueType.Double)]
        public double DimOutdoorTemp { get; set; }

        public double th_store { get; set; }
        public double dim_store_temp { get; set; }


        // HEATING SYSTEM SELECTORS //

        // Has electric radiators (1. El-radiator)
        [FieldAttribute(XmlElementName = "sup_heating", ValueType = Attributes.ValueType.Bool)]
        public bool Has_Electric_Radiators { get; set; }

        // Has oven heating (2. Brændeovne, gasvarmere etc.)
        [FieldAttribute(XmlElementName = "sup_oven", ValueType = Attributes.ValueType.Bool)]
        public bool Has_Oven { get; set; }
        
        // Has solar heating (3. Solvarme)
        [FieldAttribute(XmlElementName = "solarpanel", ValueType = Attributes.ValueType.Bool)]
        public bool Has_Solar_Heating { get; set; }

        // Has heat-pump (4. Varmepumpe)
        [FieldAttribute(XmlElementName = "heatpump", ValueType = Attributes.ValueType.Bool)]
        public bool Has_Heatpump { get; set; }

        // Has photovoltaics (5. Solceller)
        [FieldAttribute(XmlElementName = "pv_panel", ValueType = Attributes.ValueType.Bool)]
        public bool Has_PV_Panels { get; set; }

        [FieldAttribute(XmlElementName = "windmill", ValueType = Attributes.ValueType.Bool)]
        public bool Has_Windmill { get; set; }

        // CALCULATION SETTINGS //
        
        // Addition to energy frame (only applicable to non-residential buildings) [kWh/m2 year]
        [FieldAttribute(XmlElementName = "add_eframe", ValueType = Attributes.ValueType.Double)]
        public double AdditionToEnergyFrame { get; set; }

        public string calc_condition { get; set; }

        // SYSTEMS SETTINGS //

        // Has mechanical cooling
        [FieldAttribute(XmlElementName = "mech_cooling", ValueType = Attributes.ValueType.Bool)]
        public bool mech_cooling { get; set; }

        // Mechanical cooling, fraction of net floor area [0-1]
        [FieldAttribute(XmlElementName = "cooling_frac", ValueType = Attributes.ValueType.Double)]
        public double Cooling_Fraction { get; set; }

        // Has heat distribution system (only applicable to electric heating)
        [FieldAttribute(XmlElementName = "heat_dist", ValueType = Attributes.ValueType.Bool)]
        public bool HasHeatDistributionSystem { get; set; }

        public string basic_heat_supply { get; set; }




        // BUILDING PARTS //

        // Transparent constructions [windows, doors, glazing units etc..]
        [FieldAttribute(XmlElementName = "has_transp_const", ValueType = Attributes.ValueType.OneToMany)]
        public List<TransparentConstruction> TransparentConstructions { get; set; }

        // Opaque constructions [walls, roofs etc..]
        [FieldAttribute(XmlElementName = "has_opaque_const", ValueType = Attributes.ValueType.OneToMany)]
        public List<OpaqueConstruction> OpaqueConstructions { get; set; }

        // Cold bridges [foundation, windows etc..]
        [FieldAttribute(XmlElementName = "has_cold_bridge", ValueType = Attributes.ValueType.OneToMany)]
        public List<ColdBridge> ColdBridges { get; set; }

        // BUILDING OCCUPANCY & USAGE //
        
        [FieldAttribute(XmlElementName = "has_lighting", ValueType = Attributes.ValueType.OneToOne)]
        public Lighting Lighting { get; set; }

        [FieldAttribute(XmlElementName = "has_ventilation", ValueType = Attributes.ValueType.OneToMany)]
        public List<Ventilation> Ventilation { get; set; }

        [FieldAttribute(XmlElementName = "has_usage", ValueType = Attributes.ValueType.OneToOne)]
        public Usage Usage { get; set; }



        public string has_unheated_space { get; set; }
        
        public string has_heating_systems { get; set; }
        public string has_cooling { get; set; }
        public string has_heat_distribution { get; set; }
        public string has_hot_water { get; set; }
        public string has_gas_heater { get; set; }
        public string has_el_heater { get; set; }
        public string has_descript { get; set; }
        public string has_comments { get; set; }
        public string has_heated_room { get; set; }
    }

    public static class BuildingType
    {
        public const string
            AType = ".ATYPE.";
    }

}
