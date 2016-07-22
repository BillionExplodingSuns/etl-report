Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO

Public Class RecordTest2
    Inherits System.Windows.Forms.Form
    Public myCallerRec2 As Portal
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTest.SelectedIndexChanged
        If cmbTest.SelectedIndex <> -1 Then
            TextBox4.Enabled = True
            Button2.Enabled = True
            Button1.Enabled = True
            grpComp.Enabled = True
            grpSuscep.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Portal.recordTestInst.Show()
        RecordTest.recordtest2inst.Hide()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        txtNonComp.Enabled = False
        txtNonComp.Text = ""
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        txtSusceptible.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        txtNonComp.Enabled = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        txtSusceptible.Enabled = False
        txtSusceptible.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = cmbTest.SelectedItem & ".ini"
        'For Each strFolder As String In System.IO.Directory.
        '    MessageBox.Show(strFolder)
        '    If Path.GetFileName(strFolder) = FolderBrowserDialog1.SelectedPath & "\" & "Report Data" Then
        '        System.IO.File.Delete(strFolder)
        '    End If
        'Next
        FolderBrowserDialog1.SelectedPath = Portal.recordTestInst.FolderBrowserDialog1.SelectedPath
        IO.File.WriteAllText(FolderBrowserDialog1.SelectedPath & "\" & "Report Data" & "\" & name, "")
        FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & "Report Data"
        Using file As StreamWriter = New StreamWriter(FolderBrowserDialog1.SelectedPath & "\" & name, True)
            'Dim iniFile = Application.StartupPath + "\" & name
            'Dim Section = "Settings"
            'Dim Author = "Author"
            'Dim org = "Organization"
            file.WriteLine("[" & TextBox4.Text & "]") 'category
            If RadioButton1.Checked = True Then
                file.WriteLine("compliant=" & RadioButton1.Text.ToLower)
            ElseIf RadioButton2.Checked = True Then
                file.WriteLine("compliant=" & RadioButton2.Text.ToLower)
                file.WriteLine("failures=" & txtNonComp.Text)
            Else
                file.WriteLine("compliant=" & "")
            End If
            file.WriteLine("susceptibilities=" & txtSusceptible.Text)
            file.Close()
        End Using
        MessageBox.Show(ReadIni(FolderBrowserDialog1.SelectedPath & "\" & name, TextBox4.Text, "compliant", ""))
    End Sub

    Private Sub RecordTest2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FolderBrowserDialog1.SelectedPath = Portal.recordTestInst.FolderBrowserDialog1.SelectedPath
    End Sub
End Class
