namespace Chapter04_Example01.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Chapter04_Example01.Schemas.CustomerFinanceRequest", typeof(global::Chapter04_Example01.Schemas.CustomerFinanceRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Chapter04_Example01.Schemas.CustomerFinanceResponse", typeof(global::Chapter04_Example01.Schemas.CustomerFinanceResponse))]
    public sealed class FinanceRequest_to_DealerFinanceRejected : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://Chapter04_Example01.Schemas.CustomerFinanceRequest"" xmlns:ns0=""http://Chapter04_Example01.Schemas.CustomerFinanceResponse"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CustomerFinanceRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:CustomerFinanceRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;false&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;dealer&quot;)"" />
    <ns0:CustomerFinanceResponse>
      <isApproved>
        <xsl:value-of select=""$var:v1"" />
      </isApproved>
      <FinanceAmount>
        <xsl:value-of select=""FinanceAmount/text()"" />
      </FinanceAmount>
      <CustomerName>
        <xsl:value-of select=""CustomerName/text()"" />
      </CustomerName>
      <FinanceCompany>
        <xsl:value-of select=""$var:v2"" />
      </FinanceCompany>
    </ns0:CustomerFinanceResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Chapter04_Example01.Schemas.CustomerFinanceRequest";
        
        private const global::Chapter04_Example01.Schemas.CustomerFinanceRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Chapter04_Example01.Schemas.CustomerFinanceResponse";
        
        private const global::Chapter04_Example01.Schemas.CustomerFinanceResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Chapter04_Example01.Schemas.CustomerFinanceRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Chapter04_Example01.Schemas.CustomerFinanceResponse";
                return _TrgSchemas;
            }
        }
    }
}
