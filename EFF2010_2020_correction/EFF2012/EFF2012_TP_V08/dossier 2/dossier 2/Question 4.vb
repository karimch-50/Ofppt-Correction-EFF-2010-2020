Public Class Question_4

    Private Sub Question_4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        For i = 0 To ds.Tables("assvehicule").Rows.Count - 1
            If TextBox1.Text = ds.Tables("assvehicule").Rows(i)(0) And TextBox2.Text = ds.Tables("assvehicule").Rows(i)(0) Then

                For j = 0 To ds.Tables("vehicule").Rows.Count - 1
                    If ds.Tables("assvehicule").Rows(i)(4) = ds.Tables("vehicule").Rows(j)(0) Then
                        DataGridView1.Rows.Add(ds.Tables("vehicule").Rows(j)(0), ds.Tables("vehicule").Rows(j)(1), ds.Tables("vehicule").Rows(j)(2), ds.Tables("vehicule").Rows(j)(3), ds.Tables("vehicule").Rows(j)(4), ds.Tables("vehicule").Rows(j)(5), ds.Tables("vehicule").Rows(j)(6), ds.Tables("vehicule").Rows(j)(7))
                    End If
                Next
            End If
        Next
    End Sub
End Class