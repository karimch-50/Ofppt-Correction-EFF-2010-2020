Public Class Question3

    Private Sub Question3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myCOmmand.CommandText = "select * from Vehicule"
        MyDataAdapter.SelectCommand = myCOmmand
        MyDataAdapter.Fill(MyDataSet, "v")

        For Each dr As DataRow In MyDataSet.Tables("v").Rows
            ComboBox1.Items.Add(dr(0))
        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        myCOmmand.CommandText = "select E.NomEntretien,EV.DateEtretien, EV.KmVehicule from EntrVehicule EV ,Entretien E where E.IdEntretien = EV.IdEntretien AND EV.immat=" & ComboBox1.Text
        MyDataSet.Clear()
        MyDataAdapter.SelectCommand = myCOmmand
        MyDataAdapter.Fill(MyDataSet, "tbl")
        DataGridView1.DataSource = MyDataSet.Tables("tbl")

    End Sub
End Class