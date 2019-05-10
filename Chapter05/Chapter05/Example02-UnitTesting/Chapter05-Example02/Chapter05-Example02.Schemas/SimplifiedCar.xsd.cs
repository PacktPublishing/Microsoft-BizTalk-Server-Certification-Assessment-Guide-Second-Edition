namespace Chapter05_Example02.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Chapter05_Example02.Schemas.SimplifiedCar",@"Car")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Car"})]
    public sealed class SimplifiedCar : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Chapter05_Example02.Schemas.SimplifiedCar"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Chapter05_Example02.Schemas.SimplifiedCar"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Car"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RegistrationNo"" type=""xs:string"" />
        <xs:element name=""FuelTankCapacity"" type=""xs:int"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Litres"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""FuelConsumption"" type=""xs:decimal"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Litres per metric mile."" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""OperationalRange"" type=""xs:int"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Metric Miles"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SimplifiedCar() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Car";
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
