Public Class Section12

    Private Sub btnNextS12_Click(sender As Object, e As EventArgs)

        'Dim Done13 As Boolean = False
        'Dim Done14 As Boolean = False
        'Dim Done15 As Boolean = False
        'Dim Done16 As Boolean = False
        'Dim Done17 As Boolean = False
        'Dim Done18 As Boolean = False
        'Dim Done19 As Boolean = False
        'Dim Done20 As Boolean = False
        'Dim Done21 As Boolean = False
        'Dim Done22 As Boolean = False
        'Dim Done23 As Boolean = False
        'Dim Done24 As Boolean = False
        'Dim Done25 As Boolean = False
        'Dim Done26 As Boolean = False


        'Me.Hide()

        'If Main.chkSec13.Checked Then
        '    Main2.Hide()
        '    Section13.Show()
        '    Done13 = True
        '    Exit Sub

        'ElseIf Main.chkSec14.Checked Then
        '    Main2.Hide()
        '    Section14.Show()
        '    Done14 = True
        '    Exit Sub

        'ElseIf Main.chkSec15.Checked Then
        '    Main2.Hide()
        '    Section15.Show()
        '    Done15 = True
        '    Exit Sub

        'ElseIf Main.chkSec16.Checked Then
        '    Main2.Hide()
        '    Section16.Show()
        '    Done16 = True
        '    Exit Sub

        'ElseIf Main.chkSec17.Checked Then
        '    Main2.Hide()
        '    Section17.Show()
        '    Done17 = True
        '    Exit Sub

        'ElseIf Main.chkSec18.Checked Then
        '    Main2.Hide()
        '    Section18.Show()
        '    Done18 = True
        '    Exit Sub

        'ElseIf Main.chkSec19.Checked Then
        '    Main2.Hide()
        '    Section19.Show()
        '    Done19 = True
        '    Exit Sub

        'ElseIf Main.chkSec20.Checked Then
        '    Main2.Hide()
        '    Section20.Show()
        '    Done20 = True
        '    Exit Sub

        'ElseIf Main.chkSec21.Checked Then
        '    Main2.Hide()
        '    Section21.Show()
        '    Done21 = True
        '    Exit Sub

        'ElseIf Main.chkSec22.Checked Then
        '    Main2.Hide()
        '    Section22.Show()
        '    Done22 = True

        'ElseIf Main.chkSec23.Checked Then
        '    Main2.Hide()
        '    Section23.Show()
        '    Done23 = True
        '    Exit Sub

        'ElseIf Main.chkSec24.Checked Then
        '    Main2.Hide()
        '    Section24.Show()
        '    Done24 = True
        '    Exit Sub

        'ElseIf Main.chkSec25.Checked Then
        '    Main2.Hide()
        '    Section25.Show()
        '    Done25 = True
        '    Exit Sub

        'ElseIf Main.chkSec26.Checked Then
        '    Main2.Hide()
        '    Section26.Show()
        '    Done26 = True
        'Else
        '    MessageBox.Show("Please Select at least 1 Section Number.")
        'End If
    End Sub

    Private Sub Section12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNextSec12_Click(sender As Object, e As EventArgs) Handles btnNextSec12.Click
        Dim x As Integer = 13
        Dim y As Integer = 13
        Dim forms As Form() = {Section13, Section14, Section15, Section16, Section17, Section18, Section19, Section20, Section21, Section22, Section23, Section24, Section25, Section26}
        Dim Section As Form
        Dim chk As CheckBox
        Dim Checkboxes As CheckBox() = {Main2.mainInst.chkSec13, Main2.mainInst.chkSec13, Main2.mainInst.chkSec14, Main2.mainInst.chkSec15, Main2.mainInst.chkSec16, Main2.mainInst.chkSec17, Main2.mainInst.chkSec18, Main2.mainInst.chkSec19, Main2.mainInst.chkSec20, Main2.mainInst.chkSec21, Main2.mainInst.chkSec22, Main2.mainInst.chkSec23, Main2.mainInst.chkSec24, Main2.mainInst.chkSec25, Main2.mainInst.chkSec26}

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

    Private Sub txtSection5_TextChanged(sender As Object, e As EventArgs) Handles txtSection5.TextChanged

    End Sub
End Class