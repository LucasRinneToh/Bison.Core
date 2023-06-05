using System;

namespace Bison.Core.BE18.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ModelAttribute : Attribute
    {
        public string ElementName { get; set; }
    }
}
