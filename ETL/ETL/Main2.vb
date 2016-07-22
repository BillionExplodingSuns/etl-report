'Imports Word = Microsoft.Office.Interop.Word
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports System.IO
Public Class Main2
    Inherits System.Windows.Forms.Form  'Form inheritance

    Public myCaller As Portal   'Tag variable for remembering the correct order of instances loaded
    'Create instances of each child form.

    Protected Friend Shared mainInst As Main
    Protected Friend Shared portalInst As Portal
    Protected Friend Shared sec4Inst As Section4
    Protected Friend Shared sec5Inst As Section5
    Protected Friend Shared sec6Inst As Section6
    Protected Friend Shared sec7Inst As Section7
    Protected Friend Shared sec8Inst As Section8
    Protected Friend Shared sec9Inst As Section9
    Protected Friend Shared sec10Inst As Section10
    Protected Friend Shared sec11Inst As Section11
    Protected Friend Shared sec12Inst As Section12
    Protected Friend Shared sec13Inst As Section13
    Protected Friend Shared sec14Inst As Section14
    Protected Friend Shared sec15Inst As Section15
    Protected Friend Shared sec16Inst As Section16
    Protected Friend Shared sec17Inst As Section17
    Protected Friend Shared sec18Inst As Section18
    Protected Friend Shared sec19Inst As Section19
    Protected Friend Shared sec20Inst As Section20
    Protected Friend Shared sec21Inst As Section21
    Protected Friend Shared sec22Inst As Section22
    Protected Friend Shared sec23Inst As Section23
    Protected Friend Shared sec24Inst As Section24
    Protected Friend Shared sec25Inst As Section25
    Protected Friend Shared sec26Inst As Section26

    Private Sub Main2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim fileMain = My.Computer.FileSystem.GetFiles(FolderBrowserDialog1.SelectedPath, FileIO.SearchOption.SearchTopLevelOnly)
        Dim fileMain = FolderBrowserDialog1.SelectedPath
        For Each strFolder As String In System.IO.Directory.GetDirectories(fileMain)
            cmbYear.Items.Add(Path.GetFileName(strFolder))
        Next

        'For Each row In DataSet1.Tables(1).Rows
        '    row.Vendor_Name = Trim(row.Vendor_Name)
        '    row.Folder_Path = Trim(row.Folder_Path)
        'Next row
        sec4Inst.MdiParent = mainInst
        sec5Inst.MdiParent = mainInst
        sec6Inst.MdiParent = mainInst
        sec7Inst.MdiParent = mainInst
        sec8Inst.MdiParent = mainInst
        sec9Inst.MdiParent = mainInst
        sec10Inst.MdiParent = mainInst
        sec11Inst.MdiParent = mainInst
        sec12Inst.MdiParent = mainInst
        sec13Inst.MdiParent = mainInst
        sec14Inst.MdiParent = mainInst
        sec15Inst.MdiParent = mainInst
        sec16Inst.MdiParent = mainInst
        sec17Inst.MdiParent = mainInst
        sec18Inst.MdiParent = mainInst
        sec19Inst.MdiParent = mainInst
        sec20Inst.MdiParent = mainInst
        sec21Inst.MdiParent = mainInst
        sec22Inst.MdiParent = mainInst
        sec23Inst.MdiParent = mainInst
        sec24Inst.MdiParent = mainInst
        sec25Inst.MdiParent = mainInst
        sec26Inst.MdiParent = mainInst
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
        'Takes the information selected from the combo boxes and passes it along for the second part of creating the test

        Dim warningString As String = "Please complete the following information to continue: " & vbNewLine & vbNewLine     'String to show user for error catching

        'If statement that determines if information has been selected from the comboboxes
        If cmbYear.SelectedIndex = -1 Then
            warningString = warningString + "Year" & vbNewLine & "Vendor" & vbNewLine & "Report"
            txtYear.ForeColor = Color.Red
            TextBox7.ForeColor = Color.Red
            txtReport.ForeColor = Color.Red
            MessageBox.Show(warningString)
        ElseIf cboVendorName.SelectedIndex = -1 Then
            warningString = warningString + "Vendor" + vbNewLine & "Report"
            txtYear.ForeColor = Color.Black
            TextBox7.ForeColor = Color.Red
            txtReport.ForeColor = Color.Red
            MessageBox.Show(warningString)
        ElseIf cmbReport.SelectedIndex = -1 Then
            warningString = warningString + "Report" & vbNewLine
            txtYear.ForeColor = Color.Black
            TextBox7.ForeColor = Color.Black
            txtReport.ForeColor = Color.Red
            MessageBox.Show(warningString)
        Else
            If mainInst Is Nothing Then 'Creates the instance of the Main form if one hasn't already been created yet
                mainInst = New Main
                mainInst.myCaller2 = Me
            End If
            mainInst.Show()             'Show the main create a test form
            Portal.portalInst.txtCompany.Text = Portal.main2Inst.cboVendorName.SelectedItem
            Portal.portalInst.txtReport.Text = Portal.main2Inst.cmbReport.SelectedItem
            Portal.portalInst.txtYear.Text = Portal.main2Inst.cmbYear.SelectedItem

            Portal.main2Inst.Hide()     'Hide the current form
        End If
    End Sub

    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs)
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
        cboVendorName.Items.Clear()
        cmbReport.Items.Clear()
        If cmbYear.SelectedIndex <> -1 Then
            cboVendorName.Text = ""
            cmbReport.Text = ""
            FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & cmbYear.SelectedItem
        End If

        Dim fileMain = FolderBrowserDialog1.SelectedPath

        For Each strFolder As String In System.IO.Directory.GetDirectories(fileMain)
            'Dim vendor_row As DataSet1.VendorRow
            'vendor_row = Me.DataSet1.Vendor.NewRow
            'vendor_row.Vendor_Name = Path.GetFileName(strFolder)
            ''vendor_row.Vendor_Path = strFolder
            'Me.DataSet1.Vendor.Rows.Add(vendor_row)
            cboVendorName.Items.Add(Path.GetFileName(strFolder))
        Next strFolder
    End Sub

    Private Sub cboVendorName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVendorName.SelectedIndexChanged
        cmbReport.Items.Clear()
        cmbReport.Text = ""
        FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files" & "\" & cmbYear.SelectedItem
        If cboVendorName.SelectedIndex <> -1 Then
            cmbReport.Text = ""
            'cmbReport.Items.Add("Select Report")
            FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & cboVendorName.SelectedItem
        End If
        'will need a loop to add path and file name data into a report table
        Dim fileMain = FolderBrowserDialog1.SelectedPath
        For Each strFolder As String In System.IO.Directory.GetDirectories(fileMain)
            'Dim report_column As DataColumn
            cmbReport.Items.Add(Path.GetFileName(strFolder))
        Next
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        NewVendor.Show()
        Dim fileMain = "K:ETL Test Files\"
        For Each strFolder As String In System.IO.Directory.GetDirectories(fileMain)
            NewVendor.cmbYear.Items.Add(Path.GetFileName(strFolder))
        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Equipment.Show()
    End Sub

    Private Sub cmbReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReport.SelectedIndexChanged
        'eventually when report index selection is needed will need to fill in function
    End Sub

    Private Sub cmbPartNumber_SelectedIndexChanged(sender As Object, e As EventArgs)
        'eventually when needed will need to fill in function
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ''clear out cmb boxes
        cmbYear.Items.Clear()
        cmbYear.Text = ""
        cmbReport.Items.Clear()
        cmbReport.Text = ""
        cboVendorName.Items.Clear()
        cboVendorName.Text = ""

        ''refill year combo box for selection
        FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files"
        Dim fileMain = FolderBrowserDialog1.SelectedPath
        For Each strFolder As String In System.IO.Directory.GetDirectories(fileMain)
            cmbYear.Items.Add(Path.GetFileName(strFolder))
        Next
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim report As String

        If (cmbYear.SelectedIndex <> -1 And cboVendorName.SelectedIndex <> -1) Then
            report = InputBox("Enter report name:", "Add Report", "")
            If (report <> "") Then
                cmbReport.Items.Clear()
                cmbReport.Text = ""
                FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files" & "\" & cmbYear.SelectedItem & "\" & cboVendorName.SelectedItem
                'lines are adding fill folders into new vendor folder
                MkDir(FolderBrowserDialog1.SelectedPath & "\" & report)
                MkDir(FolderBrowserDialog1.SelectedPath & "\" & report & "\" & "Quote")
                MkDir(FolderBrowserDialog1.SelectedPath & "\" & report & "\" & "Test Data")
                MkDir(FolderBrowserDialog1.SelectedPath & "\" & report & "\" & "Test Plan")
                MkDir(FolderBrowserDialog1.SelectedPath & "\" & report & "\" & "Test Report")
                MkDir(FolderBrowserDialog1.SelectedPath & "\" & report & "\" & "Time Sheet")

                'used to fill subfolders of vendor with fill folders in Test Data
                FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath & "\" & report & "\" & "Test Data"
                MkDir(FolderBrowserDialog1.SelectedPath & "\" & "Conformity Paperwork")
                MkDir(FolderBrowserDialog1.SelectedPath & "\" & "NFR")
                MkDir(FolderBrowserDialog1.SelectedPath & "\" & "Test Setup Charts")
                My.Computer.FileSystem.CopyFile("K:\Visual Basic\Visual Basic 2\Visual Basic 1\Test Status.xlsx", FolderBrowserDialog1.SelectedPath & "\" & "Test Status.xlsx")
                FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files\" & cmbYear.SelectedItem & "\" & cboVendorName.SelectedItem & "\" & report & "\" & "Time Sheet"
                My.Computer.FileSystem.CopyFile("K:\Visual Basic\Visual Basic 2\Visual Basic 1\Billable Hours.xlsm", FolderBrowserDialog1.SelectedPath & "\" & "Billable Hours.xlsm")

                FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files" & "\" & cmbYear.SelectedItem & "\" & cboVendorName.SelectedItem
                For Each strFolder As String In System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)
                    cmbReport.Items.Add(Path.GetFileName(strFolder))
                Next
                cmbReport.SelectedItem = report
            End If
        End If
    End Sub
End Class


