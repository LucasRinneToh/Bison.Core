using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BeElement
    {
        [FieldAttribute(XmlElementName = "rid", ValueType = Attributes.ValueType.PrimaryKey)]
        public int rid { get; set; } // Unique identifier (limited to 10-characters with '#'-prefix)
        [FieldAttribute(XmlElementName = "id", ValueType = Attributes.ValueType.String)]
        public string id { get; set; } // Common (non-unique) property for all elements

        public BeElement()
        {
            this.rid = 1;
        }

        private bool PropertyHasAttribute(PropertyInfo property)
        {
            var attribute = property.GetCustomAttribute(typeof(FieldAttribute));
            return (attribute == null ? false : true);
        }

        private string SerializeProperty(PropertyInfo property, Attributes.ValueType type)
        {
            var propertyValue = property.GetValue(this, null);
            if (propertyValue != null)
            {
                switch (type)
                {
                    case Attributes.ValueType.String:
                        return (string)propertyValue;
                    case Attributes.ValueType.Double:
                        return propertyValue.ToString();
                    case Attributes.ValueType.Int:
                        return propertyValue.ToString();
                    case Attributes.ValueType.Bool:
                        return ((bool)propertyValue == true ? ".T." : ".F.");
                    case Attributes.ValueType.OneToOne:
                        return "#" + ((BeElement)propertyValue).rid;
                    case Attributes.ValueType.OneToMany:
                        IEnumerable<BeElement> instances = (IEnumerable<BeElement>)propertyValue;
                        List<string> rids = new List<string>();
                        foreach (BeElement instance in instances)
                        {
                            rids.Add("#" + instance.rid);
                        }
                        return (rids.Count > 0 ? String.Join(" ", rids) : string.Empty);
                    default:
                        throw new InvalidOperationException("Field attribute 'value type' has not been defined");
                }
            } else
            {
                return string.Empty;
            }
        }

        public void ToXml(XmlDocument document, XmlElement rootNode)
        {
            // Get Element name
            ModelAttribute modelAttribute = (ModelAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(ModelAttribute));
            string elementName = string.Empty;
            if (modelAttribute == null) { 
                throw new InvalidOperationException("Attribute not applied to model"); 
            } else { 
                elementName = modelAttribute.ElementName; 
            }

            // Create node
            XmlElement element = document.CreateElement(string.Empty, elementName, string.Empty);
            rootNode.AppendChild(element);

            // Add class props as children to node
            PropertyInfo[] properties = GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (PropertyHasAttribute(property))
                {
                    // Convert property value to XML output
                    FieldAttribute attribute = property.GetCustomAttribute<FieldAttribute>();
                    Attributes.ValueType type = attribute.ValueType;

                    // Get property value
                    var propertyValue = property.GetValue(this, null);

                    if (type == Attributes.ValueType.PrimaryKey) { 
                        element.SetAttribute("rid", "#" + rid.ToString()); 
                    } 
                    else {
                        if (propertyValue != null)
                        {
                            string elementValue = SerializeProperty(property, type);
                            XmlElement childNode = document.CreateElement(attribute.XmlElementName);
                            if (!string.IsNullOrEmpty(elementValue))
                            {
                                childNode.InnerText = elementValue;
                            }
                            element.AppendChild(childNode);

                            if (type == Attributes.ValueType.OneToOne)
                            {
                                BeElement child = (BeElement)property.GetValue(this, null);
                                child.ToXml(document, rootNode);
                            }

                            if (type == Attributes.ValueType.OneToMany)
                            {
                                IEnumerable<BeElement> children = (IEnumerable<BeElement>)property.GetValue(this, null);
                                foreach (BeElement child in children)
                                {
                                    child.ToXml(document, rootNode);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
