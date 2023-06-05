using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bison.Core.BSim.Attributes
{
    public enum BSimValueType
    {
        PrimaryKey,
        String,
        Double,
        Int,
        Bool,
        OneToOne,
        OneToMany,
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class BSimXmlModelProperty : Attribute
    {
        public string Name { get; set; }
        public BSimValueType Type { get; set; }
        public string NullValue { get; set; } = null;
    }
}
