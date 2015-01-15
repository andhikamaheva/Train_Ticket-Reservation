Imports System.Data
Imports System.Data.SqlClient

Public Class tmbh_user


    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        Me.Hide()
    End Sub

    Private Sub tmbh_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_simpan.Enabled = False
        Me.MdiParent = Menu_admin
        Call koneksi()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        conn.Open()
        Dim cek As String

        query = "select username from admin where username = '" & txt_username.Text & "'"

        comm = New SqlCommand(query, conn)
        cek = comm.ExecuteScalar()
        comm.Dispose()
        If cek = "" Then
            query = "insert into admin values ('"& txt_nama.Text & "','" & txt_username.Text & "','" & txt_password.Text & "','" & cbo_akses.Text & "')"
            comm = New SqlCommand(query, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Succes!")
        Else
            MsgBox("Data yang Anda masukkan tidak valid!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Failed!")
        End If
        comm.Dispose()
        conn.Close()

        txt_username.Text = ""
        txt_password.Text = ""
        txt_nama.Text = ""
    End Sub

    Private Sub cbo_akses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_akses.SelectedIndexChanged
        If txt_nama.Text <> "" And txt_password.Text <> "" And txt_username.Text <> "" And cbo_akses.Text <> "" Then

            btn_simpan.Enabled = True
        End If
    End Sub


    Private Sub txt_nama_TextChanged(sender As Object, e As EventArgs)
        txt_nama.Focus()
    End Sub

End Class