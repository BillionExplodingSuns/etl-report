Imports System.IO
Imports System.Diagnostics.Process

Public Class AccessTest

    Private Sub AccessTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim fileMain = My.Computer.FileSystem.GetFiles(FolderBrowserDialog1.SelectedPath, FileIO.SearchOption.SearchTopLevelOnly)
        Dim fileMain = FolderBrowserDialog1.SelectedPath
        For Each strFolder As String In IO.Directory.GetDirectories(fileMain)
            cmbYear.Items.Add(Path.GetFileName(strFolder))
        Next

    End Sub

    Private Function VendorInfoAdapter() As Object
        Throw New NotImplementedException
    End Function

    Private Function VendorInfoTableAdapter() As Object
        Throw New NotImplementedException
    End Function

    Private Function trim_string(ByRef old_string As String)
        Dim new_string As String
        new_string = Trim(old_string)   'removes any leading or trailing spaces in string
        Return new_string
    End Function

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Portal.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Main.Show()
    End Sub

    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        Dim path As String
        path = FolderBrowserDialog1.SelectedPath
        FolderBrowserDialog1.ShowDialog()
    End Sub
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
        If cboVendorName.SelectedIndex <> -1 Then
            cmbReport.Items.Clear()
            cmbReport.Items.Add("Select Report")
            FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & cboVendorName.SelectedItem
        End If
        'will need a loop to add path and file name data into a report table
        Dim fileMain = FolderBrowserDialog1.SelectedPath
        cmbReport.Items.Clear()
        For Each strFolder As String In IO.Directory.GetDirectories(fileMain)
            'Dim report_column As DataColumn
            cmbReport.Items.Add(Path.GetFileName(strFolder))
        Next strFolder
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Portal.Show()
        Me.Hide()
    End Sub

    'Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
    '    NewVendor.Show()
    'End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Equipment.Show()
    End Sub

    Private Sub cmbReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReport.SelectedIndexChanged
        'eventually when report index selection is needed will need to fill in function
    End Sub

    'Private Sub cmbPartNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPartNumber.SelectedIndexChanged
    '    'eventually when needed will need to fill in function
    'End Sub
End Class


