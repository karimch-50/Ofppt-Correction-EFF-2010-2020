''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright ©2011-2012 AJDI Yassin, All Rights Reserved.
' 
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  G-Mail: yassin.ajdi@gmail.com
'  Facebook: https://www.facebook.com/yassin.ajdi
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports System.Data.SqlClient
Public Class ajoute_calander
    Dim dtt As New DataTable
    Dim flag As Boolean = False
    
    Private Sub ajoute_calander_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            affichage_form(Me)
            'fill dataset
            da = New SqlDataAdapter("select * from Calendrier", cn)
            da.Fill(ds.Q4)

            cmd = New SqlCommand("select code_ligne from ligne", cn)
            cn.Open()
            dr = cmd.ExecuteReader
            dt = New DataTable
            dt.Load(dr)
            With ComboBox1
                .DisplayMember = "code_ligne"
                .ValueMember = "code_ligne"
                .DataSource = dt
            End With
            cn.Close()
            dtt.Columns.Add("code_calendrier")
            dtt.Columns.Add("jour_voyage")
            dtt.Columns.Add("heure_depart")
            dtt.Columns.Add("heure_arrivee")
            DataGridView1.DataSource = dtt
        Catch ex As Exception
            exception(ex)
        End Try
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If dtt.Rows.Count > 0 Then
                Dim d_view As New DataView(ds.Q4)
                d_view.Sort = "code_calendrier"
                Dim x As Integer = d_view.Find(CInt(dtt.Rows(0)(0)))
                If x <> -1 Then
                    MsgBox("exist deja")
                    dtt.Clear()
                    Exit Sub
                End If
                ds.Q4.Rows.Add(Val(dtt.Rows(0)(0)), Val(dtt.Rows(0)(1)), Val(dtt.Rows(0)(2)), Val(dtt.Rows(0)(3)), ComboBox1.SelectedValue)
                Dim cmdb As New SqlCommandBuilder(da)
                da.Update(ds.Q4)
                dtt.Clear()
                MsgBox("bien ajouter")
            End If

        Catch ex As Exception
            exception(ex)
            dtt.Clear()
        End Try
    End Sub

End Class