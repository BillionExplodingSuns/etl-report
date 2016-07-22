Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports MigraDoc
Imports MigraDoc.DocumentObjectModel.Tables
Imports MigraDoc.DocumentObjectModel.Shapes
Imports Microsoft.Office.Interop
Imports System.IO

Public Class Portal
    'Create instances of the first accessible classes after the portal class
    Protected Friend Shared portalInst As Portal
    Protected Friend Shared main2Inst As Main2
    'Protected Friend Shared mainInst As Main
    Protected Friend Shared recordTestInst As RecordTest
    Protected Friend Shared accessTestInst As AccessTest
    Protected Friend Shared niarContactInst As NIARContact
    Protected Friend Shared accessQuoteInst As AccessQuote
    Protected Friend Shared equipmentInst As Equipment

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Create a test
        If main2Inst Is Nothing Then
            main2Inst = New Main2
            main2Inst.myCaller = Me
        End If
        main2Inst.Show()
        portalInst.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Exit the program
        portalInst.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Record a test
        If recordTestInst Is Nothing Then
            recordTestInst = New RecordTest
            recordTestInst.myCallerRec = Me
        End If
        recordTestInst = RecordTest
        recordTestInst.Show()
        portalInst.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Access a test
        accessTestInst = AccessTest
        accessTestInst.Show()
        portalInst.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Generate a quote
        If niarContactInst Is Nothing Then
            niarContactInst = New NIARContact
            niarContactInst.myCallerNIAR = Me
        End If
        niarContactInst.Show()
        portalInst.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Access a quote
        accessQuoteInst = AccessQuote
        accessQuoteInst.Show()
        portalInst.Hide()
    End Sub

    Private Sub Portal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        portalInst = Me 'Set instance of portal
        portalInst.Show()   'Show that instance
        Me.Hide()   'Hide the default form

        'Set the portal as the parent class to the 5 first accessible classes
        main2Inst.MdiParent = portalInst
        recordTestInst.MdiParent = portalInst
        accessTestInst.MdiParent = portalInst
        niarContactInst.MdiParent = portalInst
        accessQuoteInst.MdiParent = portalInst
        'mainInst.MdiParent = portalInst
        equipmentInst.MdiParent = portalInst

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If equipmentInst Is Nothing Then
            equipmentInst = New Equipment
        End If
        equipmentInst = Equipment
        equipmentInst.Show()
        Dim check As Boolean = True
        Dim fileMain = FolderBrowserDialog1.SelectedPath & "\" & txtYear.Text & "\" & txtCompany.Text & "\" & txtReport.Text & "\" & "Test Data"
        'MessageBox.Show(fileMain)
        For Each strFolder As String In System.IO.Directory.GetDirectories(fileMain)
            Dim section As String = "Section"
            'MessageBox.Show(Path.GetFileName(strFolder))
            If Len(Path.GetFileName(strFolder)) > 6 Then
                check = True
                For i As Integer = 0 To 6 Step 1
                    If Path.GetFileName(strFolder)(i) <> section(i) Then
                        check = False
                        'MessageBox.Show("False")
                    End If
                Next
                If check = True Then
                    equipmentInst.cboSection.Items.Add(Path.GetFileName(strFolder))
                End If
            End If
        Next
        portalInst.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Create a test
        If main2Inst Is Nothing Then
            main2Inst = New Main2
            main2Inst.myCaller = Me
        End If
        'If mainInst Is Nothing Then
        '    mainInst = New Main
        '    'mainInst.myCaller2 = Me
        'End If
        main2Inst.Show()
        portalInst.Hide()
    End Sub
End Class
