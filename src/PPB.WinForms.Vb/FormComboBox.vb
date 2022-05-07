Public Class FormComboBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As Form = New FormComboBoxMvvmCommunityToolkit()
        form.ShowDialog()
    End Sub
End Class