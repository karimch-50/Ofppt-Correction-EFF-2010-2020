''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright ©2011-2012 AJDI Yassin, All Rights Reserved.
' 
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  G-Mail: yassin.ajdi@gmail.com
'  Facebook: https://www.facebook.com/yassin.ajdi
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.Data.SqlClient
Partial Public Class Ligin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label3.Text = ""
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        cmd = New SqlCommand("select * from Personnel where Matricule= " & Val(TextBox1.Text) & " and passe=" & Val(TextBox2.Text), cn)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If

        dr = cmd.ExecuteReader
        If dr.Read Then
            Label3.Text = "login .."
            dr.Close()
            cn.Close()
            Response.Redirect("~\Default.aspx")
        Else
            Label3.Text = "erreur"
        End If
        dr.Close()
        cn.Close()
    End Sub
End Class