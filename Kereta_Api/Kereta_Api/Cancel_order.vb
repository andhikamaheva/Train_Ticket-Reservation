Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Cancel_order

    Private Sub Cancel_order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Menu_admin
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        conn.Open()
        Dim idpemesan
        query = "SELECT ID_PEMESAN FROM BUKTI_PEMESANAN WHERE NO_BOOKING = '" & TextBox1.Text & "'"
        idpemesan = comm.ExecuteReader()
        comm.Dispose()
        If idpemesan = "" Then
            MsgBox("Data Tidak Ditemukan !", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Failed!")
        Else
            query = "DELETE * FROM BUKTI_PEMESANAN WHERE NO_BOOKING = '" & TextBox1.Text & "'"
            comm = New SqlCommand(query, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil di Update !", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Succes")
            comm.Dispose()

        End If
        conn.Close()
    End Sub
End Class