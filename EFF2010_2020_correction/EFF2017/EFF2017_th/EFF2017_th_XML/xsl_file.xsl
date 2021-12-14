<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
  <html>
    <head>
      <title>Exemple de sortie HTML</title>
      <meta http-equiv="Content-Type" content="text/html; 	charset=ISO-8859-1" />
    </head>
    <body>
      <h1>Les courriers:</h1>
      <ul>
        <li>
        Date message :<xsl:value-of select="courriers/compte/message/date"/>
        _Objet :<xsl:value-of select="courriers/compte/message/objet"/>
        _Priorite :<xsl:value-of select="courriers/compte/message/priorite"/>
        </li>
      </ul>
    </body>
  </html>
</xsl:template>
</xsl:stylesheet>