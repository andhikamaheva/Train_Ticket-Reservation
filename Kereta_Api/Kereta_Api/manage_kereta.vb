Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class manage_kereta

    Private Sub manage_kereta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Menu_admin
        Call koneksi()
        conn.Open()
        query = "select * from kereta"
        comm = New SqlCommand(query, conn)

        exec = comm.ExecuteReader()

        dgvHasil.ColumnCount = 5
        dgvHasil.Columns(0).Name = "No. Kereta"
        dgvHasil.Columns(1).Name = "Nama"
        dgvHasil.Columns(2).Name = "Kelas"
        dgvHasil.Columns(3).Name = "Tarif Kereta"
        dgvHasil.Columns(4).Name = "ID Jurusan"

        While exec.Read
            dgvHasil.Rows.Add(exec(0).ToString, exec(1).ToString, exec(2).ToString, exec(3).ToString, exec(4).ToString)
        End While
        conn.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Cari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text = "" Then
            btnCari.Enabled = False
        Else
            btnCari.Enabled = True

        End If
    End Sub

    Private Sub dgvHasil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHasil.CellClick
        conn.Open()
       
    End Sub

  
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        dgvHasil.Rows.Clear()
        conn.Open()
        query = "select * from Kereta where nama_kereta like '%" & txtCari.Text & "%'"
        comm = New SqlCommand(query, conn)
        exec = comm.ExecuteReader()

        dgvHasil.ColumnCount = 5
        dgvHasil.Columns(0).Name = "No. Kereta"
        dgvHasil.Columns(1).Name = "Nama"
        dgvHasil.Columns(2).Name = "Kelas"
        dgvHasil.Columns(3).Name = "Tarif Kereta"
        dgvHasil.Columns(4).Name = "ID Jurusan"

        While exec.Read
            dgvHasil.Rows.Add(exec(0).ToString, exec(1).ToString, exec(2).ToString, exec(3).ToString, exec(4).ToString)
        End While

        comm.Dispose()
        exec.Close()
        conn.Close()

    End Sub
End Class