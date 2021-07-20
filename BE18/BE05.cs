using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bison.Core.BE18
{
    public class BE05 : BeElement
    {
        public Building has_building { get; set; }
        public string has_climate { get; set; }

        public BE05(string rid)
        {
            this.rid = rid;
            id = "Be18, version 9.18.1.4";
        }
    }
}
