﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace Zahar.SqlClient.Mapping {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="Zahar.SqlClient.Mapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="Zahar.SqlClient.Mapping", IsNullable=false)]
    public partial class Mapping {
        
        private Procedure[] proceduresField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Add", IsNullable=false)]
        public Procedure[] Procedures {
            get {
                return this.proceduresField;
            }
            set {
                this.proceduresField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="Zahar.SqlClient.Mapping")]
    public partial class Procedure {
        
        private string schemaField;
        
        private string nameField;
        
        private bool ignoreQueryResultField;
        
        private bool ignoreQueryResultFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Schema {
            get {
                return this.schemaField;
            }
            set {
                this.schemaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IgnoreQueryResult {
            get {
                return this.ignoreQueryResultField;
            }
            set {
                this.ignoreQueryResultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IgnoreQueryResultSpecified {
            get {
                return this.ignoreQueryResultFieldSpecified;
            }
            set {
                this.ignoreQueryResultFieldSpecified = value;
            }
        }
    }
}
