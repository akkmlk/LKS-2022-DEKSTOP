Imports System.Data.SqlClient
Public Class AdminNavigationForm
    Sub munculGrid()
        Call koneksi()
        da = New SqlDataAdapter("select Id_Log, Username, Waktu, Aktifitas from Tbl_Log INNER Join Tbl_User ON Tbl_User.Id_User = Tbl_Log.Id_User", conn)
        ds = New DataSet
        da.Fill(ds, "Tbl_Log")
        Dgv1.DataSource = ds.Tables("Tbl_Log")
    End Sub
    Private Sub ButtonKeloUser_Click(sender As Object, e As EventArgs) Handles ButtonKeloUser.Click
        Me.Hide()
        KelolaUserForm.Show()
    End Sub

    Private Sub BtnKeloObat_Click(sender As Object, e As EventArgs) Handles BtnKeloObat.Click
        Me.Hide()
        KelolaObatForm.Show()
    End Sub

    Private Sub BtnKeloLaporan_Click(sender As Object, e As EventArgs) Handles BtnKeloLaporan.Click
        Me.Hide()
        KelolaLaporanForm.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub AdminNavigationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call munculGrid()
    End Sub
End Class