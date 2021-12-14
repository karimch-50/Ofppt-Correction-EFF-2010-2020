Imports System.Data.SqlClient
Imports System.Data
Public Class Question2

    Private Sub Question2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myCOmmand.CommandText = "select * from Conducteur"
        MyDataAdapter.SelectCommand = myCOmmand
        MyDataAdapter.Fill(MyDataSet, "Conducteur")

        For Each dr As DataRow In MyDataSet.Tables("Conducteur").Rows
            ComboBox1.Items.Add(dr(0))
        Next


        myCOmmand.CommandText = "select * from Vehicule"
        MyDataAdapter.SelectCommand = myCOmmand
        MyDataAdapter.Fill(MyDataSet, "Vehicule")
        Dim dt As DataTable = MyDataSet.Tables("Vehicule")

        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Compteur -= 1
        If Compteur < 0 Then
            Compteur = 0
        End If
        With MyDataSet.Tables("Vehicule").Rows(Compteur)
            TextBox1.Text = .Item(0)
            TextBox2.Text = .Item(1)
            TextBox3.Text = .Item(2)
            TextBox4.Text = .Item(3)
            TextBox5.Text = .Item(4)
            TextBox6.Text = .Item(5)
            TextBox7.Text = .Item(6)
            ComboBox1.SelectedIndex = Compteur
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Compteur = 0
        With MyDataSet.Tables("Vehicule").Rows(Compteur)
            TextBox1.Text = .Item(0)
            TextBox2.Text = .Item(1)
            TextBox3.Text = .Item(2)
            TextBox4.Text = .Item(3)
            TextBox5.Text = .Item(4)
            TextBox6.Text = .Item(5)
            TextBox7.Text = .Item(6)
            ComboBox1.SelectedIndex = Compteur
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Compteur += 1
        If Compteur > MyDataSet.Tables("Vehicule").Rows.Count - 1 Then
            Compteur = 0
        End If
        With MyDataSet.Tables("Vehicule").Rows(Compteur)
            TextBox1.Text = .Item(0)
            TextBox2.Text = .Item(1)
            TextBox3.Text = .Item(2)
            TextBox4.Text = .Item(3)
            TextBox5.Text = .Item(4)
            TextBox6.Text = .Item(5)
            TextBox7.Text = .Item(6)
            ComboBox1.SelectedIndex = Compteur
        End With
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Compteur = MyDataSet.Tables("Vehicule").Rows.Count - 1
        With MyDataSet.Tables("Vehicule").Rows(Compteur)
            TextBox1.Text = .Item(0)
            TextBox2.Text = .Item(1)
            TextBox3.Text = .Item(2)
            TextBox4.Text = .Item(3)
            TextBox5.Text = .Item(4)
            TextBox6.Text = .Item(5)
            TextBox7.Text = .Item(6)
            ComboBox1.SelectedIndex = Compteur
        End With
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MyRow = MyDataSet.Tables("Vehicule").NewRow
        MyRow(0) = TextBox1.Text
        MyRow(1) = TextBox2.Text
        MyRow(2) = TextBox3.Text
        MyRow(3) = TextBox4.Text
        MyRow(4) = TextBox5.Text
        MyRow(5) = TextBox6.Text
        MyRow(6) = TextBox7.Text
        MyRow(7) = CInt(ComboBox1.Text)
        MyDataSet.Tables("Vehicule").Rows.Add(MyRow)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        For i As Integer = 0 To MyDataSet.Tables("Vehicule").Rows().Count - 1
            If MyDataSet.Tables("Vehicule").Rows(i)(0) = Val(TextBox1.Text) Then
                With MyDataSet.Tables("Vehicule").Rows(i)
                    .BeginEdit()
                    .Item(0) = TextBox1.Text
                    .Item(1) = TextBox2.Text
                    .Item(2) = TextBox3.Text
                    .Item(3) = TextBox4.Text
                    .Item(4) = TextBox5.Text
                    .Item(5) = TextBox6.Text
                    .Item(6) = TextBox7.Text
                    .Item(7) = CInt(ComboBox1.Text)
                    .EndEdit()
                End With
                Exit For
            End If
        Next i
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MyCommandBuilder = New SqlCommandBuilder(MyDataAdapter)
        MyDataAdapter.Update(MyDataSet, "Vehicule")

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        For i As Integer = 0 To MyDataSet.Tables("Vehicule").Rows.Count - 1
            If MyDataSet.Tables("Vehicule").Rows(i)(0) = TextBox1.Text Then
                MyDataSet.Tables("Vehicule").Rows(i).Delete()
                Exit Sub
            End If
        Next i
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class