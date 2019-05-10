namespace Example01_Deployment {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Example01_Deployment.MBWRecall", typeof(global::Example01_Deployment.MBWRecall))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Example01_Deployment.HWLCRecall", typeof(global::Example01_Deployment.HWLCRecall))]
    public sealed class MBWRecall_to_HWLCRecall : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://Example01_Deployment.MBWRecall"" xmlns:ns0=""http://Example01_Deployment.HWLCRecall"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:MBWRecall"" />
  </xsl:template>
  <xsl:template match=""/s0:MBWRecall"">
    <ns0:HWLCRecall>
      <RecallID>
        <xsl:value-of select=""PartID/text()"" />
      </RecallID>
      <RecallReason>
        <xsl:value-of select=""RecallReason/text()"" />
      </RecallReason>
      <PartName>
        <xsl:value-of select=""PartName/text()"" />
      </PartName>
      <RecallDate>
        <xsl:value-of select=""DateRecalled/text()"" />
      </RecallDate>
    </ns0:HWLCRecall>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Example01_Deployment.MBWRecall";
        
        private const global::Example01_Deployment.MBWRecall _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Example01_Deployment.HWLCRecall";
        
        private const global::Example01_Deployment.HWLCRecall _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Example01_Deployment.MBWRecall";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Example01_Deployment.HWLCRecall";
                return _TrgSchemas;
            }
        }
    }
}
