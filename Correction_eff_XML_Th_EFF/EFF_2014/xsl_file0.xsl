<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
    <head></head>
    <body>
    <xsl:for-each select="FOOT/JOURNEE">
        <h3>NUMERO:<xsl:value-of select="@NUMERO"/>     DATE:<xsl:value-of select="@DATE"/></h3>
        <table border="1">
            <tr>
                <th>LOCAUX</th>
                <th>VISITEURS</th>
                <th>BUTS_LOCAUX</th>
                <th>BUTS_VISITEURS</th>
            </tr>
            <tr>
                <td><xsl:value-of select="MATCH/@LOCAUX"/></td>
                <td><xsl:value-of select="MATCH/@VISITEURS"/></td>
                <td><xsl:value-of select="MATCH/@BUTS_LOCAUX"/></td>
                <td><xsl:value-of select="MATCH/@BUTS_VISITEURS"/></td>
            </tr>
        </table>
    </xsl:for-each>
    </body>
</html>
</xsl:template>
</xsl:stylesheet>