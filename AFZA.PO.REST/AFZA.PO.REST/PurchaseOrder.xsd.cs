namespace AFZA.PO.REST {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://AFZA.com/PurchaseOrderSchema.xsd",@"purchaseOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"purchaseOrder"})]
    public sealed class PurchaseOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://AFZA.com/PurchaseOrderSchema.xsd"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://AFZA.com/PurchaseOrderSchema.xsd"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""purchaseOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""items"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""item"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""productName"" type=""xs:string"" />
                    <xs:element name=""quantity"" type=""xs:unsignedByte"" />
                    <xs:element name=""USPrice"" type=""xs:decimal"" />
                    <xs:element name=""comment"" type=""xs:string"" />
                    <xs:element name=""shipDate"" type=""xs:date"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PurchaseOrder() {
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
