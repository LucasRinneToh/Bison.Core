using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "GROUND")]
    public class Ground : BSimElement
    {
        public Ground(
            string name = "Ground",
            double maxTemp = 12,
            double maxHumidity = 0.0058,
            string maxAtDate = "10.8",
            double minTemp = 9,
            double minHumidity = 0.004

            )
        {
            this.Name = name;
            this.Cell = new Cell("Groundcell", 0);
            this.MaxTemp = maxTemp;
            this.MaxHumidity = maxHumidity;
            this.MaxAtDate = maxAtDate;
            this.MinTemp = minTemp;
            this.MinHumidity = minHumidity;
        }


        [BSimXmlModelProperty(Name = "represented_by_cell", Type = BSimValueType.OneToOne)]
        public Cell Cell { get; set; }

        [BSimXmlModelProperty(Name = "max_temp", Type = BSimValueType.Double)]
        public double MaxTemp { get; set; }

        [BSimXmlModelProperty(Name = "max_humidity", Type = BSimValueType.Double)]
        public double MaxHumidity { get; set; }

        [BSimXmlModelProperty(Name = "max_at_date", Type = BSimValueType.String)]
        public string MaxAtDate { get; set; }

        [BSimXmlModelProperty(Name = "min_temp", Type = BSimValueType.Double)]
        public double MinTemp { get; set; }

        [BSimXmlModelProperty(Name = "min_humidity", Type = BSimValueType.Double)]
        public double MinHumidity { get; set; }
    }
}
