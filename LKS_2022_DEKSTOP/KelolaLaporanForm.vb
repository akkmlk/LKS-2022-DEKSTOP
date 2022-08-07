Imports System.Data.SqlClient
Public Class KelolaLaporanForm
    Private Sub ButtonKeloUser_Click(sender As Object, e As EventArgs) Handles ButtonKeloUser.Click
        Me.Hide()
        KelolaUserForm.Show()
    End Sub

    Private Sub BtnKeloObat_Click(sender As Object, e As EventArgs) Handles BtnKeloObat.Click
        Me.Hide()
        KelolaObatForm.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        FormLogin.Show()
    End Sub
End Class