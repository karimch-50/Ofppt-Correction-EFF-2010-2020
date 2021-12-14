<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
        <head>
        	<title>Exemple de sortie HTML</title>
        	<meta http-equiv="Content-Type" content="text/html; 	charset=ISO-8859-1" />
        </head>
	<body>
		<table border="l">
			<tr>
				<th>Formateurs</th>
				<th>Groupes</th>
				<th>Modules</th>
			</tr>
		<xsl:for-each select="seances/seance">
			<tr>
				<td> <xsl:value-of select="formateur"/></td>
				<td> <xsl:value-of select="groupe"/></td>
				<td> <xsl:value-of select="module"/></td>
			</tr>
		</xsl:for-each>
		</table>
	</body>
</html>
</xsl:template>
</xsl:stylesheet>

