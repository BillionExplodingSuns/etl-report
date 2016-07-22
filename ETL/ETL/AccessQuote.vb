Imports System.IO

Public Class AccessQuote

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        FolderBrowserDialog1.SelectedPath = "K:ETL Test Files"
        If cmbYear.SelectedIndex <> -1 And cboVendorName.SelectedIndex <> -1 Then
            FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & cmbYear.SelectedItem & "\" & cboVendorName.SelectedItem
        End If
        Portal.Show()
        Me.Hide()
    End Sub

    Private Sub AccessQuote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileMain = FolderBrowserDialog1.SelectedPath
        For Each strFolder As String In System.IO.Directory.GetDirectories(fileMain)
            If Path.GetFileName(strFolder) = "2016" Then
                cmbYear.Items.Add(Path.GetFileName(strFolder))
            End If
        Next
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        cmbQuote.Items.Clear()
        cmbQuote.Text = ""
        cboVendorName.Items.Clear()
        cboVendorName.Text = ""
        FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files"
        If (cmbYear.SelectedIndex <> -1) Then
            cboVendorName.Enabled = True
            FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & cmbYear.SelectedItem
        End If
        For Each strFolder As String In System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)
            cboVendorName.Items.Add(Path.GetFileName(strFolder))
        Next
    End Sub

    Private Sub cboVendorName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVendorName.SelectedIndexChanged
        FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files"
        If (cboVendorName.SelectedIndex <> -1) Then
            cmbTest.Enabled = True
            FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & "\" & cmbYear.Text & "\" & cboVendorName.SelectedItem
        End If

        For Each strfolder As String In System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)
            cmbTest.Items.Add(Path.GetFileName(strfolder))
        Next
    End Sub

    Private Sub cmbTest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTest.SelectedIndexChanged
        FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files"
        If (cboVendorName.SelectedIndex <> -1) Then
            cmbQuote.Enabled = True
            FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & "\" & cmbYear.SelectedItem & "\" & cboVendorName.SelectedItem & "\" & cmbTest.SelectedItem & "\" & "Quote and PO"
        End If

        For Each strfolder As String In System.IO.Directory.GetFiles(FolderBrowserDialog1.SelectedPath)
            cmbQuote.Items.Add(Path.GetFileName(strfolder))
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        If cmbYear.SelectedIndex <> -1 And cboVendorName.SelectedIndex <> -1 And cmbTest.SelectedIndex <> -1 And cmbQuote.SelectedIndex <> -1 Then
            FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files" & "\" & cmbYear.SelectedItem & "\" & cboVendorName.SelectedItem & "\" & cmbTest.SelectedItem & "\" & "Quote and PO" & "\" & cmbQuote.SelectedItem
            File.Open(FolderBrowserDialog1.SelectedPath, FileMode.Open, FileAccess.Read)
        End If
    End Sub

    Private Sub cmbQuote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQuote.SelectedIndexChanged
        FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files" & "\" & cmbYear.SelectedItem & "\" & cboVendorName.SelectedItem & "\" & cmbTest.SelectedItem & "\" & "Quote and PO"
        If cmbQuote.SelectedIndex <> -1 Then
            FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & cmbQuote.SelectedItem
        End If
    End Sub
End Class