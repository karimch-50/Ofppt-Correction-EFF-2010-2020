Imports System.Windows.Forms

Public Class MDIParent1

    

    Private Sub Question2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Question2ToolStripMenuItem.Click
        Question_2.MdiParent = Me
        Question_2.Show()
    End Sub

    Private Sub Question3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Question3ToolStripMenuItem.Click
        Question_3.MdiParent = Me
        Question_3.Show()
    End Sub

    Private Sub Question4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Question4ToolStripMenuItem.Click
        Question_4.MdiParent = Me
        Question_4.Show()
    End Sub

    Private Sub Question5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Question5ToolStripMenuItem.Click
        Question_5.MdiParent = Me
        Question_5.Show()
    End Sub

    Private Sub Question6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Question6ToolStripMenuItem.Click
        Question6.MdiParent = Me
        Question6.Show()
    End Sub
End Class
