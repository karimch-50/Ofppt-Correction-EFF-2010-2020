<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
    <head></head>
    <body>
        <h2>Participant</h2>
        <table border="1">
            <tr>
                <th>nom</th>
                <th>prenom</th>
                <th>civilite</th>
                <th>tel</th>
            </tr>
            <xsl:for-each select="FestivaleRire/participant">
            <tr>
                <td><xsl:value-of select="nom"/></td>
                <td><xsl:value-of select="prenom"/></td>
                <td><xsl:value-of select="civilite"/></td>
                <td><xsl:value-of select="tel"/></td>
            </tr>
            </xsl:for-each>
        </table>
        <h3>ville</h3>
        <table border="1">
            <tr>
                <th>idv</th>
                <th>libellev</th>
            </tr>
            <xsl:for-each select="FestivaleRire/participant/ville">
            <tr>
                <td><xsl:value-of select="idv"/></td>
                <td><xsl:value-of select="libellev"/></td>
            </tr>
            </xsl:for-each>
        </table>
        <h3>blague</h3>
        <table border="1">
            <tr>
                <th>titre</th>
                <th>contenu</th>
                <th>nbrvote</th>
            </tr>
            <xsl:for-each select="FestivaleRire/participant/blague">
            <tr>
                <td><xsl:value-of select="titre"/></td>
                <td><xsl:value-of select="contenu"/></td>
                <td><xsl:value-of select="nbrvote"/></td>
            </tr>
            </xsl:for-each>
        </table>
    </body>
</html>
</xsl:template>
</xsl:stylesheet>