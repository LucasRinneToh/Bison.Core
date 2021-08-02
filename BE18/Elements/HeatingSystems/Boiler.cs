using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements.HeatingSystems
{
    [ModelAttribute(ElementName = "BOILER")]
    public class Boiler : BeElement
    {
        public Boiler(
            string name = "New boiler",
            double units = 1,
            string fuelType = BoilerFuelType.Oil,
            double nominalPower = 0,
            double dhwShare = 0,
            double fullLoad = 1,
            double fullEffeciency = 0.910,
            double fullBoilerTemp = 70,
            double fullCorrection = 0.001,
            double partLoad = 0.3,
            double partEffeciency = 0.910,
            double partBoilerTemp = 35,
            double partCorrection = 0.001,
            double idleLossFactor = 0.01,
            double idleShareToRoom = 0.5,
            double idleTempDifference = 30,
            double idlePower = 0,
            double minBoilerTemp = 60,
            double bFactor = 0,
            double fanPower = 100,
            double auxElPower = 5
            )
        {
            this.id = name;
            this.Sfb = null;
            this.NominalPower = nominalPower;
            this.DHW_Share = dhwShare;
            this.FullLoad = fullLoad;
            this.FullEffeciency = fullEffeciency;
            this.FullBoilerTemp = fullBoilerTemp;
            this.FullCorrection = fullCorrection;
            this.PartLoad = partLoad;
            this.PartEffeciency = partEffeciency;
            this.PartBoilerTemp = partBoilerTemp;
            this.PartCorrection = partCorrection;
            this.IdleLossFactor = idleLossFactor;
            this.IdleShareToRoom = idleShareToRoom;
            this.IdleTempDifference = idleTempDifference;
            this.IdlePower = idlePower;
            this.MinBoilerTemp = minBoilerTemp;
            this.bFactor = bFactor;
            this.FanPower = fanPower;
            this.AuxElPower = auxElPower;
            this.Units = units;
            this.Fuel = fuelType;
        }


        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Nominal power [kW]
        [FieldAttribute(XmlElementName = "nom_eff", ValueType = Attributes.ValueType.Double)]
        public double NominalPower { get; set; }

        // Share of power used for domestic hot water production (0-1) [-]
        [FieldAttribute(XmlElementName = "part_dhw", ValueType = Attributes.ValueType.Double)]
        public double DHW_Share { get; set; }

        // Full load [-]
        [FieldAttribute(XmlElementName = "full_load", ValueType = Attributes.ValueType.Double)]
        public double FullLoad { get; set; }

        // Full effeciency [-]
        [FieldAttribute(XmlElementName = "full_ngn", ValueType = Attributes.ValueType.Double)]
        public double FullEffeciency { get; set; }

        // Full boiler temperature [*C]
        [FieldAttribute(XmlElementName = "full_tgn", ValueType = Attributes.ValueType.Double)]
        public double FullBoilerTemp { get; set; }

        // Full correction [1/*C]
        [FieldAttribute(XmlElementName = "full_fcor", ValueType = Attributes.ValueType.Double)]
        public double FullCorrection { get; set; }

        // Part load [-]
        [FieldAttribute(XmlElementName = "part_load", ValueType = Attributes.ValueType.Double)]
        public double PartLoad { get; set; }

        // Part effeciency [-]
        [FieldAttribute(XmlElementName = "part_ngn", ValueType = Attributes.ValueType.Double)]
        public double PartEffeciency { get; set; }

        // Part boiler temperature [*C]
        [FieldAttribute(XmlElementName = "part_tgn", ValueType = Attributes.ValueType.Double)]
        public double PartBoilerTemp { get; set; }

        // Part correction [1/*C]
        [FieldAttribute(XmlElementName = "part_fcor", ValueType = Attributes.ValueType.Double)]
        public double PartCorrection { get; set; }

        // Idle loss factor [-]
        [FieldAttribute(XmlElementName = "stb_frac", ValueType = Attributes.ValueType.Double)]
        public double IdleLossFactor { get; set; }

        // Idle share to room
        [FieldAttribute(XmlElementName = "stb_rgn", ValueType = Attributes.ValueType.Double)]
        public double IdleShareToRoom { get; set; }

        // Idle temperature difference
        [FieldAttribute(XmlElementName = "stb_dtgn", ValueType = Attributes.ValueType.Double)]
        public double IdleTempDifference { get; set; }

        // Idle power
        [FieldAttribute(XmlElementName = "stb_load", ValueType = Attributes.ValueType.Double)]
        public double IdlePower { get; set; }

        // Minimum boiler temperature [*C]
        [FieldAttribute(XmlElementName = "min_boil_temp", ValueType = Attributes.ValueType.Double)]
        public double MinBoilerTemp { get; set; }

        // b-factor for rooms [-]
        [FieldAttribute(XmlElementName = "b_factor", ValueType = Attributes.ValueType.Double)]
        public double bFactor { get; set; }

        // Fan power [W]
        [FieldAttribute(XmlElementName = "fan_eff", ValueType = Attributes.ValueType.Double)]
        public double FanPower { get; set; }

        // Auxillary electric power 
        [FieldAttribute(XmlElementName = "auto_stb", ValueType = Attributes.ValueType.Double)]
        public double AuxElPower { get; set; }

        // Units (number of boilers) [-]
        [FieldAttribute(XmlElementName = "no", ValueType = Attributes.ValueType.Double)]
        public double Units { get; set; }

        // Fuel type
        [FieldAttribute(XmlElementName = "has_fuel", ValueType = Attributes.ValueType.String)]
        public string Fuel { get; set; }
    }

    public static class BoilerFuelType
    {
        public const string
            Oil = ".FU_OIL.",
            Gas = ".FU_GAS.",
            BioFuel = ".FU_BIO.";
    }
}
