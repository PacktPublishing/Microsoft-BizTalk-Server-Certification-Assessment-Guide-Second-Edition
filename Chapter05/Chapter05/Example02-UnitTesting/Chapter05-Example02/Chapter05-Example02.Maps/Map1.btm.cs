namespace Chapter05_Example02.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Chapter05_Example02.Schemas.SimplifiedCar", typeof(global::Chapter05_Example02.Schemas.SimplifiedCar))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Chapter05_Example02.Schemas.SimplifiedCar", typeof(global::Chapter05_Example02.Schemas.SimplifiedCar))]
    public sealed class Map1 : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://Chapter05_Example02.Schemas.SimplifiedCar"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Car"" />
  </xsl:template>
  <xsl:template match=""/ns0:Car"">
    <ns0:Car>
      <RegistrationNo>
        <xsl:value-of select=""RegistrationNo/text()"" />
      </RegistrationNo>
      <FuelTankCapacity>
        <xsl:value-of select=""FuelTankCapacity/text()"" />
      </FuelTankCapacity>
      <FuelConsumption>
        <xsl:value-of select=""FuelConsumption/text()"" />
      </FuelConsumption>
      <xsl:if test=""OperationalRange"">
        <OperationalRange>
          <xsl:value-of select=""OperationalRange/text()"" />
        </OperationalRange>
      </xsl:if>
    </ns0:Car>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Chapter05_Example02.Schemas.SimplifiedCar";
        
        private const global::Chapter05_Example02.Schemas.SimplifiedCar _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Chapter05_Example02.Schemas.SimplifiedCar";
        
        private const global::Chapter05_Example02.Schemas.SimplifiedCar _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Chapter05_Example02.Schemas.SimplifiedCar";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Chapter05_Example02.Schemas.SimplifiedCar";
                return _TrgSchemas;
            }
        }
    }
}
