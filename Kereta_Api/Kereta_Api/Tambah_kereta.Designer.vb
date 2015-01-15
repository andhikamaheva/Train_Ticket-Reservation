<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_kereta
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
        Me.cboJurusan = New System.Windows.Forms.ComboBox()
        Me.cboKelas = New System.Windows.Forms.ComboBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtTarif = New System.Windows.Forms.TextBox()
        Me.txtNamaKereta = New System.Windows.Forms.TextBox()
        Me.txtNoKereta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KAIDataSet1 = New Kereta_Api.KAIDataSet1()
        Me.JURUSANBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JURUSANTableAdapter = New Kereta_Api.KAIDataSet1TableAdapters.JURUSANTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.KAIDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JURUSANBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboJurusan)
        Me.GroupBox1.Controls.Add(Me.cboKelas)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.txtTarif)
        Me.GroupBox1.Controls.Add(Me.txtNamaKereta)
        Me.GroupBox1.Controls.Add(Me.txtNoKereta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 282)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Kereta"
        '
        'cboJurusan
        '
        Me.cboJurusan.DataSource = Me.JURUSANBindingSource
        Me.cboJurusan.DisplayMember = "ID_JURUSAN"
        Me.cboJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJurusan.FormattingEnabled = True
        Me.cboJurusan.Location = New System.Drawing.Point(207, 193)
        Me.cboJurusan.Name = "cboJurusan"
        Me.cboJurusan.Size = New System.Drawing.Size(163, 21)
        Me.cboJurusan.TabIndex = 13
        '
        'cboKelas
        '
        Me.cboKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKelas.FormattingEnabled = True
        Me.cboKelas.Items.AddRange(New Object() {"Ekonomi - AC", "Bisnis", "Eksekutif"})
        Me.cboKelas.Location = New System.Drawing.Point(207, 102)
        Me.cboKelas.Name = "cboKelas"
        Me.cboKelas.Size = New System.Drawing.Size(121, 21)
        Me.cboKelas.TabIndex = 12
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(232, 236)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 11
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(71, 236)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtTarif
        '
        Me.txtTarif.Location = New System.Drawing.Point(207, 144)
        Me.txtTarif.Name = "txtTarif"
        Me.txtTarif.Size = New System.Drawing.Size(100, 20)
        Me.txtTarif.TabIndex = 8
        '
        'txtNamaKereta
        '
        Me.txtNamaKereta.Location = New System.Drawing.Point(207, 62)
        Me.txtNamaKereta.Name = "txtNamaKereta"
        Me.txtNamaKereta.Size = New System.Drawing.Size(163, 20)
        Me.txtNamaKereta.TabIndex = 6
        '
        'txtNoKereta
        '
        Me.txtNoKereta.Location = New System.Drawing.Point(207, 20)
        Me.txtNoKereta.Name = "txtNoKereta"
        Me.txtNoKereta.Size = New System.Drawing.Size(100, 20)
        Me.txtNoKereta.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jurusan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tarif Kereta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kelas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Kereta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Kereta"
        '
        'KAIDataSet1
        '
        Me.KAIDataSet1.DataSetName = "KAIDataSet1"
        Me.KAIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JURUSANBindingSource
        '
        Me.JURUSANBindingSource.DataMember = "JURUSAN"
        Me.JURUSANBindingSource.DataSource = Me.KAIDataSet1
        '
        'JURUSANTableAdapter
        '
        Me.JURUSANTableAdapter.ClearBeforeFill = True
        '
        'Tambah_kereta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 352)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Tambah_kereta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Kereta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.KAIDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JURUSANBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboKelas As System.Windows.Forms.ComboBox
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtTarif As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaKereta As System.Windows.Forms.TextBox
    Friend WithEvents txtNoKereta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents KAIDataSet1 As Kereta_Api.KAIDataSet1
    Friend WithEvents JURUSANBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JURUSANTableAdapter As Kereta_Api.KAIDataSet1TableAdapters.JURUSANTableAdapter
End Class
