<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
  <html>
    <head>
      <title>Exemple de sortie HTML</title>
      <meta http-equiv="Content-Type" content="text/html; 	charset=ISO-8859-1" />
    </head>
    <body>
	<table border="1">
		<tr>
			<th>NomCommun</th>
			<th>NomBotanique</th>	
			<th>zone</th>
			<th>Eclairage</th>
			<th>Prix</th>
			<th>quantiteStock</th>
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