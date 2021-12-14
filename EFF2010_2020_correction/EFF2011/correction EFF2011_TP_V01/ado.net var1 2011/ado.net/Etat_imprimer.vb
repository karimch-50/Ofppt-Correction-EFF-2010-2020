''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright ©2011-2012 AJDI Yassin, All Rights Reserved.
' 
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  G-Mail: yassin.ajdi@gmail.com
'  Facebook: https://www.facebook.com/yassin.ajdi
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.Data.SqlClient
Public Class Etat_imprimer
    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'module1.vb
        affichage_form(Me)

        cmd = New SqlCommand("select code_ville, nom_ville from Ville", cn)
        cn.Open()
        dr = cmd.ExecuteReader
        dt = New DataTable
        dt.Load(dr)
        With ComboBox2
            .DisplayMember = "nom_ville"
            .ValueMember = "code_ville"
            .DataSource = dt
        End With
        dr = cmd.ExecuteReader
        dt = New DataTable
        dt.Load(dr)
        With ComboBox3
            .DisplayMember = "nom_ville"
            .ValueMember = "code_ville"
            .DataSource = dt
        End With
        cn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r As New CrystalReport1
        Try
            Dim da As New SqlDataAdapter("select jour_voyage, heure_depart, heure_arrivee from Calendrier where code_ligne=" & _
                                    "(select code_ligne from Ligne where code_ville_depart=" & Val(ComboBox2.SelectedValue) & _
                                    " and code_ville_arrivee=" & Val(ComboBox3.SelectedValue) & ")", cn)
            ds.Clear()
            da.Fill(ds.calendrier)
            r.SetDataSource(ds.Tables("calendrier"))
            CrystalReportViewer1.ReportSource = r
        Catch ex As Exception
            exception(ex)
        End Try
    End Sub
End Class
