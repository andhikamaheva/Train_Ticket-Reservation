<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ubah_data
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_pass1 = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.cbo_akses = New System.Windows.Forms.ComboBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.txt_warning = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_warning)
        Me.GroupBox1.Controls.Add(Me.txt_pass1)
        Me.GroupBox1.Controls.Add(Me.txt_pass)
        Me.GroupBox1.Controls.Add(Me.cbo_akses)
        Me.GroupBox1.Controls.Add(Me.txt_username)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_id)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt_pass1
        '
        Me.txt_pass1.Location = New System.Drawing.Point(246, 189)
        Me.txt_pass1.Name = "txt_pass1"
        Me.txt_pass1.Size = New System.Drawing.Size(100, 20)
        Me.txt_pass1.TabIndex = 23
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(246, 154)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(100, 20)
        Me.txt_pass.TabIndex = 22
        '
        'cbo_akses
        '
        Me.cbo_akses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_akses.FormattingEnabled = True
        Me.cbo_akses.Items.AddRange(New Object() {"Administrator", "Kasir"})
        Me.cbo_akses.Location = New System.Drawing.Point(246, 120)
        Me.cbo_akses.Name = "cbo_akses"
        Me.cbo_akses.Size = New System.Drawing.Size(121, 21)
        Me.cbo_akses.TabIndex = 21
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(246, 83)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(100, 20)
        Me.txt_username.TabIndex = 20
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(246, 49)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(151, 20)
        Me.txt_nama.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(82, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Konfirm password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Hak Akses"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nama"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(243, 16)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(39, 13)
        Me.lbl_id.TabIndex = 13
        Me.lbl_id.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID"
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(134, 296)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 1
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(320, 296)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 23)
        Me.btn_batal.TabIndex = 2
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'txt_warning
        '
        Me.txt_warning.AutoSize = True
        Me.txt_warning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_warning.Location = New System.Drawing.Point(186, 224)
        Me.txt_warning.Name = "txt_warning"
        Me.txt_warning.Size = New System.Drawing.Size(123, 13)
        Me.txt_warning.TabIndex = 24
        Me.txt_warning.Text = "Masukkan Password"
        '
        'ubah_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 346)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ubah_data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pass1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents cbo_akses As System.Windows.Forms.ComboBox
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents btn_batal As System.Windows.Forms.Button
    Friend WithEvents txt_warning As System.Windows.Forms.Label
End Class
