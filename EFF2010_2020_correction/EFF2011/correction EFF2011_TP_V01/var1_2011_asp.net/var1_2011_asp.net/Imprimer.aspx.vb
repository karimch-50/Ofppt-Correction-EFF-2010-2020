''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright ©2011-2012 AJDI Yassin, All Rights Reserved.
' 
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  G-Mail: yassin.ajdi@gmail.com
'  Facebook: https://www.facebook.com/yassin.ajdi
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Partial Public Class Imprimer
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim da As New SqlDataAdapter("select jour_voyage, heure_depart, heure_arrivee from calendrier where code_ligne= " & Val(TextBox1.Text), cn)
        ds.Clear()
        da.Fill(ds.calendrier1)
        'Method 1
        Dim r As New CrystalReport1
        r.SetDataSource(ds.Tables("calendrier1"))
        CrystalReportViewer2.ReportSource = r
        CrystalReportViewer2.DataBind()

        'Method2
        Dim crystalReport As New ReportDocument()
        crystalReport.Load(Server.MapPath("CrystalReport1.rpt"))
        crystalReport.SetDataSource(ds.Tables("calendrier1"))
        CrystalReportViewer1.ReportSource = crystalReport

    End Sub
End Class