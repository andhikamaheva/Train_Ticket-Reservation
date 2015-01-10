Imports System.Data
Imports System.Data.SqlClient

Public Class ubah_data
    Public id As String
    Public nama As String
    Public username As String
    Public hak As String

    Dim connStr As String = "server=ROOT;database=K_API;integrated security = true; MultipleActiveResultSets=true"
    Dim conn As New SqlConnection(connStr)
    Dim comm As SqlCommand
    Dim exec As SqlDataReader
    Dim query As String
    Dim adapter As SqlDataAdapter
    Dim dt As DataTable

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub

    Private Sub ubah_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_username.Enabled = False
        lbl_id.Text = id
        txt_nama.Text = nama
        txt_username.Text = username
        cbo_akses.Text = hak
        btn_simpan.Enabled = False
        Me.MdiParent = Menu_admin
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        Me.Hide()
    End Sub

    Private Sub txt_pass1_TextChanged(sender As Object, e As EventArgs) Handles txt_pass1.TextChanged
        If txt_nama.Text <> "" And txt_pass.Text <> "" And txt_username.Text <> "" And txt_pass.Text <> "" And txt_pass1.Text <> "" And cbo_akses.Text <> "" Then
            btn_simpan.Enabled = True
        Else
            btn_simpan.Enabled = False
        End If

        If txt_pass.Text <> txt_pass1.Text Then
            txt_warning.ForeColor = System.Drawing.Color.Red
            txt_warning.Text = "Password Tidak Sama!"
            btn_simpan.Enabled = False
        Else
            btn_simpan.Enabled = True
            txt_warning.ForeColor = System.Drawing.Color.Green
            txt_warning.Text = "Password Sama!"
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        conn.Open()
        query = "update admin set nama = '" & txt_nama.Text & "',hak_akses='" & cbo_akses.Text & "',pass ='" & txt_pass1.Text & "' where id =" & lbl_id.Text
        comm = New SqlCommand(query, conn)
        comm.ExecuteNonQuery()
        MsgBox("Data Berhasil diupdate!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Success!")
        comm.Dispose()
        conn.Close()
    End Sub
End Class