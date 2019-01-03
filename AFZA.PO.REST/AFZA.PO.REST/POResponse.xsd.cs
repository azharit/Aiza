namespace AFZA.PO.REST {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://AFZA.PO.REST.POResponse",@"ProcessedPO")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ProcessedPO"})]
    public sealed class POResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://AFZA.PO.REST.POResponse"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://AFZA.PO.REST.POResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ProcessedPO"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Result"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public POResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ProcessedPO";
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
