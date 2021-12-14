<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Question2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Question3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Question4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Question5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Question6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Question2ToolStripMenuItem, Me.Question3ToolStripMenuItem, Me.Question4ToolStripMenuItem, Me.Question5ToolStripMenuItem, Me.Question6ToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'Question2ToolStripMenuItem
        '
        Me.Question2ToolStripMenuItem.Name = "Question2ToolStripMenuItem"
        Me.Question2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Question2ToolStripMenuItem.Text = "Question 2"
        '
        'Question3ToolStripMenuItem
        '
        Me.Question3ToolStripMenuItem.Name = "Question3ToolStripMenuItem"
        Me.Question3ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Question3ToolStripMenuItem.Text = "Question 3"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'Question4ToolStripMenuItem
        '
        Me.Question4ToolStripMenuItem.Name = "Question4ToolStripMenuItem"
        Me.Question4ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Question4ToolStripMenuItem.Text = "Question 4"
        '
        'Question5ToolStripMenuItem
        '
        Me.Question5ToolStripMenuItem.Name = "Question5ToolStripMenuItem"
        Me.Question5ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Question5ToolStripMenuItem.Text = "Question 5"
        '
        'Question6ToolStripMenuItem
        '
        Me.Question6ToolStripMenuItem.Name = "Question6ToolStripMenuItem"
        Me.Question6ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Question6ToolStripMenuItem.Text = "Question 6"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Question2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Question3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Question4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Question5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Question6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
