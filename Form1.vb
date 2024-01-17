Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles myItem.Click
        Dim myItem
        myItem = ("Enter your phone")
        ComboBox1.Items.Add(myItem)
    End Sub

    Private Sub myItem2_Click(sender As Object, e As EventArgs) Handles myItem2.Click
        Dim myItem2
        myItem2 = ("Enter your phone")
        ComboBox1.Items.Add(myItem2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.Items.Clear()
    End Sub
End Class
