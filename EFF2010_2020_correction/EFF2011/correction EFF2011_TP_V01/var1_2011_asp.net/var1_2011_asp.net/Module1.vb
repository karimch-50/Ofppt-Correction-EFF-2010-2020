Imports System.Data.SqlClient
Module Module1
    Public cn As New SqlConnection("Data Source=(local);Initial Catalog=v12011;Integrated Security=True")
    Public dr As SqlDataReader
    Public cmd As SqlCommand
    Public dataset As New DataSet
    Public ds As New DataSet1
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Copyright ©2011-2012 AJDI Yassin, All Rights Reserved.
    ' 
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '  G-Mail: yassin.ajdi@gmail.com
    '  Facebook: https://www.facebook.com/yassin.ajdi
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
End Module
