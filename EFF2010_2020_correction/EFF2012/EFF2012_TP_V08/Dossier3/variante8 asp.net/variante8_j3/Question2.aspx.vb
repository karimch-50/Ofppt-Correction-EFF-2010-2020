Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("ID_C") IsNot Nothing Then
            Dim Sql As String = "select * from vehicule where idconducteur = @ID"
            Dim Command_Vehicule As New SqlCommand(Sql, Cn)
            Command_Vehicule.Parameters.AddWithValue("@ID", Session("ID_C"))
            Cn.Open()
            Dim dr As SqlDataReader = Command_Vehicule.ExecuteReader
            Dim dt As New DataTable
            dt.Load(dr)
            Me.Grid_Vehicule.DataSource = dt
            Cn.Close()
            Dim Sql2 As String = "select * from panne where immat = @Imm"
            Dim Command_Pannes As New SqlCommand(Sql2, Cn)
            Cn.Open()
            Command_Pannes.Parameters.AddWithValue("@Imm", dt.Rows(0)(0))
            Dim dt2 As New DataTable
            Dim dr2 As SqlDataReader = Command_Pannes.ExecuteReader
            dt2.Load(dr2)
            Me.Grid_Pannes.DataSource = dt2
            Cn.Close()
            Login1.Visible = False
        Else
            Panel1.Visible = False
        End If

    End Sub

    Protected Sub Login1_Authenticate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AuthenticateEventArgs) Handles Login1.Authenticate
        Dim Sql As String = "select * from conducteur where idconduteur= @ID and pass =@pass"
        Dim Command As New SqlCommand(Sql, Cn)
        Command.Parameters.AddWithValue("@ID", Login1.UserName)
        Command.Parameters.AddWithValue("@pass", Login1.Password)
        Cn.Open()
        Dim dr As SqlDataReader = Command.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            Session("ID_C") = dr(0)
            Response.Redirect("Question2.aspx")
        End If
        Cn.Close()
    End Sub
End Class