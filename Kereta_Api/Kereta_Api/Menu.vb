Public Class Menu_admin

    Private Sub HapisUserToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles txt_log.Click

    End Sub

    Private Sub Menu_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_log.Text = "Login as : " & Login.username.ToString()
        
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
End Class