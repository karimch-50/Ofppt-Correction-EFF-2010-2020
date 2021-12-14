<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MEnu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.Question2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Question3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Question4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Question5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Question2ToolStripMenuItem, Me.Question3ToolStripMenuItem, Me.Question4ToolStripMenuItem, Me.Question5ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1169, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Question2ToolStripMenuItem
        '
        Me.Question2ToolStripMenuItem.Name = "Question2ToolStripMenuItem"
        Me.Question2ToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.Question2ToolStripMenuItem.Text = "&Question2"
        '
        'Question3ToolStripMenuItem
        '
        Me.Question3ToolStripMenuItem.Name = "Question3ToolStripMenuItem"
        Me.Question3ToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.Question3ToolStripMenuItem.Text = "&Question3"
        '
        'Question4ToolStripMenuItem
        '
        Me.Question4ToolStripMenuItem.Name = "Question4ToolStripMenuItem"
        Me.Question4ToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.Question4ToolStripMenuItem.Text = "Question4"
        '
        'Question5ToolStripMenuItem
        '
        Me.Question5ToolStripMenuItem.Name = "Question5ToolStripMenuItem"
        Me.Question5ToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.Question5ToolStripMenuItem.Text = "Question5"
        '
        'MEnu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 669)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MEnu"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Question2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Question3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Question4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Question5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
