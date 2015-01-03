<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_admin
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dp_tambah = New System.Windows.Forms.ToolStripMenuItem()
        Me.dp_manage = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageJadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahJadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatJadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CariJadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txt_log = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministratorToolStripMenuItem, Me.ManageJadwalToolStripMenuItem, Me.ManageOrderToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(655, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dp_tambah, Me.dp_manage, Me.UbahPasswordToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem"
        Me.AdministratorToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.AdministratorToolStripMenuItem.Text = "Administrator"
        '
        'dp_tambah
        '
        Me.dp_tambah.Name = "dp_tambah"
        Me.dp_tambah.Size = New System.Drawing.Size(155, 22)
        Me.dp_tambah.Text = "Tambah User"
        '
        'dp_manage
        '
        Me.dp_manage.Name = "dp_manage"
        Me.dp_manage.Size = New System.Drawing.Size(155, 22)
        Me.dp_manage.Text = "Manage User"
        '
        'UbahPasswordToolStripMenuItem
        '
        Me.UbahPasswordToolStripMenuItem.Name = "UbahPasswordToolStripMenuItem"
        Me.UbahPasswordToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.UbahPasswordToolStripMenuItem.Text = "Ubah Password"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ManageJadwalToolStripMenuItem
        '
        Me.ManageJadwalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahJadwalToolStripMenuItem, Me.LihatJadwalToolStripMenuItem})
        Me.ManageJadwalToolStripMenuItem.Name = "ManageJadwalToolStripMenuItem"
        Me.ManageJadwalToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ManageJadwalToolStripMenuItem.Text = "Manage Jadwal"
        '
        'TambahJadwalToolStripMenuItem
        '
        Me.TambahJadwalToolStripMenuItem.Name = "TambahJadwalToolStripMenuItem"
        Me.TambahJadwalToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TambahJadwalToolStripMenuItem.Text = "Tambah Jadwal"
        '
        'LihatJadwalToolStripMenuItem
        '
        Me.LihatJadwalToolStripMenuItem.Name = "LihatJadwalToolStripMenuItem"
        Me.LihatJadwalToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.LihatJadwalToolStripMenuItem.Text = "Lihat Jadwal"
        '
        'ManageOrderToolStripMenuItem
        '
        Me.ManageOrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CariJadwalToolStripMenuItem})
        Me.ManageOrderToolStripMenuItem.Name = "ManageOrderToolStripMenuItem"
        Me.ManageOrderToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ManageOrderToolStripMenuItem.Text = "Manage Order"
        '
        'CariJadwalToolStripMenuItem
        '
        Me.CariJadwalToolStripMenuItem.Name = "CariJadwalToolStripMenuItem"
        Me.CariJadwalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CariJadwalToolStripMenuItem.Text = "Cari Jadwal"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txt_log})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 311)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(655, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txt_log
        '
        Me.txt_log.Name = "txt_log"
        Me.txt_log.Size = New System.Drawing.Size(60, 17)
        Me.txt_log.Text = "Login as : "
        '
        'Menu_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(655, 333)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dp_tambah As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dp_manage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UbahPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageJadwalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahJadwalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatJadwalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CariJadwalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txt_log As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
