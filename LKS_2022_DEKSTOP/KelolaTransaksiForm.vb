Imports System.Data.SqlClient
Public Class KelolaTransaksiForm
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        FormLogin.Show()
    End Sub
End Class