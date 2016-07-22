Option Explicit On
Imports System.IO
Imports System.Diagnostics.Process
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf



Public Class Main
    Inherits System.Windows.Forms.Form
    Public myCaller2 As Main2
    Dim current As Integer
    Dim count As Integer
    Dim checkboxes As List(Of Control) = New List(Of Control)
    'Declare arrays for the differend D0-160 revisions
    Dim sec4cat, sec5cat, sec6cat, sec7cat, sec8cat, sec9cat, sec10cat, sec11cat, sec12cat, sec13cat, sec14cat, sec15cat, sec16cat, sec17cat, sec18cat, sec19cat, sec20cat, sec21cat, sec22acat, sec22bcat, sec22ccat, sec22dcat, sec22ecat, sec23cat, sec24cat, sec25cat, sec26cat As String
    Dim sec4arr(), sec5arr(), sec6arr(), sec7arr(), sec8arr(), sec9arr(), sec10arr(), sec11arr(), sec12arr(), sec13arr(), sec14arr(), sec15arr(), sec16arr(), sec17arr(), sec18arr(), sec19arr(), sec20arr(), sec21arr(), sec22aarr(), sec22barr(), sec22carr(), sec22darr(), sec22earr(), sec23arr(), sec24arr(), sec25arr(), sec26arr() As String
    Dim catArray(22) As String
    Dim arrArray(22) As String
    Dim nIndex As Long

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CentralDatabaseDataSet._D0160_G' table. You can move, or remove it, as needed.
        Me.D0160_GTableAdapter.Fill(Me.CentralDatabaseDataSet._D0160_G)
        'TODO: This line of code loads data into the 'CentralDatabaseDataSet._D0160_F' table. You can move, or remove it, as needed.
        Me.D0160_FTableAdapter.Fill(Me.CentralDatabaseDataSet._D0160_F)
        'TODO: This line of code loads data into the 'CentralDatabaseDataSet._D0160_E' table. You can move, or remove it, as needed.
        Me.D0160_ETableAdapter.Fill(Me.CentralDatabaseDataSet._D0160_E)
        catArray(0) = "sec4cat"
        catArray(1) = "sec5cat"
        catArray(2) = "sec6cat"

        arrArray(0) = "sec4arr"
        arrArray(1) = "sec5arr"
        arrArray(2) = "sec6arr"

        cboTestSpec.Enabled = False
        cboTestSpec.SelectedIndex = 0


    End Sub

    Private Sub cmbA42F1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbA42F1.SelectedIndexChanged
        'Handles multiple operating modes question
        If cmbA4F1.SelectedIndex = -1 Then
            MessageBox.Show("Please select an option")    'No selection made
        ElseIf cmbA42F1.SelectedIndex = 0 Then
            txtQ43F1.ForeColor = Color.Gray
            'txtQ43F1.Enabled = False
            txtA43F1.Enabled = False

        ElseIf cmbA42F1.SelectedIndex = 1 Then
            txtQ43F1.ForeColor = Color.Black
            'txtQ43F1.Enabled = True
            txtA43F1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAddDevice.Click
        Dim control1 As TextBox = New TextBox
        Dim control2 As CheckBox = New CheckBox
        Dim checkboxes As List(Of Control) = New List(Of Control)
        checkboxes.Add(control2)
        tblDevices.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tblDevices.RowCount = tblDevices.RowStyles.Count
        current = tblDevices.RowCount - 1
        control1.Size = tblDevices.GetControlFromPosition(0, 2).Size
        tblDevices.Controls.Add(control1, 0, current)
        tblDevices.Controls.Add(control2, 1, current)
    End Sub
   
    Private Sub cmbA4F1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbA4F1.SelectedIndexChanged
        If cmbA4F1.SelectedIndex = -1 Then
            MessageBox.Show("Please select an option")    'No selection made
        ElseIf cmbA4F1.SelectedIndex = 0 Then
            txtQ41F1.ForeColor = Color.Black
            txtQ42F1.ForeColor = Color.Black
            txtQ42F1.ForeColor = Color.Black
            'txtQ43F1.ForeColor = Color.Black
            txtQ44F1.ForeColor = Color.Black
            ' txtQ45F1.ForeColor = Color.Black
            cmbA41F1.Enabled = True
            cmbA42F1.Enabled = True

        ElseIf cmbA4F1.SelectedIndex = 1 Then
            txtQ41F1.ForeColor = Color.Gray
            txtQ42F1.ForeColor = Color.Gray
            txtQ42F1.ForeColor = Color.Gray
            txtQ43F1.ForeColor = Color.Gray
            txtQ44F1.ForeColor = Color.Gray
            txtQ45F1.ForeColor = Color.Gray
            cmbA41F1.Enabled = False
            cmbA42F1.Enabled = False
        End If

    End Sub


    Function convert_string(ByVal chk_section As String, ByVal index As Integer)
        Return (chk_section & CStr(index))
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles NextMain.Click  'Next button, if the user clicks this then the programs checks if they completed everything before continuing
        errorCheck()
        'populateSections()
        'checkRevision() 'THIS WILL BE MOVED BELEE DAT
    End Sub

    Private Function trim_string(ByRef old_string As String)
        Dim new_string As String
        new_string = Trim(old_string)   'removes any leading or trailing spaces in string
        Return new_string
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Me.Close()
        Main2.mainInst.Hide()
        Portal.main2Inst.Show()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'dothissssss
    End Sub

    Private Sub cmbA5F1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbA5F1.SelectedIndexChanged     'Handles the AC or DC combobox
        'This sub needs a lot of work when someone gets bored!!!
        If cmbA5F1.SelectedIndex = -1 Then
            MessageBox.Show("Please select an option")    'No selection made
            txtQ51F1.ForeColor = Color.Red
        ElseIf cmbA5F1.SelectedIndex = 0 Then
            txtQ51F1.ForeColor = Color.Black
            txtQ52F1.ForeColor = Color.Black
            txtA51F1.Enabled = True
            txtA52F1.Enabled = True
            txtA51F1.ReadOnly = False
            txtA52F1.ReadOnly = False
        ElseIf cmbA5F1.SelectedIndex = 1 Then
            txtQ51F1.ForeColor = Color.Black
            txtQ52F1.ForeColor = Color.Black
            txtA51F1.ReadOnly = True
            txtA52F1.ReadOnly = True
            txtA52F1.Enabled = True
            txtA52F1.Enabled = True
        End If
    End Sub

    Private Sub cmbA3F1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbA3F1.SelectedIndexChanged
        'Deletes any existing equipment categories pulled from a dataset and repopulates the information from the correct D0-160 revision
        checkRevision()
    End Sub

    Private Sub checkRevision()     'If the user has selected an option from the revision combobox, determine which D0-160 revision to populate equipment categories from.
        If cmbA3F1.SelectedIndex = 0 Then
            fillRevE()
        ElseIf cmbA3F1.SelectedIndex = 1 Then
            fillRevF()
        ElseIf cmbA3F1.SelectedIndex = 2 Then
            fillRevG()
        End If
    End Sub

    Function errorCheck()   'Subroutine checks if the user forgot to complete information. Both booleans must equal true before moving on.
        Dim warningString As String = "Complete red fields to continue." & vbNewLine & vbNewLine 'String to show user for error catching
        Dim IsValid As Boolean = True   'boolean to see if all necessary information on the form has been completed
        Dim chkValid As Boolean = False 'boolean to see if any of the checkboxes have been selected or not

        'resets the colors of the question texts
        'if the user forgot to complete a section and the text turned red, this will reset the color back to black once they input information
        txtQ1F1.ForeColor = Color.Black
        txtQ2F1.ForeColor = Color.Black
        txtQ3F1.ForeColor = Color.Black
        TextBox5.ForeColor = Color.Black
        txtQ4F1.ForeColor = Color.Black
        txtQ41F1.ForeColor = Color.LightGray
        txtQ42F1.ForeColor = Color.LightGray
        txtQ43F1.ForeColor = Color.LightGray
        txtQ44F1.ForeColor = Color.LightGray
        txtQ45F1.ForeColor = Color.LightGray
        txtQ5F1.ForeColor = Color.Black
        txtQ51F1.ForeColor = Color.Black
        txtQ52F1.ForeColor = Color.Black

        'If statements that determine if the user completed that question or not
        'Number of units included in the test
        If cmbA1F1.SelectedIndex = -1 Then
            txtQ1F1.ForeColor = Color.Red
            warningString = warningString + "Number of units included in the test" & vbNewLine
            IsValid = False
        End If
        'Certification or evaluation
        If cmbA2F1.SelectedIndex = -1 Then
            txtQ2F1.ForeColor = Color.Red
            warningString = warningString + "Certification or evaluation" & vbNewLine
            IsValid = False
        End If
        'Testing specification
        If cboTestSpec.SelectedIndex = -1 Then
            txtQ3F1.ForeColor = Color.Red
            warningString = warningString + "Testing specification" & vbNewLine
            IsValid = False
        End If
        'Revision
        If cmbA3F1.SelectedIndex = -1 Then
            TextBox5.ForeColor = Color.Red
            warningString = warningString + "Revision" & vbNewLine
            IsValid = False
            'Else
            '    checkRevision()
            '    IsValid = True
        End If
        'Multiple Operating Modes Groupbox
        If cmbA4F1.SelectedIndex = -1 Then
            txtQ4F1.ForeColor = Color.Red
            warningString = warningString + "Multiple Operating Modes" & vbNewLine
            IsValid = False
        ElseIf cmbA4F1.SelectedIndex = 0 Then   'If yes
            txtQ4F1.ForeColor = Color.Black
            IsValid = True
            'How many operating modes
            If cmbA41F1.SelectedIndex = -1 Then
                txtQ41F1.ForeColor = Color.Red
                warningString = warningString + "How many operating modes" & vbNewLine
                IsValid = False
            Else
                txtQ41F1.ForeColor = Color.Black
                IsValid = True
            End If
            'Will all units be tested in multiple operating modes?
            If cmbA42F1.SelectedIndex = -1 Then
                txtQ42F1.ForeColor = Color.Red
                warningString = warningString + "Will all units be tested in multiple operating modes?" & vbNewLine
                IsValid = False
            ElseIf cmbA42F1.SelectedIndex = 1 Then  'If no
                txtQ42F1.ForeColor = Color.Black
                IsValid = True
                'List the units that will be tested in multiple operating modes
                If txtA43F1.Text = "" Then
                    txtQ43F1.ForeColor = Color.Red
                    warningString = warningString + "List the units that will be tested in multiple operating modes" & vbNewLine
                    IsValid = False
                Else
                    txtQ43F1.ForeColor = Color.Black
                    IsValid = True
                End If
            Else
                txtQ42F1.ForeColor = Color.Black
                IsValid = True
            End If
            'Will all test sections be used
            If cmbA44F1.SelectedIndex = -1 Then
                txtQ44F1.ForeColor = Color.Red
                warningString = warningString + "Will all test sections be used with each operating mode" & vbNewLine
                IsValid = False
            ElseIf cmbA44F1.SelectedIndex = 1 Then 'If no
                txtQ44F1.ForeColor = Color.Black
                IsValid = True
                'Which sections will be tested?
                If cmbA45F1.SelectedIndex = -1 Then
                    txtQ45F1.ForeColor = Color.Red
                    warningString = warningString + "Which sections will be tested in multiple modes" & vbNewLine
                    IsValid = False
                Else
                    cmbA45F1.ForeColor = Color.Black
                    IsValid = True
                End If
            Else
                txtQ44F1.ForeColor = Color.Black
                IsValid = True
            End If
        Else 'End of groupbox question
            txtQ4F1.ForeColor = Color.Black
            IsValid = True
        End If
        'AC or DC
        If cmbA5F1.SelectedIndex = -1 Then
            txtQ5F1.ForeColor = Color.Red
            warningString = warningString + "AC or DC" & vbNewLine
            IsValid = False
        End If
        'Voltage
        If txtA51F1.Text = "" Then
            txtQ51F1.ForeColor = Color.Red
            warningString = warningString + "Voltage" & vbNewLine
            IsValid = False
        End If
        'Frequency
        If txtA52F1.Text = "" Then
            txtQ52F1.ForeColor = Color.Red
            warningString = warningString + "Frequency" & vbNewLine
            IsValid = False
        End If

        'checkbox array of all the section checkboxes
        Dim chk As CheckBox
        Dim Checkboxes As CheckBox() = {chkSec4, chkSec5, chkSec6, chkSec7, chkSec8, chkSec9, chkSec10, chkSec11, chkSec12, chkSec13, chkSec13, chkSec14, chkSec15, chkSec16, chkSec17, chkSec18, chkSec19, chkSec20, chkSec21, chkSec22, chkSec23, chkSec24, chkSec25, chkSec26}

        'For loops looks to see if there has been a checkbox selected
        'If yes, continue normally. If no, chkValid stays false and error catches out at the if statement below
        For Each chk In Checkboxes
            If chk.Checked = True Then
                chkValid = True
                GroupBox1.ForeColor = Color.Black
            End If
        Next chk

        'If statement that determines if chkValid is still false. If it is, change the color of the text to red and warn the user
        If chkValid = False Then
            GroupBox1.ForeColor = Color.Red
            warningString = warningString + "Please select a D0-160 Section to test in" & vbNewLine
        ElseIf chkValid = True And IsValid = True Then
            populateSections() 'This is the final check of the entire subroutine. If both booleans equal true then all information is completed and the user can move on
        End If

        'If isValid ever turns false, then a user forgot to complete information and warn them
        If IsValid = False Then
            MessageBox.Show(warningString)
        End If

        Return IsValid
    End Function

    Private Sub populateSections()
        Dim x As Integer = 4
        Dim y As Integer = 4
        Dim forms As Form() = {Section4, Section5, Section6, Section7, Section8, Section9, Section10, Section11, Section12, Section13, Section14, Section15, Section16, Section17, Section18, Section19, Section20, Section21, Section22, Section23, Section24, Section25, Section26}
        Dim Section As Form
        Dim chk As CheckBox
        Dim Checkboxes As CheckBox() = {Main2.mainInst.chkSec4, Main2.mainInst.chkSec5, Main2.mainInst.chkSec6, Main2.mainInst.chkSec7, Main2.mainInst.chkSec8, Main2.mainInst.chkSec9, Main2.mainInst.chkSec10, Main2.mainInst.chkSec11, Main2.mainInst.chkSec12, Main2.mainInst.chkSec13, Main2.mainInst.chkSec13, Main2.mainInst.chkSec14, Main2.mainInst.chkSec15, Main2.mainInst.chkSec16, Main2.mainInst.chkSec17, Main2.mainInst.chkSec18, Main2.mainInst.chkSec19, Main2.mainInst.chkSec20, Main2.mainInst.chkSec21, Main2.mainInst.chkSec22, Main2.mainInst.chkSec23, Main2.mainInst.chkSec24, Main2.mainInst.chkSec25, Main2.mainInst.chkSec26}

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

    Private Sub fillRevE()
        'Populates each combobox in the section forms with the appropiate equipment categories according to the different D0-160 revisions

        Dim intCount As Integer 'Used in trimming code
        Dim j As Integer = 0    'Used in the loop that desginates which row goes to the corresponding string, determines which row of the dataset to access

        'TODO: Write a loop to handle the code below
        'Clears any existing data within the strings and arrays
        sec4cat = vbNullString
        sec5cat = vbNullString
        sec6cat = vbNullString
        sec7cat = vbNullString
        sec8cat = vbNullString
        sec9cat = vbNullString
        sec10cat = vbNullString
        sec11cat = vbNullString
        sec12cat = vbNullString
        sec13cat = vbNullString
        sec14cat = vbNullString
        sec15cat = vbNullString
        sec16cat = vbNullString
        sec17cat = vbNullString
        sec18cat = vbNullString
        sec19cat = vbNullString
        sec20cat = vbNullString
        sec21cat = vbNullString
        sec22acat = vbNullString
        sec22bcat = vbNullString
        sec22ccat = vbNullString
        sec22dcat = vbNullString
        sec22ecat = vbNullString
        sec23cat = vbNullString
        sec24cat = vbNullString
        sec25cat = vbNullString
        sec26cat = vbNullString
        Erase sec4arr, sec5arr, sec6arr, sec7arr, sec8arr, sec9arr, sec10arr, sec11arr, sec12arr, sec13arr, sec14arr, sec15arr, sec16arr, sec17arr, sec18arr, sec19arr, sec20arr, sec21arr, sec22aarr, sec22barr, sec22carr, sec22darr, sec22darr, sec22earr, sec23arr, sec24arr, sec25arr, sec26arr

        'TODO: Loop to handle the code below
        'For i = 0 To UBound(catArray) 
        '    catArray(i) = DataSet1._D0_160E.Rows(j)("Categories").ToString()
        '    j = j + 1
        'Next

        'Fills the string variables with the equipment categories from each row in the database
        sec4cat = Me.CentralDatabaseDataSet._D0160_E.Rows(0)("Category").ToString()
        sec5cat = Me.CentralDatabaseDataSet._D0160_E.Rows(1)("Category").ToString()
        sec6cat = Me.CentralDatabaseDataSet._D0160_E.Rows(2)("Category").ToString()
        sec7cat = Me.CentralDatabaseDataSet._D0160_E.Rows(3)("Category").ToString()
        sec8cat = Me.CentralDatabaseDataSet._D0160_E.Rows(4)("Category").ToString()
        sec9cat = Me.CentralDatabaseDataSet._D0160_E.Rows(5)("Category").ToString()
        sec10cat = Me.CentralDatabaseDataSet._D0160_E.Rows(6)("Category").ToString()
        sec11cat = Me.CentralDatabaseDataSet._D0160_E.Rows(7)("Category").ToString()
        sec12cat = Me.CentralDatabaseDataSet._D0160_E.Rows(8)("Category").ToString()
        sec13cat = Me.CentralDatabaseDataSet._D0160_E.Rows(9)("Category").ToString()
        sec14cat = Me.CentralDatabaseDataSet._D0160_E.Rows(10)("Category").ToString()
        sec15cat = Me.CentralDatabaseDataSet._D0160_E.Rows(11)("Category").ToString()
        sec16cat = Me.CentralDatabaseDataSet._D0160_E.Rows(12)("Category").ToString()
        sec17cat = Me.CentralDatabaseDataSet._D0160_E.Rows(13)("Category").ToString()
        sec18cat = Me.CentralDatabaseDataSet._D0160_E.Rows(14)("Category").ToString()
        sec19cat = Me.CentralDatabaseDataSet._D0160_E.Rows(15)("Category").ToString()
        sec20cat = Me.CentralDatabaseDataSet._D0160_E.Rows(16)("Category").ToString()
        sec21cat = Me.CentralDatabaseDataSet._D0160_E.Rows(17)("Category").ToString()
        sec22acat = Me.CentralDatabaseDataSet._D0160_E.Rows(18)("Category").ToString()
        sec22bcat = Me.CentralDatabaseDataSet._D0160_E.Rows(19)("Category").ToString()
        sec22ccat = Me.CentralDatabaseDataSet._D0160_E.Rows(20)("Category").ToString()
        sec22dcat = Me.CentralDatabaseDataSet._D0160_E.Rows(21)("Category").ToString()
        sec22ecat = Me.CentralDatabaseDataSet._D0160_E.Rows(22)("Category").ToString()
        sec23cat = Me.CentralDatabaseDataSet._D0160_E.Rows(23)("Category").ToString()
        sec24cat = Me.CentralDatabaseDataSet._D0160_E.Rows(24)("Category").ToString()
        sec25cat = Me.CentralDatabaseDataSet._D0160_E.Rows(25)("Category").ToString()
        sec26cat = Me.CentralDatabaseDataSet._D0160_E.Rows(26)("Category").ToString()


        'TODO: Loop for the code below
        'For i = 0 To UBound(arrArray)
        '    arrArray(i) = Split(catArray(i), ",")
        'Next

        'TODO: Need a loop for the code below
        'Splits each equipment category at the comma, then inserts each individual letter into an array
        sec4arr = Split(sec4cat, ",")
        sec5arr = Split(sec5cat, ",")
        sec6arr = Split(sec6cat, ",")
        sec7arr = Split(sec7cat, ",")
        sec8arr = Split(sec8cat, ",")
        sec9arr = Split(sec9cat, ",")
        sec10arr = Split(sec10cat, ",")
        sec11arr = Split(sec11cat, ",")
        sec12arr = Split(sec12cat, ",")
        sec13arr = Split(sec13cat, ",")
        sec14arr = Split(sec14cat, ",")
        sec15arr = Split(sec15cat, ",")
        sec16arr = Split(sec16cat, ",")
        sec17arr = Split(sec17cat, ",")
        sec18arr = Split(sec18cat, ",")
        sec19arr = Split(sec19cat, ",")
        sec20arr = Split(sec20cat, ",")
        sec21arr = Split(sec21cat, ",")
        sec22aarr = Split(sec22acat, ",")
        sec22barr = Split(sec22bcat, ",")
        sec22carr = Split(sec22ccat, ",")
        sec22darr = Split(sec22dcat, ",")
        sec22earr = Split(sec22ecat, ",")
        sec23arr = Split(sec23cat, ",")
        sec24arr = Split(sec24cat, ",")
        sec25arr = Split(sec25cat, ",")
        sec26arr = Split(sec26cat, ",")

        'TODO: Need a loop for the code below
        'Trims the empty characters after each letter 
        For intCount = LBound(sec4arr) To UBound(sec4arr)
            Debug.Print(Trim(sec4arr(intCount)))
        Next
        For intCount = LBound(sec5arr) To UBound(sec5arr)
            Debug.Print(Trim(sec5arr(intCount)))
        Next
        For intCount = LBound(sec6arr) To UBound(sec6arr)
            Debug.Print(Trim(sec6arr(intCount)))
        Next
        For intCount = LBound(sec7arr) To UBound(sec7arr)
            Debug.Print(Trim(sec7arr(intCount)))
        Next
        For intCount = LBound(sec8arr) To UBound(sec8arr)
            Debug.Print(Trim(sec8arr(intCount)))
        Next
        For intCount = LBound(sec9arr) To UBound(sec9arr)
            Debug.Print(Trim(sec9arr(intCount)))
        Next
        For intCount = LBound(sec10arr) To UBound(sec10arr)
            Debug.Print(Trim(sec10arr(intCount)))
        Next
        For intCount = LBound(sec11arr) To UBound(sec11arr)
            Debug.Print(Trim(sec11arr(intCount)))
        Next
        For intCount = LBound(sec12arr) To UBound(sec12arr)
            Debug.Print(Trim(sec12arr(intCount)))
        Next
        For intCount = LBound(sec13arr) To UBound(sec13arr)
            Debug.Print(Trim(sec13arr(intCount)))
        Next
        For intCount = LBound(sec14arr) To UBound(sec14arr)
            Debug.Print(Trim(sec14arr(intCount)))
        Next
        For intCount = LBound(sec15arr) To UBound(sec15arr)
            Debug.Print(Trim(sec15arr(intCount)))
        Next
        For intCount = LBound(sec16arr) To UBound(sec16arr)
            Debug.Print(Trim(sec16arr(intCount)))
        Next
        For intCount = LBound(sec18arr) To UBound(sec18arr)
            Debug.Print(Trim(sec18arr(intCount)))
        Next
        For intCount = LBound(sec19arr) To UBound(sec19arr)
            Debug.Print(Trim(sec19arr(intCount)))
        Next
        For intCount = LBound(sec20arr) To UBound(sec20arr)
            Debug.Print(Trim(sec20arr(intCount)))
        Next
        For intCount = LBound(sec21arr) To UBound(sec21arr)
            Debug.Print(Trim(sec21arr(intCount)))
        Next
        For intCount = LBound(sec22aarr) To UBound(sec22aarr)
            Debug.Print(Trim(sec22aarr(intCount)))
        Next
        For intCount = LBound(sec22barr) To UBound(sec22barr)
            Debug.Print(Trim(sec22barr(intCount)))
        Next
        For intCount = LBound(sec22carr) To UBound(sec22carr)
            Debug.Print(Trim(sec22carr(intCount)))
        Next
        For intCount = LBound(sec22darr) To UBound(sec22darr)
            Debug.Print(Trim(sec22darr(intCount)))
        Next
        For intCount = LBound(sec22earr) To UBound(sec22earr)
            Debug.Print(Trim(sec22earr(intCount)))
        Next
        For intCount = LBound(sec23arr) To UBound(sec23arr)
            Debug.Print(Trim(sec23arr(intCount)))
        Next
        For intCount = LBound(sec24arr) To UBound(sec24arr)
            Debug.Print(Trim(sec24arr(intCount)))
        Next
        For intCount = LBound(sec25arr) To UBound(sec25arr)
            Debug.Print(Trim(sec25arr(intCount)))
        Next
        For intCount = LBound(sec26arr) To UBound(sec26arr)
            Debug.Print(Trim(sec26arr(intCount)))
        Next

        'TODO: Write a loop for the code below
        'Clears the combobox before adding the equipment categories to it
        Section4.cboA1S4.Items.AddRange(sec4arr)
        Section5.cboA1S5.Items.Clear()
        Section5.cboA1S5.Items.AddRange(sec5arr)
        Section6.cboA1S6.Items.Clear()
        Section6.cboA1S6.Items.AddRange(sec6arr)
        Section7.cboA1S7.Items.Clear()
        Section7.cboA1S7.Items.AddRange(sec7arr)
        Section8.cboA1S8.Items.Clear()
        Section8.cboA1S8.Items.AddRange(sec8arr)
        Section9.cboA1S9.Items.Clear()
        Section9.cboA1S9.Items.AddRange(sec9arr)
        Section10.cboA1S10.Items.Clear()
        Section10.cboA1S10.Items.AddRange(sec10arr)
        Section11.cboA1S11.Items.Clear()
        Section11.cboA1S11.Items.AddRange(sec11arr)
        Section12.cboA1S12.Items.Clear()
        Section12.cboA1S12.Items.AddRange(sec12arr)
        Section13.cboA1S13.Items.Clear()
        Section13.cboA1S13.Items.AddRange(sec13arr)
        Section14.cboA1S14.Items.Clear()
        Section14.cboA1S14.Items.AddRange(sec14arr)
        Section15.cboA1S15.Items.Clear()
        Section15.cboA1S15.Items.AddRange(sec15arr)
        Section16.cboA1S16.Items.Clear()
        Section16.cboA1S16.Items.AddRange(sec16arr)
        Section17.cboA1S17.Items.Clear()
        Section17.cboA1S17.Items.AddRange(sec17arr)
        Section18.cboA1S18.Items.Clear()
        Section18.cboA1S18.Items.AddRange(sec18arr)
        Section19.cboA1S19.Items.Clear()
        Section19.cboA1S19.Items.AddRange(sec19arr)
        Section20.cboA1S20.Items.Clear()
        Section20.cboA1S20.Items.AddRange(sec20arr)
        Section21.cboA1S21.Items.Clear()
        Section21.cboA1S21.Items.AddRange(sec21arr)
        Section22.cboA1S22A.Items.Clear()
        Section22.cboA1S22A.Items.AddRange(sec22aarr)
        Section22.cboA1S22B.Items.Clear()
        Section22.cboA1S22B.Items.AddRange(sec22barr)
        Section22.cboA1S22C.Items.Clear()
        Section22.cboA1S22C.Items.AddRange(sec22carr)
        Section22.cboA1S22D.Items.Clear()
        Section22.cboA1S22D.Items.AddRange(sec22darr)
        Section22.cboA1S22E.Items.Clear()
        Section22.cboA1S22E.Items.AddRange(sec22earr)
        Section23.cboA1S23.Items.Clear()
        Section23.cboA1S23.Items.AddRange(sec23arr)
        Section24.cboA1S24.Items.Clear()
        Section24.cboA1S24.Items.AddRange(sec24arr)
        Section25.cboA1S25.Items.Clear()
        Section25.cboA1S25.Items.AddRange(sec25arr)
        Section26.cboA1S26.Items.Clear()
        Section26.cboA1S26.Items.AddRange(sec26arr)
    End Sub

    Private Sub fillRevF()
        'Populates each combobox in the section forms with the appropiate equipment categories according to the different D0-160 revisions

        Dim intCount As Integer 'Used in trimming code
        Dim j As Integer = 0    'Used in the loop that desginates which row goes to the corresponding string, determines which row of the dataset to access

        'TODO: Write a loop to handle the code below
        'Clears any existing data within the strings and arrays
        sec4cat = vbNullString
        sec5cat = vbNullString
        sec6cat = vbNullString
        sec7cat = vbNullString
        sec8cat = vbNullString
        sec9cat = vbNullString
        sec10cat = vbNullString
        sec11cat = vbNullString
        sec12cat = vbNullString
        sec13cat = vbNullString
        sec14cat = vbNullString
        sec15cat = vbNullString
        sec16cat = vbNullString
        sec17cat = vbNullString
        sec18cat = vbNullString
        sec19cat = vbNullString
        sec20cat = vbNullString
        sec21cat = vbNullString
        sec22acat = vbNullString
        sec22bcat = vbNullString
        sec22ccat = vbNullString
        sec22dcat = vbNullString
        sec22ecat = vbNullString
        sec23cat = vbNullString
        sec24cat = vbNullString
        sec25cat = vbNullString
        sec26cat = vbNullString
        Erase sec4arr, sec5arr, sec6arr, sec7arr, sec8arr, sec9arr, sec10arr, sec11arr, sec12arr, sec13arr, sec14arr, sec15arr, sec16arr, sec17arr, sec18arr, sec19arr, sec20arr, sec21arr, sec22aarr, sec22barr, sec22carr, sec22darr, sec22darr, sec22earr, sec23arr, sec24arr, sec25arr, sec26arr

        'TODO: Loop to handle the code below
        'For i = 0 To UBound(catArray) 
        '    catArray(i) = DataSet1._D0_160E.Rows(j)("Categories").ToString()
        '    j = j + 1
        'Next

        'Fills the string variables with the equipment categories from each row in the database
        sec4cat = Me.CentralDatabaseDataSet._D0160_F.Rows(0)("Category").ToString()
        sec5cat = Me.CentralDatabaseDataSet._D0160_F.Rows(1)("Category").ToString()
        sec6cat = Me.CentralDatabaseDataSet._D0160_F.Rows(2)("Category").ToString()
        sec7cat = Me.CentralDatabaseDataSet._D0160_F.Rows(3)("Category").ToString()
        sec8cat = Me.CentralDatabaseDataSet._D0160_F.Rows(4)("Category").ToString()
        sec9cat = Me.CentralDatabaseDataSet._D0160_F.Rows(5)("Category").ToString()
        sec10cat = Me.CentralDatabaseDataSet._D0160_F.Rows(6)("Category").ToString()
        sec11cat = Me.CentralDatabaseDataSet._D0160_F.Rows(7)("Category").ToString()
        sec12cat = Me.CentralDatabaseDataSet._D0160_F.Rows(8)("Category").ToString()
        sec13cat = Me.CentralDatabaseDataSet._D0160_F.Rows(9)("Category").ToString()
        sec14cat = Me.CentralDatabaseDataSet._D0160_F.Rows(10)("Category").ToString()
        sec15cat = Me.CentralDatabaseDataSet._D0160_F.Rows(11)("Category").ToString()
        sec16cat = Me.CentralDatabaseDataSet._D0160_F.Rows(12)("Category").ToString()
        sec17cat = Me.CentralDatabaseDataSet._D0160_F.Rows(13)("Category").ToString()
        sec18cat = Me.CentralDatabaseDataSet._D0160_F.Rows(14)("Category").ToString()
        sec19cat = Me.CentralDatabaseDataSet._D0160_F.Rows(15)("Category").ToString()
        sec20cat = Me.CentralDatabaseDataSet._D0160_F.Rows(16)("Category").ToString()
        sec21cat = Me.CentralDatabaseDataSet._D0160_F.Rows(17)("Category").ToString()
        sec22acat = Me.CentralDatabaseDataSet._D0160_F.Rows(18)("Category").ToString()
        sec22bcat = Me.CentralDatabaseDataSet._D0160_F.Rows(19)("Category").ToString()
        sec22ccat = Me.CentralDatabaseDataSet._D0160_F.Rows(20)("Category").ToString()
        sec22dcat = Me.CentralDatabaseDataSet._D0160_F.Rows(21)("Category").ToString()
        sec22ecat = Me.CentralDatabaseDataSet._D0160_F.Rows(22)("Category").ToString()
        sec23cat = Me.CentralDatabaseDataSet._D0160_F.Rows(23)("Category").ToString()
        sec24cat = Me.CentralDatabaseDataSet._D0160_F.Rows(24)("Category").ToString()
        sec25cat = Me.CentralDatabaseDataSet._D0160_F.Rows(25)("Category").ToString()
        sec26cat = Me.CentralDatabaseDataSet._D0160_F.Rows(26)("Category").ToString()

        'TODO: Loop for the code below
        'For i = 0 To UBound(arrArray)
        '    arrArray(i) = Split(catArray(i), ",")
        'Next

        'TODO: Need a loop for the code below
        'Splits each equipment category at the comma, then inserts each individual letter into an array
        sec4arr = Split(sec4cat, ",")
        sec5arr = Split(sec5cat, ",")
        sec6arr = Split(sec6cat, ",")
        sec7arr = Split(sec7cat, ",")
        sec8arr = Split(sec8cat, ",")
        sec9arr = Split(sec9cat, ",")
        sec10arr = Split(sec10cat, ",")
        sec11arr = Split(sec11cat, ",")
        sec12arr = Split(sec12cat, ",")
        sec13arr = Split(sec13cat, ",")
        sec14arr = Split(sec14cat, ",")
        sec15arr = Split(sec15cat, ",")
        sec16arr = Split(sec16cat, ",")
        sec17arr = Split(sec17cat, ",")
        sec18arr = Split(sec18cat, ",")
        sec19arr = Split(sec19cat, ",")
        sec20arr = Split(sec20cat, ",")
        sec21arr = Split(sec21cat, ",")
        sec22aarr = Split(sec22acat, ",")
        sec22barr = Split(sec22bcat, ",")
        sec22carr = Split(sec22ccat, ",")
        sec22darr = Split(sec22dcat, ",")
        sec22earr = Split(sec22ecat, ",")
        sec23arr = Split(sec23cat, ",")
        sec24arr = Split(sec24cat, ",")
        sec25arr = Split(sec25cat, ",")
        sec26arr = Split(sec26cat, ",")

        'TODO: Need a loop for the code below
        'Trims the empty characters after each letter 
        For intCount = LBound(sec4arr) To UBound(sec4arr)
            Debug.Print(Trim(sec4arr(intCount)))
        Next
        For intCount = LBound(sec5arr) To UBound(sec5arr)
            Debug.Print(Trim(sec5arr(intCount)))
        Next
        For intCount = LBound(sec6arr) To UBound(sec6arr)
            Debug.Print(Trim(sec6arr(intCount)))
        Next
        For intCount = LBound(sec7arr) To UBound(sec7arr)
            Debug.Print(Trim(sec7arr(intCount)))
        Next
        For intCount = LBound(sec8arr) To UBound(sec8arr)
            Debug.Print(Trim(sec8arr(intCount)))
        Next
        For intCount = LBound(sec9arr) To UBound(sec9arr)
            Debug.Print(Trim(sec9arr(intCount)))
        Next
        For intCount = LBound(sec10arr) To UBound(sec10arr)
            Debug.Print(Trim(sec10arr(intCount)))
        Next
        For intCount = LBound(sec11arr) To UBound(sec11arr)
            Debug.Print(Trim(sec11arr(intCount)))
        Next
        For intCount = LBound(sec12arr) To UBound(sec12arr)
            Debug.Print(Trim(sec12arr(intCount)))
        Next
        For intCount = LBound(sec13arr) To UBound(sec13arr)
            Debug.Print(Trim(sec13arr(intCount)))
        Next
        For intCount = LBound(sec14arr) To UBound(sec14arr)
            Debug.Print(Trim(sec14arr(intCount)))
        Next
        For intCount = LBound(sec15arr) To UBound(sec15arr)
            Debug.Print(Trim(sec15arr(intCount)))
        Next
        For intCount = LBound(sec16arr) To UBound(sec16arr)
            Debug.Print(Trim(sec16arr(intCount)))
        Next
        For intCount = LBound(sec18arr) To UBound(sec18arr)
            Debug.Print(Trim(sec18arr(intCount)))
        Next
        For intCount = LBound(sec19arr) To UBound(sec19arr)
            Debug.Print(Trim(sec19arr(intCount)))
        Next
        For intCount = LBound(sec20arr) To UBound(sec20arr)
            Debug.Print(Trim(sec20arr(intCount)))
        Next
        For intCount = LBound(sec21arr) To UBound(sec21arr)
            Debug.Print(Trim(sec21arr(intCount)))
        Next
        For intCount = LBound(sec22aarr) To UBound(sec22aarr)
            Debug.Print(Trim(sec22aarr(intCount)))
        Next
        For intCount = LBound(sec22barr) To UBound(sec22barr)
            Debug.Print(Trim(sec22barr(intCount)))
        Next
        For intCount = LBound(sec22carr) To UBound(sec22carr)
            Debug.Print(Trim(sec22carr(intCount)))
        Next
        For intCount = LBound(sec22darr) To UBound(sec22darr)
            Debug.Print(Trim(sec22darr(intCount)))
        Next
        For intCount = LBound(sec22earr) To UBound(sec22earr)
            Debug.Print(Trim(sec22earr(intCount)))
        Next
        For intCount = LBound(sec23arr) To UBound(sec23arr)
            Debug.Print(Trim(sec23arr(intCount)))
        Next
        For intCount = LBound(sec24arr) To UBound(sec24arr)
            Debug.Print(Trim(sec24arr(intCount)))
        Next
        For intCount = LBound(sec25arr) To UBound(sec25arr)
            Debug.Print(Trim(sec25arr(intCount)))
        Next
        For intCount = LBound(sec26arr) To UBound(sec26arr)
            Debug.Print(Trim(sec26arr(intCount)))
        Next

        'TODO: Write a loop for the code below
        'Clears the combobox before adding the equipment categories to it
        Section4.cboA1S4.Items.AddRange(sec4arr)
        Section5.cboA1S5.Items.Clear()
        Section5.cboA1S5.Items.AddRange(sec5arr)
        Section6.cboA1S6.Items.Clear()
        Section6.cboA1S6.Items.AddRange(sec6arr)
        Section7.cboA1S7.Items.Clear()
        Section7.cboA1S7.Items.AddRange(sec7arr)
        Section8.cboA1S8.Items.Clear()
        Section8.cboA1S8.Items.AddRange(sec8arr)
        Section9.cboA1S9.Items.Clear()
        Section9.cboA1S9.Items.AddRange(sec9arr)
        Section10.cboA1S10.Items.Clear()
        Section10.cboA1S10.Items.AddRange(sec10arr)
        Section11.cboA1S11.Items.Clear()
        Section11.cboA1S11.Items.AddRange(sec11arr)
        Section12.cboA1S12.Items.Clear()
        Section12.cboA1S12.Items.AddRange(sec12arr)
        Section13.cboA1S13.Items.Clear()
        Section13.cboA1S13.Items.AddRange(sec13arr)
        Section14.cboA1S14.Items.Clear()
        Section14.cboA1S14.Items.AddRange(sec14arr)
        Section15.cboA1S15.Items.Clear()
        Section15.cboA1S15.Items.AddRange(sec15arr)
        Section16.cboA1S16.Items.Clear()
        Section16.cboA1S16.Items.AddRange(sec16arr)
        Section17.cboA1S17.Items.Clear()
        Section17.cboA1S17.Items.AddRange(sec17arr)
        Section18.cboA1S18.Items.Clear()
        Section18.cboA1S18.Items.AddRange(sec18arr)
        Section19.cboA1S19.Items.Clear()
        Section19.cboA1S19.Items.AddRange(sec19arr)
        Section20.cboA1S20.Items.Clear()
        Section20.cboA1S20.Items.AddRange(sec20arr)
        Section21.cboA1S21.Items.Clear()
        Section21.cboA1S21.Items.AddRange(sec21arr)
        Section22.cboA1S22A.Items.Clear()
        Section22.cboA1S22A.Items.AddRange(sec22aarr)
        Section22.cboA1S22B.Items.Clear()
        Section22.cboA1S22B.Items.AddRange(sec22barr)
        Section22.cboA1S22C.Items.Clear()
        Section22.cboA1S22C.Items.AddRange(sec22carr)
        Section22.cboA1S22D.Items.Clear()
        Section22.cboA1S22D.Items.AddRange(sec22darr)
        Section22.cboA1S22E.Items.Clear()
        Section22.cboA1S22E.Items.AddRange(sec22earr)
        Section23.cboA1S23.Items.Clear()
        Section23.cboA1S23.Items.AddRange(sec23arr)
        Section24.cboA1S24.Items.Clear()
        Section24.cboA1S24.Items.AddRange(sec24arr)
        Section25.cboA1S25.Items.Clear()
        Section25.cboA1S25.Items.AddRange(sec25arr)
        Section26.cboA1S26.Items.Clear()
        Section26.cboA1S26.Items.AddRange(sec26arr)
    End Sub

    Private Sub fillRevG()
        'Populates each combobox in the section forms with the appropiate equipment categories according to the different D0-160 revisions

        Dim intCount As Integer 'Used in trimming code
        Dim j As Integer = 0    'Used in the loop that desginates which row goes to the corresponding string, determines which row of the dataset to access

        'TODO: Write a loop to handle the code below
        'Clears any existing data within the strings and arrays
        sec4cat = vbNullString
        sec5cat = vbNullString
        sec6cat = vbNullString
        sec7cat = vbNullString
        sec8cat = vbNullString
        sec9cat = vbNullString
        sec10cat = vbNullString
        sec11cat = vbNullString
        sec12cat = vbNullString
        sec13cat = vbNullString
        sec14cat = vbNullString
        sec15cat = vbNullString
        sec16cat = vbNullString
        sec17cat = vbNullString
        sec18cat = vbNullString
        sec19cat = vbNullString
        sec20cat = vbNullString
        sec21cat = vbNullString
        sec22acat = vbNullString
        sec22bcat = vbNullString
        sec22ccat = vbNullString
        sec22dcat = vbNullString
        sec22ecat = vbNullString
        sec23cat = vbNullString
        sec24cat = vbNullString
        sec25cat = vbNullString
        sec26cat = vbNullString
        Erase sec4arr, sec5arr, sec6arr, sec7arr, sec8arr, sec9arr, sec10arr, sec11arr, sec12arr, sec13arr, sec14arr, sec15arr, sec16arr, sec17arr, sec18arr, sec19arr, sec20arr, sec21arr, sec22aarr, sec22barr, sec22carr, sec22darr, sec22darr, sec22earr, sec23arr, sec24arr, sec25arr, sec26arr

        'TODO: Loop to handle the code below
        'For i = 0 To UBound(catArray) 
        '    catArray(i) = DataSet1._D0_160E.Rows(j)("Categories").ToString()
        '    j = j + 1
        'Next

        'Fills the string variables with the equipment categories from each row in the database
        sec4cat = Me.CentralDatabaseDataSet._D0160_G.Rows(0)("Category").ToString()
        sec5cat = Me.CentralDatabaseDataSet._D0160_G.Rows(1)("Category").ToString()
        sec6cat = Me.CentralDatabaseDataSet._D0160_G.Rows(2)("Category").ToString()
        sec7cat = Me.CentralDatabaseDataSet._D0160_G.Rows(3)("Category").ToString()
        sec8cat = Me.CentralDatabaseDataSet._D0160_G.Rows(4)("Category").ToString()
        sec9cat = Me.CentralDatabaseDataSet._D0160_G.Rows(5)("Category").ToString()
        sec10cat = Me.CentralDatabaseDataSet._D0160_G.Rows(6)("Category").ToString()
        sec11cat = Me.CentralDatabaseDataSet._D0160_G.Rows(7)("Category").ToString()
        sec12cat = Me.CentralDatabaseDataSet._D0160_G.Rows(8)("Category").ToString()
        sec13cat = Me.CentralDatabaseDataSet._D0160_G.Rows(9)("Category").ToString()
        sec14cat = Me.CentralDatabaseDataSet._D0160_G.Rows(10)("Category").ToString()
        sec15cat = Me.CentralDatabaseDataSet._D0160_G.Rows(11)("Category").ToString()
        sec16cat = Me.CentralDatabaseDataSet._D0160_G.Rows(12)("Category").ToString()
        sec17cat = Me.CentralDatabaseDataSet._D0160_G.Rows(13)("Category").ToString()
        sec18cat = Me.CentralDatabaseDataSet._D0160_G.Rows(14)("Category").ToString()
        sec19cat = Me.CentralDatabaseDataSet._D0160_G.Rows(15)("Category").ToString()
        sec20cat = Me.CentralDatabaseDataSet._D0160_G.Rows(16)("Category").ToString()
        sec21cat = Me.CentralDatabaseDataSet._D0160_G.Rows(17)("Category").ToString()
        sec22acat = Me.CentralDatabaseDataSet._D0160_G.Rows(18)("Category").ToString()
        sec22bcat = Me.CentralDatabaseDataSet._D0160_G.Rows(19)("Category").ToString()
        sec22ccat = Me.CentralDatabaseDataSet._D0160_G.Rows(20)("Category").ToString()
        sec22dcat = Me.CentralDatabaseDataSet._D0160_G.Rows(21)("Category").ToString()
        sec22ecat = Me.CentralDatabaseDataSet._D0160_G.Rows(22)("Category").ToString()
        sec23cat = Me.CentralDatabaseDataSet._D0160_G.Rows(23)("Category").ToString()
        sec24cat = Me.CentralDatabaseDataSet._D0160_G.Rows(24)("Category").ToString()
        sec25cat = Me.CentralDatabaseDataSet._D0160_G.Rows(25)("Category").ToString()
        sec26cat = Me.CentralDatabaseDataSet._D0160_G.Rows(26)("Category").ToString()

        'TODO: Loop for the code below
        'For i = 0 To UBound(arrArray)
        '    arrArray(i) = Split(catArray(i), ",")
        'Next

        'TODO: Need a loop for the code below
        'Splits each equipment category at the comma, then inserts each individual letter into an array
        sec4arr = Split(sec4cat, ",")
        sec5arr = Split(sec5cat, ",")
        sec6arr = Split(sec6cat, ",")
        sec7arr = Split(sec7cat, ",")
        sec8arr = Split(sec8cat, ",")
        sec9arr = Split(sec9cat, ",")
        sec10arr = Split(sec10cat, ",")
        sec11arr = Split(sec11cat, ",")
        sec12arr = Split(sec12cat, ",")
        sec13arr = Split(sec13cat, ",")
        sec14arr = Split(sec14cat, ",")
        sec15arr = Split(sec15cat, ",")
        sec16arr = Split(sec16cat, ",")
        sec17arr = Split(sec17cat, ",")
        sec18arr = Split(sec18cat, ",")
        sec19arr = Split(sec19cat, ",")
        sec20arr = Split(sec20cat, ",")
        sec21arr = Split(sec21cat, ",")
        sec22aarr = Split(sec22acat, ",")
        sec22barr = Split(sec22bcat, ",")
        sec22carr = Split(sec22ccat, ",")
        sec22darr = Split(sec22dcat, ",")
        sec22earr = Split(sec22ecat, ",")
        sec23arr = Split(sec23cat, ",")
        sec24arr = Split(sec24cat, ",")
        sec25arr = Split(sec25cat, ",")
        sec26arr = Split(sec26cat, ",")

        'TODO: Need a loop for the code below
        'Trims the empty characters after each letter 
        For intCount = LBound(sec4arr) To UBound(sec4arr)
            Debug.Print(Trim(sec4arr(intCount)))
        Next
        For intCount = LBound(sec5arr) To UBound(sec5arr)
            Debug.Print(Trim(sec5arr(intCount)))
        Next
        For intCount = LBound(sec6arr) To UBound(sec6arr)
            Debug.Print(Trim(sec6arr(intCount)))
        Next
        For intCount = LBound(sec7arr) To UBound(sec7arr)
            Debug.Print(Trim(sec7arr(intCount)))
        Next
        For intCount = LBound(sec8arr) To UBound(sec8arr)
            Debug.Print(Trim(sec8arr(intCount)))
        Next
        For intCount = LBound(sec9arr) To UBound(sec9arr)
            Debug.Print(Trim(sec9arr(intCount)))
        Next
        For intCount = LBound(sec10arr) To UBound(sec10arr)
            Debug.Print(Trim(sec10arr(intCount)))
        Next
        For intCount = LBound(sec11arr) To UBound(sec11arr)
            Debug.Print(Trim(sec11arr(intCount)))
        Next
        For intCount = LBound(sec12arr) To UBound(sec12arr)
            Debug.Print(Trim(sec12arr(intCount)))
        Next
        For intCount = LBound(sec13arr) To UBound(sec13arr)
            Debug.Print(Trim(sec13arr(intCount)))
        Next
        For intCount = LBound(sec14arr) To UBound(sec14arr)
            Debug.Print(Trim(sec14arr(intCount)))
        Next
        For intCount = LBound(sec15arr) To UBound(sec15arr)
            Debug.Print(Trim(sec15arr(intCount)))
        Next
        For intCount = LBound(sec16arr) To UBound(sec16arr)
            Debug.Print(Trim(sec16arr(intCount)))
        Next
        For intCount = LBound(sec18arr) To UBound(sec18arr)
            Debug.Print(Trim(sec18arr(intCount)))
        Next
        For intCount = LBound(sec19arr) To UBound(sec19arr)
            Debug.Print(Trim(sec19arr(intCount)))
        Next
        For intCount = LBound(sec20arr) To UBound(sec20arr)
            Debug.Print(Trim(sec20arr(intCount)))
        Next
        For intCount = LBound(sec21arr) To UBound(sec21arr)
            Debug.Print(Trim(sec21arr(intCount)))
        Next
        For intCount = LBound(sec22aarr) To UBound(sec22aarr)
            Debug.Print(Trim(sec22aarr(intCount)))
        Next
        For intCount = LBound(sec22barr) To UBound(sec22barr)
            Debug.Print(Trim(sec22barr(intCount)))
        Next
        For intCount = LBound(sec22carr) To UBound(sec22carr)
            Debug.Print(Trim(sec22carr(intCount)))
        Next
        For intCount = LBound(sec22darr) To UBound(sec22darr)
            Debug.Print(Trim(sec22darr(intCount)))
        Next
        For intCount = LBound(sec22earr) To UBound(sec22earr)
            Debug.Print(Trim(sec22earr(intCount)))
        Next
        For intCount = LBound(sec23arr) To UBound(sec23arr)
            Debug.Print(Trim(sec23arr(intCount)))
        Next
        For intCount = LBound(sec24arr) To UBound(sec24arr)
            Debug.Print(Trim(sec24arr(intCount)))
        Next
        For intCount = LBound(sec25arr) To UBound(sec25arr)
            Debug.Print(Trim(sec25arr(intCount)))
        Next
        For intCount = LBound(sec26arr) To UBound(sec26arr)
            Debug.Print(Trim(sec26arr(intCount)))
        Next

        'TODO: Write a loop for the code below
        'Clears the combobox before adding the equipment categories to it
        Section4.cboA1S4.Items.AddRange(sec4arr)
        Section5.cboA1S5.Items.Clear()
        Section5.cboA1S5.Items.AddRange(sec5arr)
        Section6.cboA1S6.Items.Clear()
        Section6.cboA1S6.Items.AddRange(sec6arr)
        Section7.cboA1S7.Items.Clear()
        Section7.cboA1S7.Items.AddRange(sec7arr)
        Section8.cboA1S8.Items.Clear()
        Section8.cboA1S8.Items.AddRange(sec8arr)
        Section9.cboA1S9.Items.Clear()
        Section9.cboA1S9.Items.AddRange(sec9arr)
        Section10.cboA1S10.Items.Clear()
        Section10.cboA1S10.Items.AddRange(sec10arr)
        Section11.cboA1S11.Items.Clear()
        Section11.cboA1S11.Items.AddRange(sec11arr)
        Section12.cboA1S12.Items.Clear()
        Section12.cboA1S12.Items.AddRange(sec12arr)
        Section13.cboA1S13.Items.Clear()
        Section13.cboA1S13.Items.AddRange(sec13arr)
        Section14.cboA1S14.Items.Clear()
        Section14.cboA1S14.Items.AddRange(sec14arr)
        Section15.cboA1S15.Items.Clear()
        Section15.cboA1S15.Items.AddRange(sec15arr)
        Section16.cboA1S16.Items.Clear()
        Section16.cboA1S16.Items.AddRange(sec16arr)
        Section17.cboA1S17.Items.Clear()
        Section17.cboA1S17.Items.AddRange(sec17arr)
        Section18.cboA1S18.Items.Clear()
        Section18.cboA1S18.Items.AddRange(sec18arr)
        Section19.cboA1S19.Items.Clear()
        Section19.cboA1S19.Items.AddRange(sec19arr)
        Section20.cboA1S20.Items.Clear()
        Section20.cboA1S20.Items.AddRange(sec20arr)
        Section21.cboA1S21.Items.Clear()
        Section21.cboA1S21.Items.AddRange(sec21arr)
        Section22.cboA1S22A.Items.Clear()
        Section22.cboA1S22A.Items.AddRange(sec22aarr)
        Section22.cboA1S22B.Items.Clear()
        Section22.cboA1S22B.Items.AddRange(sec22barr)
        Section22.cboA1S22C.Items.Clear()
        Section22.cboA1S22C.Items.AddRange(sec22carr)
        Section22.cboA1S22D.Items.Clear()
        Section22.cboA1S22D.Items.AddRange(sec22darr)
        Section22.cboA1S22E.Items.Clear()
        Section22.cboA1S22E.Items.AddRange(sec22earr)
        Section23.cboA1S23.Items.Clear()
        Section23.cboA1S23.Items.AddRange(sec23arr)
        Section24.cboA1S24.Items.Clear()
        Section24.cboA1S24.Items.AddRange(sec24arr)
        Section25.cboA1S25.Items.Clear()
        Section25.cboA1S25.Items.AddRange(sec25arr)
        Section26.cboA1S26.Items.Clear()
        Section26.cboA1S26.Items.AddRange(sec26arr)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim control As CheckBox = New CheckBox
        For Each control In checkboxes
            If control.Checked = True Then
                For i = 1 To tblDevices.RowCount Step 1
                    If tblDevices.GetControlFromPosition(1, i).Name = control.Name Then

                    End If
                Next
            End If
        Next
    End Sub

    Private Sub D0160_EBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.D0160_EBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CentralDatabaseDataSet)

    End Sub
End Class