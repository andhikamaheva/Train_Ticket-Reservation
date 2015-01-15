Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Tambah_jurusan

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Tambah_jurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KAIDataSet1.KOTA' table. You can move, or remove it, as needed.
        Me.KOTATableAdapter.Fill(Me.KAIDataSet1.KOTA)
        'TODO: This line of code loads data into the 'KAIDataSet1.STASIUN' table. You can move, or remove it, as needed.
        Me.STASIUNTableAdapter.Fill(Me.KAIDataSet1.STASIUN)
        Call koneksi()
      
    End Sub



    Private Sub FillStasiun(namaKota As String)
        conn.Open()
        ds = New DataSet("Kota")
        query = " select id_stasiun from stasiun where id_kota = @p1"
        adapter = New SqlClient.SqlDataAdapter(query, conn)
        'adapter.Dispose()

        Try
            adapter.SelectCommand.Parameters.AddWithValue("@p1", namaKota)
            adapter.Fill(ds, "Stasiun")
            ComboBox3.DataSource = ds.Tables("Stasiun")
            ComboBox3.ValueMember = "ID_STASIUN"
            ComboBox3.DisplayMember = "nama"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub FillStasiun2(namaKota As String)

        ds = New DataSet("Kota")
        query = " select id_stasiun from stasiun where id_kota = @p1"
        adapter = New SqlClient.SqlDataAdapter(query, conn)

        Try
            adapter.SelectCommand.Parameters.AddWithValue("@p1", namaKota)
            adapter.Fill(ds, "Stasiun")
            ComboBox4.DataSource = ds.Tables("Stasiun")
            ComboBox4.ValueMember = "ID_STASIUN"
            ComboBox4.DisplayMember = "nama"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (Not IsNothing(ComboBox1.Text)) Then

            '' ambil ID benua yang dipilih user
            Dim namaKota = ComboBox1.Text
            '' isi combobox country berdasarkan benua yang dipilih
            conn.Open()
            query = " select nama_kota from kota where id_kota = '" & namaKota & "'"
            comm = New SqlCommand(query, conn)
            txtAsal.Text = comm.ExecuteScalar()
            conn.Close()
            FillStasiun(namaKota)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If (Not IsNothing(ComboBox2.Text)) Then

            '' ambil ID benua yang dipilih user
            Dim namaKota = ComboBox2.Text
            conn.Open()
            query = " select nama_kota from kota where id_kota = '" & namaKota & "'"
            comm = New SqlCommand(query, conn)
            txtTujuan.Text = comm.ExecuteScalar()
            conn.Close()
            FillStasiun2(namaKota)
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim namaStasiun As String = ComboBox4.Text
        conn.Open()
        query = " select nama_stasiun from stasiun where id_stasiun = '" & namaStasiun & "'"
        comm = New SqlCommand(query, conn)
        txtStasiunTujuan.Text = comm.ExecuteScalar()
        conn.Close()
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim namaStasiun As String = ComboBox3.Text
        conn.Open()
        query = " select nama_stasiun from stasiun where id_stasiun = '" & namaStasiun & "'"
        comm = New SqlCommand(query, conn)
        txtStasiunAsal.Text = comm.ExecuteScalar()
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        If ComboBox3.Text = "" Or ComboBox4.Text = "" Or ComboBox2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data Tidak Valid!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Error!")
        Else
            Dim idJurusan As String = (ComboBox3.Text & "-" & ComboBox4.Text)
            query = "insert into jurusan  values('" & idJurusan & "', '" & ComboBox3.Text & "', '" & ComboBox4.Text & "')"
            comm = New SqlCommand(query, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Succes Added!")
        End If
        conn.Close()
    End Sub
End Class