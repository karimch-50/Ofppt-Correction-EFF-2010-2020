<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
    <head></head>
    <body>
        <table border="1">
            <tr>
                <th>salle</th>
                <th>module</th>
                <th>formateur</th>
                <th>groupe</th>
            </tr>
            <xsl:for-each select="seances/seance">
            <tr>
                <td><xsl:value-of select="salle"/></td>
                <td><xsl:value-of select="module"/></td>
                <td><xsl:value-of select="formateur"/></td>
                <td><xsl:value-of select="groupe"/></td>
            </tr>
        </xsl:for-each>
        </table>
    </body>
</html>
</xsl:template>
</xsl:stylesheet>