Public Class MEnu

    Private Sub Question2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Question2ToolStripMenuItem.Click
        With Question2
            .MdiParent = Me
            .Show()
            .Dock = DockStyle.Fill
        End With
        Question3.Close()
        Question4.Close()
        Question5.Close()
    End Sub

    Private Sub Question3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Question3ToolStripMenuItem.Click
        With Question3
            .MdiParent = Me
            .Show()
            .Dock = DockStyle.Fill
        End With
        Question2.Close()
        Question4.Close()
        Question5.Close()
    End Sub

    Private Sub Question4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Question4ToolStripMenuItem.Click
        With Question4
            .MdiParent = Me
            .Show()
            .Dock = DockStyle.Fill
        End With
        Question2.Close()
        Question3.Close()
        Question5.Close()
    End Sub

    Private Sub Question5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Question5ToolStripMenuItem.Click
        With Question5
            .MdiParent = Me
            .Show()
            .Dock = DockStyle.Fill
        End With
        Question2.Close()
        Question3.Close()
        Question4.Close()
    End Sub
End Class
