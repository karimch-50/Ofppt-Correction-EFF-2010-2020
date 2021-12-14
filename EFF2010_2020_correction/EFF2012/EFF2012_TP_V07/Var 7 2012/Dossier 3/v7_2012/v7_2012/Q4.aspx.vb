Imports System.Data.SqlClient
Partial Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        daentr.Fill(ds, ("entretien"))
        affichage()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim l As DataRow = ds.Tables("cand").NewRow
        l(0) = TextBox1.Text
        l(1) = TextBox2.Text
        l(2) = TextBox3.Text
        l(3) = TextBox4.Text
        l(4) = TextBox5.Text
        l(5) = TextBox6.Text
        ds.Tables("entretien").Rows.Add(l)
        Dim cb As New SqlCommandBuilder(daentr)
        daentr.Update(ds, ("entretien"))
        affichage()
        MsgBox("ajout effectue avec succes")
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        For i = 0 To ds.Tables("entretien").Rows.Count - 1
            If TextBox1.Text = ds.Tables("entretien").Rows(i)(0) Then
                ds.Tables("entretien").Rows(i)(0) = TextBox1.Text
                ds.Tables("entretien").Rows(i)(1) = TextBox2.Text
                ds.Tables("entretien").Rows(i)(2) = TextBox3.Text
                ds.Tables("entretien").Rows(i)(3) = TextBox4.Text
                ds.Tables("entretien").Rows(i)(4) = TextBox5.Text
                ds.Tables("entretien").Rows(i)(5) = TextBox6.Text

            End If
        Next
        Dim cb As New SqlCommandBuilder(daentr)
        daentr.Update(ds, ("entretien"))
        affichage()
        MsgBox("modification effectue avec succes")
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        For i = 0 To ds.Tables("entretien").Rows.Count - 1
            If ds.Tables("entretien").Rows(i)(0) = TextBox1.Text Then
                ds.Tables("entretien").Rows(i).Delete()
                Exit For

            End If
        Next
        Dim cb As New SqlCommandBuilder(daentr)
        daentr.Update(ds, ("entretien"))
        affichage()
        MsgBox("supression effectue avec succes")
    End Sub
    Sub affichage()
        cn.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from entretien"
        cmd.Connection = cn
        dr = cmd.ExecuteReader

        Dim dt As New DataTable

        dt.Load(dr)
        GridView1.DataSource = dt
        GridView1.DataBind()
        cn.Close()
        dr.Close()
    End Sub
End Class