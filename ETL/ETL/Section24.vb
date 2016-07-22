Public Class Section24

    Private Sub btnNextS24_Click(sender As Object, e As EventArgs) Handles btnNextS24.Click
        Dim x As Integer = 25
        Dim y As Integer = 25
        Dim forms As Form() = {Section25, Section26}
        Dim Section As Form
        Dim chk As CheckBox
        Dim Checkboxes As CheckBox() = {Main2.mainInst.chkSec25, Main2.mainInst.chkSec26}

        Me.Hide()
        For Each chk In Checkboxes
            If chk.Checked = True Then
                Exit For
            End If
            x = x + 1
        Next chk

        For Each Section In forms
            If y = x Then
                Section.Show()
                Exit Sub
            End If
            y = y + 1
        Next Section
    End Sub
End Class