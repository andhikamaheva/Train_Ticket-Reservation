Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module1
    Public connStr As String = "server=ROOT;database=KAI;integrated security = true; MultipleActiveResultSets=true"
    Public conn As SqlConnection
    Public comm As SqlCommand
    Public exec As SqlDataReader
    Public query As String
    Public adapter As SqlDataAdapter
    Public dt As DataTable
    Public ds As DataSet

    Sub koneksi()
        conn = New SqlConnection(connStr)
    End Sub

End Module
