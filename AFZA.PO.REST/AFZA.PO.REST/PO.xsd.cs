namespace AFZA.PO.REST {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://tempuri.org/PurchaseOrderSchema.xsd",@"purchaseOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"purchaseOrder"})]
    public sealed class PO : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsd:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://tempuri.org/PurchaseOrderSchema.xsd"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/PurchaseOrderSchema.xsd"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <xsd:annotation>
    <xsd:appinfo>
      <schemaInfo root_reference=""purchaseOrder"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xsd:appinfo>
  </xsd:annotation>
  <xsd:element name=""comment"" type=""xsd:string"" />
  <xsd:element name=""purchaseOrder"" type=""tns:PurchaseOrderType"" />
  <xsd:complexType name=""USAddress"">
    <xsd:annotation>
      <xsd:documentation>
        Purchase order schema for Example.Microsoft.com.
      </xsd:documentation>
    </xsd:annotation>
    <xsd:sequence>
      <xsd:element name=""name"" type=""xsd:string"" />
      <xsd:element name=""street"" type=""xsd:string"" />
      <xsd:element name=""city"" type=""xsd:string"" />
      <xsd:element name=""state"" type=""xsd:string"" />
      <xsd:element name=""zip"" type=""xsd:decimal"" />
    </xsd:sequence>
    <xsd:attribute fixed=""US"" name=""country"" type=""xsd:NMTOKEN"" />
  </xsd:complexType>
  <xsd:simpleType name=""SKU"">
    <xsd:restriction base=""xsd:string"">
      <xsd:pattern value=""\d{3}\w{3}"" />
    </xsd:restriction>
  </xsd:simpleType>
  <xsd:complexType name=""Items"">
    <xsd:sequence>
      <xsd:element minOccurs=""0"" maxOccurs=""unbounded"" name=""item"">
        <xsd:complexType>
          <xsd:sequence>
            <xsd:element name=""productName"" type=""xsd:string"" />
            <xsd:element name=""quantity"">
              <xsd:simpleType>
                <xsd:restriction base=""xsd:positiveInteger"">
                  <xsd:minInclusive value=""1"" />
                  <xsd:maxExclusive value=""100"" />
                </xsd:restriction>
              </xsd:simpleType>
            </xsd:element>
            <xsd:element name=""USPrice"" type=""xsd:decimal"" />
            <xsd:element ref=""tns:comment"" />
            <xsd:element minOccurs=""0"" name=""shipDate"" type=""xsd:date"" />
          </xsd:sequence>
          <xsd:attribute name=""partNum"" type=""tns:SKU"" />
        </xsd:complexType>
      </xsd:element>
    </xsd:sequence>
  </xsd:complexType>
  <xsd:complexType name=""PurchaseOrderType"">
    <xsd:sequence>
      <xsd:element name=""shipTo"" type=""tns:USAddress"" />
      <xsd:element name=""billTo"" type=""tns:USAddress"" />
      <xsd:element minOccurs=""0"" ref=""tns:comment"" />
      <xsd:element name=""items"" type=""tns:Items"" />
    </xsd:sequence>
    <xsd:attribute name=""orderDate"" type=""xsd:date"" />
    <xsd:attribute name=""confirmDate"" type=""xsd:date"" use=""required"" />
  </xsd:complexType>
</xsd:schema>";
        
        public PO() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "purchaseOrder";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
