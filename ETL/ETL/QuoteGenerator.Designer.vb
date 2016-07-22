<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuoteGenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuoteGenerator))
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NextMain = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CentralDatabaseDataSet = New ETL.CentralDatabaseDataSet()
        Me.QuotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuotesTableAdapter = New ETL.CentralDatabaseDataSetTableAdapters.QuotesTableAdapter()
        Me.TableAdapterManager = New ETL.CentralDatabaseDataSetTableAdapters.TableAdapterManager()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CentralDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(12, 121)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(428, 26)
        Me.TextBox3.TabIndex = 39
        Me.TextBox3.Text = "TEST DESCRIPTION"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 153)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(428, 82)
        Me.TextBox1.TabIndex = 40
        '
        'NextMain
        '
        Me.NextMain.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextMain.Location = New System.Drawing.Point(12, 248)
        Me.NextMain.Name = "NextMain"
        Me.NextMain.Size = New System.Drawing.Size(87, 46)
        Me.NextMain.TabIndex = 41
        Me.NextMain.Text = "ADD TEST"
        Me.NextMain.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(105, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 46)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "VIEW TEST"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(209, 248)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 46)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "CREATE QUOTE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(335, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 46)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "RETURN"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(428, 103)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'CentralDatabaseDataSet
        '
        Me.CentralDatabaseDataSet.DataSetName = "CentralDatabaseDataSet"
        Me.CentralDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuotesBindingSource
        '
        Me.QuotesBindingSource.DataMember = "Quotes"
        Me.QuotesBindingSource.DataSource = Me.CentralDatabaseDataSet
        '
        'QuotesTableAdapter
        '
        Me.QuotesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.D0160_ETableAdapter = Nothing
        Me.TableAdapterManager.D0160_FTableAdapter = Nothing
        Me.TableAdapterManager.D0160_GTableAdapter = Nothing
        Me.TableAdapterManager.ElectricalTableAdapter = Nothing
        Me.TableAdapterManager.Equipment_10TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_11TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_12TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_13TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_14TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_15TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_16TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_17TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_18TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_19TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_20TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_21TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_22TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_23TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_24TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_25TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_26TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_4TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_5TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_6TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_7TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_8TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_9TableAdapter = Nothing
        Me.TableAdapterManager.Equipment_ExtraTableAdapter = Nothing
        Me.TableAdapterManager.MechanicalTableAdapter = Nothing
        Me.TableAdapterManager.QuotesTableAdapter = Me.QuotesTableAdapter
        Me.TableAdapterManager.Selected_EquipmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ETL.CentralDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QuoteGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 314)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.NextMain)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "QuoteGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuoteGenerator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CentralDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NextMain As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CentralDatabaseDataSet As ETL.CentralDatabaseDataSet
    Friend WithEvents QuotesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QuotesTableAdapter As ETL.CentralDatabaseDataSetTableAdapters.QuotesTableAdapter
    Friend WithEvents TableAdapterManager As ETL.CentralDatabaseDataSetTableAdapters.TableAdapterManager
End Class
