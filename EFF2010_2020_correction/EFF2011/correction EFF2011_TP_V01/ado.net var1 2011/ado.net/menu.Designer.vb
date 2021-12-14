<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.EtatQ2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EtatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HistogrammeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Q3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FormulaireMiseAjourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AjouterCalanderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsulterListVoyagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EtatQ2ToolStripMenuItem, Me.Q3ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1118, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EtatQ2ToolStripMenuItem
        '
        Me.EtatQ2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EtatToolStripMenuItem, Me.HistogrammeToolStripMenuItem})
        Me.EtatQ2ToolStripMenuItem.Name = "EtatQ2ToolStripMenuItem"
        Me.EtatQ2ToolStripMenuItem.Size = New System.Drawing.Size(55, 19)
        Me.EtatQ2ToolStripMenuItem.Text = "Q2 & Q6"
        '
        'EtatToolStripMenuItem
        '
        Me.EtatToolStripMenuItem.Name = "EtatToolStripMenuItem"
        Me.EtatToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.EtatToolStripMenuItem.Text = "Q2 Etat"
        '
        'HistogrammeToolStripMenuItem
        '
        Me.HistogrammeToolStripMenuItem.Name = "HistogrammeToolStripMenuItem"
        Me.HistogrammeToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.HistogrammeToolStripMenuItem.Text = "Q6 histogramme"
        '
        'Q3ToolStripMenuItem
        '
        Me.Q3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormulaireMiseAjourToolStripMenuItem, Me.AjouterCalanderToolStripMenuItem, Me.ConsulterListVoyagesToolStripMenuItem})
        Me.Q3ToolStripMenuItem.Name = "Q3ToolStripMenuItem"
        Me.Q3ToolStripMenuItem.Size = New System.Drawing.Size(76, 19)
        Me.Q3ToolStripMenuItem.Text = "Q3 & Q4 & Q5"
        '
        'FormulaireMiseAjourToolStripMenuItem
        '
        Me.FormulaireMiseAjourToolStripMenuItem.Name = "FormulaireMiseAjourToolStripMenuItem"
        Me.FormulaireMiseAjourToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.FormulaireMiseAjourToolStripMenuItem.Text = "Q3 Formulaire mise ajour"
        '
        'AjouterCalanderToolStripMenuItem
        '
        Me.AjouterCalanderToolStripMenuItem.Name = "AjouterCalanderToolStripMenuItem"
        Me.AjouterCalanderToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AjouterCalanderToolStripMenuItem.Text = "Q4 Ajouter Calander"
        '
        'ConsulterListVoyagesToolStripMenuItem
        '
        Me.ConsulterListVoyagesToolStripMenuItem.Name = "ConsulterListVoyagesToolStripMenuItem"
        Me.ConsulterListVoyagesToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ConsulterListVoyagesToolStripMenuItem.Text = "Q5 Consulter list voyages"
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1118, 618)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "menu"
        Me.Text = "menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EtatQ2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EtatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistogrammeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Q3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormulaireMiseAjourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterCalanderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsulterListVoyagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
