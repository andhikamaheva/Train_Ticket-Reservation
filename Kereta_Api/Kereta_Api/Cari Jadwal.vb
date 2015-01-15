Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Cari_Jadwal

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cari_Jadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KAIDataSet1.STASIUN' table. You can move, or remove it, as needed.
        Me.STASIUNTableAdapter.Fill(Me.KAIDataSet1.STASIUN)
        Me.MdiParent = Menu_admin
        Call koneksi()
        conn.Open()
        query = "select * from jadwal"
        comm = New SqlCommand(query, conn)
        exec = comm.ExecuteReader()

        dgv_hasil.ColumnCount = 4
        dgv_hasil.Columns(0).Name = "No. Kereta"
        dgv_hasil.Columns(1).Name = "ID Stasiun"
        dgv_hasil.Columns(2).Name = "Datang"
        dgv_hasil.Columns(3).Name = "Berangkat"


        While exec.Read
            dgv_hasil.Rows.Add(exec(0).ToString, exec(1).ToString, exec(2).ToString, exec(3).ToString)
        End While

        conn.Close()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dateDatang.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        query = "select * from jadwal where id_stasiun = '" & cboStasiun.Text & "' and jam_dtg = '" & dateDatang.Text & "'"
        comm.ExecuteReader()
            dgv_hasil.ColumnCount = 4
            dgv_hasil.Columns(0).Name = "No. Kereta"
            dgv_hasil.Columns(1).Name = "ID Stasiun"
            dgv_hasil.Columns(2).Name = "Datang"
            dgv_hasil.Columns(3).Name = "Berangkat"
            While exec.Read
                dgv_hasil.Rows.Add(exec(0).ToString, exec(1).ToString, exec(2).ToString, exec(3).ToString)
            End While
            conn.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStasiun.SelectedIndexChanged

    End Sub
End Class