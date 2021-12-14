''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright ©2011-2012 AJDI Yassin, All Rights Reserved.
' 
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  G-Mail: yassin.ajdi@gmail.com
'  Facebook: https://www.facebook.com/yassin.ajdi
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class menu
    'sub clear forms in mdi form
    Public Sub clear()
        If Me.MdiChildren.Length > 0 Then
            Me.MdiChildren.First().Close()
        End If
    End Sub
    Public Sub menu_dynamic(ByVal x As Form)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub EtatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtatToolStripMenuItem.Click
        clear()
        menu_dynamic(Etat_imprimer)
    End Sub

    Private Sub HistogrammeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistogrammeToolStripMenuItem.Click
        clear()
        menu_dynamic(Histo)
    End Sub

    Private Sub FormulaireMiseAjourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormulaireMiseAjourToolStripMenuItem.Click
        clear()
        menu_dynamic(mise_ajour_autocar)
    End Sub

    Private Sub AjouterCalanderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterCalanderToolStripMenuItem.Click
        clear()
        menu_dynamic(ajoute_calander)
    End Sub

    Private Sub ConsulterListVoyagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsulterListVoyagesToolStripMenuItem.Click
        clear()
        menu_dynamic(List_voyages)
    End Sub

    Private Sub menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Me
            .MaximizeBox = False
            .MinimizeBox = False
            .TopMost = True
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
        End With
    End Sub
End Class