''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright ©2011-2012 AJDI Yassin, All Rights Reserved.
' 
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  G-Mail: yassin.ajdi@gmail.com
'  Facebook: https://www.facebook.com/yassin.ajdi
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.Data.SqlClient
Public Class Histo

    Private Sub Histo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            affichage_form(Me)
            da = New SqlDataAdapter("select l.code_ligne, sum(v.compteur_arrivee - v.compteur_depart) as [distance]" & _
                                    " from Ligne l inner join Calendrier c on c.code_ligne= l.code_ligne inner join" & _
                                    " Voyage v on v.code_calendrier= c.code_calendrier group by l.code_ligne", cn)
            ds.Clear()
            da.Fill(ds.ligne1)
            Dim r As New histogramme
            r.SetDataSource(ds.Tables("ligne1"))
            CrystalReportViewer1.ReportSource = r
        Catch ex As Exception
            exception(ex)
        End Try
    End Sub

End Class