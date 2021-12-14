Imports System.Data.SqlClient
Partial Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim id As String = TextBox1.Text
        Dim pass As String = TextBox2.Text
        cn.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from conducteur where idconducteur = '" & id & "' and pass = '" & pass & "'"
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Dim dt As New DataTable
            dt.Load(dr)
            Session("open") = "1"
            Session("conducteur") = dt

            cn.Close()
            Response.Redirect("Q1info.aspx")
        Else
            MsgBox("mot de passe errone")
        End If
        cn.Close()
    End Sub
End Class