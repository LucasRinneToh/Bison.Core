﻿using System;

namespace Bison.Core.BE18.Attributes
{
    public enum ValueType
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
    public class FieldAttribute : Attribute
    {
        public string XmlElementName { get; set; }
        public ValueType ValueType { get; set; }
        public string NullValue { get; set; } = null;
    }
}
