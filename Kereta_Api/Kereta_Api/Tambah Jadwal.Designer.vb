<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_Jadwal
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
        Me.timeBerangkat = New System.Windows.Forms.DateTimePicker()
        Me.timeDatang = New System.Windows.Forms.DateTimePicker()
        Me.dateBerangkat = New System.Windows.Forms.DateTimePicker()
        Me.dateDatang = New System.Windows.Forms.DateTimePicker()
        Me.cboStasiun = New System.Windows.Forms.ComboBox()
        Me.STASIUNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboKota = New System.Windows.Forms.ComboBox()
        Me.cboNoKereta = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.STASIUNTableAdapter = New Kereta_Api.KAIDataSet1TableAdapters.STASIUNTableAdapter()
        Me.txtIdStasiun = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.STASIUNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIdStasiun)
        Me.GroupBox1.Controls.Add(Me.timeBerangkat)
        Me.GroupBox1.Controls.Add(Me.timeDatang)
        Me.GroupBox1.Controls.Add(Me.dateBerangkat)
        Me.GroupBox1.Controls.Add(Me.dateDatang)
        Me.GroupBox1.Controls.Add(Me.cboStasiun)
        Me.GroupBox1.Controls.Add(Me.cboKota)
        Me.GroupBox1.Controls.Add(Me.cboNoKereta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 215)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Jadwal"
        '
        'timeBerangkat
        '
        Me.timeBerangkat.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeBerangkat.Location = New System.Drawing.Point(319, 171)
        Me.timeBerangkat.Name = "timeBerangkat"
        Me.timeBerangkat.ShowUpDown = True
        Me.timeBerangkat.Size = New System.Drawing.Size(80, 20)
        Me.timeBerangkat.TabIndex = 12
        '
        'timeDatang
        '
        Me.timeDatang.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeDatang.Location = New System.Drawing.Point(319, 136)
        Me.timeDatang.Name = "timeDatang"
        Me.timeDatang.ShowUpDown = True
        Me.timeDatang.Size = New System.Drawing.Size(80, 20)
        Me.timeDatang.TabIndex = 11
        '
        'dateBerangkat
        '
        Me.dateBerangkat.CustomFormat = "MM/dd/yyy"
        Me.dateBerangkat.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateBerangkat.Location = New System.Drawing.Point(182, 172)
        Me.dateBerangkat.Name = "dateBerangkat"
        Me.dateBerangkat.Size = New System.Drawing.Size(131, 20)
        Me.dateBerangkat.TabIndex = 10
        '
        'dateDatang
        '
        Me.dateDatang.CustomFormat = "MM/dd/yyy"
        Me.dateDatang.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateDatang.Location = New System.Drawing.Point(182, 135)
        Me.dateDatang.Name = "dateDatang"
        Me.dateDatang.RightToLeftLayout = True
        Me.dateDatang.Size = New System.Drawing.Size(131, 20)
        Me.dateDatang.TabIndex = 9
        '
        'cboStasiun
        '
        Me.cboStasiun.DataSource = Me.STASIUNBindingSource
        Me.cboStasiun.DisplayMember = "ID_STASIUN"
        Me.cboStasiun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStasiun.FormattingEnabled = True
        Me.cboStasiun.Location = New System.Drawing.Point(182, 96)
        Me.cboStasiun.Name = "cboStasiun"
        Me.cboStasiun.Size = New System.Drawing.Size(121, 21)
        Me.cboStasiun.TabIndex = 8
        '
        'cboKota
        '
        Me.cboKota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKota.FormattingEnabled = True
        Me.cboKota.Location = New System.Drawing.Point(182, 59)
        Me.cboKota.Name = "cboKota"
        Me.cboKota.Size = New System.Drawing.Size(121, 21)
        Me.cboKota.TabIndex = 7
        '
        'cboNoKereta
        '
        Me.cboNoKereta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNoKereta.FormattingEnabled = True
        Me.cboNoKereta.Location = New System.Drawing.Point(182, 25)
        Me.cboNoKereta.Name = "cboNoKereta"
        Me.cboNoKereta.Size = New System.Drawing.Size(121, 21)
        Me.cboNoKereta.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Berangkat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Datang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stasiun"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kota"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Kereta"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(150, 247)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(261, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'STASIUNTableAdapter
        '
        Me.STASIUNTableAdapter.ClearBeforeFill = True
        '
        'txtIdStasiun
        '
        Me.txtIdStasiun.AutoSize = True
        Me.txtIdStasiun.Location = New System.Drawing.Point(316, 104)
        Me.txtIdStasiun.Name = "txtIdStasiun"
        Me.txtIdStasiun.Size = New System.Drawing.Size(0, 13)
        Me.txtIdStasiun.TabIndex = 13
        '
        'Tambah_Jadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 287)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Tambah_Jadwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Jadwal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.STASIUNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dateBerangkat As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateDatang As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboStasiun As System.Windows.Forms.ComboBox
    Friend WithEvents cboKota As System.Windows.Forms.ComboBox
    Friend WithEvents cboNoKereta As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents timeBerangkat As System.Windows.Forms.DateTimePicker
    Friend WithEvents timeDatang As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents STASIUNBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STASIUNTableAdapter As Kereta_Api.KAIDataSet1TableAdapters.STASIUNTableAdapter
    Friend WithEvents txtIdStasiun As System.Windows.Forms.Label
End Class
