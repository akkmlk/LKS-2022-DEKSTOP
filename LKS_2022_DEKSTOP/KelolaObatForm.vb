Imports System.Data.SqlClient
Public Class KelolaObatForm
    Sub kondisiAwal()
        TbxNama.Text = ""
        TbxKode.Text = ""
        TbxExpired.Text = ""
        TbxQty.Text = ""
        TbxHarga.Text = ""
        TbxNama.Enabled = False
        TbxKode.Enabled = False
        TbxExpired.Enabled = False
        TbxQty.Enabled = False
        TbxHarga.Enabled = False
        ButtonAdd.Text = "Tambah"
        ButtonUpdate.Text = "Edit"
        ButtonDelete.Text = "Hapus"
        ButtonAdd.Enabled = True
        ButtonUpdate.Enabled = True
        ButtonDelete.Enabled = True
        Call munculGrid()
    End Sub
    Sub terbuka()
        TbxNama.Enabled = True
        TbxKode.Enabled = True
        TbxExpired.Enabled = True
        TbxQty.Enabled = True
        TbxHarga.Enabled = True
    End Sub
    Sub munculGrid()
        Call koneksi()
        da = New SqlDataAdapter("select * from Tbl_Obat", conn)
        ds = New DataSet
        da.Fill(ds, "Tbl_Obat")
        Dgv1.DataSource = ds.Tables("Tbl_Obat")
    End Sub
    Private Sub KelolaObatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If ButtonAdd.Text = "Tambah" Then
            ButtonAdd.Text = "Save"
            ButtonUpdate.Enabled = False
            ButtonDelete.Text = "Cancel"
            Call terbuka()
        Else
            If TbxNama.Text = "" Or TbxKode.Text = "" Or TbxExpired.Text = "" Or TbxQty.Text = "" Or TbxHarga.Text = "" Then
                MsgBox("Isi Lengkap sema data!!")
            Else
                Call koneksi()
                Dim simpan As String = "Insert into Tbl_Obat values ('" & TbxKode.Text & "', '" & TbxNama.Text & "', '" & TbxExpired.Text & "', '" & TbxQty.Text & "', '" & TbxHarga.Text & "')"
                cmd = New SqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Tambah data berhasil!!")
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If LabelIdObat.Text = "" Or TbxNama.Text = "" Then
            MsgBox("Pilih data yang ingin di edit!!")
        Else
            If ButtonUpdate.Text = "Edit" Then
                ButtonAdd.Enabled = False
                ButtonUpdate.Text = "Save"
                ButtonDelete.Text = "Cancel"
                Call terbuka()
            Else
                If TbxKode.Text = "" Or TbxNama.Text = "" Or TbxExpired.Text = "" Or TbxQty.Text = "" Or TbxHarga.Text = "" Then
                    MsgBox("Isi Lengkap sema data!!")
                Else
                    Call koneksi()
                    Dim edit As String = "Update Tbl_Obat set Kode_Obat = '" & TbxKode.Text & "', Nama_Obat = '" & TbxNama.Text & "', Expired_Date = '" & TbxExpired.Text & "', Jumlah = '" & TbxQty.Text & "', Harga = '" & TbxHarga.Text & "' where Id_Obat = '" & LabelIdObat.Text & "'"
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
        LabelIdObat.Text = Dgv1.Item(0, i).Value
        TbxKode.Text = Dgv1.Item(1, i).Value
        TbxNama.Text = Dgv1.Item(2, i).Value
        TbxExpired.Text = Dgv1.Item(3, i).Value
        TbxQty.Text = Dgv1.Item(4, i).Value
        TbxHarga.Text = Dgv1.Item(5, i).Value
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If ButtonDelete.Text = "Cancel" Then
            Call kondisiAwal()
        Else
            If LabelIdObat.Text = "" Or TbxNama.Text = "" Then
                MsgBox("Pilih data yang ingin di edit!!")
            Else
                If MessageBox.Show("YAKIN DIHAPUS", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Call koneksi()
                    Dim hapus As String = "delete Tbl_Obat where Id_Obat = '" & LabelIdObat.Text & "'"
                    cmd = New SqlCommand(hapus, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Hapus data berhasil!!")
                    Call kondisiAwal()
                End If
            End If
        End If
    End Sub

    Private Sub TbxSearch_TextChanged(sender As Object, e As EventArgs) Handles TbxSearch.TextChanged
        Call koneksi()
        cmd = New SqlCommand("select * from Tbl_Obat where Nama_Obat like '" & TbxSearch.Text & "%'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call koneksi()
            da = New SqlDataAdapter("select * from Tbl_Obat where Nama_Obat like '" & TbxSearch.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "ketemuData")
            Dgv1.DataSource = ds.Tables("ketemuData")
        End If
    End Sub

    Private Sub ButtonKeloUser_Click(sender As Object, e As EventArgs) Handles ButtonKeloUser.Click
        Me.Hide()
        KelolaUserForm.Show()
    End Sub

    Private Sub BtnKeloLaporan_Click(sender As Object, e As EventArgs) Handles BtnKeloLaporan.Click
        Me.Hide()
        KelolaLaporanForm.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        FormLogin.Show()
    End Sub
End Class