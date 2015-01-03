<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lihat_user
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.dgv_hasil = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_hasil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(217, 43)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(211, 20)
        Me.txt_cari.TabIndex = 1
        Me.txt_cari.Text = "Username / Nama"
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(444, 43)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(75, 23)
        Me.btn_cari.TabIndex = 2
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'dgv_hasil
        '
        Me.dgv_hasil.AllowUserToAddRows = False
        Me.dgv_hasil.AllowUserToDeleteRows = False
        Me.dgv_hasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_hasil.Location = New System.Drawing.Point(12, 106)
        Me.dgv_hasil.Name = "dgv_hasil"
        Me.dgv_hasil.ReadOnly = True
        Me.dgv_hasil.Size = New System.Drawing.Size(627, 225)
        Me.dgv_hasil.TabIndex = 3
        '
        'lihat_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 369)
        Me.Controls.Add(Me.dgv_hasil)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.Label1)
        Me.Name = "lihat_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lihat User"
        CType(Me.dgv_hasil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cari As System.Windows.Forms.TextBox
    Friend WithEvents btn_cari As System.Windows.Forms.Button
    Friend WithEvents dgv_hasil As System.Windows.Forms.DataGridView
End Class
