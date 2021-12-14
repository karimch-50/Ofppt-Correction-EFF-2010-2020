''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright ©2011-2012 AJDI Yassin, All Rights Reserved.
' 
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  G-Mail: yassin.ajdi@gmail.com
'  Facebook: https://www.facebook.com/yassin.ajdi
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.Data.SqlClient
Partial Public Class XML
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = ""
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim da As New SqlDataAdapter("select * from Ville", cn)
        da.Fill(dataset, "ville")
        dataset.WriteXml(Server.MapPath("~\") & "xmlfile.xml")
        Label1.Text = "Directory: " & Server.MapPath("~\").ToString
    End Sub
End Class