<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Section4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Section4))
        Me.txtSection4 = New System.Windows.Forms.TextBox()
        Me.txtQ2S4 = New System.Windows.Forms.TextBox()
        Me.txtComS4 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboA1S4 = New System.Windows.Forms.ComboBox()
        Me.txtQ1S4 = New System.Windows.Forms.TextBox()
        Me.btnAddCatS4 = New System.Windows.Forms.Button()
        Me.btnNextSec4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSection4
        '
        Me.txtSection4.BackColor = System.Drawing.SystemColors.Control
        Me.txtSection4.Enabled = False
        Me.txtSection4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection4.Location = New System.Drawing.Point(12, 151)
        Me.txtSection4.Multiline = True
        Me.txtSection4.Name = "txtSection4"
        Me.txtSection4.ReadOnly = True
        Me.txtSection4.Size = New System.Drawing.Size(631, 101)
        Me.txtSection4.TabIndex = 0
        Me.txtSection4.Text = "Section 4: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Temperature and Altitude"
        '
        'txtQ2S4
        '
        Me.txtQ2S4.BackColor = System.Drawing.SystemColors.Control
        Me.txtQ2S4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQ2S4.Location = New System.Drawing.Point(21, 478)
        Me.txtQ2S4.Multiline = True
        Me.txtQ2S4.Name = "txtQ2S4"
        Me.txtQ2S4.ReadOnly = True
        Me.txtQ2S4.Size = New System.Drawing.Size(622, 38)
        Me.txtQ2S4.TabIndex = 1
        Me.txtQ2S4.Text = "There are no specific questions for Section 4." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtComS4
        '
        Me.txtComS4.BackColor = System.Drawing.SystemColors.Control
        Me.txtComS4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComS4.Location = New System.Drawing.Point(21, 522)
        Me.txtComS4.Multiline = True
        Me.txtComS4.Name = "txtComS4"
        Me.txtComS4.Size = New System.Drawing.Size(622, 100)
        Me.txtComS4.TabIndex = 2
        Me.txtComS4.Text = "Comments:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(631, 112)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'cboA1S4
        '
        Me.cboA1S4.BackColor = System.Drawing.SystemColors.Control
        Me.cboA1S4.FormattingEnabled = True
        Me.cboA1S4.Location = New System.Drawing.Point(256, 269)
        Me.cboA1S4.Name = "cboA1S4"
        Me.cboA1S4.Size = New System.Drawing.Size(240, 21)
        Me.cboA1S4.TabIndex = 46
        '
        'txtQ1S4
        '
        Me.txtQ1S4.BackColor = System.Drawing.SystemColors.Control
        Me.txtQ1S4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQ1S4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQ1S4.Location = New System.Drawing.Point(108, 268)
        Me.txtQ1S4.Multiline = True
        Me.txtQ1S4.Name = "txtQ1S4"
        Me.txtQ1S4.ReadOnly = True
        Me.txtQ1S4.Size = New System.Drawing.Size(156, 42)
        Me.txtQ1S4.TabIndex = 45
        Me.txtQ1S4.Text = "Category:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnAddCatS4
        '
        Me.btnAddCatS4.Location = New System.Drawing.Point(502, 269)
        Me.btnAddCatS4.Name = "btnAddCatS4"
        Me.btnAddCatS4.Size = New System.Drawing.Size(141, 23)
        Me.btnAddCatS4.TabIndex = 47
        Me.btnAddCatS4.Text = "Add Category"
        Me.btnAddCatS4.UseVisualStyleBackColor = True
        '
        'btnNextSec4
        '
        Me.btnNextSec4.Location = New System.Drawing.Point(540, 650)
        Me.btnNextSec4.Name = "btnNextSec4"
        Me.btnNextSec4.Size = New System.Drawing.Size(103, 35)
        Me.btnNextSec4.TabIndex = 48
        Me.btnNextSec4.Text = "Next"
        Me.btnNextSec4.UseVisualStyleBackColor = True
        '
        'Section4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 697)
        Me.Controls.Add(Me.btnNextSec4)
        Me.Controls.Add(Me.btnAddCatS4)
        Me.Controls.Add(Me.cboA1S4)
        Me.Controls.Add(Me.txtQ1S4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtComS4)
        Me.Controls.Add(Me.txtQ2S4)
        Me.Controls.Add(Me.txtSection4)
        Me.Name = "Section4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Section 4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSection4 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ2S4 As System.Windows.Forms.TextBox
    Friend WithEvents txtComS4 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboA1S4 As System.Windows.Forms.ComboBox
    Friend WithEvents txtQ1S4 As System.Windows.Forms.TextBox
    Friend WithEvents btnAddCatS4 As System.Windows.Forms.Button
    Friend WithEvents btnNextSec4 As System.Windows.Forms.Button
End Class
