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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_admin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dp_tambah = New System.Windows.Forms.ToolStripMenuItem()
        Me.dp_manage = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterKeretaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKeretaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeretaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerbongToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageKeretaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageJadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatJadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahJurusanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahJadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CariJadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonfirmasiPembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txt_log = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministratorToolStripMenuItem, Me.MasterKeretaToolStripMenuItem, Me.ManageJadwalToolStripMenuItem, Me.ManageOrderToolStripMenuItem, Me.ReportToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1230, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dp_tambah, Me.dp_manage, Me.UbahPasswordToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
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
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MasterKeretaToolStripMenuItem
        '
        Me.MasterKeretaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKeretaToolStripMenuItem, Me.ManageKeretaToolStripMenuItem})
        Me.MasterKeretaToolStripMenuItem.Name = "MasterKeretaToolStripMenuItem"
        Me.MasterKeretaToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.MasterKeretaToolStripMenuItem.Text = "Master Kereta"
        '
        'TambahKeretaToolStripMenuItem
        '
        Me.TambahKeretaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeretaToolStripMenuItem, Me.GerbongToolStripMenuItem})
        Me.TambahKeretaToolStripMenuItem.Name = "TambahKeretaToolStripMenuItem"
        Me.TambahKeretaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.TambahKeretaToolStripMenuItem.Text = "Tambah Data"
        '
        'KeretaToolStripMenuItem
        '
        Me.KeretaToolStripMenuItem.Name = "KeretaToolStripMenuItem"
        Me.KeretaToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.KeretaToolStripMenuItem.Text = "Kereta"
        '
        'GerbongToolStripMenuItem
        '
        Me.GerbongToolStripMenuItem.Name = "GerbongToolStripMenuItem"
        Me.GerbongToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.GerbongToolStripMenuItem.Text = "Gerbong"
        '
        'ManageKeretaToolStripMenuItem
        '
        Me.ManageKeretaToolStripMenuItem.Name = "ManageKeretaToolStripMenuItem"
        Me.ManageKeretaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ManageKeretaToolStripMenuItem.Text = "Lihat Jadwal"
        '
        'ManageJadwalToolStripMenuItem
        '
        Me.ManageJadwalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahJurusanToolStripMenuItem, Me.TambahJadwalToolStripMenuItem, Me.LihatJadwalToolStripMenuItem})
        Me.ManageJadwalToolStripMenuItem.Name = "ManageJadwalToolStripMenuItem"
        Me.ManageJadwalToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ManageJadwalToolStripMenuItem.Text = "Master Jadwal"
        '
        'LihatJadwalToolStripMenuItem
        '
        Me.LihatJadwalToolStripMenuItem.Name = "LihatJadwalToolStripMenuItem"
        Me.LihatJadwalToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.LihatJadwalToolStripMenuItem.Text = "LIhat Jadwal"
        '
        'TambahJurusanToolStripMenuItem
        '
        Me.TambahJurusanToolStripMenuItem.Name = "TambahJurusanToolStripMenuItem"
        Me.TambahJurusanToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.TambahJurusanToolStripMenuItem.Text = "Tambah Jurusan"
        '
        'TambahJadwalToolStripMenuItem
        '
        Me.TambahJadwalToolStripMenuItem.Name = "TambahJadwalToolStripMenuItem"
        Me.TambahJadwalToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.TambahJadwalToolStripMenuItem.Text = "Tambah Jadwal"
        '
        'ManageOrderToolStripMenuItem
        '
        Me.ManageOrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CariJadwalToolStripMenuItem, Me.KonfirmasiPembayaranToolStripMenuItem})
        Me.ManageOrderToolStripMenuItem.Name = "ManageOrderToolStripMenuItem"
        Me.ManageOrderToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ManageOrderToolStripMenuItem.Text = "Transaksi"
        '
        'CariJadwalToolStripMenuItem
        '
        Me.CariJadwalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenOrderToolStripMenuItem, Me.CancelOrderToolStripMenuItem})
        Me.CariJadwalToolStripMenuItem.Name = "CariJadwalToolStripMenuItem"
        Me.CariJadwalToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.CariJadwalToolStripMenuItem.Text = "Booking"
        '
        'OpenOrderToolStripMenuItem
        '
        Me.OpenOrderToolStripMenuItem.Name = "OpenOrderToolStripMenuItem"
        Me.OpenOrderToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.OpenOrderToolStripMenuItem.Text = "Open Order"
        '
        'CancelOrderToolStripMenuItem
        '
        Me.CancelOrderToolStripMenuItem.Name = "CancelOrderToolStripMenuItem"
        Me.CancelOrderToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CancelOrderToolStripMenuItem.Text = "Cancel Order"
        '
        'KonfirmasiPembayaranToolStripMenuItem
        '
        Me.KonfirmasiPembayaranToolStripMenuItem.Name = "KonfirmasiPembayaranToolStripMenuItem"
        Me.KonfirmasiPembayaranToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.KonfirmasiPembayaranToolStripMenuItem.Text = "Konfirmasi Pembayaran"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.VersionToolStripMenuItem.Text = "Version"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txt_log})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 639)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1230, 22)
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
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1230, 661)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard Administrator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterKeretaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahKeretaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageKeretaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KonfirmasiPembayaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeretaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GerbongToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahJurusanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
