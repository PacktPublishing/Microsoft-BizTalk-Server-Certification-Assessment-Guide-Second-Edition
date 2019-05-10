namespace Example01_Deployment {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Example01_Deployment.HWLCRecall",@"HWLCRecall")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Example01_Deployment.PropertySchema.RecallID), XPath = @"/*[local-name()='HWLCRecall' and namespace-uri()='http://Example01_Deployment.HWLCRecall']/*[local-name()='RecallID' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"HWLCRecall"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Example01_Deployment.PropertySchema.PropertySchema", typeof(global::Example01_Deployment.PropertySchema.PropertySchema))]
    public sealed class HWLCRecall : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Example01_Deployment.HWLCRecall"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Example01_Deployment.PropertySchema"" targetNamespace=""http://Example01_Deployment.HWLCRecall"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Example01_Deployment.PropertySchema"" location=""Example01_Deployment.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""HWLCRecall"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:RecallID"" xpath=""/*[local-name()='HWLCRecall' and namespace-uri()='http://Example01_Deployment.HWLCRecall']/*[local-name()='RecallID' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RecallID"" type=""xs:string"" />
        <xs:element name=""RecallReason"" type=""xs:string"" />
        <xs:element name=""PartName"" type=""xs:string"" />
        <xs:element name=""RecallDate"" type=""xs:date"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public HWLCRecall() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "HWLCRecall";
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
