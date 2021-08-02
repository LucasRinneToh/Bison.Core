﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements.HeatingSystems
{
    [ModelAttribute(ElementName = "HEATING_SYSTEMS")]
    public class HeatingSystems : BeElement
    {
        public HeatingSystems()
        {
            this.id = null;
            this.SolarCollector = null;
            this.PvCells = new List<PhotovoltaicCell>();
            this.Boilers = new List<Boiler>();
            this.DistrictHeatExchanger = null;
            this.SupplementalRoomHeating = null;
        }

        [FieldAttribute(XmlElementName = "has_solar_collector", ValueType = Attributes.ValueType.OneToOne)]
        public SolarCollector SolarCollector { get; set; }

        [FieldAttribute(XmlElementName = "has_pv_cell", ValueType = Attributes.ValueType.OneToMany)]
        public List<PhotovoltaicCell> PvCells { get; set; }

        [FieldAttribute(XmlElementName = "has_boiler", ValueType = Attributes.ValueType.OneToMany)]
        public List<Boiler> Boilers { get; set; }

        [FieldAttribute(XmlElementName = "has_d_h_exch", ValueType = Attributes.ValueType.OneToOne)]
        public DistrictHeatExchanger DistrictHeatExchanger { get; set; }

        [FieldAttribute(XmlElementName = "has_sup_room_heat", ValueType = Attributes.ValueType.OneToOne)]
        public SupplementalRoomHeating SupplementalRoomHeating { get; set; }
    }
}
