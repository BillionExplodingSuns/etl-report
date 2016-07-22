Imports System.IO
Imports System.Diagnostics.Process
'Imports Microsoft.Office.Interop.Excel
Imports System.Text.RegularExpressions

Public Class Equipment
    Dim sections(22) As String
    'Dim xlsmApp As New Excel.Application
    'Dim xlsmWB1 As Excel.Workbook
    'Dim xlsmWS1 As Excel.Worksheet
    Dim view As DataGridView = New DataGridView
    'used to open up the master equipment database file from excel
    'Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    '    Dim fileEquip As String = "k:\\Visual Basic\NIAR\ETL\Copy Equipment Master Database.xlsm"
    '    xlsmApp.Workbooks.Open(fileEquip)
    '    xlsmApp.Visible = True
    '    Exit Sub

    'End Sub

    'used to get all the data from the equipment database file
    'will need to update to automatically find out how many rows and columns are in file
    'Private Sub Button2_Click(sender As Object, e As EventArgs)

    '    Dim fileEquip As String = "C:\Users\rramirez\Downloads\Copy of Equipment Master Database.xlsm"
    '    xlsmWB1 = xlsmApp.Workbooks.Open(fileEquip)
    '    xlsmApp.Visible = False
    '    xlsmWS1 = xlsmWB1.Worksheets("tblEquipment")

    '    Dim excel_col As Integer = 2
    '    Dim excel_row As Integer
    '    Dim max_row As Integer = 2

    '    While (xlsmWS1.Cells(max_row, 2).Value IsNot Nothing)
    '        max_row = max_row + 1
    '    End While
    '    'Reading the Excel file and putting everything in Memory for faster manipulationn
    '    Dim bool4 As Boolean = False
    '    Dim bool5 As Boolean = False
    '    Dim bool6 As Boolean = False
    '    Dim bool7 As Boolean = False
    '    Dim bool8 As Boolean = False
    '    Dim bool9 As Boolean = False
    '    Dim bool10 As Boolean = False
    '    Dim bool11 As Boolean = False
    '    Dim bool12 As Boolean = False
    '    Dim bool13 As Boolean = False
    '    Dim bool14 As Boolean = False
    '    Dim bool15 As Boolean = False
    '    Dim bool16 As Boolean = False
    '    Dim bool17 As Boolean = False
    '    Dim bool18 As Boolean = False
    '    Dim bool19 As Boolean = False
    '    Dim bool20 As Boolean = False
    '    Dim bool21 As Boolean = False
    '    Dim bool22 As Boolean = False
    '    Dim bool23 As Boolean = False
    '    Dim bool24 As Boolean = False
    '    Dim bool25 As Boolean = False
    '    Dim bool26 As Boolean = False

    '    For excel_row = 934 To max_row Step 1
    '        bool4 = False
    '        bool5 = False
    '        bool6 = False
    '        bool7 = False
    '        bool8 = False
    '        bool9 = False
    '        bool10 = False
    '        bool11 = False
    '        bool12 = False
    '        bool13 = False
    '        bool14 = False
    '        bool15 = False
    '        bool16 = False
    '        bool17 = False
    '        bool18 = False
    '        bool19 = False
    '        bool20 = False
    '        bool21 = False
    '        bool22 = False
    '        bool23 = False
    '        bool24 = False
    '        bool25 = False
    '        bool26 = False
    '        Dim equip_row As DataRow = Me.CentralDatabaseDataSet.Equipment_4.NewEquipment_4Row
    '        equip_row("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row1 As DataRow = Me.CentralDatabaseDataSet.Equipment_6.NewEquipment_6Row
    '        equip_row1("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row1("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row1("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row1("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row1("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row1("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row1("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row1("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row1("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row1("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row2 As DataRow = Me.CentralDatabaseDataSet.Equipment_7.NewEquipment_7Row
    '        equip_row2("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row2("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row2("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row2("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row2("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row2("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row2("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row2("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row2("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row2("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row3 As DataRow = Me.CentralDatabaseDataSet.Equipment_8.NewEquipment_8Row
    '        equip_row3("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row3("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row3("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row3("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row3("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row3("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row3("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row3("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row3("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row3("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row4 As DataRow = Me.CentralDatabaseDataSet.Equipment_9.NewEquipment_9Row
    '        equip_row4("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row4("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row4("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row4("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row4("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row4("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row4("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row4("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row4("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row4("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row5 As DataRow = Me.CentralDatabaseDataSet.Equipment_10.NewEquipment_10Row
    '        equip_row5("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row5("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row5("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row5("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row5("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row5("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row5("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row5("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row5("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row5("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value


    '        Dim equip_row6 As DataRow = Me.CentralDatabaseDataSet.Equipment_11.NewEquipment_11Row
    '        equip_row6("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row6("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row6("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row6("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row6("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row6("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row6("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row6("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row6("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row6("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row7 As DataRow = Me.CentralDatabaseDataSet.Equipment_12.NewEquipment_12Row
    '        equip_row7("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row7("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row7("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row7("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row7("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row7("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row7("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row7("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row7("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row7("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row8 As DataRow = Me.CentralDatabaseDataSet.Equipment_13.NewEquipment_13Row
    '        equip_row8("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row8("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row8("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row8("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row8("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row8("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row8("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row8("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row8("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row8("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row9 As DataRow = Me.CentralDatabaseDataSet.Equipment_14.NewEquipment_14Row
    '        equip_row9("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row9("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row9("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row9("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row9("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row9("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row9("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row9("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row9("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row9("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row10 As DataRow = Me.CentralDatabaseDataSet.Equipment_15.NewEquipment_15Row
    '        equip_row10("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row10("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row10("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row10("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row10("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row10("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row10("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row10("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row10("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row10("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row11 As DataRow = Me.CentralDatabaseDataSet.Equipment_16.NewEquipment_16Row
    '        equip_row11("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row11("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row11("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row11("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row11("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row11("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row11("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row11("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row11("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row11("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row12 As DataRow = Me.CentralDatabaseDataSet.Equipment_17.NewEquipment_17Row
    '        equip_row12("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row12("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row12("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row12("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row12("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row12("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row12("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row12("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row12("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row12("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row13 As DataRow = Me.CentralDatabaseDataSet.Equipment_18.NewEquipment_18Row
    '        equip_row13("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row13("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row13("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row13("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row13("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row13("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row13("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row13("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row13("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row13("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row14 As DataRow = Me.CentralDatabaseDataSet.Equipment_19.NewEquipment_19Row
    '        equip_row14("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row14("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row14("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row14("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row14("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row14("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row14("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row14("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row14("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row14("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row15 As DataRow = Me.CentralDatabaseDataSet.Equipment_20.NewEquipment_20Row
    '        equip_row15("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row15("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row15("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row15("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row15("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row15("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row15("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row15("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row15("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row15("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row16 As DataRow = Me.CentralDatabaseDataSet.Equipment_21.NewEquipment_21Row
    '        equip_row16("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row16("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row16("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row16("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row16("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row16("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row16("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row16("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row16("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row16("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row17 As DataRow = Me.CentralDatabaseDataSet.Equipment_22.NewEquipment_22Row
    '        equip_row17("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row17("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row17("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row17("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row17("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row17("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row17("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row17("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row17("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row17("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row18 As DataRow = Me.CentralDatabaseDataSet.Equipment_23.NewEquipment_23Row
    '        equip_row18("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    'xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row18("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row18("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row18("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row18("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row18("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row18("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row18("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row18("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row19 As DataRow = Me.CentralDatabaseDataSet.Equipment_24.NewEquipment_24Row
    '        equip_row19("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row19("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row19("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row19("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row19("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row19("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row19("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row19("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row19("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row19("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row20 As DataRow = Me.CentralDatabaseDataSet.Equipment_25.NewEquipment_25Row
    '        equip_row20("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row20("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row20("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row20("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row20("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row20("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row20("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row20("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row20("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row20("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        Dim equip_row21 As DataRow = Me.CentralDatabaseDataSet.Equipment_26.NewEquipment_26Row
    '        equip_row21("Type") = xlsmWS1.Cells(excel_row, excel_col).Value
    '        equip_row21("Description") = xlsmWS1.Cells(excel_row, excel_col + 1).Value
    '        equip_row21("Model Number") = xlsmWS1.Cells(excel_row, excel_col + 2).Value
    '        equip_row21("Serial Number") = xlsmWS1.Cells(excel_row, excel_col + 3).Value
    '        equip_row21("Asset Number") = xlsmWS1.Cells(excel_row, excel_col + 4).Value
    '        equip_row21("Manufacturer ID") = xlsmWS1.Cells(excel_row, excel_col + 5).Value
    '        equip_row21("Department ID") = xlsmWS1.Cells(excel_row, excel_col + 6).Value
    '        equip_row21("Location") = xlsmWS1.Cells(excel_row, excel_col + 7).Value
    '        equip_row21("Last Calibration") = xlsmWS1.Cells(excel_row, excel_col + 8).Value
    '        equip_row21("Calibration Due Date") = xlsmWS1.Cells(excel_row, excel_col + 9).Value

    '        'check value of cell for "X"
    '        If xlsmWS1.Cells(excel_row, excel_col + 12).Value = "X" Then
    '            bool4 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 12).Value = "X" Then
    '            bool6 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 13).Value = "X" Then
    '            bool7 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 14).Value = "X" Then
    '            bool8 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 15).Value = "X" Then
    '            bool9 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 16).Value = "X" Then
    '            bool10 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 17).Value = "X" Then
    '            bool11 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 18).Value = "X" Then
    '            bool12 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 19).Value = "X" Then
    '            bool13 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 20).Value = "X" Then
    '            bool14 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 21).Value = "X" Then
    '            bool15 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 22).Value = "X" Then
    '            bool16 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 23).Value = "X" Then
    '            bool17 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 24).Value = "X" Then
    '            bool18 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 25).Value = "X" Then
    '            bool19 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 26).Value = "X" Then
    '            bool20 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 27).Value = "X" Then
    '            bool21 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 28).Value = "X" Then
    '            bool22 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 29).Value = "X" Then
    '            bool23 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 30).Value = "X" Then
    '            bool24 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 31).Value = "X" Then
    '            bool25 = True
    '        End If
    '        If xlsmWS1.Cells(excel_row, excel_col + 32).Value = "X" Then
    '            bool26 = True
    '        End If


    '        If bool4 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_4.AddEquipment_4Row(equip_row)
    '            Equipment_4TableAdapter.Update(Me.CentralDatabaseDataSet)
    '        End If
    '        If bool6 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_6.AddEquipment_6Row(equip_row1)
    '            Equipment_6TableAdapter.Update(Me.CentralDatabaseDataSet)
    '        End If
    '        If bool7 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_7.AddEquipment_7Row(equip_row2)
    '            Equipment_7TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_7)
    '        End If
    '        If bool8 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_8.AddEquipment_8Row(equip_row3)
    '            Equipment_8TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_8)
    '        End If
    '        If bool9 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_9.AddEquipment_9Row(equip_row4)
    '            Equipment_9TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_9)
    '        End If
    '        If bool10 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_10.AddEquipment_10Row(equip_row5)
    '            Equipment_10TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_10)
    '        End If
    '        If bool11 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_11.AddEquipment_11Row(equip_row6)
    '            Equipment_11TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_11)
    '        End If
    '        If bool12 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_12.AddEquipment_12Row(equip_row7)
    '            Equipment_12TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_12)
    '        End If
    '        If bool13 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_13.AddEquipment_13Row(equip_row8)
    '            Equipment_13TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_13)
    '        End If
    '        If bool14 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_14.AddEquipment_14Row(equip_row9)
    '            Equipment_14TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_14)
    '        End If
    '        If bool15 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_15.AddEquipment_15Row(equip_row10)
    '            Equipment_15TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_15)
    '        End If
    '        If bool16 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_16.AddEquipment_16Row(equip_row11)
    '            Equipment_16TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_16)
    '        End If
    '        If bool17 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_17.AddEquipment_17Row(equip_row12)
    '            Equipment_17TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_17)
    '        End If
    '        If bool18 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_18.AddEquipment_18Row(equip_row13)
    '            Equipment_18TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_18)
    '        End If
    '        If bool19 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_19.AddEquipment_19Row(equip_row14)
    '            Equipment_19TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_19)
    '        End If
    '        If bool20 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_20.AddEquipment_20Row(equip_row15)
    '            Equipment_20TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_20)
    '        End If
    '        If bool21 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_21.AddEquipment_21Row(equip_row16)
    '            Equipment_21TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_21)
    '        End If
    '        If bool22 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_22.AddEquipment_22Row(equip_row17)
    '            Equipment_22TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_22)
    '        End If
    '        If bool23 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_23.AddEquipment_23Row(equip_row18)
    '            Equipment_23TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_23)
    '        End If
    '        If bool24 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_24.AddEquipment_24Row(equip_row19)
    '            Equipment_24TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_24)
    '        End If
    '        If bool25 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_25.AddEquipment_25Row(equip_row20)
    '            Equipment_25TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_25)
    '        End If
    '        If bool26 = True Then
    '            Me.CentralDatabaseDataSet.Equipment_26.AddEquipment_26Row(equip_row21)
    '            Equipment_26TableAdapter.Update(Me.CentralDatabaseDataSet.Equipment_26)
    '        End If
    '    Next
    '    MessageBox.Show("Done")
    '    xlsmWB1.Close()
    '    xlsmApp.Quit()
    '    xlsmApp = Nothing
    '    xlsmWB1 = Nothing
    '    xlsmWS1 = Nothing
    '    Exit Sub
    'End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim tables() As DataTable = {Me.CentralDatabaseDataSet.Equipment_4, Me.CentralDatabaseDataSet.Equipment_5, Me.CentralDatabaseDataSet.Equipment_6, _
                Me.CentralDatabaseDataSet.Equipment_7, Me.CentralDatabaseDataSet.Equipment_8, Me.CentralDatabaseDataSet.Equipment_9, _
                Me.CentralDatabaseDataSet.Equipment_10, Me.CentralDatabaseDataSet.Equipment_11, Me.CentralDatabaseDataSet.Equipment_12, _
                Me.CentralDatabaseDataSet.Equipment_13, Me.CentralDatabaseDataSet.Equipment_14, Me.CentralDatabaseDataSet.Equipment_15, _
                Me.CentralDatabaseDataSet.Equipment_16, Me.CentralDatabaseDataSet.Equipment_17, Me.CentralDatabaseDataSet.Equipment_18, _
                Me.CentralDatabaseDataSet.Equipment_19, Me.CentralDatabaseDataSet.Equipment_20, Me.CentralDatabaseDataSet.Equipment_21, _
                Me.CentralDatabaseDataSet.Equipment_22, Me.CentralDatabaseDataSet.Equipment_23, Me.CentralDatabaseDataSet.Equipment_24, _
                Me.CentralDatabaseDataSet.Equipment_25, Me.CentralDatabaseDataSet.Equipment_26, Me.CentralDatabaseDataSet.Mechanical, Me.CentralDatabaseDataSet.Electrical}

        Dim grids As DataGridView() = {Equip4, Equip5, Equip6, Equip7, Equip8, Equip9, Equip10, Equip11, Equip12, Equip13, Equip14, Equip15, Equip16, Equip17, _
                               Equip18, Equip19, Equip20, Equip21, Equip22, Equip23, Equip24, Equip25, Equip26, MechanicalDataGridView, ElectricalDataGridView}
        Dim select_row As DataRow = Me.CentralDatabaseDataSet.Selected_Equipment.NewRow
        Dim view As DataGridView = New DataGridView
        Dim counter As Integer = 0
        Dim temp1 As DataRow = Me.CentralDatabaseDataSet.Selected_Equipment.NewRow
        For Each view In grids
            If view.Visible = True Then
                Dim temp2 As DataRow = tables(counter).NewRow
                temp2 = tables(counter).Rows(Me.BindingNavigatorPositionItem.Text - 1)
                temp1("Type") = temp2("Type")
                temp1("Description") = temp2("Description")
                temp1("Model Number") = temp2("Model Number")
                temp1("Serial Number") = temp2("Serial Number")
                temp1("Asset Number") = temp2("Asset Number")
                temp1("Manufacturer ID") = temp2("Manufacturer ID")
                temp1("Department ID") = temp2("Department ID")
                temp1("Last Calibration") = temp2("Last Calibration")
                temp1("Calibration Due Date") = temp2("Calibration Due Date")
                Me.CentralDatabaseDataSet.Selected_Equipment.Rows.Add(temp1)
            End If
            counter = counter + 1
        Next
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim application As New Microsoft.Office.Interop.Excel.Application
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = application.Workbooks.Open(Portal.portalInst.FolderBrowserDialog1.SelectedPath & "\" & Portal.portalInst.txtYear.Text & "\" & Portal.portalInst.txtCompany.Text & "\" & Portal.portalInst.txtReport.Text & "\" & "Test Data" & "\" & cboSection.SelectedItem & "\" & "Equipment.xlsx")
        application.Visible = False
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = workbook.Worksheets("Sheet1")
        Dim counter1 As Integer = 2
        Dim counter2 As Integer = 1
        Dim temp As DataRow = Me.CentralDatabaseDataSet.Selected_Equipment.NewRow
        For Each temp In Me.CentralDatabaseDataSet.Selected_Equipment.Rows
            worksheet.Cells(counter1, counter2) = temp("Type")
            worksheet.Cells(counter1, counter2 + 1) = temp("Description")
            worksheet.Cells(counter1, counter2 + 2) = temp("Model Number")
            worksheet.Cells(counter1, counter2 + 3) = temp("Serial Number")
            worksheet.Cells(counter1, counter2 + 4) = temp("Asset Number")
            worksheet.Cells(counter1, counter2 + 5) = temp("Manufacturer ID")
            worksheet.Cells(counter1, counter2 + 6) = temp("Department ID")
            worksheet.Cells(counter1, counter2 + 7) = temp("Last Calibration")
            worksheet.Cells(counter1, counter2 + 8) = temp("Calibration Due Date")

            counter1 = counter1 + 1
        Next
        Me.CentralDatabaseDataSet.Selected_Equipment.Clear()
        workbook.SaveAs(Portal.portalInst.FolderBrowserDialog1.SelectedPath & "\" & Portal.portalInst.txtYear.Text & "\" & Portal.portalInst.txtCompany.Text & "\" & Portal.portalInst.txtReport.Text & "\" & "Test Data" & "\" & cboSection.SelectedItem & "\" & "Equipment.xlsx")
        workbook.Close()
        application.Quit()
        application = Nothing
        workbook = Nothing
        worksheet = Nothing


    End Sub

    'used to check the section selected and then display corresponding equipment that is in section from database
    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged

        'array of strings to determine which section was selected
        Dim sections As String() = {"Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", _
                                    "Section 14", "Section 15", "Section 16", "Section 17", "Section 18", "Section 19", "Section 20", "Section 21", "Section 22", "Section 23", _
                                    "Section 24", "Section 25", "Section 26"}
        Dim section As String 'used iterate through string array
        Dim counter As Integer = -1 'used to iterate through data tables
        Dim grids As DataGridView() = {Equip4, Equip5, Equip6, Equip7, Equip8, Equip9, Equip10, Equip11, Equip12, Equip13, Equip14, Equip15, Equip16, Equip17, _
                                       Equip18, Equip19, Equip20, Equip21, Equip22, Equip23, Equip24, Equip25, Equip26, MechanicalDataGridView, ElectricalDataGridView}
        Dim source As BindingSource = New BindingSource
        Dim temp As DataGridView = New DataGridView
        For Each temp In grids
            If temp.Visible = True Then
                temp.Visible = False
            End If
        Next
        If cboSection.SelectedIndex <> -1 Then
            For Each section In sections
                counter = counter + 1
                If cboSection.SelectedItem = section Then
                    view = grids(counter)
                    view.Visible = True
                    navEquipment.BindingSource = grids(counter).DataSource
                End If
            Next
        End If

        'SECTION USED TO FILL IN SELECTED EQUIPMENT TABLE IF EXCEL SHEET IS NOT EMPTY
        'NOT FILLING IN CORRECT VALUES OF CELLS
        Dim file As String = Portal.portalInst.FolderBrowserDialog1.SelectedPath & "\" & Portal.portalInst.txtYear.Text & "\" & Portal.portalInst.txtCompany.Text & "\" & Portal.portalInst.txtReport.Text & "\" & "Test Data" & "\" & cboSection.SelectedItem & "\" & "Equipment.xlsx"
        Dim app As New Microsoft.Office.Interop.Excel.Application
        Dim book As Microsoft.Office.Interop.Excel.Workbook = app.Workbooks.Open(file)
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = book.Worksheets("Sheet1")
        Dim max_row As Integer = 2
        app.Visible = True
        While (worksheet.Cells(max_row, 1).Value IsNot Nothing)
            max_row = max_row + 1
        End While
        If worksheet.Cells(2, 1).value IsNot Nothing Then
            If max_row > 2 Or max_row = 2 Then
                'Me.CentralDatabaseDataSet.Selected_Equipment.Clear()
                For i As Integer = 2 To max_row Step 1
                    Dim add As DataRow = Me.CentralDatabaseDataSet.Selected_Equipment.NewRow

                    add("Type") = worksheet.Range("A" & i).Text
                    add("Description") = worksheet.Range("B" & i).Text
                    add("Model Number") = worksheet.Range("C" & i).Text
                    add("Serial Number") = worksheet.Range("D" & i).Text
                    add("Asset Number") = worksheet.Range("E" & i).Text
                    add("Manufacturer ID") = worksheet.Range("F" & i).Text
                    add("Department ID") = worksheet.Range("G" & i).Text
                    add("Last Calibration") = worksheet.Range("H" & i).Text
                    add("Calibration Due Date") = worksheet.Range("I" & i).Text

                    Me.CentralDatabaseDataSet.Selected_Equipment.AddSelected_EquipmentRow(add)
                Next
            End If
        End If
        book.Close()
        app.Quit()
    End Sub
    Private Sub Equipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Equipment_ExtraTableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_Extra)
        Me.Equipment_9TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_9)
        Me.Equipment_8TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_8)
        Me.Equipment_7TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_7)
        Me.Equipment_6TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_6)
        Me.Equipment_5TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_5)
        Me.Equipment_4TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_4)
        Me.Equipment_26TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_26)
        Me.Equipment_25TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_25)
        Me.Equipment_24TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_24)
        Me.Equipment_23TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_23)
        Me.Equipment_22TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_22)
        Me.Equipment_21TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_21)
        Me.Equipment_20TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_20)
        Me.Equipment_19TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_19)
        Me.Equipment_18TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_18)
        Me.Equipment_17TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_17)
        Me.Equipment_16TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_16)
        Me.Equipment_15TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_15)
        Me.Equipment_14TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_14)
        Me.Equipment_13TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_13)
        Me.Equipment_12TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_12)
        Me.Equipment_11TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_11)
        Me.Equipment_10TableAdapter.Fill(Me.CentralDatabaseDataSet.Equipment_10)
        Me.Selected_EquipmentTableAdapter.Fill(Me.CentralDatabaseDataSet.Selected_Equipment)

        'hide equipment tables until section is selected
        Equip4.Visible = False
        Equip5.Visible = False
        Equip6.Visible = False
        Equip7.Visible = False
        Equip8.Visible = False
        Equip9.Visible = False
        Equip10.Visible = False
        Equip11.Visible = False
        Equip12.Visible = False
        Equip13.Visible = False
        Equip14.Visible = False
        Equip15.Visible = False
        Equip16.Visible = False
        Equip17.Visible = False
        Equip18.Visible = False
        Equip19.Visible = False
        Equip20.Visible = False
        Equip21.Visible = False
        Equip22.Visible = False
        Equip23.Visible = False
        Equip24.Visible = False
        Equip25.Visible = False
        Equip26.Visible = False
        MechanicalDataGridView.Visible = False
        ElectricalDataGridView.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Portal.portalInst.Show()
        Portal.equipmentInst.Hide()
    End Sub

    Private Sub btnMechanical_Click(sender As Object, e As EventArgs) Handles btnMechanical.Click
        Me.CentralDatabaseDataSet.Mechanical.Clear()
        Dim all_grids As DataGridView() = {Equip4, Equip5, Equip6, Equip7, Equip8, Equip9, Equip10, Equip11, Equip12, Equip13, Equip14, Equip15, Equip16, Equip17, _
                               Equip18, Equip19, Equip20, Equip21, Equip22, Equip23, Equip24, Equip25, Equip26, ElectricalDataGridView}
        Dim all_tables As DataTable() = {Me.CentralDatabaseDataSet.Equipment_4, Me.CentralDatabaseDataSet.Equipment_5, Me.CentralDatabaseDataSet.Equipment_6, Me.CentralDatabaseDataSet.Equipment_7, _
                                    Me.CentralDatabaseDataSet.Equipment_8, Me.CentralDatabaseDataSet.Equipment_9, Me.CentralDatabaseDataSet.Equipment_10, Me.CentralDatabaseDataSet.Equipment_11, Me.CentralDatabaseDataSet.Equipment_12, _
                                    Me.CentralDatabaseDataSet.Equipment_13, Me.CentralDatabaseDataSet.Equipment_14, Me.CentralDatabaseDataSet.Equipment_24}
        Dim row As DataRow
        Dim table As DataTable
        For Each temp In all_grids
            If temp.Visible = True Then
                temp.Visible = False
            End If
        Next
        For Each table In all_tables
            For Each row In table.Rows
                Me.CentralDatabaseDataSet.Mechanical.ImportRow(row)
            Next
        Next
        MechanicalDataGridView.Visible = True
        navEquipment.BindingSource = MechanicalDataGridView.DataSource
    End Sub

    Private Sub btnElectrical_Click(sender As Object, e As EventArgs) Handles btnElectrical.Click
        Me.CentralDatabaseDataSet.Electrical.Clear()
        Dim grids As DataGridView() = {Equip4, Equip5, Equip6, Equip7, Equip8, Equip9, Equip10, Equip11, Equip12, Equip13, Equip14, Equip15, Equip16, Equip17, _
                               Equip18, Equip19, Equip20, Equip21, Equip22, Equip23, Equip24, Equip25, Equip26, MechanicalDataGridView}
        Dim sets As DataTable() = {Me.CentralDatabaseDataSet.Equipment_15, Me.CentralDatabaseDataSet.Equipment_16, Me.CentralDatabaseDataSet.Equipment_17, _
                                         Me.CentralDatabaseDataSet.Equipment_18, Me.CentralDatabaseDataSet.Equipment_19, Me.CentralDatabaseDataSet.Equipment_20, _
                                         Me.CentralDatabaseDataSet.Equipment_21, Me.CentralDatabaseDataSet.Equipment_22, Me.CentralDatabaseDataSet.Equipment_23, _
                                         Me.CentralDatabaseDataSet.Equipment_25}
        For Each temp In grids
            If temp.Visible = True Then
                temp.Visible = False
            End If
        Next
        For Each table In sets
            For Each row In table.Rows
                Me.CentralDatabaseDataSet.Electrical.ImportRow(row)
            Next
        Next
        ElectricalDataGridView.Visible = True
        navEquipment.BindingSource = ElectricalDataGridView.DataSource
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class