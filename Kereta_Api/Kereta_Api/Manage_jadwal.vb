Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Manage_jadwal

    Private Sub Manage_jadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Menu_admin
        Call koneksi()
        conn.Open()
        query = "select * from jadwal"
        comm = New SqlCommand(query, conn)

        exec = comm.ExecuteReader()

        dgvHasil.ColumnCount = 4
        dgvHasil.Columns(0).Name = "No. Kereta"
        dgvHasil.Columns(1).Name = "ID Stasiun"
        dgvHasil.Columns(2).Name = "Jam Datang"
        dgvHasil.Columns(3).Name = "Jam Berangkat"

        While exec.Read
            dgvHasil.Rows.Add(exec(0).ToString, exec(1).ToString, exec(2).ToString, exec(3).ToString)
        End While

    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        dgvHasil.Rows.Clear()
        conn.Open()
        query = "select * from Jadwal where no_kereta like '%" & txtCari.Text & "%'"
        comm = New SqlCommand(query, conn)
        exec = comm.ExecuteReader()

         dgvHasil.ColumnCount = 4
        dgvHasil.Columns(0).Name = "No. Kereta"
        dgvHasil.Columns(1).Name = "ID Stasiun"
        dgvHasil.Columns(2).Name = "Jam Datang"
        dgvHasil.Columns(3).Name = "Jam Berangkat"

        While exec.Read
            dgvHasil.Rows.Add(exec(0).ToString, exec(1).ToString, exec(2).ToString, exec(3).ToString)
        End While

        comm.Dispose()
        exec.Close()
        conn.Close()

    End Sub
End Class