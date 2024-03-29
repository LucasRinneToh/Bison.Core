﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "VENTILATION")]
    public class Ventilation : BeElement
    {
        public Ventilation(
            string name = "New ventilation",
            double area = 0,
            double q_mech_winter_day = 0,
            double q_mech_summer_day = 0,
            double q_mech_summer_night = 0,
            double q_nat_winter_day = 0,
            double q_nat_winter_night = 0,
            double q_nat_summer_day = 0,
            double q_nat_summer_night = 0,
            double heatEffeciency = 0.85,
            double inletTemp = 18,
            bool hasElReheater = false,
            double SEL = 800,
            double usageFactor = 1
            )
        {
            this.id = name;
            this.Area = area;
            this.q_mech_winter_day = q_mech_winter_day;
            this.q_mech_summer_day = q_mech_summer_day;
            this.q_mech_summer_night = q_mech_summer_night;
            this.q_nat_winter_day = q_nat_winter_day;
            this.q_nat_winter_night = q_nat_winter_night;
            this.q_nat_summer_day = q_nat_summer_day;
            this.q_nat_summer_night = q_nat_summer_night;
            this.HeatEffeciency = heatEffeciency;
            this.InletTemp = inletTemp;
            this.HasElReheater = hasElReheater;
            this.SEL = SEL;
            this.part = 0;
            this.UsageFactor = usageFactor;
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Area [m2]
        [FieldAttribute(XmlElementName = "area", ValueType = Attributes.ValueType.Double)]
        public double Area { get; set; }

        // Mechanical ventilation (winter, occupancy) [L/s*m2]
        [FieldAttribute(XmlElementName = "qvm", ValueType = Attributes.ValueType.Double)]
        public double q_mech_winter_day { get; set; }

        // Mechanical ventilation (summer, occupancy) [L/s*m2]
        [FieldAttribute(XmlElementName = "qvm_day", ValueType = Attributes.ValueType.Double)]
        public double q_mech_summer_day { get; set; }

        // Mechanical ventilation (summer, night) [L/s*m2]
        [FieldAttribute(XmlElementName = "qvm_night", ValueType = Attributes.ValueType.Double)]
        public double q_mech_summer_night { get; set; }

        // Natural ventilation (winter, occupancy) [L/s*m2]
        [FieldAttribute(XmlElementName = "qid", ValueType = Attributes.ValueType.Double)]
        public double q_nat_winter_day { get; set; }

        // Natural ventilation (winter, night) [L/s*m2]
        [FieldAttribute(XmlElementName = "qis", ValueType = Attributes.ValueType.Double)]
        public double q_nat_winter_night { get; set; }

        // Natural ventilation (summer, occupancy) [L/s*m2]
        [FieldAttribute(XmlElementName = "qid_day", ValueType = Attributes.ValueType.Double)]
        public double q_nat_summer_day{ get; set; }

        // Natural ventilation (summer, night) [L/s*m2]
        [FieldAttribute(XmlElementName = "qis_night", ValueType = Attributes.ValueType.Double)]
        public double q_nat_summer_night { get; set; }

        // Heat effeciency (0-1) [-]
        [FieldAttribute(XmlElementName = "nvgv", ValueType = Attributes.ValueType.Double)]
        public double HeatEffeciency { get; set; }

        // Inlet temperatur [*C]
        [FieldAttribute(XmlElementName = "tin", ValueType = Attributes.ValueType.Double)]
        public double InletTemp { get; set; }

        // Has reheater battery?
        [FieldAttribute(XmlElementName = "el_vf", ValueType = Attributes.ValueType.Bool)]
        public bool HasElReheater { get; set; }        

        // Specific fan power (SEL) [kJ/m3]
        [FieldAttribute(XmlElementName = "sel", ValueType = Attributes.ValueType.Double)]
        public double SEL { get; set; }       

        [FieldAttribute(XmlElementName = "part", ValueType = Attributes.ValueType.Double)]
        public double part { get; set; }

        // Usage factor (0-1) [-]
        [FieldAttribute(XmlElementName = "fo", ValueType = Attributes.ValueType.Double)]
        public double UsageFactor { get; set; }
    }
}
