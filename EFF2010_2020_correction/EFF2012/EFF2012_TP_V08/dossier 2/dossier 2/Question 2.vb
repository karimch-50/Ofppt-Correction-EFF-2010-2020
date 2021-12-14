Imports System.Data.SqlClient

Public Class Question_2

    Private Sub Question_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        charge()
        dt = red_veh()
        While dt.Read
            ComboBox1.Items.Add(dt(0))
        End While
        dt.Close()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        dt = red_panne()
        While dt.Read
            TextBox1.Text = dt(0)
            TextBox2.Text = dt(1)
            TextBox3.Text = dt(2)
            TextBox4.Text = dt(3)
            TextBox5.Text = dt(4)
            ComboBox1.Text = dt(5)
            Exit While
        End While
        dt.Close()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        dt = red_panne()
        While dt.Read
            TextBox1.Text = dt(0)
            TextBox2.Text = dt(1)
            TextBox3.Text = dt(2)
            TextBox4.Text = dt(3)
            TextBox5.Text = dt(4)
            ComboBox1.Text = dt(5)
        End While
        dt.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        dt = red_suivant(TextBox1.Text)
        If dt.HasRows Then
            While dt.Read
                TextBox1.Text = dt(0)
                TextBox2.Text = dt(1)
                TextBox3.Text = dt(2)
                TextBox4.Text = dt(3)
                TextBox5.Text = dt(4)
                ComboBox1.Text = dt(5)
                Exit While
            End While
        Else
            MsgBox("vous etes sur le dernnier")
        End If
        dt.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        dt = red_precedent(TextBox1.Text)
        If dt.HasRows Then
            While dt.Read
                TextBox1.Text = dt(0)
                TextBox2.Text = dt(1)
                TextBox3.Text = dt(2)
                TextBox4.Text = dt(3)
                TextBox5.Text = dt(4)
                ComboBox1.Text = dt(5)
            End While
        Else
            MsgBox("vous etes sur le premier")
        End If
        dt.Close()
    End Sub
    Sub vide()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim li As DataRow = ds.Tables("panne").NewRow
        li(0) = TextBox1.Text
        li(1) = TextBox2.Text
        li(2) = TextBox3.Text
        li(3) = TextBox4.Text
        li(4) = TextBox5.Text
        li(5) = ComboBox1.Text
        ds.Tables("panne").Rows.Add(li)
        MsgBox("l'ajou a ete effectuee ")
        vide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim p As Integer = -1
        For i = 0 To ds.Tables("panne").Rows.Count - 1
            If TextBox1.Text = ds.Tables("panne").Rows(i)(0) Then
                p = i
            End If
        Next
        If p = -1 Then
            MsgBox("personne introvable")
        Else
            ds.Tables("panne").Rows(p).Delete()
            MsgBox("suppression effectuee")
            vide()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim dld As New SqlCommandBuilder(data_panne)
        data_panne.Update(ds, "panne")
        MsgBox("enregestrer effecutee")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim p As Integer = -1
        For i = 0 To ds.Tables("panne").Rows.Count - 1
            If TextBox1.Text = ds.Tables("panne").Rows(i)(0) Then
                p = i
            End If
        Next
        If p = -1 Then
            MsgBox("personne introvable")
        Else
            ds.Tables("panne").Rows(p)(1) = TextBox2.Text
            ds.Tables("panne").Rows(p)(2) = TextBox3.Text
            ds.Tables("panne").Rows(p)(3) = TextBox4.Text
            ds.Tables("panne").Rows(p)(4) = TextBox5.Text
            ds.Tables("panne").Rows(p)(5) = ComboBox1.Text
            MsgBox("modification effectuee")
            vide()
        End If
    End Sub
End Class