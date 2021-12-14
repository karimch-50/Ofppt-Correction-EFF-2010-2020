Imports System.Data.SqlClient
Partial Public Class Qusetion5
    Inherits System.Web.UI.Page
    Dim ds As DataSet
    Dim da As New SqlDataAdapter
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ds.Clear()
            da = New SqlDataAdapter("select distinct left(modele,1)as [lettre] from vehicule", Cn)
            da.Fill(ds, "lettrs")
            With Repeater1
                .DataSource = ds.Tables("lettrs")
                .DataBind()
            End With
        End If

        If Request.QueryString("lettre") IsNot Nothing Then
            da = New SqlDataAdapter("select immat,modele from Circonscription where nomCir like'" & Request.QueryString("lettre").ToString & "%'", Cn)
            da.Fill(ds, "mod")
            With Repeater2
                .DataSource = ds.Tables("mod")
                .DataBind()
            End With
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        ds.Tables("mod").WriteXml("/fichierXML.xml")
    End Sub
End Class