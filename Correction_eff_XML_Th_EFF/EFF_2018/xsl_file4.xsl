<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
    <head></head>
    <body>
        <table border="1">
            <tr>
                <th>NomCommun</th>
                <th>NomBotanique</th>
                <th>zone</th>
                <th>Eclairage</th>
                <th>Prix</th>
                <th>QuantiteStock</th>
            </tr>
            <xsl:for-each select="Catalogue/Plante">
            <tr>
                <td><xsl:value-of select="NomCommun"/></td>
                <td><xsl:value-of select="NomBotanique"/></td>
                <td><xsl:value-of select="zone"/></td>
                <td><xsl:value-of select="Eclairage"/></td>
                <td><xsl:value-of select="Prix"/></td>
                <td><xsl:value-of select="QuantiteStock"/></td>
            </tr>
            </xsl:for-each>
        </table>
    </body>
</html>
</xsl:template>
</xsl:stylesheet>