''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright ©2011-2012 AJDI Yassin, All Rights Reserved.
' 
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  G-Mail: yassin.ajdi@gmail.com
'  Facebook: https://www.facebook.com/yassin.ajdi
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.Data.SqlClient
Partial Public Class miseajour_gridview
    Inherits System.Web.UI.Page
    Dim da As New SqlDataAdapter("select * from Calendrier", cn)
    Dim daLign As New SqlDataAdapter("select code_ligne from Ligne", cn)
    Dim txt_box As TextBox
    Dim ddl As DropDownList
    Public Sub binddata()
        da.Fill(ds.calendrier)
        GridView1.DataSource = ds.calendrier
        GridView1.DataBind()
        ddl = New DropDownList
        ddl = CType(GridView1.FooterRow.FindControl("DropDownList2"), DropDownList)
        bind_ddl(ddl)
    End Sub
    Public Sub bind_ddl(ByVal ddl As DropDownList)
        daLign.Fill(ds.ligne)
        ddl.DataTextField = "code_ligne"
        ddl.DataSource = ds.ligne
        ddl.DataBind()
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            binddata()
        ElseIf Page.IsPostBack Then
            da.Fill(ds.calendrier)
        End If
    End Sub

    Private Sub GridView1_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        GridView1.PageIndex = e.NewPageIndex
        GridView1.EditIndex = -1
        binddata()
    End Sub

    Private Sub GridView1_RowCancelingEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCancelEditEventArgs) Handles GridView1.RowCancelingEdit
        GridView1.EditIndex = -1
        binddata()
    End Sub

    Private Sub GridView1_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles GridView1.RowDeleting
        'RowIndex: Gets the index of the GridViewRow object in the Rows collection of a GridView control.
        'DataItemIndex: Gets the underlying data object to which the GridViewRow object is bound.
        Try
            Dim row As GridViewRow = GridView1.Rows(e.RowIndex)
            ds.calendrier.Rows(row.DataItemIndex).Delete()
            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds.calendrier)
            GridView1.EditIndex = -1
            binddata()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        
    End Sub

    Private Sub GridView1_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles GridView1.RowEditing
        GridView1.EditIndex = e.NewEditIndex
        binddata()
        ddl = New DropDownList
        ddl = DirectCast(GridView1.Rows(e.NewEditIndex).Cells(4).FindControl("DropDownList1"), DropDownList)
        bind_ddl(ddl)
    End Sub
   

    Private Sub GridView1_RowUpdating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewUpdateEventArgs) Handles GridView1.RowUpdating
        Try
            Dim r As GridViewRow = GridView1.Rows(e.RowIndex)
            ds.calendrier.Rows(r.DataItemIndex)(1) = CInt(CType(r.Cells(1).FindControl("TextBox1"), TextBox).Text)
            ds.calendrier.Rows(r.DataItemIndex)(2) = CInt(CType(r.Cells(2).FindControl("TextBox2"), TextBox).Text)
            ds.calendrier.Rows(r.DataItemIndex)(3) = CInt(CType(r.Cells(3).FindControl("TextBox3"), TextBox).Text)
            Dim al As New ArrayList
            For i = 0 To r.Cells(4).Controls.Count - 1
                If TypeOf r.Cells(4).Controls(i) Is DropDownList Then
                    ds.calendrier.Rows(r.DataItemIndex)(4) = CInt(CType(r.Cells(4).Controls(i), DropDownList).Text)
                    Exit For
                End If
            Next
            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds.calendrier)
            GridView1.EditIndex = -1
            binddata()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        
    End Sub
    Public Sub ajouter(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim code_cal, jour, code_ligne As Integer
            Dim h_depart, h_arrive As Double
            code_cal = CInt(DirectCast(GridView1.FooterRow.Cells(0).FindControl("TextBox4"), TextBox).Text)
            For Each r In ds.calendrier.Rows
                If CInt(r(0)) = CInt(code_cal) Then
                    MsgBox("calander exist deja")
                    Exit Sub
                End If
            Next
            jour = CInt(DirectCast(GridView1.FooterRow.Cells(1).FindControl("TextBox5"), TextBox).Text)
            h_depart = CInt(DirectCast(GridView1.FooterRow.Cells(2).FindControl("TextBox6"), TextBox).Text)
            h_arrive = CInt(DirectCast(GridView1.FooterRow.Cells(3).FindControl("TextBox7"), TextBox).Text)
            code_ligne = CInt(DirectCast(GridView1.FooterRow.Cells(4).FindControl("DropDownList2"), DropDownList).Text)
            ds.calendrier.Rows.Add(code_cal, jour, h_depart, h_arrive, code_ligne)
            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds.calendrier)
            GridView1.EditIndex = -1
            binddata()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

End Class