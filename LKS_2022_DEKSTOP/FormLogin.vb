Imports System.Data.SqlClient
Public Class FormLogin
    Sub kondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.PasswordChar = "•"
    End Sub
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        cmd = New SqlCommand("select * from Tbl_User where Username = '" & TextBox1.Text & "' And Password = '" & TextBox2.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Isi semua field")
        Else
            If Not rd.HasRows Then
                MsgBox("Username atau Password yang anda masukkan tidak valid!")
            Else
                If rd("Tipe_User").ToString = "Admin" Then
                    Me.Hide()
                    AdminNavigationForm.Show()
                Else
                    If rd("Tipe_User").ToString = "Apoteker" Then
                        Me.Hide()
                        KelolaResepForm.Show()
                    Else
                        Me.Hide()
                        KelolaTransaksiForm.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CheckBoxMata_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMata.CheckedChanged
        If CheckBoxMata.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "•"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call kondisiAwal()
    End Sub
End Class
