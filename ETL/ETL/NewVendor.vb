Imports System.IO
Imports System.Diagnostics.Process
'This Form is intended to add new vendors into ETL Test file directories 

''' <summary>
''' Eventually will want to add vendor names/contacts into database
''' </summary>
''' <remarks></remarks>

Public Class NewVendor

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim answer As MsgBoxResult
        If cmbYear.SelectedIndex <> -1 And txtNewName.TextLength > 0 And txtReport.TextLength > 0 Then
            answer = MsgBox("Vendor will not be added. Continue?", MsgBoxStyle.YesNo)
        Else
            Me.Hide()
            Main2.Show()
        End If
        If answer = MsgBoxResult.Yes Then
            cmbYear.Items.Clear()
            cmbYear.Text = ""
            txtNewName.Text = ""
            txtReport.Text = ""
            Me.Hide()
            Main2.Show()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Add_Vendor.Click

        'On Error GoTo ErrHandler
        'MessageBox.Show((StrComp("", txtNewName.Text, CompareMethod.Binary)))
        '& (StrComp("", txtNewName.Text) = 0) = False & (StrComp("", txtReport.Text) = 0) = False Then
        Dim exist As Boolean = False
        Dim fileMain As String
        If cmbYear.SelectedIndex <> -1 Then
            fileMain = "K:ETL Test Files\" & cmbYear.SelectedItem
            For Each strFolder As String In System.IO.Directory.GetDirectories(fileMain)
                If Path.GetFileName(strFolder) = cmbYear.SelectedItem Then
                    exist = True
                    MsgBox("Vendor already exists", vbCritical, "Error")
                End If
            Next
        End If

        If txtNewName.Text.Length > 0 And cmbYear.SelectedIndex <> -1 And txtReport.Text.Length > 0 And exist = False Then
            FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files" & "\" & cmbYear.SelectedItem & "\" & txtNewName.Text
            MkDir(FolderBrowserDialog1.SelectedPath)        ''creates new folder for vendor

            'lines are adding fill folders into new vendor folder
            MkDir(FolderBrowserDialog1.SelectedPath & "\" & txtReport.Text)
            MkDir(FolderBrowserDialog1.SelectedPath & "\" & txtReport.Text & "\" & "Quote and PO")
            MkDir(FolderBrowserDialog1.SelectedPath & "\" & txtReport.Text & "\" & "Test Data")
            MkDir(FolderBrowserDialog1.SelectedPath & "\" & txtReport.Text & "\" & "Test Plan")
            MkDir(FolderBrowserDialog1.SelectedPath & "\" & txtReport.Text & "\" & "Test Report")
            MkDir(FolderBrowserDialog1.SelectedPath & "\" & txtReport.Text & "\" & "Time Sheet")

            'used to fill test report folder
            MkDir(FolderBrowserDialog1.SelectedPath & "\" & txtReport.Text & "\" & "Test Report" & "\" & "Report Data")


            'used to fill subfolders of vendor with fill folders in Test Data
            FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & txtReport.Text & "\" & "Test Data"
            MkDir(FolderBrowserDialog1.SelectedPath & "\" & "Conformity Paperwork")
            MkDir(FolderBrowserDialog1.SelectedPath & "\" & "NFR")
            MkDir(FolderBrowserDialog1.SelectedPath & "\" & "Test Setup Charts")
            My.Computer.FileSystem.CopyFile("C:\UserFiles\TestFiles\testFile.txt", "C:\UserFiles\TestFiles2\testFile.txt")
            My.Computer.FileSystem.CopyFile("K:\Visual Basic\Visual Basic 2\Visual Basic 1\Test Status.xlsx", FolderBrowserDialog1.SelectedPath & "\" & "Test Status.xlsx")
            FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files\" & cmbYear.SelectedItem & "\" & txtNewName.Text & "\" & txtReport.Text & "\" & "Time Sheet"
            My.Computer.FileSystem.CopyFile("C:\Users\rramirez\Downloads\Rueben Trials" & "Equipment.xlsx", FolderBrowserDialog1.SelectedPath & "\Equipment.xlsx")

            'will confirm added vendor and clear out entry fields
            'fills in combo box selection from main2.vb form
            Main2.cmbYear.Text = Me.cmbYear.SelectedItem
            Main2.cboVendorName.Text = Me.txtNewName.Text
            Main2.cmbReport.Text = Me.txtReport.Text
            cmbYear.Items.Clear()
            cmbYear.Text = ""
            txtNewName.Text = ""
            txtReport.Text = ""
            MessageBox.Show("Added Vendor and Report.")
            For Each strFolder As String In System.IO.Directory.GetDirectories("K:\ETL Test Files")
                cmbYear.Items.Add(Path.GetFileName(strFolder))
            Next
        End If

    End Sub

End Class