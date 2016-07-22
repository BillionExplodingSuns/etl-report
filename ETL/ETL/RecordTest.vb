Imports System.IO
Imports System.Diagnostics.Process

Public Class RecordTest
    Inherits System.Windows.Forms.Form
    Public myCallerRec As Portal
    Protected Friend Shared recordtest2inst As RecordTest2 = New RecordTest2

    Private Sub RecordTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'recordtest2inst.MdiParent = Portal.recordTestInst
        Dim fileMain = FolderBrowserDialog1.SelectedPath
        For Each strFolder As String In IO.Directory.GetDirectories(fileMain)
            cmbYear.Items.Add(Path.GetFileName(strFolder))
        Next

        'For Each row In DataSet1.Tables(1).Rows
        '    row.Vendor_Name = Trim(row.Vendor_Name)
        '    row.Folder_Path = Trim(row.Folder_Path)
        'Next row
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the program
        Portal.portalInst.Show()
        Portal.recordTestInst.Hide()
    End Sub

    Private Function trim_string(ByRef old_string As String)
        Dim new_string As String
        new_string = Trim(old_string)   'removes any leading or trailing spaces in string
        Return new_string
    End Function

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Portal.portalInst.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim warningString As String = "Please complete the following information to continue: " & vbNewLine & vbNewLine     'String to show user for error catching

        'If statement that determines if information has been selected from the comboboxes
        If cmbYear.SelectedIndex = -1 Then
            warningString = warningString + "Year" & vbNewLine & "Vendor" & vbNewLine & "Report" & vbNewLine & "Section"
            txtYear.ForeColor = Color.Red
            TextBox7.ForeColor = Color.Red
            txtReport.ForeColor = Color.Red
            TextBox1.ForeColor = Color.Red
            MessageBox.Show(warningString)
        ElseIf cboVendorName.SelectedIndex = -1 Then
            warningString = warningString + "Vendor" + vbNewLine & "Report" & vbNewLine & "Section"
            txtYear.ForeColor = Color.Black
            TextBox7.ForeColor = Color.Red
            txtReport.ForeColor = Color.Red
            TextBox1.ForeColor = Color.Red
            MessageBox.Show(warningString)
        ElseIf cmbReport.SelectedIndex = -1 Then
            warningString = warningString + "Report" & vbNewLine & "Section"
            txtYear.ForeColor = Color.Black
            TextBox7.ForeColor = Color.Black
            txtReport.ForeColor = Color.Red
            TextBox1.ForeColor = Color.Red
            MessageBox.Show(warningString)
        ElseIf cmbSection.SelectedIndex = -1 Then
            warningString = warningString + "Section" & vbNewLine
            txtYear.ForeColor = Color.Black
            TextBox7.ForeColor = Color.Black
            txtReport.ForeColor = Color.Black
            TextBox1.ForeColor = Color.Red
            MessageBox.Show(warningString)
        Else
            txtYear.ForeColor = Color.Black
            TextBox7.ForeColor = Color.Black
            txtReport.ForeColor = Color.Black
            TextBox1.ForeColor = Color.Black
            If recordtest2inst Is Nothing Then
                recordtest2inst = New RecordTest2
                'recordtest2inst.myCallerRec2 = Me
            End If
            FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files" & "\" & cmbYear.SelectedItem & "\" & cboVendorName.SelectedItem & "\" & cmbReport.SelectedItem & "\" & "Test Report"
            recordtest2inst.Show()
            Portal.recordTestInst.Hide()
        End If
    End Sub

    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        Dim path As String
        path = FolderBrowserDialog1.SelectedPath
        FolderBrowserDialog1.ShowDialog()
    End Sub

    Private Function VendorInfoAdapter() As Object
        Throw New NotImplementedException
    End Function
    'used to get file path
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    MessageBox.Show(FolderBrowserDialog1.SelectedPath)
    'End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'ListFiles(FolderBrowserDialog1.SelectedPath)
    End Sub

    'Private Sub ListFiles(ByVal folderPath As String)

    '    '    ListBox1.Items.Clear()
    '    '    Dim fileNames = My.Computer.FileSystem.GetFiles(
    '    '        folderPath, FileIO.SearchOption.SearchAllSubDirectories, "*.pdf")

    '    '    For Each fileName As String In fileNames
    '    '        ListBox1.Items.Add(fileName)
    '    '    Next
    '    'End Sub

    Private Function path_name(ByVal file_name As String)
        Dim fixed_string As String
        fixed_string = Path.GetFileName(file_name)
        Return fixed_string
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        path_name(FolderBrowserDialog1.SelectedPath)
        MessageBox.Show(path_name(FolderBrowserDialog1.SelectedPath))
    End Sub



    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        Dim i As Integer = 0
        FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files"
        If cmbYear.SelectedIndex <> -1 Then
            cboVendorName.Items.Clear()
            cboVendorName.Text = ""
            cmbReport.Items.Clear()
            cmbReport.Text = ""
            cmbSection.Items.Clear()
            cmbSection.Text = ""
            FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & cmbYear.SelectedItem
        End If

        Dim fileMain = FolderBrowserDialog1.SelectedPath
        cboVendorName.Items.Clear()

        For Each strFolder As String In IO.Directory.GetDirectories(fileMain)
            'Dim vendor_row As DataSet1.VendorRow
            'vendor_row = Me.DataSet1.Vendor.NewRow
            'vendor_row.Vendor_Name = Path.GetFileName(strFolder)
            ''vendor_row.Vendor_Path = strFolder
            'Me.DataSet1.Vendor.Rows.Add(vendor_row)

            cboVendorName.Items.Add(Path.GetFileName(strFolder))
        Next strFolder

    End Sub

    Private Sub cboVendorName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVendorName.SelectedIndexChanged
        FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files"
        If cboVendorName.SelectedIndex <> -1 Then
            FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & cmbYear.SelectedItem & "\" & cboVendorName.SelectedItem
        End If
        'will need a loop to add path and file name data into a report table
        Dim fileMain = FolderBrowserDialog1.SelectedPath
        cmbReport.Items.Clear()
        cmbSection.Items.Clear()
        cmbReport.Text = ""
        cmbSection.Text = ""
        For Each strFolder As String In IO.Directory.GetDirectories(fileMain)
            'Dim report_column As DataColumn
            cmbReport.Items.Add(Path.GetFileName(strFolder))
        Next strFolder
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    'Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
    '    NewVendor.Show()
    'End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Equipment.Show()
    End Sub

    Private Sub cmbReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReport.SelectedIndexChanged
        FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files"
        If cmbReport.SelectedIndex <> -1 Then

            FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & cmbYear.SelectedItem & "\" & cboVendorName.SelectedItem & "\" & cmbReport.SelectedItem & "\Test Data"
        End If
        'will need a loop to add path and file name data into a report table
        Dim fileMain = FolderBrowserDialog1.SelectedPath
        cmbSection.Items.Clear()
        cmbSection.Text = ""
        For Each strFolder As String In IO.Directory.GetDirectories(fileMain)
            cmbSection.Items.Add(Path.GetFileName(strFolder))
        Next


    End Sub

    'Private Sub cmbPartNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPartNumber.SelectedIndexChanged
    '    'eventually when needed will need to fill in function
    'End Sub
End Class


