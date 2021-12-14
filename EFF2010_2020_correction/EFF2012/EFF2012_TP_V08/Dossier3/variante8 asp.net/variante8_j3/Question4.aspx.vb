Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim sql As String = "insert into accident values (@ID , @Date , @Note , @Veh )"
        Dim Command As New SqlCommand(sql, Cn)
        Command.Parameters.AddWithValue("@ID", Me.txtb_IDAcc.Text)
        Command.Parameters.AddWithValue("@Date", Me.txtb_Date.Text)
        Command.Parameters.AddWithValue("@Note", Me.txtb_Note.Text)
        Command.Parameters.AddWithValue("@Veh", Me.cmb_Vehicule.SelectedItem)
        Cn.Open()
        Command.ExecuteNonQuery()
        Cn.Close()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim sql As String = "delete from accident where  immat=@ID "
        Dim Command As New SqlCommand(sql, Cn)
        Command.Parameters.AddWithValue("@ID", Me.txtb_IDAcc.Text)
        Cn.Open()
        Command.ExecuteNonQuery()
        Cn.Close()
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Dim sql As String = "update  accident set  dateaccident= @Date ,note= @Note , immat=@Veh  where idAccident=@ID "
        Dim Command As New SqlCommand(sql, Cn)
        Command.Parameters.AddWithValue("@ID", Me.txtb_IDAcc.Text)
        Command.Parameters.AddWithValue("@Date", Me.txtb_Date.Text)
        Command.Parameters.AddWithValue("@Note", Me.txtb_Note.Text)
        Command.Parameters.AddWithValue("@Veh", Me.cmb_Vehicule.SelectedItem)
        Cn.Open()
        Command.ExecuteNonQuery()
        Cn.Close()
    End Sub
End Class