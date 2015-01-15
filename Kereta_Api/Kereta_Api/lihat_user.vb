Imports System.Data
Imports System.Data.SqlClient

Public Class lihat_user




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        dgv_hasil.Rows.Clear()
        conn.Open()
        query = "select id_admin as ID, nama_admin as Nama, username as Username, hak_akses as [Hak Akses] from admin where username ='" & txt_cari.Text & "' or nama like '" & txt_cari.Text & "%'"
        comm = New SqlCommand(query, conn)
        exec = comm.ExecuteReader()

        dgv_hasil.ColumnCount = 4
        dgv_hasil.Columns(0).Name = "ID"
        dgv_hasil.Columns(1).Name = "Nama"
        dgv_hasil.Columns(2).Name = "Username"
        dgv_hasil.Columns(3).Name = "Hak AKses"
     
        While exec.Read
            dgv_hasil.Rows.Add(exec(0).ToString, exec(1).ToString, exec(2).ToString, exec(3).ToString)
        End While

        Dim btn As New DataGridViewButtonColumn()
        dgv_hasil.Columns.Add(btn)
        btn.HeaderText = "Edit Data"
        btn.Text = "Edit"
        btn.Name = "btn_edit"
        btn.UseColumnTextForButtonValue = True

        Dim btn1 As New DataGridViewButtonColumn()
        dgv_hasil.Columns.Add(btn1)
        btn1.HeaderText = "Hapus Data"
        btn1.Text = "Hapus"
        btn1.Name = "btn_hapus"
        btn1.UseColumnTextForButtonValue = True

        comm.Dispose()
        exec.Close()
        conn.Close()

    End Sub

  

    Private Sub lihat_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Menu_admin
        Call koneksi()

        conn.Open()
        query = "select id_admin, nama_admin, username, hak_akses from admin"
        comm = New SqlCommand(query, conn)
        exec = comm.ExecuteReader()

        dgv_hasil.ColumnCount = 4
        dgv_hasil.Columns(0).Name = "ID"
        dgv_hasil.Columns(1).Name = "Nama"
        dgv_hasil.Columns(2).Name = "Username"
        dgv_hasil.Columns(3).Name = "Hak AKses"


        While exec.Read
            dgv_hasil.Rows.Add(exec(0).ToString, exec(1).ToString, exec(2).ToString, exec(3).ToString)
        End While

        Dim btn As New DataGridViewButtonColumn()
        dgv_hasil.Columns.Add(btn)
        btn.HeaderText = "Edit Data"
        btn.Text = "Edit"
        btn.Name = "btn_edit"
        btn.UseColumnTextForButtonValue = True

        Dim btn1 As New DataGridViewButtonColumn()
        dgv_hasil.Columns.Add(btn1)
        btn1.HeaderText = "Hapus Data"
        btn1.Text = "Hapus"
        btn1.Name = "btn_hapus"
        btn1.UseColumnTextForButtonValue = True

        conn.Close()

    End Sub

    Private Sub txt_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cari.KeyPress
        dgv_hasil.Rows.Clear()
        If Asc(e.KeyChar) = 13 Then
            conn.Open()
            query = "select id_admin, nama_admin, username, hak_akses from admin where username ='" & txt_cari.Text & "' or nama like '" & txt_cari.Text & "%'"
            comm = New SqlCommand(query, conn)
            exec = comm.ExecuteReader()

            dgv_hasil.ColumnCount = 4
            dgv_hasil.Columns(0).Name = "ID"
            dgv_hasil.Columns(1).Name = "Nama"
            dgv_hasil.Columns(2).Name = "Username"
            dgv_hasil.Columns(3).Name = "Hak AKses"


            While exec.Read
                dgv_hasil.Rows.Add(exec(0).ToString, exec(1).ToString, exec(2).ToString, exec(3).ToString)
            End While

            Dim btn As New DataGridViewButtonColumn()
            dgv_hasil.Columns.Add(btn)
            btn.HeaderText = "Edit Data"
            btn.Text = "Edit"
            btn.Name = "btn_edit"
            btn.UseColumnTextForButtonValue = True

            Dim btn1 As New DataGridViewButtonColumn()
            dgv_hasil.Columns.Add(btn1)
            btn1.HeaderText = "Hapus Data"
            btn1.Text = "Hapus"
            btn1.Name = "btn_hapus"
            btn1.UseColumnTextForButtonValue = True
          
            comm.Dispose()
            exec.Close()
            conn.Close()
        End If
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        If txt_cari.Text = "" Then
            btn_cari.Enabled = False
        Else
            btn_cari.Enabled = True
        End If
    End Sub

    Private Sub dgv_hasil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_hasil.CellClick
        conn.Open()
        If e.ColumnIndex = 4 Then
            ubah_data.id = dgv_hasil.Item(0, dgv_hasil.CurrentRow.Index).Value.ToString()
            ubah_data.nama = dgv_hasil.Item(1, dgv_hasil.CurrentRow.Index).Value.ToString()
            ubah_data.username = dgv_hasil.Item(2, dgv_hasil.CurrentRow.Index).Value.ToString()
            ubah_data.hak = dgv_hasil.Item(3, dgv_hasil.CurrentRow.Index).Value.ToString()
            ubah_data.Show()
        Else
            If e.ColumnIndex = 5 Then
                If MsgBox("Yakin akan menghapus ? ", MsgBoxStyle.OkCancel, "Hapus Data") = MsgBoxResult.Ok Then
                    query = "delete admin where id_admin = " & dgv_hasil.Item(0, dgv_hasil.CurrentRow.Index).Value.ToString()
                    comm = New SqlCommand(query, conn)
                    comm.ExecuteNonQuery()
                    MsgBox("Data Berhasil dihapus!", MsgBoxStyle.OkOnly, "Succes")
                    dgv_hasil.Rows.RemoveAt(dgv_hasil.CurrentRow.Index)
                End If
            End If
        End If
        comm.Dispose()
        conn.Close()
    End Sub
    Private Sub dgv_hasil_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_hasil.CellContentClick

    End Sub
End Class