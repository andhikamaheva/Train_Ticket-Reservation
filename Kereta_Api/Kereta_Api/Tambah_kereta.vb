Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Tambah_kereta

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Tambah_kereta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Call koneksi()

        conn.Open()
        ds = New DataSet("Kota")
        query = " select id_jurusan from jurusan"
        adapter = New SqlClient.SqlDataAdapter(query, conn)
        'adapter.Dispose()

        Try
            adapter.Fill(ds, "Jurusan")
            cboJurusan.DataSource = ds.Tables("Jurusan")
            cboJurusan.ValueMember = "ID_JURUSAN"
            cboJurusan.DisplayMember = "Jurusan"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        conn.Close()
        btnSimpan.Enabled = False
        Me.MdiParent = Menu_admin



    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJurusan.SelectedIndexChanged
        If txtNamaKereta.Text <> "" And txtNoKereta.Text <> "" And txtTarif.Text <> "" Then
            btnSimpan.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        
            Dim cek As String
            conn.Open()
            query = "select * from kereta where no_kereta = '" & txtNoKereta.Text & "'"
            comm = New SqlCommand(query, conn)
            cek = comm.ExecuteScalar()
            comm.Dispose()
            If cek = "" Then
                query = "insert into kereta values ('" & txtNoKereta.Text & "','" & txtNamaKereta.Text & "','" & cboKelas.Text & "'," & txtTarif.Text & ", '" & cboJurusan.Text & "')"
                comm = New SqlCommand(query, conn)
                comm.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Succes!")
            Else
                MsgBox("Data Gagal Disimpan!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Failed!")
            End If
            comm.Dispose()
            conn.Close()

            txtNamaKereta.Text = ""
            txtNoKereta.Text = ""
            txtTarif.Text = ""

        
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class