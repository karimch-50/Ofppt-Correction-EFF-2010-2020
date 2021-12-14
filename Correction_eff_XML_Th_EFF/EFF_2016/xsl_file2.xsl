<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
    <html>
        <head></head>
        <body>
            <h3>NillSat</h3>
            <Table border="1">
                <tr>
                    <th>nomch</th>
                    <th>datLencement</th>
                    <th>frequence</th>
                    <th>polarisation</th>
                    <th>debit</th>
                </tr>
                <xsl:for-each select="emission/satellite[@nomsat='NillSat']/chaine">
                    <tr>
                        <td><xsl:value-of select="@nomch"/></td>
                        <td><xsl:value-of select="@datLencement"/></td>
                        <td><xsl:value-of select="frequence"/></td>
                        <td><xsl:value-of select="polarisation"/></td>
                        <td><xsl:value-of select="debit"/></td>
                    </tr>
                </xsl:for-each>
            </Table>
            <h3>HotBird</h3>
            <Table border="1">
                <tr>
                    <th>nomch</th>
                    <th>datLencement</th>
                    <th>frequence</th>
                    <th>polarisation</th>
                    <th>debit</th>
                </tr>
                <xsl:for-each select="emission/satellite[@nomsat='HotBird']/chaine">
                    <tr>
                        <td><xsl:value-of select="@nomch"/></td>
                        <td><xsl:value-of select="@datLencement"/></td>
                        <td><xsl:value-of select="frequence"/></td>
                        <td><xsl:value-of select="polarisation"/></td>
                        <td><xsl:value-of select="debit"/></td>
                    </tr>
                </xsl:for-each>
            </Table>
        </body>
    </html>
</xsl:template>
</xsl:stylesheet>