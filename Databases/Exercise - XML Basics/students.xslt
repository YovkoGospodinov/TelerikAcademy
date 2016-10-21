<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
    <head>
    <title>FMI Faculty Students</title>
    <style>
          body
          {
            display: flex;
            flex-direction: row;
            flex-wrap: wrap;
            justify-content: center;
            align-items: center;
          }
          h1
          {
            background:#D6E685;
            color:white;
            padding:10px;
            width: 50%;
            border-radius:10px;
          }
          .student-container
          {
            width:50%;
            margin:10px;
            background:#c4c4c4;
            color:black;
            font-size:20px;
            padding:10px;
            border-radius:10px;
          }
          .exam-title
          {
            margin-left:20px;
          }
          .exam-container
          {
            margin-left:40px;
          }
        </style>
    <body>
      <h1>FMI Faculty Students</h1>
      <xsl:for-each select="students/student">
          <div class="student-container">
            <xsl:for-each select="name">
            <div>
                First Name: <xsl:value-of select="firstname"/>
                </div>
                <div>
                Last Name: <xsl:value-of select="lastname"/>
                </div>
            </xsl:for-each>
            
            <div>
                Gender: <xsl:value-of select="gender"/>
            </div>
            <div>
              Faculty Number: <xsl:value-of select="facultynumber"/>
            </div>
            <div class="exam-title">Taken exams:</div>
            <xsl:for-each select="takenexams/exam">
              <div class="exam-container">
                <xsl:value-of select="position()"/>. <xsl:value-of select="name"/> - Score: <xsl:value-of select="grade"/> (Tutor: <xsl:value-of select="tutor"/>)
              </div>
            </xsl:for-each>
          </div>
        </xsl:for-each>
    </body>
    </head>
  </html>
  </xsl:template>
</xsl:stylesheet>