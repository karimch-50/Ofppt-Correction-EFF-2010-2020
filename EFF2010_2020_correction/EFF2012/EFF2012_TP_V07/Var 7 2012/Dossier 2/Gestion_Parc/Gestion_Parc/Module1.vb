Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Common
Module Module1


    Public MyConnection As New SqlConnection("Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=Gestion_Parc;Integrated Security=True")
    Public MyDataSet As New DataSet
    Public myCOmmand As SqlCommand = MyConnection.CreateCommand
    Public MyDataAdapter As New SqlDataAdapter
    Public MyCommandBuilder As SqlCommandBuilder
    Public MyRow As DataRow
    Public Compteur As Integer = 0

End Module
