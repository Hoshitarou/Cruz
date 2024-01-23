Imports System.Data.OleDb
Module Connections
    Public cn As New OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public sql As String

    Public Sub connection()
        cn.Close()
        'cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb"
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cuteaq\Downloads\BookPOS-Cruz\bin\Debug\POSdb.accdb"
        cn.Open()


    End Sub
End Module
