﻿Public Class Section18

    Private Sub btnNextS18_Click(sender As Object, e As EventArgs)

        'Dim Done19 As Boolean = False
        'Dim Done20 As Boolean = False
        'Dim Done21 As Boolean = False
        'Dim Done22 As Boolean = False
        'Dim Done23 As Boolean = False
        'Dim Done24 As Boolean = False
        'Dim Done25 As Boolean = False
        'Dim Done26 As Boolean = False

        'Me.Hide()

        'If Main.chkSec19.Checked Then
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
        '    Exit Sub

        'ElseIf Main.chkSec23.Checked Then
        '    Me.Hide()
        '    Section23.Show()
        '    Done23 = True
        '    Exit Sub

        'ElseIf Main.chkSec24.Checked Then
        '    Me.Hide()
        '    Section24.Show()
        '    Done24 = True
        '    Exit Sub

        'ElseIf Main.chkSec25.Checked Then
        '    Me.Hide()
        '    Section25.Show()
        '    Done25 = True
        '    Exit Sub

        'ElseIf Main.chkSec26.Checked Then
        '    Me.Hide()
        '    Section26.Show()
        '    Done26 = True
        '    Exit Sub
        'Else
        '    MessageBox.Show("Please Select at least 1 Section Number.")
        'End If
    End Sub

    Private Sub btnNextSec18_Click(sender As Object, e As EventArgs) Handles btnNextSec18.Click
        Dim x As Integer = 19
        Dim y As Integer = 19
        Dim forms As Form() = {Section19, Section20, Section21, Section22, Section23, Section24, Section25, Section26}
        Dim Section As Form
        Dim chk As CheckBox
        Dim Checkboxes As CheckBox() = {Main2.mainInst.chkSec19, Main2.mainInst.chkSec20, Main2.mainInst.chkSec21, Main2.mainInst.chkSec22, Main2.mainInst.chkSec23, Main2.mainInst.chkSec24, Main2.mainInst.chkSec25, Main2.mainInst.chkSec26}

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

    Private Sub Section18_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class