Public Class NIARContact

    Inherits System.Windows.Forms.Form
    Public myCallerNIAR As Portal
    Protected Friend Shared custContInst As CustomerContact

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Portal.portalInst.Show()
        Portal.niarContactInst.Hide()
    End Sub

    'used for error catching. ensuring all area fields are filled and filled properly
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim bool As Boolean = True
        Dim phone As Boolean
        Dim warningString = "Please complete the following fields:"
        TextBox7.ForeColor = Color.Black
        txtNEWcontact.ForeColor = Color.Black
        TextBox1.ForeColor = Color.Black
        TextBox10.ForeColor = Color.Black

        If txtTime.TextLength = 0 Then
            bool = False
            TextBox7.ForeColor = Color.Red
            warningString = warningString & vbNewLine & TextBox7.Text
        End If
        If txtContact.TextLength = 0 Then
            bool = False
            txtNEWcontact.ForeColor = Color.Red
            warningString = warningString & vbNewLine & txtNEWcontact.Text
        End If

        ''''phone check
        If IsNumeric(txtPhone1.Text) And txtPhone1.TextLength = 3 Then
            phone = True
        Else
            phone = False
        End If

        If IsNumeric(txtPhone2.Text) And txtPhone2.TextLength = 3 Then
            phone = True
        Else
            phone = False
        End If

        If IsNumeric(txtPhone3.Text) And txtPhone3.TextLength = 4 Then
            phone = True
        Else
            phone = False
        End If
        If phone = True Then
        Else
            bool = False
            TextBox1.ForeColor = Color.Red
            warningString = warningString & vbNewLine & TextBox1.Text
        End If
        ''''end phone check

        If txtEmail.TextLength = 0 Then
            bool = False
            TextBox10.ForeColor = Color.Red
            warningString = warningString & vbNewLine & TextBox10.Text
        End If

        '''''If ... then add info to generatequote.pdf
        If bool = True Then
            If custContInst Is Nothing Then 'Creates the instance of the Main form if one hasn't already been created yet
                custContInst = New CustomerContact
                custContInst.myCallerCust = Me
            End If
            custContInst.Show()             'Show the main create a test form
            Portal.niarContactInst.Hide()     'Hide the current form
        Else
            MessageBox.Show(warningString)
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'used to reset everything the user typed in to default values
        txtContact.Text = ""
        txtEmail.Text = ""
        txtPhone1.Text = ""
        txtPhone2.Text = ""
        txtPhone3.Text = ""
        txtTime.Text = ""
        DateTimePicker1.Value = Date.Now
    End Sub


    Public Sub pdf_update(void)

    End Sub

    Private Sub NIARContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        custContInst.MdiParent = Portal.niarContactInst

    End Sub
End Class