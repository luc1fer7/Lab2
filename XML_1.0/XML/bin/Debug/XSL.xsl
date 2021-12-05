<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
				xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html"/>

	<xsl:template match="/">
		<html>
			<body>
				<table border ="1px">
					<tbody>
						<TR>
							<th>Conference Name</th>
							<th>Place</th>
							<th>Theme</th>
							<th>Person</th>
							<th>Date</th>
							<th>Period</th>
							<th>Cost</th>
						</TR>
						<xsl:for-each select="DataBase/CONFERENCE">
							<tr>
								<td>
									<xsl:value-of select="@ConfName"/>
								</td>
								<td>
									<xsl:value-of select="PLACE/@Place"/>
								</td>
								<td>
									<xsl:value-of select="PLACE/INFO/@Theme"/>
								</td>
								<td>
									<xsl:value-of select="PLACE/INFO/@Person"/>
								</td>
								<td>
									<xsl:value-of select="PLACE/INFO/@Date"/>
								</td>
								<td>
									<xsl:value-of select="PLACE/INFO/@Period"/>
								</td>
								<td>
									<xsl:value-of select="PLACE/INFO/@Cost"/>
								</td>
							</tr>
						</xsl:for-each>
					</tbody>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
