Imports System.Data
Imports System.Data.SqlClient

Public Class Ubah_pass
    Dim connStr As String = "server=ROOT;database=K_API;integrated security = true; MultipleActiveResultSets=true"
    Dim conn As New SqlConnection(connStr)
    Dim comm As SqlCommand
    Dim exec As SqlDataReader
    Dim query As String
    Public username As String

    

    Private Sub Ubah_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_simpan.Enabled = False
        conn.Open()
        query = "select id, nama, username, hak_akses from admin where username = '" & Login.username & "'"
        comm = New SqlCommand(query, conn)
        exec = comm.ExecuteReader()
        While exec.Read
            lbl_id.Text = exec(0)
            lbl_nama.Text = exec(1)
            lbl_username.Text = exec(2)
            lbl_hakakses.Text = exec(3)
        End While
        comm.Dispose()
        exec.Close()
        conn.Close()
        Me.lbl_warning.ForeColor = System.Drawing.Color.Black
        lbl_warning.Text = "Masukkan Password!"
        Me.MdiParent = Menu_admin
    End Sub

    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged
        
    End Sub

    Private Sub txt_pass2_TextChanged(sender As Object, e As EventArgs) Handles txt_pass2.TextChanged
        If txt_pass.Text <> "" And txt_pass2.Text <> "" Then
            btn_simpan.Enabled = True
        End If
        If txt_pass.Text = txt_pass2.Text Then
            Me.lbl_warning.ForeColor = System.Drawing.Color.Green
            lbl_warning.Text = "Password Benar!"
        Else
            Me.lbl_warning.ForeColor = System.Drawing.Color.Red
            lbl_warning.Text = "Password Tidak Sama!"
            btn_simpan.Enabled = False
        End If
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        Me.Hide()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        conn.Open()
        query = "update admin set pass = '" & txt_pass2.Text & "' where id =" & lbl_id.Text
        comm = New SqlCommand(query, conn)
        comm.ExecuteNonQuery()
        comm.Dispose()
        conn.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl_warning.Click
       
    End Sub
End Class