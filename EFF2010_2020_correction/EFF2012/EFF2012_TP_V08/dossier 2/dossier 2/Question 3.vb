Public Class Question_3

    Private Sub Question_3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = red_veh()
        While dt.Read
            ComboBox1.Items.Add(dt(0))
        End While
        dt.Close()
        charge()
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        For i = 0 To ds.Tables("histoconducteur").Rows.Count - 1
            If ComboBox1.Text = ds.Tables("histoconducteur").Rows(i)(1) Then
                For j = 0 To ds.Tables("conducteur").Rows.Count - 1
                    If ds.Tables("histoconducteur").Rows(i)(2) = ds.Tables("conducteur").Rows(j)(0) Then
                        DataGridView1.Rows.Add(ds.Tables("conducteur").Rows(j)(1), ds.Tables("conducteur").Rows(j)(2), ds.Tables("histoconducteur").Rows(i)(3), ds.Tables("histoconducteur").Rows(i)(4))
                    End If
                Next

            End If
        Next


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                If row.Cells(4).Value = 1 Then
                    cmd.CommandText = "delete conducteur from conducteur where nomC='" & row.Cells(0).Value & "' and prenC='" & row.Cells(1).Value & "'"
                    cmd.Connection = cnx
                    cnx.Open()
                    cmd.ExecuteNonQuery()
                    cnx.Close()
                End If
            End If
        Next
    End Sub
End Class