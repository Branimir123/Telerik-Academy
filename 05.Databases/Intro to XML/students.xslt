<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="./students">
    <xsl:template match="/">
        <html>
            <body>
                <div id="studens-wrapper">
                    <xsl:for-each select="students">
                        <h1>name</h1>
                        <h4>sex</h4>
                    </xsl:for-each>
                </div>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>
