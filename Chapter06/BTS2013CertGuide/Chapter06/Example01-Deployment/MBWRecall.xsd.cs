namespace Example01_Deployment {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Example01_Deployment.MBWRecall",@"MBWRecall")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MBWRecall"})]
    public sealed class MBWRecall : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Example01_Deployment.MBWRecall"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Example01_Deployment.MBWRecall"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""MBWRecall"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PartID"" type=""xs:string"" />
        <xs:element name=""PartName"" type=""xs:string"" />
        <xs:element name=""DateRecalled"" type=""xs:date"" />
        <xs:element name=""RecallReason"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public MBWRecall() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "MBWRecall";
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
