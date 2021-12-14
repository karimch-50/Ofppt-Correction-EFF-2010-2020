<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
    <head></head>
    <body>
    <h3>disponible:<xsl:value-of select="etat"/>
    </h3>
        <table border="1">
            <tr>
                <th>date</th>
                <th>objet</th>
                <th>priorite</th>
                <th>contenu</th>
            </tr>     
            <xsl:for-each select="courriers/compte/message">
       
            <tr>
                <td><xsl:value-of select="date"/></td>
                <td><xsl:value-of select="objet"/></td>
                <td><xsl:value-of select="priorite"/></td>
                <td><xsl:value-of select="contenu"/></td>
            </tr>
        </xsl:for-each>
        </table>
    </body>
</html>
</xsl:template>
</xsl:stylesheet>