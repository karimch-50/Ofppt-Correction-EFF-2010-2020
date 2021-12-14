Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Module Module1
    Public rep As New ReportDocument
    Public cnx As New SqlConnection("Data Source=localhost;Initial Catalog=var8_2012;Integrated Security=True")
    Public dt As SqlDataReader
    Public cmd As New SqlCommand
    Public ds As New DataSet
    Public data_vehicule As New SqlDataAdapter("select * from vehicule", cnx)
    Public data_conducteur As New SqlDataAdapter("select * from conducteur", cnx)
    Public data_panne As New SqlDataAdapter("select * from panne", cnx)
    Public data_histoconducteur As New SqlDataAdapter("select * from histoconducteur", cnx)
    Public data_assvehicule As New SqlDataAdapter("select * from assvehicule", cnx)
    Public Function exec(ByVal str As String, Optional ByVal type As String = "r")
        cmd.CommandText = str
        cmd.Connection = cnx
        opencnx()
        If type = "r" Then
            Return cmd.ExecuteReader
        Else
            Return cmd.ExecuteNonQuery
        End If
        closecnx()
    End Function
    Public Sub opencnx()
        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If
    End Sub
    Public Sub closecnx()
        If cnx.State = ConnectionState.Open Then
            cnx.Close()
        End If
    End Sub
    Public Function red_conducteur()
        Return exec("select * from conducteur")
    End Function
    Public Function red_veh()
        Return exec("select * from vehicule")
    End Function
    Public Function red_panne()
        Return exec("select * from panne")
    End Function
    Public Function red_suivant(ByVal tx As Integer)
        Return exec("select top 1 * from panne where idpanne >" & tx.ToString & " order by idpanne asc")
    End Function
    Public Function red_precedent(ByVal tx As Integer)
        Return exec("select top 1 * from panne where idpanne <" & tx.ToString & " order by idpanne desc")
    End Function
    Sub charge()
        data_panne.Fill(ds, "panne")
        data_conducteur.Fill(ds, "conducteur")
        data_histoconducteur.Fill(ds, "histoconducteur")
        data_assvehicule.Fill(ds, "assvehicule")
    End Sub
    Public Function red_veh_accs(ByVal tx As Integer)
        Return exec("select * from vehicule where immat=" & tx.ToString)
    End Function
    
End Module
