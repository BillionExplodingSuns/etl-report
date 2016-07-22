<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Section5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Section5))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSection5 = New System.Windows.Forms.TextBox()
        Me.txtQ2S5 = New System.Windows.Forms.TextBox()
        Me.txtComS5 = New System.Windows.Forms.TextBox()
        Me.txtQ1S5 = New System.Windows.Forms.TextBox()
        Me.cboA1S5 = New System.Windows.Forms.ComboBox()
        Me.btnAddCatS5 = New System.Windows.Forms.Button()
        Me.btnNextSec5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(631, 112)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'txtSection5
        '
        Me.txtSection5.BackColor = System.Drawing.SystemColors.Control
        Me.txtSection5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection5.Location = New System.Drawing.Point(12, 160)
        Me.txtSection5.Multiline = True
        Me.txtSection5.Name = "txtSection5"
        Me.txtSection5.ReadOnly = True
        Me.txtSection5.Size = New System.Drawing.Size(631, 101)
        Me.txtSection5.TabIndex = 12
        Me.txtSection5.Text = "Section 5: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Temperature Variation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtQ2S5
        '
        Me.txtQ2S5.BackColor = System.Drawing.SystemColors.Control
        Me.txtQ2S5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQ2S5.Location = New System.Drawing.Point(12, 363)
        Me.txtQ2S5.Multiline = True
        Me.txtQ2S5.Name = "txtQ2S5"
        Me.txtQ2S5.ReadOnly = True
        Me.txtQ2S5.Size = New System.Drawing.Size(631, 42)
        Me.txtQ2S5.TabIndex = 13
        Me.txtQ2S5.Text = "There are no specific questions for Section 4." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtComS5
        '
        Me.txtComS5.BackColor = System.Drawing.SystemColors.Control
        Me.txtComS5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComS5.Location = New System.Drawing.Point(12, 445)
        Me.txtComS5.Multiline = True
        Me.txtComS5.Name = "txtComS5"
        Me.txtComS5.Size = New System.Drawing.Size(622, 100)
        Me.txtComS5.TabIndex = 14
        Me.txtComS5.Text = "Comments:"
        '
        'txtQ1S5
        '
        Me.txtQ1S5.BackColor = System.Drawing.SystemColors.Control
        Me.txtQ1S5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQ1S5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQ1S5.Location = New System.Drawing.Point(12, 288)
        Me.txtQ1S5.Multiline = True
        Me.txtQ1S5.Name = "txtQ1S5"
        Me.txtQ1S5.ReadOnly = True
        Me.txtQ1S5.Size = New System.Drawing.Size(156, 42)
        Me.txtQ1S5.TabIndex = 46
        Me.txtQ1S5.Text = "Category:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cboA1S5
        '
        Me.cboA1S5.BackColor = System.Drawing.SystemColors.Control
        Me.cboA1S5.FormattingEnabled = True
        Me.cboA1S5.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "B1", "B2", "B3", "B4", "C1", "C2", "C3", "C4", "D1", "D2", "D3", "E1", "E2", "F1", "F2", "F3"})
        Me.cboA1S5.Location = New System.Drawing.Point(174, 289)
        Me.cboA1S5.Name = "cboA1S5"
        Me.cboA1S5.Size = New System.Drawing.Size(240, 21)
        Me.cboA1S5.TabIndex = 47
        '
        'btnAddCatS5
        '
        Me.btnAddCatS5.Location = New System.Drawing.Point(451, 289)
        Me.btnAddCatS5.Name = "btnAddCatS5"
        Me.btnAddCatS5.Size = New System.Drawing.Size(141, 23)
        Me.btnAddCatS5.TabIndex = 48
        Me.btnAddCatS5.Text = "Add Category"
        Me.btnAddCatS5.UseVisualStyleBackColor = True
        '
        'btnNextSec5
        '
        Me.btnNextSec5.Location = New System.Drawing.Point(540, 650)
        Me.btnNextSec5.Name = "btnNextSec5"
        Me.btnNextSec5.Size = New System.Drawing.Size(103, 35)
        Me.btnNextSec5.TabIndex = 49
        Me.btnNextSec5.Text = "Next"
        Me.btnNextSec5.UseVisualStyleBackColor = True
        '
        'Section5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 697)
        Me.Controls.Add(Me.btnNextSec5)
        Me.Controls.Add(Me.btnAddCatS5)
        Me.Controls.Add(Me.cboA1S5)
        Me.Controls.Add(Me.txtQ1S5)
        Me.Controls.Add(Me.txtComS5)
        Me.Controls.Add(Me.txtQ2S5)
        Me.Controls.Add(Me.txtSection5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Section5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSection5 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ2S5 As System.Windows.Forms.TextBox
    Friend WithEvents txtComS5 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ1S5 As System.Windows.Forms.TextBox
    Friend WithEvents cboA1S5 As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddCatS5 As System.Windows.Forms.Button
    Friend WithEvents btnNextSec5 As System.Windows.Forms.Button
End Class
