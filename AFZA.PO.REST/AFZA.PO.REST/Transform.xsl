<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s0" version="1.0" xmlns:s0="http://AFZA.com/PurchaseOrderSchema.xsd" xmlns:ns0="http://AFZA.PO.REST.POResponse">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s0:purchaseOrder" />
  </xsl:template>

  <xsl:template match="/s0:purchaseOrder">
    <ns0:ProcessedPO xmlns:ns0="http://AFZA.PO.REST.POResponse">

      <xsl:variable name="bullets">
        <xsl:for-each select="items/item">
          <xsl:variable name="product">
            <xsl:value-of select="productName"/>
          </xsl:variable>
            <xsl:value-of select="concat($product,',')"/>
        </xsl:for-each>
      </xsl:variable>

      <xsl:variable name="Pos">
        <xsl:value-of select="substring($bullets, 1, string-length($bullets) - 1)"/>
      </xsl:variable>

      <Result>
        <xsl:value-of select="concat('Following POs are successfully processed: ',$Pos)"/>
      </Result>
    </ns0:ProcessedPO>
  </xsl:template>
</xsl:stylesheet>