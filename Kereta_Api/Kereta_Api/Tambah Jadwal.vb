Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Tambah_Jadwal

    Private Sub Tambah_Jadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call FillKereta()
        Call FillKota()
        Me.MdiParent = Menu_admin
        btnSimpan.Enabled = False
    End Sub

    Private Sub FillKereta()
        conn.Open()
        ds = New DataSet("Kereta")
        query = " select no_kereta from kereta"
        adapter = New SqlClient.SqlDataAdapter(query, conn)
        'adapter.Dispose()

        Try
            adapter.Fill(ds, "Kereta")
            cboNoKereta.DataSource = ds.Tables("Kereta")
            cboNoKereta.ValueMember = "NO_KERETA"
            cboNoKereta.DisplayMember = "NO_KERETA"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub FillKota()
        conn.Open()
        ds = New DataSet("KOTA")
        query = " select id_kota from kota"
        adapter = New SqlClient.SqlDataAdapter(query, conn)

        Try
            adapter.Fill(ds, "KOTA")
            cboKota.DataSource = ds.Tables("KOTA")
            cboKota.ValueMember = "ID_KOTA"
            cboKota.DisplayMember = "ID_KOTA"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub FillStasiun(idKota As String)

        ds = New DataSet("Stasiun")
        query = " select nama_stasiun from stasiun where id_kota = @p1"
        adapter = New SqlClient.SqlDataAdapter(query, conn)

        Try
            adapter.SelectCommand.Parameters.AddWithValue("@p1", idKota)
            adapter.Fill(ds, "Stasiun")
            cboStasiun.DataSource = ds.Tables("Stasiun")
            cboStasiun.ValueMember = "NAMA_STASIUN"
            cboStasiun.DisplayMember = "NAMA_STASIUN"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click


        conn.Open()
        query = "insert into jadwal values ('" & cboNoKereta.Text & "', '" & txtIdStasiun.Text & "', '" & (dateDatang.Text & " " & timeDatang.Text) & "', '" & (dateBerangkat.Text & " " & timeBerangkat.Text) & "' )"
        comm = New SqlCommand(query, conn)
        comm.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Succes!")
        conn.Close()
    End Sub

    Private Sub cboKota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKota.SelectedIndexChanged
        If (Not IsNothing(cboKota.Text)) Then
            Dim idKota As String = cboKota.Text
            FillStasiun(idKota)
        End If
    End Sub

    Private Sub cboStasiun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStasiun.SelectedIndexChanged
        If cboKota.Text <> "" And cboNoKereta.Text <> "" And cboStasiun.Text <> "" Then
            btnSimpan.Enabled = True
        End If
        If (Not IsNothing(cboStasiun.SelectedIndex)) Then
            conn.Open()
            query = " select id_stasiun from stasiun where nama_stasiun = '" & cboStasiun.Text & "'"
            comm = New SqlCommand(query, conn)
            txtIdStasiun.Text = comm.ExecuteScalar
            conn.Close()

        End If
    End Sub
End Class