<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cari_Jadwal
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dateDatang = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboStasiun = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_hasil = New System.Windows.Forms.DataGridView()
        Me.KAIDataSet1 = New Kereta_Api.KAIDataSet1()
        Me.STASIUNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STASIUNTableAdapter = New Kereta_Api.KAIDataSet1TableAdapters.STASIUNTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_hasil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAIDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STASIUNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dateDatang)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboStasiun)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(554, 178)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(228, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 27)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dateDatang
        '
        Me.dateDatang.AllowDrop = True
        Me.dateDatang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dateDatang.CustomFormat = ""
        Me.dateDatang.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDatang.Location = New System.Drawing.Point(276, 82)
        Me.dateDatang.Name = "dateDatang"
        Me.dateDatang.Size = New System.Drawing.Size(113, 20)
        Me.dateDatang.TabIndex = 9
        Me.dateDatang.Value = New Date(2015, 1, 11, 16, 35, 3, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tanggal Berangkat"
        '
        'cboStasiun
        '
        Me.cboStasiun.DataSource = Me.STASIUNBindingSource
        Me.cboStasiun.DisplayMember = "ID_STASIUN"
        Me.cboStasiun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStasiun.FormattingEnabled = True
        Me.cboStasiun.Location = New System.Drawing.Point(270, 32)
        Me.cboStasiun.Name = "cboStasiun"
        Me.cboStasiun.Size = New System.Drawing.Size(121, 21)
        Me.cboStasiun.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID Stasiun"
        '
        'dgv_hasil
        '
        Me.dgv_hasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_hasil.Location = New System.Drawing.Point(12, 224)
        Me.dgv_hasil.Name = "dgv_hasil"
        Me.dgv_hasil.Size = New System.Drawing.Size(554, 209)
        Me.dgv_hasil.TabIndex = 1
        '
        'KAIDataSet1
        '
        Me.KAIDataSet1.DataSetName = "KAIDataSet1"
        Me.KAIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STASIUNBindingSource
        '
        Me.STASIUNBindingSource.DataMember = "STASIUN"
        Me.STASIUNBindingSource.DataSource = Me.KAIDataSet1
        '
        'STASIUNTableAdapter
        '
        Me.STASIUNTableAdapter.ClearBeforeFill = True
        '
        'Cari_Jadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 462)
        Me.Controls.Add(Me.dgv_hasil)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimizeBox = False
        Me.Name = "Cari_Jadwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cari Jadwal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_hasil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAIDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STASIUNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboStasiun As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgv_hasil As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dateDatang As System.Windows.Forms.DateTimePicker
    Friend WithEvents KAIDataSet1 As Kereta_Api.KAIDataSet1
    Friend WithEvents STASIUNBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STASIUNTableAdapter As Kereta_Api.KAIDataSet1TableAdapters.STASIUNTableAdapter
End Class
