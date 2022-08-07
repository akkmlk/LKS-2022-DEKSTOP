<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KelolaTransaksiForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KelolaTransaksiForm))
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonBayar = New System.Windows.Forms.Button()
        Me.TbxQty = New System.Windows.Forms.TextBox()
        Me.TbxPasien = New System.Windows.Forms.TextBox()
        Me.TbxTgl = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TbxTipe = New System.Windows.Forms.TextBox()
        Me.TbxHarga = New System.Windows.Forms.TextBox()
        Me.TbxObat = New System.Windows.Forms.TextBox()
        Me.TbxDokter = New System.Windows.Forms.TextBox()
        Me.TbxNo = New System.Windows.Forms.TextBox()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.ButtonKosongkan = New System.Windows.Forms.Button()
        Me.ButtonTambahkan = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLogout
        '
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Location = New System.Drawing.Point(9, 371)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(126, 41)
        Me.BtnLogout.TabIndex = 14
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.ButtonSave)
        Me.Panel1.Controls.Add(Me.ButtonPrint)
        Me.Panel1.Controls.Add(Me.ButtonBayar)
        Me.Panel1.Controls.Add(Me.TbxQty)
        Me.Panel1.Controls.Add(Me.TbxPasien)
        Me.Panel1.Controls.Add(Me.TbxTgl)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TbxTipe)
        Me.Panel1.Controls.Add(Me.TbxHarga)
        Me.Panel1.Controls.Add(Me.TbxObat)
        Me.Panel1.Controls.Add(Me.TbxDokter)
        Me.Panel1.Controls.Add(Me.TbxNo)
        Me.Panel1.Controls.Add(Me.Dgv1)
        Me.Panel1.Controls.Add(Me.ButtonKosongkan)
        Me.Panel1.Controls.Add(Me.ButtonTambahkan)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(151, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 450)
        Me.Panel1.TabIndex = 30
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.Location = New System.Drawing.Point(566, 399)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(71, 29)
        Me.ButtonSave.TabIndex = 13
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrint.Location = New System.Drawing.Point(489, 398)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(71, 29)
        Me.ButtonPrint.TabIndex = 12
        Me.ButtonPrint.Text = "Print"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ButtonBayar
        '
        Me.ButtonBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBayar.Location = New System.Drawing.Point(17, 395)
        Me.ButtonBayar.Name = "ButtonBayar"
        Me.ButtonBayar.Size = New System.Drawing.Size(71, 29)
        Me.ButtonBayar.TabIndex = 11
        Me.ButtonBayar.Text = "Bayar"
        Me.ButtonBayar.UseVisualStyleBackColor = True
        '
        'TbxQty
        '
        Me.TbxQty.Location = New System.Drawing.Point(483, 188)
        Me.TbxQty.Name = "TbxQty"
        Me.TbxQty.Size = New System.Drawing.Size(99, 20)
        Me.TbxQty.TabIndex = 8
        '
        'TbxPasien
        '
        Me.TbxPasien.Location = New System.Drawing.Point(196, 185)
        Me.TbxPasien.Name = "TbxPasien"
        Me.TbxPasien.Size = New System.Drawing.Size(146, 20)
        Me.TbxPasien.TabIndex = 4
        '
        'TbxTgl
        '
        Me.TbxTgl.Location = New System.Drawing.Point(196, 143)
        Me.TbxTgl.Name = "TbxTgl"
        Me.TbxTgl.Size = New System.Drawing.Size(146, 20)
        Me.TbxTgl.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 404)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TbxTipe
        '
        Me.TbxTipe.Location = New System.Drawing.Point(196, 60)
        Me.TbxTipe.Name = "TbxTipe"
        Me.TbxTipe.Size = New System.Drawing.Size(146, 20)
        Me.TbxTipe.TabIndex = 1
        '
        'TbxHarga
        '
        Me.TbxHarga.Location = New System.Drawing.Point(483, 147)
        Me.TbxHarga.Name = "TbxHarga"
        Me.TbxHarga.Size = New System.Drawing.Size(99, 20)
        Me.TbxHarga.TabIndex = 7
        '
        'TbxObat
        '
        Me.TbxObat.Location = New System.Drawing.Point(483, 104)
        Me.TbxObat.Name = "TbxObat"
        Me.TbxObat.Size = New System.Drawing.Size(99, 20)
        Me.TbxObat.TabIndex = 6
        '
        'TbxDokter
        '
        Me.TbxDokter.Location = New System.Drawing.Point(483, 65)
        Me.TbxDokter.Name = "TbxDokter"
        Me.TbxDokter.Size = New System.Drawing.Size(99, 20)
        Me.TbxDokter.TabIndex = 5
        '
        'TbxNo
        '
        Me.TbxNo.Location = New System.Drawing.Point(196, 100)
        Me.TbxNo.Name = "TbxNo"
        Me.TbxNo.Size = New System.Drawing.Size(146, 20)
        Me.TbxNo.TabIndex = 2
        '
        'Dgv1
        '
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Location = New System.Drawing.Point(61, 259)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.Size = New System.Drawing.Size(557, 107)
        Me.Dgv1.TabIndex = 15
        '
        'ButtonKosongkan
        '
        Me.ButtonKosongkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKosongkan.Location = New System.Drawing.Point(427, 221)
        Me.ButtonKosongkan.Name = "ButtonKosongkan"
        Me.ButtonKosongkan.Size = New System.Drawing.Size(123, 32)
        Me.ButtonKosongkan.TabIndex = 10
        Me.ButtonKosongkan.Text = "Kosongkan"
        Me.ButtonKosongkan.UseVisualStyleBackColor = True
        '
        'ButtonTambahkan
        '
        Me.ButtonTambahkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambahkan.Location = New System.Drawing.Point(139, 221)
        Me.ButtonTambahkan.Name = "ButtonTambahkan"
        Me.ButtonTambahkan.Size = New System.Drawing.Size(158, 32)
        Me.ButtonTambahkan.TabIndex = 9
        Me.ButtonTambahkan.Text = "Tambahkan"
        Me.ButtonTambahkan.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(250, 421)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 23)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Kembali"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Chartreuse
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(315, 421)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 23)
        Me.Label14.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Chartreuse
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(109, 378)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cari"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(368, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Quantity"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(85, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 23)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Nama Pasien"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(85, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tgl Resep"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(368, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Harga Obat"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(368, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nama Obat"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(368, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nama Dokter"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Resep"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipe Resep"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Form Transaksi"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 282)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 23)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "TRANSAKSI"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 23)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "KELOLA"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 23)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "KASIR"
        '
        'KelolaTransaksiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Name = "KelolaTransaksiForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KelolaTransaksiForm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLogout As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TbxQty As TextBox
    Friend WithEvents TbxTgl As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TbxTipe As TextBox
    Friend WithEvents TbxObat As TextBox
    Friend WithEvents TbxDokter As TextBox
    Friend WithEvents TbxNo As TextBox
    Friend WithEvents Dgv1 As DataGridView
    Friend WithEvents ButtonKosongkan As Button
    Friend WithEvents ButtonTambahkan As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TbxPasien As TextBox
    Friend WithEvents TbxHarga As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents ButtonBayar As Button
End Class
