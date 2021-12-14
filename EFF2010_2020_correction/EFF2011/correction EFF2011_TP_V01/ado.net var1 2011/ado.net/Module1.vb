Imports System.Data.SqlClient
Module Module1
    Public cn As New SqlConnection("Data Source=(local);Initial Catalog=v12011;Integrated Security=True")
    Public dr As SqlDataReader
    Public cmd As SqlCommand
    Public dt As DataTable
    Public da As SqlDataAdapter
    Public ds As New DataSet1
    'des parametres pour l'affichage des forms
    Public Sub affichage_form(ByVal f As Form)
        With f
            'Restore down = agrandire :p
            .MaximizeBox = True
            'reduire
            .MinimizeBox = False
            'full screen
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
        End With
    End Sub
    Public Sub exception(ByVal ex As Exception)
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Copyright ©2011-2012 AJDI Yassin, All Rights Reserved.
    ' 
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '  G-Mail: yassin.ajdi@gmail.com
    '  Facebook: https://www.facebook.com/yassin.ajdi
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
End Module
