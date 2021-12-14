<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" >

  <xsl:template match="/">
    <html>
      <body>
        <u>
          <h1 align="center" style="color: #7A5C99">Liste Des Villes </h1>
        </u>
        <table border="1" with="800px" align="center" style="background: #E6E65C; color: #B26B47">
          <tr style="background: #CCFF66; color: #668033">
            <th with="400px"><b>Code De Ville</b></th>
            <th with="400px"><b>Nom De Ville</b></th>
          </tr>
          <xsl:for-each select="NewDataSet/ville">
            <tr>
              <td>
                <xsl:value-of select="code_ville"/>
              </td>
              <td>
                <xsl:value-of select="nom_ville"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
