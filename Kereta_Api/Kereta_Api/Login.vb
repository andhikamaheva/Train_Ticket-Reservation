Imports System.Data
Imports System.Data.SqlClient

Public Class Login
    Dim connStr As String = "server=ROOT;database=K_API;integrated security = true; MultipleActiveResultSets=true"
    Dim conn As New SqlConnection(connStr)
    Dim comm As SqlCommand
    Dim exec As SqlDataReader
    Dim query As String
    Public username As String
    Public akses As String
    Public pass As String
    Public aksesx As String



    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles label_timer.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.label_timer.Text = "Timer Server : " & Format(Microsoft.VisualBasic.Now, "hh:mm:ss")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Interval = 1000
        Me.Timer1.Enabled = True
        txt_username.Text = ""
        txt_pass.Text = ""
    End Sub

    Private Sub bt_batal_Click(sender As Object, e As EventArgs) Handles bt_batal.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        conn.Open()
        query = "select * from ADMIN where username = '" & txt_username.Text & "' and pass = '" & txt_pass.Text & "'"
        comm = New SqlCommand(query, conn)



        exec = comm.ExecuteReader()
        While exec.Read
            username = exec(2)
            pass = exec(3)
            akses = exec(4)
        End While
        username = txt_username.Text
        If username <> "" And pass <> "" And akses = "Administrator" Then
            aksesx = "Dashboard Administrator"
            Menu_admin.Show()
            Me.Hide()
        ElseIf username <> "" And pass <> "" And akses = "Kasir" Then
            aksesx = "Dashboard Kasir"
            Menu_admin.Show()
            Menu_admin.AdministratorToolStripMenuItem.Enabled = False
        Else
            MsgBox("Username atau password Anda salah!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Login gagal!")

        End If
        comm.Dispose()
        exec.Close()
        conn.Close()
    End Sub

    Private Sub txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            conn.Open()
            query = "select * from ADMIN where username = '" & txt_username.Text & "' and pass = '" & txt_pass.Text & "'"
            comm = New SqlCommand(query, conn)

            exec = comm.ExecuteReader()
            While exec.Read
                username = exec(2)
                pass = exec(3)
                akses = exec(4)
            End While
            If username <> "" And pass <> "" And akses = "Administrator" Then
                aksesx = "Dashboard Administrator"
                Menu_admin.Show()
                Me.Hide()

            ElseIf username <> "" And pass <> "" And akses = "Kasir" Then
                aksesx = "Dashboard Kasir"
                Menu_admin.Show()
                Me.Hide()


                'Menu_admin.AdministratorToolStripMenuItem.Enabled = False
                Menu_admin.dp_manage.Enabled = False
                Menu_admin.dp_tambah.Enabled = False



            Else
                MsgBox("Username atau password Anda salah!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Login gagal!")

            End If
            comm.Dispose()
            exec.Close()
            conn.Close()
        End If
    End Sub

    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged
        
    End Sub
End Class
