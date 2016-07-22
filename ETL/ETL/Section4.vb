Option Explicit On
Imports System.IO
Imports ETL.Main

Public Class Section4

    'Dim writer As StreamWriter = _
    '    New StreamWriter("c:\KBTest.txt")
    'Dim nSelectedIndex As String

    Private Property Section6 As Object
    Private Property Section7 As Object
    Private Property Section8 As Object
    Private Property Section9 As Object
    Private Property Section10 As Object
    Private Property Section11 As Object
    Private Property Section12 As Object
    Private Property Section13 As Object
    Private Property Section14 As Object
    Private Property Section15 As Object
    Private Property Section16 As Object
    Private Property Section17 As Object
    Private Property Section18 As Object
    Private Property Section19 As Object
    Private Property Section20 As Object
    Private Property Section21 As Object
    Private Property Section22 As Object
    Private Property Section23 As Object
    Private Property Section24 As Object
    Private Property Section25 As Object
    Private Property Section26 As Object

    'Private Sub btnNextS4_Click(sender As Object, e As EventArgs)

    '    Dim Done5 As Boolean = False
    '    Dim Done6 As Boolean = False
    '    Dim Done7 As Boolean = False
    '    Dim Done8 As Boolean = False
    '    Dim Done9 As Boolean = False
    '    Dim Done10 As Boolean = False
    '    Dim Done11 As Boolean = False
    '    Dim Done12 As Boolean = False
    '    Dim Done13 As Boolean = False
    '    Dim Done14 As Boolean = False
    '    Dim Done15 As Boolean = False
    '    Dim Done16 As Boolean = False
    '    Dim Done17 As Boolean = False
    '    Dim Done18 As Boolean = False
    '    Dim Done19 As Boolean = False
    '    Dim Done20 As Boolean = False
    '    Dim Done21 As Boolean = False
    '    Dim Done22 As Boolean = False
    '    Dim Done23 As Boolean = False
    '    Dim Done24 As Boolean = False
    '    Dim Done25 As Boolean = False
    '    Dim Done26 As Boolean = False

    '    Me.Hide()

    '    If Main.chkSec5.Checked Then
    '        Main2.Hide()
    '        Section5.Show()
    '        Done5 = True
    '        Exit Sub

    '    ElseIf Main.chkSec6.Checked Then
    '        Main2.Hide()
    '        Section6.Show()
    '        Done6 = True
    '        Exit Sub

    '    ElseIf Main.chkSec7.Checked Then
    '        Main2.Hide()
    '        Section7.Show()
    '        Done7 = True
    '        Exit Sub

    '    ElseIf Main.chkSec8.Checked Then
    '        Main2.Hide()
    '        Section8.Show()
    '        Done8 = True
    '        Exit Sub

    '    ElseIf Main.chkSec9.Checked Then
    '        Main2.Hide()
    '        Section9.Show()
    '        Done9 = True
    '        Exit Sub

    '    ElseIf Main.chkSec10.Checked Then
    '        Main2.Hide()
    '        Section10.Show()
    '        Done10 = True
    '        Exit Sub

    '    ElseIf Main.chkSec11.Checked Then
    '        Main2.Hide()
    '        Section11.Show()
    '        Done11 = True
    '        Exit Sub

    '    ElseIf Main.chkSec12.Checked Then
    '        Main2.Hide()
    '        Section12.Show()
    '        Done12 = True
    '        Exit Sub

    '    ElseIf Main.chkSec13.Checked Then
    '        Main2.Hide()
    '        Section13.Show()
    '        Done13 = True
    '        Exit Sub

    '    ElseIf Main.chkSec14.Checked Then
    '        Main2.Hide()
    '        Section14.Show()
    '        Done14 = True
    '        Exit Sub

    '    ElseIf Main.chkSec15.Checked Then
    '        Main2.Hide()
    '        Section15.Show()
    '        Done15 = True
    '        Exit Sub

    '    ElseIf Main.chkSec16.Checked Then
    '        Main2.Hide()
    '        Section16.Show()
    '        Done16 = True
    '        Exit Sub

    '    ElseIf Main.chkSec17.Checked Then
    '        Main2.Hide()
    '        Section17.Show()
    '        Done17 = True
    '        Exit Sub

    '    ElseIf Main.chkSec18.Checked Then
    '        Main2.Hide()
    '        Section18.Show()
    '        Done18 = True
    '        Exit Sub

    '    ElseIf Main.chkSec19.Checked Then
    '        Main2.Hide()
    '        Section19.Show()
    '        Done19 = True
    '        Exit Sub

    '    ElseIf Main.chkSec20.Checked Then
    '        Main2.Hide()
    '        Section20.Show()
    '        Done20 = True
    '        Exit Sub

    '    ElseIf Main.chkSec21.Checked Then
    '        Main2.Hide()
    '        Section21.Show()
    '        Done21 = True
    '        Exit Sub

    '    ElseIf Main.chkSec22.Checked Then
    '        Main2.Hide()
    '        Section22.Show()
    '        Done22 = True
    '        Exit Sub

    '    ElseIf Main.chkSec23.Checked Then
    '        Main2.Hide()
    '        Section23.Show()
    '        Done23 = True
    '        Exit Sub

    '    ElseIf Main.chkSec24.Checked Then
    '        Main2.Hide()
    '        Section24.Show()
    '        Done24 = True
    '        Exit Sub

    '    ElseIf Main.chkSec25.Checked Then
    '        Main2.Hide()
    '        Section25.Show()
    '        Done25 = True
    '        Exit Sub

    '    ElseIf Main.chkSec26.Checked Then
    '        Main2.Hide()
    '        Section26.Show()
    '        Done26 = True
    '        Exit Sub
    '    Else
    '        'nSelectedIndex = cboA1S4.SelectedText.ToString

    '        'writer.WriteLine("Section 4")
    '        'writer.WriteLine("Category: " & nSelectedIndex)
    '        'writer.WriteLine("Additional Comments: None")
    '        'writer.Close()
    '    End If
    'End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnNextSec4.Click
        Dim x As Integer = 5
        Dim y As Integer = 5
        Dim forms As Form() = {Section5, Section6, Section7, Section8, Section9, Section10, Section11, Section12, Section13, Section14, Section15, Section16, Section17, Section18, Section19, Section20, Section21, Section22, Section23, Section24, Section25, Section26}
        Dim Section As Form
        Dim chk As CheckBox
        Dim Checkboxes As CheckBox() = {Main2.mainInst.chkSec5, Main2.mainInst.chkSec6, Main2.mainInst.chkSec7, Main2.mainInst.chkSec8, Main2.mainInst.chkSec9, Main2.mainInst.chkSec10, Main2.mainInst.chkSec11, Main2.mainInst.chkSec12, Main2.mainInst.chkSec13, Main2.mainInst.chkSec13, Main2.mainInst.chkSec14, Main2.mainInst.chkSec15, Main2.mainInst.chkSec16, Main2.mainInst.chkSec17, Main2.mainInst.chkSec18, Main2.mainInst.chkSec19, Main2.mainInst.chkSec20, Main2.mainInst.chkSec21, Main2.mainInst.chkSec22, Main2.mainInst.chkSec23, Main2.mainInst.chkSec24, Main2.mainInst.chkSec25, Main2.mainInst.chkSec26}
        Me.Hide()
        For Each chk In Checkboxes
            If chk.Checked = True Then
                MessageBox.Show(x)
                Exit For
            End If
            x = x + 1
        Next chk
        For Each Section In forms
            If y = x Then
                Section.Show()
                Me.Hide()
                Exit Sub
            End If
            y = y + 1
        Next Section
        If y = x Then

        End If
    End Sub

    Private Sub Section4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class