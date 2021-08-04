using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18
{
    [ModelAttribute(ElementName = "OPAQUE_CONST")]
    public class OpaqueConstruction : BeElement
    {
        public double area { get; set; }
        public double u { get; set; }
        public double td_in { get; set; }
        public double td_out { get; set; }
        public double has_b { get; set; }
        public string sfb { get; set; }

        public OpaqueConstruction(
            string _name = "New construction",
            double _area = 0,
            double _u = 0.15,
            double _td_in = 20,
            double _td_out = -12,
            double _has_b = 1,
            string _sfb = null
            )
        {
            id = _name;
            area = _area;
            u = _u;
            td_in = _td_in;
            td_out = _td_out;
            has_b = _has_b;
            sfb = _sfb;
        }
    }
}
