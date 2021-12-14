<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
    <head></head>
    <body>
        <xsl:for-each select="list/hotel">
            <h3>Hotel:<xsl:value-of select="@code"/></h3>
            <table border="1">
                <tr>
                    <th>nom</th>
                    <th>adresse</th>
                    <th>ville</th>
                    <th>tel</th>
                    <th>fax</th>
                    <th>mail</th>
                </tr>
                <tr>
                    <td><xsl:value-of select="nom"/></td>
                    <td><xsl:value-of select="adresse"/></td>
                    <td><xsl:value-of select="ville"/></td>
                    <td><xsl:value-of select="tel"/><br/></td>
                    <td><xsl:value-of select="fax"/><br/></td>
                    <td><xsl:value-of select="mail"/></td>
                </tr>
            </table>
        </xsl:for-each>
    </body>
</html>
</xsl:template>
</xsl:stylesheet>