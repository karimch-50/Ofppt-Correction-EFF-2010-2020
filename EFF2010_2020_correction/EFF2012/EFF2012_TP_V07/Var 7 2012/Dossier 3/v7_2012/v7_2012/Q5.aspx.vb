Imports System.Data.SqlClient
Partial Public Class WebForm5
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            daveh.Fill(ds, "veh")
            Dim a As String = ""
            For i = 0 To ds.Tables("veh").Rows.Count - 1
                a &= "<a href = Listeveh.aspx?id=" & ds.Tables("veh").Rows(i)(0) & ">" & ds.Tables("veh").Rows(i)(1) & "</a>" & "  |  "
            Next
            Label1.Text = a
        End If
        ds.Tables("veh").Clear()
    End Sub

End Class