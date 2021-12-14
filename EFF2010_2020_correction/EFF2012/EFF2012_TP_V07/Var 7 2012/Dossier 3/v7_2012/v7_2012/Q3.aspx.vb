Imports System.io
Partial Public Class WebForm4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack = False Then
            daveh.Fill(ds, ("vehicule"))
            DropDownList1.DataTextField = "immat"
            DropDownList1.DataSource = ds.Tables("vehicule")
            DropDownList1.DataBind()
        End If


    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        cn.Open()
        Dim s As Integer = 0

        cmd.CommandType = CommandType.Text
        cmd.CommandText = " select entretien.* from entretien,entrvehicule where entretien.identretien = entrvehicule.identretien and  entrvehicule.immat =" & DropDownList1.SelectedItem.ToString & ""
        cmd.Connection = cn
        dr = cmd.ExecuteReader
        GridView1.DataSource = dr
        GridView1.DataBind()
        For i = 0 To GridView1.Rows.Count - 1
            s += GridView1.Rows(i).Cells(5).Text
        Next

        cn.Close()
        dr.Close()
        Label1.Text = s
    End Sub

    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton3.Click
        Dim sw As New StreamWriter("F:/fichier.txt")
        For i = 0 To GridView1.Rows.Count - 1
            Dim ch As CheckBox = GridView1.Rows(i).Cells(0).FindControl("CheckBox1")
            If ch.Checked Then
                sw.WriteLine(GridView1.Rows(i).Cells(1).Text & " | " & GridView1.Rows(i).Cells(2).Text & " | " & GridView1.Rows(i).Cells(3).Text & " | " & GridView1.Rows(i).Cells(4).Text & " | " & GridView1.Rows(i).Cells(5).Text & " | " & GridView1.Rows(i).Cells(6).Text)
            End If
        Next
        sw.Close()
    End Sub
End Class