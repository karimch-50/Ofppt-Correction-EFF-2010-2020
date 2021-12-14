Imports System.Data.SqlClient
Imports System.Data
Public Class Question4

    Private Sub Question4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myCOmmand.CommandText = "select * from Vehicule"
        MyDataAdapter.SelectCommand = myCOmmand
        MyDataAdapter.Fill(MyDataSet, "v")

        For Each dr As DataRow In MyDataSet.Tables("v").Rows
            ComboBox1.Items.Add(dr(0))
        Next

        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).Name = "ID"
        DataGridView1.Columns(1).Name = "Immatriculation"
        DataGridView1.Columns(2).Name = "ID_Entretien"
        DataGridView1.Columns(3).Name = "Date"
        DataGridView1.Columns(4).Name = "KM_vehicule"

        Dim c As New DataGridViewCheckBoxColumn
        c.Name = "selectionner"
        DataGridView1.Columns.Add(c)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        myCOmmand.CommandText = "select EV.* from Vehicule V,EntrVehicule EV Where V.immat=EV.immat and V.compteur>EV.KmVehicule and V.immat=" & ComboBox1.Text
        MyDataSet.Clear()
        MyDataAdapter.SelectCommand = myCOmmand
        DataGridView1.Rows.Clear()
        MyDataAdapter.Fill(MyDataSet, "tbl")
        For Each dr As DataRow In MyDataSet.Tables("tbl").Rows
            DataGridView1.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(5).Value = True Then
                MyDataSet.Tables("tbl").Rows(i).Delete()
            End If
        Next
    End Sub
End Class