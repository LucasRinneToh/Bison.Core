using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    /// <summary>
    /// This is the root element for Be18 projects
    /// </summary>
    [Model(ElementName = "BE05")]
    public class BE05 : BeElement
    {
        public BE05()
        {
            id = "Be18, version 9.18.1.4";
            Building = new Building();
            Climate = "$";
        }

        // Building
        [Field(XmlElementName = "has_building", ValueType = ValueType.OneToOne)]
        public Building Building { get; set; }

        // Climate // TO-DO: Implement climate
        [Field(XmlElementName = "has_climate", ValueType = ValueType.String)]
        public string Climate { get; set; }
    }
}
