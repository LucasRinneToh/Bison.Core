using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18.Elements
{
    [ModelAttribute(ElementName = "DESCRIPT")]
    public class Description : BeElement
    {
        public Description(
            string name = null,
            string bbr = null,
            string owner = null,
            string address1 = null,
            string address2 = null,
            string address3 = null
            )
        {
            this.id = name;
            this.BBR = bbr;
            this.Owner = owner;
            this.Address1 = address1;
            this.Address2 = address2;
            this.Address3 = address3;
        }

        // bbr-code
        [FieldAttribute(XmlElementName = "bbr", ValueType = Attributes.ValueType.String)]
        public string BBR { get; set; }

        // Owner
        [FieldAttribute(XmlElementName = "owner", ValueType = Attributes.ValueType.String)]
        public string Owner { get; set; }

        // Address line 1
        [FieldAttribute(XmlElementName = "addr1", ValueType = Attributes.ValueType.String)]
        public string Address1 { get; set; }

        // Address line 2
        [FieldAttribute(XmlElementName = "addr2", ValueType = Attributes.ValueType.String)]
        public string Address2 { get; set; }

        // Address line 3
        [FieldAttribute(XmlElementName = "addr3", ValueType = Attributes.ValueType.String)]
        public string Address3 { get; set; }

    }
}
