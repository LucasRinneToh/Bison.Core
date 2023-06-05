using System;

namespace Bison.Core.BSim.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BSimXmlModel : Attribute
    {
        public string Name { get; set; }
    }
}
