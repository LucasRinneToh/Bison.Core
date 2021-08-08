using System;
using System.Collections.Generic;
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
        // Unique identifier (limited to 10-characters with '#'-prefix)
        [FieldAttribute(XmlElementName = "rid", ValueType = Attributes.ValueType.PrimaryKey)]
        public int Rid { get; set; }

        // Common (non-unique) property for all elements
        [FieldAttribute(XmlElementName = "id", ValueType = Attributes.ValueType.String)]
        public string id { get; set; }


        public BeElement(int rid = -1)
        {
            if (rid == -1)
            {
                Random random = new Random();
                int randomRid = random.Next(0, 10000000);
                this.Rid = randomRid;
            } else
            {
                this.Rid = rid;
            }
        }

        private bool PropertyHasAttribute(PropertyInfo property)
        {
            var attribute = property.GetCustomAttribute(typeof(FieldAttribute));
            return (attribute == null ? false : true);
        }

        private string SerializeProperty(PropertyInfo property, Attributes.ValueType type, string nullValue)
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
                        return "#" + ((BeElement)propertyValue).Rid;
                    case Attributes.ValueType.OneToMany:
                        IEnumerable<BeElement> instances = (IEnumerable<BeElement>)propertyValue;
                        List<string> rids = new List<string>();
                        foreach (BeElement instance in instances)
                        {
                            rids.Add("#" + instance.Rid);
                        }
                        return (rids.Count > 0 ? String.Join(" ", rids) : string.Empty);
                    default:
                        throw new InvalidOperationException("Field attribute 'value type' has not been defined");
                }
            } else
            {
                return nullValue;
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
                    string nullValue = attribute.NullValue;

                    // Get property value
                    var propertyValue = property.GetValue(this, null);

                    if (type == Attributes.ValueType.PrimaryKey) { 
                        element.SetAttribute("rid", "#" + Rid.ToString()); 
                    } 
                    else {
                        if (propertyValue != null)
                        {
                            string elementValue = SerializeProperty(property, type, nullValue);
                            XmlElement childNode = document.CreateElement(attribute.XmlElementName);
                            if (!string.IsNullOrEmpty(elementValue))
                            {
                                childNode.InnerText = elementValue;
                            }
                            element.AppendChild(childNode);

                            // Handle iteration through children
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
                        } else
                        {
                            XmlElement childNode = document.CreateElement(attribute.XmlElementName);
                            childNode.InnerText = nullValue;
                            element.AppendChild(childNode);
                        }
                    }
                }
            }
        }
    }
}
