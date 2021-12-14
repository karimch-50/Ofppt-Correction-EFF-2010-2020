<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
<head>
    <title>test</title>
</head>
<body>
    <table border="1">
        <tr>
            <th>ID</th>
            <th>isbn</th>
            <th>Titre</th>
        </tr>
        <xsl:for-each select="Studentinfo/Details">
        <tr>
            <td><xsl:value-of select="ID"/></td>
            <td><xsl:value-of select="isbn"/></td>
            <td><xsl:value-of select="Titre"/></td>
        </tr>
        </xsl:for-each>
    </table>
</body>
</html>
</xsl:template>
</xsl:stylesheet>