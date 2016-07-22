Imports Microsoft.Office.Interop

Public Class QuoteGenerator

    Inherits System.Windows.Forms.Form
    Public myCallerGen As CustomerContact
    Protected Friend Shared viewTestQuoteInst As ViewTestQuote
    Protected Friend Shared addTestQuoteInst As AddTestQuote

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'CustomerContact.Show()
        'Me.Hide()
        NIARContact.custContInst.myCallerCust.Show()
        CustomerContact.quoteGenInst.Hide()
    End Sub

    Private Sub NextMain_Click(sender As Object, e As EventArgs) Handles NextMain.Click
        If addTestQuoteInst Is Nothing Then 'Creates the instance of the Main form if one hasn't already been created yet
            addTestQuoteInst = New AddTestQuote
            'quoteGenInst.myCallerGen = Me
        End If
        addTestQuoteInst.Show()             'Show the main create a test form
        CustomerContact.quoteGenInst.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If viewTestQuoteInst Is Nothing Then 'Creates the instance of the Main form if one hasn't already been created yet
            viewTestQuoteInst = New ViewTestQuote
            'quoteGenInst.myCallerGen = Me
        End If
        viewTestQuoteInst.Show()             'Show the main create a test form
        CustomerContact.quoteGenInst.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'this section is used to create a new word document based off of 
        'a premade template and what the user enters in the forms NIARcontact, customerContact and add test
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim row As Integer
        Dim column As Integer = 1
        Dim quote_file = InputBox("Enter Quote Name:", "Quote Generator", ) 'have the user name the file

        If quote_file.ToString <> "" Then
            'Start Word and open the document template.
            oWord = CreateObject("Word.Application")
            oWord.Visible = False
            oDoc = oWord.Documents.Add("C:\Users\rramirez\Downloads\Rueben Trials\NIAR\ETL\Quote2.dotx") 'open up template

            'SUCCESS!!!
            'fill in info for customer
            oDoc.Bookmarks("Customer").Range.Text = NIARContact.custContInst.txtNewName.Text
            oDoc.Bookmarks("Address").Range.Text = NIARContact.custContInst.txtAddress.Text
            oDoc.Bookmarks("City").Range.Text = NIARContact.custContInst.txtCity.Text
            oDoc.Bookmarks("Phone").Range.Text = "(" & NIARContact.custContInst.txtPhone1.Text & ")" & NIARContact.custContInst.txtPhone2.Text & "-" & NIARContact.custContInst.txtPhone3.Text
            oDoc.Bookmarks("Contact").Range.Text = NIARContact.custContInst.txtContact.Text
            oDoc.Bookmarks("Email").Range.Text = NIARContact.custContInst.txtEmail.Text
            oDoc.Bookmarks("State").Range.Text = NIARContact.custContInst.cmbState.SelectedItem
            oDoc.Bookmarks("Zip").Range.Text = NIARContact.custContInst.txtZipCode.Text
            oDoc.Bookmarks("Fax").Range.Text = NIARContact.custContInst.txtFax1.Text & NIARContact.custContInst.txtFax2.Text & NIARContact.custContInst.txtFax3.Text

            'fill in info for NIAR contact
            oDoc.Bookmarks("Date").Range.Text = Portal.niarContactInst.DateTimePicker1.Value
            oDoc.Bookmarks("NIARcontact").Range.Text = Portal.niarContactInst.txtContact.Text
            oDoc.Bookmarks("NIARphone").Range.Text = "(" & Portal.niarContactInst.txtPhone1.Text & ")" & "-" & Portal.niarContactInst.txtPhone2.Text & "-" & Portal.niarContactInst.txtPhone3.Text
            oDoc.Bookmarks("NIARemail").Range.Text = Portal.niarContactInst.txtEmail.Text

            'fill in test description section
            oDoc.Bookmarks("Description").Range.Text = Me.TextBox1.Text
            oDoc.Bookmarks("Notes").Range.Text = addTestQuoteInst.txtNote.Text
            oDoc.Bookmarks("FinalPrice").Range.Text = addTestQuoteInst.txtFinal.Text

            NIARContact.DateTimePicker1.Value = DateTime.Today.AddDays(90)
            oDoc.Bookmarks("quoteDate").Range.Text = Portal.niarContactInst.DateTimePicker1.Value
            'fill in unit pricing table
            Dim pricing As Word.Table = oDoc.Tables(1) 'reference the table in template
            Dim description As String
            'loop through each column from AddTest form table and add it to our templates table
            'can be made more efficient***
            For row = 0 To 19 Step 1
                description = addTestQuoteInst.tblPrices.GetControlFromPosition(0, row).Text
                If (Len(description) > 0) Then
                    pricing.Cell(row + 2, 1).Range.Text = description
                End If
            Next row
            For row = 0 To 19 Step 1
                    pricing.Cell(row + 2, 2).Range.Text = addTestQuoteInst.tblPrices.GetControlFromPosition(1, row).Text
            Next row
            For row = 0 To 1 Step 1
                pricing.Cell(row + 2, 3).Range.Text = addTestQuoteInst.tblPrices.GetControlFromPosition(2, row).Text
            Next row
            For row = 0 To 19 Step 1
                pricing.Cell(row + 2, 4).Range.Text = addTestQuoteInst.tblPrices.GetControlFromPosition(3, row).Text
            Next row

            'statement will reference database table to determine quote number
            Dim quote As DataRow = Me.CentralDatabaseDataSet.Quotes.NewQuotesRow
            Dim row_count As Integer = 0
            For Each quote In Me.CentralDatabaseDataSet.Quotes.Rows
                row_count = row_count + 1
            Next
            oDoc.Bookmarks("QuoteNumber").Range.Text = Portal.portalInst.txtYear.Text(2) & Portal.portalInst.txtYear.Text(3) & "-" & "2152" & "-" & "Q" & row_count + 1
            'add this quote to quote database table
            Dim new_quote As DataRow = Me.CentralDatabaseDataSet.Quotes.NewQuotesRow
            new_quote("Company") = Portal.portalInst.txtCompany.Text
            Me.CentralDatabaseDataSet.Quotes.AddQuotesRow(new_quote)
            Me.QuotesTableAdapter.Update(Me.CentralDatabaseDataSet.Quotes)
            'All done. Close this form.
            'saving of filename will be different once database is up and running with 
            oDoc.SaveAs("C:\Users\rramirez\Downloads\Rueben Trials\NIAR\ETL\" & quote_file) 'save the file
            MessageBox.Show("Saved: " & quote_file)
            oDoc.Close()
        Else
            MessageBox.Show("Must enter a filename")
        End If
    End Sub

    Private Sub QuoteGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CentralDatabaseDataSet.Quotes' table. You can move, or remove it, as needed.
        Me.QuotesTableAdapter.Fill(Me.CentralDatabaseDataSet.Quotes)
        viewTestQuoteInst.MdiParent = CustomerContact.quoteGenInst
        addTestQuoteInst.MdiParent = CustomerContact.quoteGenInst
    End Sub
End Class