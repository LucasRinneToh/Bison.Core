using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "PV_CELL")]
    public class PhotovoltaicCell : BeElement
    {
        public PhotovoltaicCell(
            string name = "New PV cell",
            double area = 0,
            double orientation = 0,
            double slope = 0,
            double horizon = 0,
            double sidefinLeft = 0,
            double sidefinRight = 0,
            double peakPower = 0,
            double effeciency = 0
            )
        {
            this.id = name;
            this.Sfb = null;
            this.Area = area;
            this.Orientation = orientation;
            this.Slope = slope;
            this.Horizon = horizon;
            this.SidefinLeft = sidefinLeft;
            this.SidefinRight = sidefinRight;
            this.PeakPower = peakPower;
            this.Efficiency = effeciency;
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

        // Sidefin left, horizontal shading [deg]
        [FieldAttribute(XmlElementName = "sidefin_left", ValueType = Attributes.ValueType.Double)]
        public double SidefinLeft { get; set; }

        // Sidefin right, horizontal shading [deg]
        [FieldAttribute(XmlElementName = "sidefin_right", ValueType = Attributes.ValueType.Double)]
        public double SidefinRight { get; set; }

        // Peak power [kW/m2]
        [FieldAttribute(XmlElementName = "peak_power", ValueType = Attributes.ValueType.Double)]
        public double PeakPower { get; set; }

        // Effeciency [-]
        [FieldAttribute(XmlElementName = "efficiency", ValueType = Attributes.ValueType.Double)]
        public double Efficiency { get; set; }
    }
}
