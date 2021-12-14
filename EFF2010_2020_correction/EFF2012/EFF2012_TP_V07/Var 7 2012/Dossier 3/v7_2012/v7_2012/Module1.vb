Imports System.Data.SqlClient
Module Module1
    Public cn As New SqlConnection("server=.;initial catalog=v7_2012;integrated security=true")
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public ds As New DataSet
    Public dacond As New SqlDataAdapter("select * from conducteur", cn)
    Public daveh As New SqlDataAdapter("select * from vehicule", cn)
    Public daentr As New SqlDataAdapter("select * from entretien", cn)
End Module
