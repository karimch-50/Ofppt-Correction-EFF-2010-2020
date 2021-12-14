''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright ©2011-2012 AJDI Yassin, All Rights Reserved.
' 
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  G-Mail: yassin.ajdi@gmail.com
'  Facebook: https://www.facebook.com/yassin.ajdi
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.Data.SqlClient
Public Class mise_ajour_autocar
    Dim bnb As BindingManagerBase

    Private Sub mise_ajour_autocar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        affichage_form(Me)

        cn.Open()
        cmd = New SqlCommand("select nom_marque from Marque", cn)
        dr = cmd.ExecuteReader
        dt = New DataTable
        dt.Load(dr)
        With ComboBox1
            .DisplayMember = "nom_marque"
            .ValueMember = "nom_marque"
            .DataSource = dt
        End With
        cn.Close()
        da = New SqlDataAdapter("select * from Autocar", cn)
        ds.autocar.Clear()
        da.Fill(ds.autocar)
        bnb = BindingContext(ds.autocar)
        'binding controls with datasource
        TextBox1.DataBindings.Add("text", ds.autocar, "code_car")
        TextBox2.DataBindings.Add("text", ds.autocar, "capacite")
        DateTimePicker1.DataBindings.Add("text", ds.autocar, "date_achat")
        TextBox4.DataBindings.Add("text", ds.autocar, "consomation")
        ComboBox1.DataBindings.Add("text", ds.autocar, "nom_marque")
        disable_enable()
        GroupBox5.Enabled = False
    End Sub
    Public Sub disable_enble_navigation()
        GroupBox1.Enabled = Not GroupBox1.Enabled
    End Sub

    Public Sub disable_enable()
        For Each c As Control In GroupBox2.Controls
            If Not TypeOf c Is Label Then
                c.Enabled = Not c.Enabled
            End If
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        bnb.Position = 0
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        bnb.Position = ds.autocar.Rows.Count - 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        bnb.Position -= 1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        bnb.Position += 1
    End Sub
    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'button new
        Try
            disable_enable()
            disable_enble_navigation()
            GroupBox3.Enabled = False
            GroupBox5.Enabled = True
            Button8.Enabled = True
            Button10.Enabled = False
            bnb.AddNew()
        Catch ex As Exception
            exception(ex)
        End Try
        
    End Sub


    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'button supp
        Try
            bnb.RemoveAt(bnb.Position)
            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds.autocar)
            MsgBox("bien supprimer")
        Catch ex As Exception
            exception(ex)
        End Try

    End Sub


    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'button modifie
        disable_enble_navigation()
        GroupBox3.Enabled = False
        GroupBox5.Enabled = True
        Button8.Enabled = False
        Button10.Enabled = True
        Button7.Enabled = True
        disable_enable()

    End Sub
    Public Sub cancel()
        GroupBox5.Enabled = False
        GroupBox3.Enabled = True
        disable_enble_navigation()
        disable_enable()
        bnb.CancelCurrentEdit()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'cancel
        cancel()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'enregistrer
        Try
            GroupBox5.Enabled = False
            GroupBox3.Enabled = True
            disable_enable()
            disable_enble_navigation()
            bnb.EndCurrentEdit()
            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds.autocar)
            MsgBox("bien modifie")
        Catch ex As Exception
            exception(ex)
            ds.autocar.RejectChanges()
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'ajout
        Try
            Dim d_view As New DataView(ds.autocar)
            d_view.Sort = "code_car"
            Dim x As Integer = d_view.Find(CInt(TextBox1.Text))
            If x <> -1 Then
                MsgBox("exist deja")
                Exit Sub
            End If
            bnb.EndCurrentEdit()
            Dim db As New SqlCommandBuilder(da)
            da.Update(ds.autocar)
            GroupBox5.Enabled = False
            GroupBox3.Enabled = True
            disable_enble_navigation()
            disable_enable()
            MsgBox("bien ajouter")
        Catch ex As Exception
            exception(ex)
        End Try
    End Sub
End Class