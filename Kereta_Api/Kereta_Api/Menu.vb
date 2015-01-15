Public Class Menu_admin

    Private Sub HapisUserToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles txt_log.Click

    End Sub

    Private Sub Menu_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_log.Text = "Login as : " & Login.txt_username.Text
        Me.Text = Login.aksesx
        
    End Sub

    Private Sub AdministratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministratorToolStripMenuItem.Click

    End Sub

    Private Sub LihatUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles dp_manage.Click
        lihat_user.Show()
    End Sub

    Private Sub TambahUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles dp_tambah.Click
        tmbh_user.Show()


    End Sub

    Private Sub UbahPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahPasswordToolStripMenuItem.Click
        Ubah_pass.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
        Login.txt_username.Text = ""
        Login.txt_pass.Text = ""
        Login.txt_username.Focus()
    End Sub

    Private Sub CariJadwalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CariJadwalToolStripMenuItem.Click
    End Sub

    Private Sub ManageJadwalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageJadwalToolStripMenuItem.Click

    End Sub

    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click
        MsgBox("Aplikasi Pemesanan Tiket V 1.0" + Chr(13) + "Develop by Andhika", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Version 1.0")

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dispose()
        Me.Close()

    End Sub

    Private Sub TambahKeretaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKeretaToolStripMenuItem.Click

    End Sub

    Private Sub OpenOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenOrderToolStripMenuItem.Click
        Cari_Jadwal.Show()
        'Data_Pemesan.Show()
    End Sub

    Private Sub CancelOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelOrderToolStripMenuItem.Click
        Cancel_order.Show()
    End Sub

    Private Sub KeretaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeretaToolStripMenuItem.Click
        Tambah_kereta.Show()
    End Sub

    Private Sub GerbongToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerbongToolStripMenuItem.Click
        Tambah_gerbong.Show()
    End Sub

    Private Sub ManageKeretaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageKeretaToolStripMenuItem.Click
        manage_kereta.Show()
    End Sub

    Private Sub LihatJadwalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatJadwalToolStripMenuItem.Click
        Manage_jadwal.Show()
    End Sub

    Private Sub TambahJadwalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahJadwalToolStripMenuItem.Click
        Tambah_Jadwal.Show()
    End Sub

    Private Sub CariJadwalToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Cari_Jadwal.Show()
    End Sub

    Private Sub KonfirmasiPembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KonfirmasiPembayaranToolStripMenuItem.Click
        konfirmasi_pembayaran.Show()

    End Sub

    Private Sub TambahJurusanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahJurusanToolStripMenuItem.Click
        Tambah_jurusan.Show()
    End Sub
End Class