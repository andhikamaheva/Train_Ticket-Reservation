Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class konfirmasi_pembayaran

    Private Sub konfirmasi_pembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Menu_admin
        Call koneksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Field Tidak Boleh Kosong!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Failed!")
        Else
            query = "update bukti_pemesanan set status_pesan = 'Lunas', keterangan = '" & TextBox2.Text & "', no_rek = '" & TextBox3.Text & "' "
            comm = New SqlCommand(query, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil di Update!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Succes!")
        End If
    End Sub
End Class