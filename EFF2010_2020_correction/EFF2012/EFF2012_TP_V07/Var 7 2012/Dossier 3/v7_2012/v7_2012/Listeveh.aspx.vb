Imports System.Data.SqlClient
Imports System.IO
Partial Public Class WebForm6
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cn.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select immat,modele from vehicule where immat = " & Request.QueryString("id") & ""
        Dim da As New SqlDataAdapter(cmd.CommandText, cn)
        da.Fill(ds, "xml")
        cmd.Connection = cn
        dr = cmd.ExecuteReader
        GridView1.DataSource = dr
        GridView1.DataBind()

        cn.Close()
        dr.Close()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        ds.Tables("xml").WriteXml("F:\fichier.xml")
    End Sub
End Class