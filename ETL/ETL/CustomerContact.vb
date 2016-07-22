Public Class CustomerContact
    'will be used in hand with database

    Inherits System.Windows.Forms.Form
    Public myCallerCust As NIARContact
    Protected Friend Shared quoteGenInst As QuoteGenerator

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Portal.niarContactInst.Show()
        NIARContact.custContInst.myCallerCust.Hide()
    End Sub

    
    Private Sub CustomerContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton2.Checked = True
        GroupBox4.Enabled = False
        GroupBox4.ForeColor = Color.Gray
        quoteGenInst.MdiParent = NIARContact.custContInst
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'check which box is checked by user
        If (RadioButton2.Checked = False) Then
            GroupBox3.Enabled = False
            GroupBox3.ForeColor = Color.Gray
        End If

        If (RadioButton2.Checked = True) Then
            GroupBox3.Enabled = True
            GroupBox3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'check which box is checked by user
        If (RadioButton1.Checked = False) Then
            GroupBox4.Enabled = False
            GroupBox4.ForeColor = Color.Gray
        End If

        If (RadioButton1.Checked = True) Then
            GroupBox4.Enabled = True
            GroupBox4.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        move_on()
    End Sub

    ''used to reset all the values to default
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cboVendorName.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        txtNewName.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        cmbState.Text = ""
        txtZipCode.Text = ""
        txtPhone1.Text = ""
        txtPhone2.Text = ""
        txtPhone3.Text = ""
        txtFax1.Text = ""
        txtFax2.Text = ""
        txtFax3.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""


    End Sub
    'used to error catch all area fields needed by user
    'incorrect fields will go red until fixed
    Public Function move_on()
        Dim bool As Boolean = True
        Dim phone As Boolean
        Dim fax As Boolean
        Dim warning_String = "Please fix the following fields:"

        txtNamePrompt.ForeColor = Color.Black
        TextBox1.ForeColor = Color.Black
        TextBox5.ForeColor = Color.Black
        TextBox8.ForeColor = Color.Black
        TextBox9.ForeColor = Color.Black
        TextBox11.ForeColor = Color.Black
        TextBox15.ForeColor = Color.Black
        TextBox19.ForeColor = Color.Black
        TextBox21.ForeColor = Color.Black
        TextBox7.ForeColor = Color.Black

        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MessageBox.Show("Please check New Customer or Existing Customer")
        End If

        If RadioButton2.Checked = True Then
            warning_String = "Please fix the following fields:"
            If cboVendorName.SelectedIndex = -1 Then
                TextBox7.ForeColor = Color.Red
                MessageBox.Show("Please select an existing customer.")
            End If

        End If
        If RadioButton1.Checked = True Then
            If txtNewName.TextLength = 0 Then
                bool = False
                txtNamePrompt.ForeColor = Color.Red
                warning_String = warning_String & vbNewLine & txtNamePrompt.Text
            End If
            If txtAddress.TextLength = 0 Then
                bool = False
                TextBox1.ForeColor = Color.Red
                warning_String = warning_String & vbNewLine & TextBox1.Text
            End If
            If txtCity.TextLength = 0 Then
                bool = False
                TextBox5.ForeColor = Color.Red
                warning_String = warning_String & vbNewLine & TextBox5.Text
            End If

            If cmbState.SelectedIndex = -1 Then
                bool = False
                TextBox8.ForeColor = Color.Red
                warning_String = warning_String & vbNewLine & TextBox8.Text
            End If

            If txtZipCode.TextLength = 0 Then
                bool = False
                TextBox9.ForeColor = Color.Red
                warning_String = warning_String & vbNewLine & TextBox9.Text
            End If

            '''''following if statements will be for phone entries
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

            If (phone = True) Then
            Else
                bool = False
                TextBox11.ForeColor = Color.Red
                warning_String = warning_String & vbNewLine & TextBox11.Text
            End If
            '''' End of phone check

            '''' Start of fax check
            If IsNumeric(txtFax1.Text) And txtFax1.TextLength = 3 Then
                fax = True
            Else
                fax = False
            End If
            If IsNumeric(txtFax2.Text) And txtFax2.TextLength = 3 Then
                fax = True
            Else
                fax = False
            End If
            If IsNumeric(txtFax3.Text) And txtFax3.TextLength = 4 Then
                fax = True
            Else
                fax = False
            End If
            If fax = True Then
            Else
                bool = False
                TextBox15.ForeColor = Color.Red
                warning_String = warning_String & vbNewLine & TextBox15.Text
            End If
            '''' End of fax check
            If txtContact.TextLength = 0 Then
                bool = False
                TextBox19.ForeColor = Color.Red
                warning_String = warning_String & vbNewLine & TextBox19.Text
            End If
            If txtEmail.TextLength = 0 Then
                bool = False
                TextBox21.ForeColor = Color.Red
                warning_String = warning_String & vbNewLine & TextBox21.Text
            End If
            ''''End of control checks
            If bool = True Then
                If quoteGenInst Is Nothing Then 'Creates the instance of the Main form if one hasn't already been created yet
                    quoteGenInst = New QuoteGenerator
                    quoteGenInst.myCallerGen = Me
                End If
                quoteGenInst.Show()             'Show the main create a test form
                NIARContact.custContInst.Hide()     'Hide the current form
            Else
                MessageBox.Show(warning_String)
            End If

        End If
        Return 0
    End Function

End Class
