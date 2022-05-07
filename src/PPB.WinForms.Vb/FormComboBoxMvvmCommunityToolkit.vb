Imports PPB.ViewModels.Cs

Public Class FormComboBoxMvvmCommunityToolkit

    Dim formViewModel As ComboBoxViewModelCommunityMvvmCs = New ComboBoxViewModelCommunityMvvmCs()

    Private Sub FormComboBoxMvvmCommunityToolkit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call formViewModel.Form_Load()

        Me.ComboBox1.DataBindings.Add("DataSource", formViewModel, "comboBox1_DataSource")
        Me.ComboBox1.DataBindings.Add("SelectedValue", formViewModel, "comboBox1_SelectedValue")
        Me.ComboBox1.DataBindings.Add("Enabled", formViewModel, "comboBox1_Enabled")

        Me.TextBox1.DataBindings.Add("Text", formViewModel, "comboBox1_SelectedValue")


    End Sub
End Class