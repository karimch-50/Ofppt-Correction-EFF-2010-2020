Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Partial Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim SQl As String = "select vehicule.*,datediff(day , datepanne , datereprise) as NombreJours)  from vehicule inner join panne on (vehicule.immat = panne.immat) where datereprise> @Date "
        Dim Command As New SqlCommand(SQl, Cn)
        Command.Parameters.AddWithValue("@Date", Now.Date)
        Cn.Open()
        Dim dr As SqlDataReader = Command.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        Me.GridView1.DataSource = dt
        Cn.Close()
        Me.DataBind()
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton1.Click
        Dim sw As New StreamWriter("Vehicules.txt")
        For Each r As GridViewRow In GridView1.Rows
            If CType(r.FindControl("CheckBox1"), CheckBox).Checked Then
                sw.WriteLine(r.Cells(0).Text & " " & r.Cells(r.Cells.Count - 1).Text)
            End If
        Next
        sw.Close()

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class