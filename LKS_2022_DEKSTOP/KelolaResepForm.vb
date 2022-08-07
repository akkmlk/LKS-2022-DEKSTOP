Imports System.Data.SqlClient
Public Class KelolaResepForm
    Sub kondisiAwal()
        TbxNoR.Text = ""
        TbxTglR.Text = ""
        TbxNamaP.Text = ""
        TbxNamaD.Text = ""
        TbxNamaO.Text = ""
        TbxQty.Text = ""
        TbxNoR.Enabled = False
        TbxTglR.Enabled = False
        TbxNamaP.Enabled = False
        TbxNamaD.Enabled = False
        TbxNamaO.Enabled = False
        TbxQty.Enabled = False
        ButtonUpdate.Text = "Edit"
        ButtonDelete.Text = "Hapus"
        ButtonUpdate.Enabled = True
        ButtonDelete.Enabled = True
        Call munculGrid()
    End Sub
    Sub terbuka()
        TbxNoR.Enabled = True
        TbxTglR.Enabled = True
        TbxNamaP.Enabled = True
        TbxNamaD.Enabled = True
        TbxNamaO.Enabled = True
        TbxQty.Enabled = True
    End Sub
    Private Sub KelolaResepForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub
    Sub munculGrid()
        Call koneksi()
        da = New SqlDataAdapter("select Id_Resep, No_Resep, Tgl_Resep, Nama_Dokter, Nama_Pasien, Nama_ObatDibeli, Jumlah_ObatDibeli from Tbl_Resep", conn)
        ds = New DataSet
        da.Fill(ds, "Tbl_Resep")
        Dgv1.DataSource = ds.Tables("Tbl_Resep")
    End Sub
    Private Sub Dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellClick
        Dim i As Integer
        i = Dgv1.CurrentRow.Index
        On Error Resume Next
        LabelIdResep.Text = Dgv1.Item(0, i).Value
        TbxNoR.Text = Dgv1.Item(1, i).Value
        TbxTglR.Text = Dgv1.Item(2, i).Value
        TbxNamaP.Text = Dgv1.Item(4, i).Value
        TbxNamaD.Text = Dgv1.Item(3, i).Value
        TbxNamaO.Text = Dgv1.Item(5, i).Value
        TbxQty.Text = Dgv1.Item(6, i).Value
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If LabelIdResep.Text = "" Or TbxNoR.Text = "" Then
            MsgBox("Pilih data yang ingin di edit!!")
        Else
            If ButtonUpdate.Text = "Edit" Then
                ButtonUpdate.Text = "Save"
                ButtonDelete.Text = "Cancel"
                Call terbuka()
            Else
                If TbxNoR.Text = "" Or TbxNamaP.Text = "" Or TbxNamaD.Text = "" Or TbxNamaO.Text = "" Or TbxQty.Text = "" Or TbxTglR.Text = "" Then
                    MsgBox("Isi Lengkap sema data!!")
                Else
                    Call koneksi()
                    Dim edit As String = "Update Tbl_Resep set No_Resep = '" & TbxNoR.Text & "', Tgl_Resep = '" & TbxTglR.Text & "', Nama_Dokter = '" & TbxNamaD.Text & "', Nama_Pasien = '" & TbxNamaP.Text & "', Nama_ObatDibeli = '" & TbxNamaO.Text & "', Jumlah_ObatDibeli = '" & TbxQty.Text & "' where Id_Resep = '" & LabelIdResep.Text & "'"
                    cmd = New SqlCommand(edit, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Edit data berhasil!!")
                    Call kondisiAwal()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If ButtonDelete.Text = "Cancel" Then
            Call kondisiAwal()
        Else
            If LabelIdResep.Text = "" Or TbxNoR.Text = "" Then
                MsgBox("Pilih data yang ingin di edit!!")
            Else
                If MessageBox.Show("YAKIN DIHAPUS", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Call koneksi()
                    Dim hapus As String = "delete Tbl_Resep where Id_Obat = '" & LabelIdResep.Text & "'"
                    cmd = New SqlCommand(hapus, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Hapus data berhasil!!")
                    Call kondisiAwal()
                End If
            End If
        End If
    End Sub
End Class