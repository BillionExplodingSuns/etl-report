Public Class Section6
    'NEED TO ALSO FILL IN CHECKED LIST BOX WITH CORRESPONDING TESTS FROM SELECTED CATEGORY
    Private Sub Section6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpRevE.Visible = False
        grpRevF.Visible = False
        grpRevG.Visible = False
        If Main2.mainInst.cmbA3F1.SelectedItem = "E" Then
            grpRevE.Visible = True
        End If
        If Main2.mainInst.cmbA3F1.SelectedItem = "F" Then
            grpRevF.Visible = True
        End If
        If Main2.mainInst.cmbA3F1.SelectedItem = "G" Then
            grpRevG.Visible = True
        End If
    End Sub


    Private Sub btnNextSec6_Click(sender As Object, e As EventArgs) Handles btnNextSec6.Click

        Dim x As Integer = 7
        Dim y As Integer = 7
        Dim forms As Form() = {Section7, Section8, Section9, Section10, Section11, Section12, Section13, Section14, Section15, Section16, Section17, Section18, Section19, Section20, Section21, Section22, Section23, Section24, Section25, Section26}
        Dim Section As Form
        Dim chk As CheckBox
        Dim Checkboxes As CheckBox() = {Main2.mainInst.chkSec7, Main2.mainInst.chkSec8, Main2.mainInst.chkSec9, Main2.mainInst.chkSec10, Main2.mainInst.chkSec11, Main2.mainInst.chkSec12, Main2.mainInst.chkSec13, Main2.mainInst.chkSec13, Main2.mainInst.chkSec14, Main2.mainInst.chkSec15, Main2.mainInst.chkSec16, Main2.mainInst.chkSec17, Main2.mainInst.chkSec18, Main2.mainInst.chkSec19, Main2.mainInst.chkSec20, Main2.mainInst.chkSec21, Main2.mainInst.chkSec22, Main2.mainInst.chkSec23, Main2.mainInst.chkSec24, Main2.mainInst.chkSec25, Main2.mainInst.chkSec26}
        'Me.Close()
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

    Private Sub btnResetSec6_Click(sender As Object, e As EventArgs) Handles btnResetSec6.Click

    End Sub

    Private Sub btnAddCatS6_Click(sender As Object, e As EventArgs) Handles btnAddCatS6.Click

    End Sub

    Private Sub cboA1S6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboA1S6.SelectedIndexChanged
        Dim subsections As CheckBox() = {chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8, chk9}
        Dim temp As CheckBox
        'reset values to true to ensure accuaracy
        For Each temp In subsections
            temp.Enabled = True
        Next
        'since revision will not change category selected i will include all of the checks in one if statement for more efficiency
        If Main2.mainInst.cmbA3F1.SelectedItem = "E" Or Main2.mainInst.cmbA3F1.SelectedItem = "F" Or Main2.mainInst.cmbA3F1.SelectedItem = "G" Then
            'check for the category selection
            If cboA1S6.SelectedItem = "A" Then
                subsections(0).Enabled = False
                subsections(1).Enabled = False
                subsections(3).Enabled = False
                subsections(4).Enabled = False
                subsections(6).Enabled = False
                subsections(7).Enabled = False
            End If
            If cboA1S6.SelectedItem = "B" Then
                subsections(0).Enabled = False
                subsections(2).Enabled = False
                subsections(3).Enabled = False
                subsections(5).Enabled = False
                subsections(6).Enabled = False
                subsections(8).Enabled = False
            End If
            If cboA1S6.SelectedItem = "C" Then
                subsections(1).Enabled = False
                subsections(2).Enabled = False
                subsections(4).Enabled = False
                subsections(5).Enabled = False
                subsections(7).Enabled = False
                subsections(8).Enabled = False
            End If
        End If
    End Sub

    Private Sub txtQ1S6_TextChanged(sender As Object, e As EventArgs) Handles txtQ1S6.TextChanged

    End Sub

    Private Sub txtSection5_TextChanged(sender As Object, e As EventArgs) Handles txtSection5.TextChanged

    End Sub

    Private Sub btnReturnSec6_Click(sender As Object, e As EventArgs) Handles btnReturnSec6.Click

    End Sub
End Class