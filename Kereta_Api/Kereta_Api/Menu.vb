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
        Cari_Jadwal.Show()

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

    End Sub
End Class