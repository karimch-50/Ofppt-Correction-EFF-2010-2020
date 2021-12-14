''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright ©2011-2012 AJDI Yassin, All Rights Reserved.
' 
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  G-Mail: yassin.ajdi@gmail.com
'  Facebook: https://www.facebook.com/yassin.ajdi
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.Data.SqlClient
Public Class List_voyages
   
    Private Sub List_voyages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        affichage_form(Me)
        cmd = New SqlCommand("select nom, Matricule from Personnel", cn)
        cn.Open()
        dr = cmd.ExecuteReader
        dt = New DataTable
        dt.Load(dr)
        With ComboBox1
            .DisplayMember = "nom"
            .ValueMember = "Matricule"
            .DataSource = dt
        End With
        cn.Close()
        fill_datagrid()
    End Sub

    Public Sub fill_datagrid()
        ds.Clear()
        da = New SqlDataAdapter("select * from Voyage where  matricule=" & CInt(ComboBox1.SelectedValue), cn)
        da.Fill(ds.Voyage)
        DataGridView1.DataSource = ds.Voyage
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        fill_datagrid()
    End Sub
End Class