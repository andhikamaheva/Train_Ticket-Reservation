Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Tambah_gerbong

    Private Sub Tambah_gerbong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()

        conn.Open()
        ds = New DataSet("Kereta")
        query = " select no_kereta from kereta"
        adapter = New SqlDataAdapter(query, conn)
        Try
            adapter.Fill(ds, "Kereta")
            cboNoKereta.DataSource = ds.Tables("Kereta")
            cboNoKereta.ValueMember = "NO_KERETA"
            cboNoKereta.DisplayMember = "NO_KERETA"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()

   

        Me.MdiParent = Menu_admin


        btnSimpan.Enabled = False


    End Sub

    Private Sub KAIDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim cek As String
        conn.Open()
        query = "select id_gerbong from gerbong where id_gerbong = '" & txtIdGerbong.Text & "'"
        comm = New SqlCommand(query, conn)
        cek = comm.ExecuteScalar()
        comm.Dispose()
        If cek = "" Then
            query = "insert into gerbong values ('" & txtIdGerbong.Text & "', '" & cboNoKereta.Text & "', " & txtJumlahKursi.Text & ")"
            comm = New SqlCommand(query, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Succes!")
        Else
            MsgBox("Data Gagal Disimpan!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Failed!")
        End If
        conn.Close()
    End Sub

    Private Sub txtJumlahKursi_TextChanged(sender As Object, e As EventArgs) Handles txtJumlahKursi.TextChanged
        If txtIdGerbong.Text <> "" And txtJumlahKursi.Text <> "" Then
            btnSimpan.Enabled = True
        End If
    End Sub
End Class