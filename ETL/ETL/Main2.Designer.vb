﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main2))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.cmbReport = New System.Windows.Forms.ComboBox()
        Me.txtReport = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboVendorName = New System.Windows.Forms.ComboBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.D0_160EBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YearBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D0_160EBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.cmbYear)
        Me.GroupBox2.Controls.Add(Me.txtYear)
        Me.GroupBox2.Controls.Add(Me.cmbReport)
        Me.GroupBox2.Controls.Add(Me.txtReport)
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.cboVendorName)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(569, 231)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(434, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 25)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "ADD REPORT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(434, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 25)
        Me.Button2.TabIndex = 65
        Me.Button2.Text = "ADD ENTRY"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(77, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(422, 22)
        Me.TextBox1.TabIndex = 64
        Me.TextBox1.Text = "VENDOR INFORMATION"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbYear
        '
        Me.cmbYear.DisplayMember = "Year"
        Me.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbYear.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(132, 54)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(295, 25)
        Me.cmbYear.TabIndex = 45
        Me.cmbYear.ValueMember = "Year"
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.SystemColors.Control
        Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtYear.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(8, 53)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 15)
        Me.txtYear.TabIndex = 44
        Me.txtYear.Text = "YEAR:"
        '
        'cmbReport
        '
        Me.cmbReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbReport.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReport.FormattingEnabled = True
        Me.cmbReport.Location = New System.Drawing.Point(132, 140)
        Me.cmbReport.Name = "cmbReport"
        Me.cmbReport.Size = New System.Drawing.Size(296, 25)
        Me.cmbReport.TabIndex = 43
        '
        'txtReport
        '
        Me.txtReport.BackColor = System.Drawing.SystemColors.Control
        Me.txtReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReport.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReport.Location = New System.Drawing.Point(7, 136)
        Me.txtReport.Name = "txtReport"
        Me.txtReport.Size = New System.Drawing.Size(100, 15)
        Me.txtReport.TabIndex = 42
        Me.txtReport.Text = "REPORT:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(233, 183)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 36)
        Me.btnExit.TabIndex = 38
        Me.btnExit.Text = "RETURN"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(7, 95)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(101, 15)
        Me.TextBox7.TabIndex = 36
        Me.TextBox7.Text = "VENDOR:"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(341, 183)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 36)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "RESET"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(131, 183)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 36)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "CONTINUE"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cboVendorName
        '
        Me.cboVendorName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboVendorName.AutoCompleteCustomSource.AddRange(New String() {"First Name:", ""})
        Me.cboVendorName.BackColor = System.Drawing.SystemColors.Window
        Me.cboVendorName.DisplayMember = "Vendor ID"
        Me.cboVendorName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboVendorName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVendorName.FormattingEnabled = True
        Me.cboVendorName.Location = New System.Drawing.Point(131, 95)
        Me.cboVendorName.Name = "cboVendorName"
        Me.cboVendorName.Size = New System.Drawing.Size(296, 25)
        Me.cboVendorName.TabIndex = 0
        Me.cboVendorName.Tag = ""
        Me.cboVendorName.ValueMember = "Vendor ID"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.FolderBrowserDialog1.SelectedPath = "K:\ETL Test Files"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(569, 110)
        Me.PictureBox2.TabIndex = 63
        Me.PictureBox2.TabStop = False

        '
        'D0_160EBindingSource
        '
        Me.D0_160EBindingSource.DataMember = "D0-160E"

        'EquipmentBindingSource
        '
        Me.EquipmentBindingSource.DataMember = "Equipment"
        '
        'YearBindingSource1
        '
        Me.YearBindingSource1.DataMember = "Year"
        '
        'VendorBindingSource
        '
        Me.VendorBindingSource.DataMember = "Vendor"
        '
        'Main2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(593, 366)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Main2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Generator"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D0_160EBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cboVendorName As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtReport As System.Windows.Forms.TextBox
    Friend WithEvents cmbReport As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents D0_160EBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EquipmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YearBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents VendorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button


End Class
