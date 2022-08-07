Imports System.Data.SqlClient
Module Module1
    Public conn As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public rd As SqlDataReader
    Public cmd As SqlCommand
    Public MyDB As String
    Public Sub koneksi()
        MyDB = "Data source=DESKTOP-82LCLSK\SQLEXPRESS;initial catalog=LKS2022_DEKSTOP;integrated security=true"
        conn = New SqlConnection(MyDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
End Module
