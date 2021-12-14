<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
    <html>
        <head>

        </head>
        <body>
            <table border="1">
                <tr>
                    <th>nom</th>
                    <th>prenom</th>
                    <th>age</th>
                </tr>
                <xsl:for-each select="group/stagiaire">
                <tr>
                    <td><xsl:value-of select="nom"/></td>
                    <td><xsl:value-of select="prenom"/></td>
                    <td><xsl:value-of select="age"/></td>
                </tr>
                </xsl:for-each>
            </table>
        </body>
    </html>
</xsl:template>
</xsl:stylesheet>