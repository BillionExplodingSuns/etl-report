<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Section11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Section11))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboA2S11 = New System.Windows.Forms.ComboBox()
        Me.txtA3S11 = New System.Windows.Forms.TextBox()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.btnResetSec11 = New System.Windows.Forms.Button()
        Me.btnReturnSec11 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnNextSec11 = New System.Windows.Forms.Button()
        Me.btnAddCatS11 = New System.Windows.Forms.Button()
        Me.cboA1S11 = New System.Windows.Forms.ComboBox()
        Me.txtQ1S11 = New System.Windows.Forms.TextBox()
        Me.txtComS11 = New System.Windows.Forms.TextBox()
        Me.txtSection9 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtQ3S11 = New System.Windows.Forms.TextBox()
        Me.chkRevE = New System.Windows.Forms.CheckedListBox()
        Me.chkRevF = New System.Windows.Forms.CheckedListBox()
        Me.chkRevG = New System.Windows.Forms.CheckedListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(631, 112)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'cboA2S11
        '
        Me.cboA2S11.FormattingEnabled = True
        Me.cboA2S11.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboA2S11.Location = New System.Drawing.Point(191, 346)
        Me.cboA2S11.Name = "cboA2S11"
        Me.cboA2S11.Size = New System.Drawing.Size(69, 21)
        Me.cboA2S11.TabIndex = 35
        '
        'txtA3S11
        '
        Me.txtA3S11.Enabled = False
        Me.txtA3S11.Location = New System.Drawing.Point(152, 383)
        Me.txtA3S11.Name = "txtA3S11"
        Me.txtA3S11.Size = New System.Drawing.Size(222, 20)
        Me.txtA3S11.TabIndex = 38
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'btnResetSec11
        '
        Me.btnResetSec11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetSec11.Location = New System.Drawing.Point(382, 398)
        Me.btnResetSec11.Name = "btnResetSec11"
        Me.btnResetSec11.Size = New System.Drawing.Size(80, 35)
        Me.btnResetSec11.TabIndex = 86
        Me.btnResetSec11.Text = "RESET"
        Me.btnResetSec11.UseVisualStyleBackColor = True
        '
        'btnReturnSec11
        '
        Me.btnReturnSec11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnSec11.Location = New System.Drawing.Point(468, 398)
        Me.btnReturnSec11.Name = "btnReturnSec11"
        Me.btnReturnSec11.Size = New System.Drawing.Size(80, 35)
        Me.btnReturnSec11.TabIndex = 85
        Me.btnReturnSec11.Text = "RETURN"
        Me.btnReturnSec11.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 410)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(87, 23)
        Me.TextBox1.TabIndex = 84
        Me.TextBox1.Text = "COMMENTS:"
        '
        'btnNextSec11
        '
        Me.btnNextSec11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextSec11.Location = New System.Drawing.Point(554, 398)
        Me.btnNextSec11.Name = "btnNextSec11"
        Me.btnNextSec11.Size = New System.Drawing.Size(80, 35)
        Me.btnNextSec11.TabIndex = 83
        Me.btnNextSec11.Text = "NEXT"
        Me.btnNextSec11.UseVisualStyleBackColor = True
        '
        'btnAddCatS11
        '
        Me.btnAddCatS11.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCatS11.Location = New System.Drawing.Point(217, 222)
        Me.btnAddCatS11.Name = "btnAddCatS11"
        Me.btnAddCatS11.Size = New System.Drawing.Size(141, 23)
        Me.btnAddCatS11.TabIndex = 82
        Me.btnAddCatS11.Text = "ADD CATEGORY"
        Me.btnAddCatS11.UseVisualStyleBackColor = True
        '
        'cboA1S11
        '
        Me.cboA1S11.BackColor = System.Drawing.SystemColors.Control
        Me.cboA1S11.FormattingEnabled = True
        Me.cboA1S11.Location = New System.Drawing.Point(105, 224)
        Me.cboA1S11.Name = "cboA1S11"
        Me.cboA1S11.Size = New System.Drawing.Size(106, 21)
        Me.cboA1S11.TabIndex = 81
        '
        'txtQ1S11
        '
        Me.txtQ1S11.BackColor = System.Drawing.SystemColors.Control
        Me.txtQ1S11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQ1S11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQ1S11.Location = New System.Drawing.Point(12, 222)
        Me.txtQ1S11.Multiline = True
        Me.txtQ1S11.Name = "txtQ1S11"
        Me.txtQ1S11.ReadOnly = True
        Me.txtQ1S11.Size = New System.Drawing.Size(87, 23)
        Me.txtQ1S11.TabIndex = 80
        Me.txtQ1S11.Text = "CATEGORY:"
        '
        'txtComS11
        '
        Me.txtComS11.BackColor = System.Drawing.Color.White
        Me.txtComS11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComS11.Location = New System.Drawing.Point(12, 439)
        Me.txtComS11.Multiline = True
        Me.txtComS11.Name = "txtComS11"
        Me.txtComS11.Size = New System.Drawing.Size(622, 98)
        Me.txtComS11.TabIndex = 79
        '
        'txtSection9
        '
        Me.txtSection9.BackColor = System.Drawing.SystemColors.Control
        Me.txtSection9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSection9.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection9.Location = New System.Drawing.Point(12, 130)
        Me.txtSection9.Multiline = True
        Me.txtSection9.Name = "txtSection9"
        Me.txtSection9.ReadOnly = True
        Me.txtSection9.Size = New System.Drawing.Size(631, 86)
        Me.txtSection9.TabIndex = 78
        Me.txtSection9.Text = "SECTION 11:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fluids Susceptibility"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(17, 335)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(168, 43)
        Me.TextBox2.TabIndex = 87
        Me.TextBox2.Text = "ADDITIONAL FLUIDS NOT LISTED IN D0-160:"
        '
        'txtQ3S11
        '
        Me.txtQ3S11.BackColor = System.Drawing.SystemColors.Control
        Me.txtQ3S11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQ3S11.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQ3S11.Location = New System.Drawing.Point(45, 384)
        Me.txtQ3S11.Multiline = True
        Me.txtQ3S11.Name = "txtQ3S11"
        Me.txtQ3S11.ReadOnly = True
        Me.txtQ3S11.Size = New System.Drawing.Size(101, 19)
        Me.txtQ3S11.TabIndex = 96
        Me.txtQ3S11.Text = "IF YES, LIST THEM:"
        '
        'chkRevE
        '
        Me.chkRevE.BackColor = System.Drawing.SystemColors.Control
        Me.chkRevE.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRevE.FormattingEnabled = True
        Me.chkRevE.Items.AddRange(New Object() {"Immersion", "Spray"})
        Me.chkRevE.Location = New System.Drawing.Point(18, 263)
        Me.chkRevE.MultiColumn = True
        Me.chkRevE.Name = "chkRevE"
        Me.chkRevE.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.chkRevE.Size = New System.Drawing.Size(617, 55)
        Me.chkRevE.TabIndex = 97
        '
        'chkRevF
        '
        Me.chkRevF.BackColor = System.Drawing.SystemColors.Control
        Me.chkRevF.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRevF.FormattingEnabled = True
        Me.chkRevF.Items.AddRange(New Object() {"Immersion", "Spray"})
        Me.chkRevF.Location = New System.Drawing.Point(17, 263)
        Me.chkRevF.MultiColumn = True
        Me.chkRevF.Name = "chkRevF"
        Me.chkRevF.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.chkRevF.Size = New System.Drawing.Size(617, 55)
        Me.chkRevF.TabIndex = 98
        '
        'chkRevG
        '
        Me.chkRevG.BackColor = System.Drawing.SystemColors.Control
        Me.chkRevG.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRevG.FormattingEnabled = True
        Me.chkRevG.Items.AddRange(New Object() {"Immersion", "Spray"})
        Me.chkRevG.Location = New System.Drawing.Point(18, 263)
        Me.chkRevG.MultiColumn = True
        Me.chkRevG.Name = "chkRevG"
        Me.chkRevG.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.chkRevG.Size = New System.Drawing.Size(617, 55)
        Me.chkRevG.TabIndex = 99
        '
        'Section11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 622)
        Me.Controls.Add(Me.chkRevG)
        Me.Controls.Add(Me.chkRevF)
        Me.Controls.Add(Me.chkRevE)
        Me.Controls.Add(Me.txtQ3S11)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnResetSec11)
        Me.Controls.Add(Me.btnReturnSec11)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnNextSec11)
        Me.Controls.Add(Me.btnAddCatS11)
        Me.Controls.Add(Me.cboA1S11)
        Me.Controls.Add(Me.txtQ1S11)
        Me.Controls.Add(Me.txtComS11)
        Me.Controls.Add(Me.txtSection9)
        Me.Controls.Add(Me.txtA3S11)
        Me.Controls.Add(Me.cboA2S11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Section11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quote Generator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboA2S11 As System.Windows.Forms.ComboBox
    Friend WithEvents txtA3S11 As System.Windows.Forms.TextBox
    Friend WithEvents DirectorySearcher1 As System.DirectoryServices.DirectorySearcher
    Friend WithEvents btnResetSec11 As System.Windows.Forms.Button
    Friend WithEvents btnReturnSec11 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnNextSec11 As System.Windows.Forms.Button
    Friend WithEvents btnAddCatS11 As System.Windows.Forms.Button
    Friend WithEvents cboA1S11 As System.Windows.Forms.ComboBox
    Friend WithEvents txtQ1S11 As System.Windows.Forms.TextBox
    Friend WithEvents txtComS11 As System.Windows.Forms.TextBox
    Friend WithEvents txtSection9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ3S11 As System.Windows.Forms.TextBox
    Friend WithEvents chkRevE As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkRevF As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkRevG As System.Windows.Forms.CheckedListBox
End Class
