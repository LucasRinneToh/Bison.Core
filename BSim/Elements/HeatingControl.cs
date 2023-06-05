using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "HEATING_CTRL")]
    public class HeatingControl : BSimElement
    {
        public HeatingControl(
            string name = "Heating Control",
            double factor = 1,
            double setPoint = 25,
            double designTemp = -12,
            double minPower = 0.5,
            double teMin = 17,
            string sensor = "$"
            )
        {
            this.Name = name;
            this.Factor = factor;
            this.SetPoint = setPoint;
            this.DesignTemp = designTemp;
            this.MinPower = minPower;
            this.TeMin = teMin;
            this.Sensor = sensor;
        }

        [BSimXmlModelProperty(Name = "factor", Type = BSimValueType.Double)]
        public double Factor { get; set; }

        [BSimXmlModelProperty(Name = "set_point", Type = BSimValueType.Double)]
        public double SetPoint { get; set; }

        [BSimXmlModelProperty(Name = "design_temp", Type = BSimValueType.Double)]
        public double DesignTemp { get; set; }

        [BSimXmlModelProperty(Name = "min_power", Type = BSimValueType.Double)]
        public double MinPower { get; set; }

        [BSimXmlModelProperty(Name = "te_min", Type = BSimValueType.Double)]
        public double TeMin { get; set; }

        [BSimXmlModelProperty(Name = "sensor", Type = BSimValueType.String)]
        public string Sensor { get; set; }
    }
}
