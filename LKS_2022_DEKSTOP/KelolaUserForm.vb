Imports System.Data.SqlClient
Public Class KelolaUserForm
    Sub kondisiAwal()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("Apoteker")
        ComboBox1.Items.Add("Kasir")
        ComboBox1.Enabled = False
        TbxNama.Text = ""
        TbxTelpon.Text = ""
        TbxAlamat.Text = ""
        TbxUsername.Text = ""
        TbxPassword.Text = ""
        TbxPassword.PasswordChar = "•"
        TbxNama.Enabled = False
        TbxTelpon.Enabled = False
        TbxAlamat.Enabled = False
        TbxUsername.Enabled = False
        TbxPassword.Enabled = False
        ButtonAdd.Text = "Tambah"
        ButtonUpdate.Text = "Edit"
        ButtonDelete.Text = "Hapus"
        ButtonAdd.Enabled = True
        ButtonUpdate.Enabled = True
        ButtonDelete.Enabled = True
        Call munculGrid()
    End Sub
    Sub terbuka()
        ComboBox1.Enabled = True
        TbxNama.Enabled = True
        TbxTelpon.Enabled = True
        TbxAlamat.Enabled = True
        TbxUsername.Enabled = True
        TbxPassword.Enabled = True
    End Sub
    Sub munculGrid()
        Call koneksi()
        da = New SqlDataAdapter("select * from Tbl_User", conn)
        ds = New DataSet
        da.Fill(ds, "Tbl_User")
        Dgv1.DataSource = ds.Tables("Tbl_User")
    End Sub
    Private Sub KelolaUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If ButtonAdd.Text = "Tambah" Then
            ButtonAdd.Text = "Save"
            ButtonUpdate.Enabled = False
            ButtonDelete.Text = "Cancel"
            Call terbuka()
        Else
            If ComboBox1.Text = "" Or TbxNama.Text = "" Or TbxTelpon.Text = "" Or TbxAlamat.Text = "" Or TbxUsername.Text = "" Or TbxPassword.Text = "" Then
                MsgBox("Isi Lengkap sema data!!")
            Else
                Call koneksi()
                Dim simpan As String = "Insert into Tbl_User values ('" & ComboBox1.Text & "', '" & TbxNama.Text & "', '" & TbxAlamat.Text & "', '" & TbxTelpon.Text & "', '" & TbxUsername.Text & "', '" & TbxPassword.Text & "')"
                cmd = New SqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Tambah data berhasil!!")
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If LabelIdUser.Text = "" Or TbxNama.Text = "" Then
            MsgBox("Pilih data yang ingin di edit!!")
        Else
            If ButtonUpdate.Text = "Edit" Then
                ButtonAdd.Enabled = False
                ButtonUpdate.Text = "Save"
                ButtonDelete.Text = "Cancel"
                Call terbuka()
            Else
                If ComboBox1.Text = "" Or TbxNama.Text = "" Or TbxTelpon.Text = "" Or TbxAlamat.Text = "" Or TbxUsername.Text = "" Or TbxPassword.Text = "" Then
                    MsgBox("Isi Lengkap sema data!!")
                Else
                    Call koneksi()
                    Dim edit As String = "Update Tbl_User set Tipe_User = '" & ComboBox1.Text & "', Nama_User = '" & TbxNama.Text & "', Alamat = '" & TbxAlamat.Text & "', Telpon = '" & TbxTelpon.Text & "', Username = '" & TbxUsername.Text & "', Password = '" & TbxPassword.Text & "' where Id_User = '" & LabelIdUser.Text & "'"
                    cmd = New SqlCommand(edit, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Edit data berhasil!!")
                    Call kondisiAwal()
                End If
            End If
        End If
    End Sub
    Private Sub Dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellClick
        Dim i As Integer
        i = Dgv1.CurrentRow.Index
        On Error Resume Next
        LabelIdUser.Text = Dgv1.Item(0, i).Value
        ComboBox1.Text = Dgv1.Item(1, i).Value
        TbxNama.Text = Dgv1.Item(2, i).Value
        TbxTelpon.Text = Dgv1.Item(4, i).Value
        TbxAlamat.Text = Dgv1.Item(3, i).Value
        TbxUsername.Text = Dgv1.Item(5, i).Value
        TbxPassword.Text = Dgv1.Item(6, i).Value
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If ButtonDelete.Text = "Cancel" Then
            Call kondisiAwal()
        Else
            If LabelIdUser.Text = "" Or TbxNama.Text = "" Then
                MsgBox("Pilih data yang ingin di edit!!")
            Else
                If MessageBox.Show("YAKIN DIHAPUS", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Call koneksi()
                    Dim hapus As String = "delete Tbl_User where Id_User = '" & LabelIdUser.Text & "'"
                    cmd = New SqlCommand(hapus, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Hapus data berhasil!!")
                    Call kondisiAwal()
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TbxSearch.TextChanged
        Call koneksi()
        cmd = New SqlCommand("select * from Tbl_User where Nama_User like '" & TbxSearch.Text & "%'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call koneksi()
            da = New SqlDataAdapter("select * from Tbl_User where Nama_User like '" & TbxSearch.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "ketemuData")
            Dgv1.DataSource = ds.Tables("ketemuData")
        End If
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

    Private Sub CheckBoxMata_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMata.CheckedChanged
        If CheckBoxMata.Checked = True Then
            TbxPassword.PasswordChar = ""
        Else
            TbxPassword.PasswordChar = "•"
        End If
    End Sub
End Class