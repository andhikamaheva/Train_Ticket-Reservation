<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_jurusan
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KAIDataSet1 = New Kereta_Api.KAIDataSet1()
        Me.STASIUNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STASIUNTableAdapter = New Kereta_Api.KAIDataSet1TableAdapters.STASIUNTableAdapter()
        Me.KOTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KOTATableAdapter = New Kereta_Api.KAIDataSet1TableAdapters.KOTATableAdapter()
        Me.STASIUNBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KOTABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtAsal = New System.Windows.Forms.Label()
        Me.txtTujuan = New System.Windows.Forms.Label()
        Me.txtStasiunAsal = New System.Windows.Forms.Label()
        Me.txtStasiunTujuan = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.KAIDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STASIUNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STASIUNBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOTABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtStasiunTujuan)
        Me.GroupBox1.Controls.Add(Me.txtStasiunAsal)
        Me.GroupBox1.Controls.Add(Me.txtTujuan)
        Me.GroupBox1.Controls.Add(Me.txtAsal)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Jurusan"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(319, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(178, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(414, 90)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 7
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(143, 92)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.KOTABindingSource1
        Me.ComboBox2.DisplayMember = "ID_KOTA"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(414, 24)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.KOTABindingSource
        Me.ComboBox1.DisplayMember = "ID_KOTA"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(143, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stasiun Tujuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stasiun Asal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kota Tujuan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kota Asal"
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
        'KOTABindingSource
        '
        Me.KOTABindingSource.DataMember = "KOTA"
        Me.KOTABindingSource.DataSource = Me.KAIDataSet1
        '
        'KOTATableAdapter
        '
        Me.KOTATableAdapter.ClearBeforeFill = True
        '
        'STASIUNBindingSource1
        '
        Me.STASIUNBindingSource1.DataMember = "STASIUN"
        Me.STASIUNBindingSource1.DataSource = Me.KAIDataSet1
        '
        'KOTABindingSource1
        '
        Me.KOTABindingSource1.DataMember = "KOTA"
        Me.KOTABindingSource1.DataSource = Me.KAIDataSet1
        '
        'txtAsal
        '
        Me.txtAsal.AutoSize = True
        Me.txtAsal.Location = New System.Drawing.Point(184, 55)
        Me.txtAsal.Name = "txtAsal"
        Me.txtAsal.Size = New System.Drawing.Size(10, 13)
        Me.txtAsal.TabIndex = 10
        Me.txtAsal.Text = "-"
        '
        'txtTujuan
        '
        Me.txtTujuan.AutoSize = True
        Me.txtTujuan.Location = New System.Drawing.Point(465, 55)
        Me.txtTujuan.Name = "txtTujuan"
        Me.txtTujuan.Size = New System.Drawing.Size(10, 13)
        Me.txtTujuan.TabIndex = 11
        Me.txtTujuan.Text = "-"
        '
        'txtStasiunAsal
        '
        Me.txtStasiunAsal.AutoSize = True
        Me.txtStasiunAsal.Location = New System.Drawing.Point(165, 116)
        Me.txtStasiunAsal.Name = "txtStasiunAsal"
        Me.txtStasiunAsal.Size = New System.Drawing.Size(10, 13)
        Me.txtStasiunAsal.TabIndex = 12
        Me.txtStasiunAsal.Text = "-"
        '
        'txtStasiunTujuan
        '
        Me.txtStasiunTujuan.AutoSize = True
        Me.txtStasiunTujuan.Location = New System.Drawing.Point(448, 116)
        Me.txtStasiunTujuan.Name = "txtStasiunTujuan"
        Me.txtStasiunTujuan.Size = New System.Drawing.Size(10, 13)
        Me.txtStasiunTujuan.TabIndex = 13
        Me.txtStasiunTujuan.Text = "-"
        '
        'Tambah_jurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 244)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Tambah_jurusan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Jurusan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.KAIDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STASIUNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STASIUNBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOTABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents KAIDataSet1 As Kereta_Api.KAIDataSet1
    Friend WithEvents STASIUNBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STASIUNTableAdapter As Kereta_Api.KAIDataSet1TableAdapters.STASIUNTableAdapter
    Friend WithEvents KOTABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KOTATableAdapter As Kereta_Api.KAIDataSet1TableAdapters.KOTATableAdapter
    Friend WithEvents txtTujuan As System.Windows.Forms.Label
    Friend WithEvents txtAsal As System.Windows.Forms.Label
    Friend WithEvents KOTABindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents STASIUNBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtStasiunTujuan As System.Windows.Forms.Label
    Friend WithEvents txtStasiunAsal As System.Windows.Forms.Label
End Class
