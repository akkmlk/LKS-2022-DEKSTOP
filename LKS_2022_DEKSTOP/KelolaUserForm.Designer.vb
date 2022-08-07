<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KelolaUserForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KelolaUserForm))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TbxTelpon = New System.Windows.Forms.TextBox()
        Me.TbxSearch = New System.Windows.Forms.TextBox()
        Me.TbxPassword = New System.Windows.Forms.TextBox()
        Me.TbxUsername = New System.Windows.Forms.TextBox()
        Me.TbxAlamat = New System.Windows.Forms.TextBox()
        Me.TbxNama = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelIdUser = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnKeloLaporan = New System.Windows.Forms.Button()
        Me.BtnKeloObat = New System.Windows.Forms.Button()
        Me.ButtonKeloUser = New System.Windows.Forms.Button()
        Me.CheckBoxMata = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(17, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.CheckBoxMata)
        Me.Panel1.Controls.Add(Me.TbxTelpon)
        Me.Panel1.Controls.Add(Me.TbxSearch)
        Me.Panel1.Controls.Add(Me.TbxPassword)
        Me.Panel1.Controls.Add(Me.TbxUsername)
        Me.Panel1.Controls.Add(Me.TbxAlamat)
        Me.Panel1.Controls.Add(Me.TbxNama)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Dgv1)
        Me.Panel1.Controls.Add(Me.ButtonDelete)
        Me.Panel1.Controls.Add(Me.ButtonUpdate)
        Me.Panel1.Controls.Add(Me.ButtonAdd)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LabelIdUser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(151, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 450)
        Me.Panel1.TabIndex = 12
        '
        'TbxTelpon
        '
        Me.TbxTelpon.Location = New System.Drawing.Point(88, 214)
        Me.TbxTelpon.Name = "TbxTelpon"
        Me.TbxTelpon.Size = New System.Drawing.Size(221, 20)
        Me.TbxTelpon.TabIndex = 3
        '
        'TbxSearch
        '
        Me.TbxSearch.Location = New System.Drawing.Point(471, 266)
        Me.TbxSearch.Name = "TbxSearch"
        Me.TbxSearch.Size = New System.Drawing.Size(143, 20)
        Me.TbxSearch.TabIndex = 10
        '
        'TbxPassword
        '
        Me.TbxPassword.Location = New System.Drawing.Point(371, 214)
        Me.TbxPassword.Name = "TbxPassword"
        Me.TbxPassword.Size = New System.Drawing.Size(221, 20)
        Me.TbxPassword.TabIndex = 6
        '
        'TbxUsername
        '
        Me.TbxUsername.Location = New System.Drawing.Point(371, 148)
        Me.TbxUsername.Name = "TbxUsername"
        Me.TbxUsername.Size = New System.Drawing.Size(221, 20)
        Me.TbxUsername.TabIndex = 5
        '
        'TbxAlamat
        '
        Me.TbxAlamat.Location = New System.Drawing.Point(371, 88)
        Me.TbxAlamat.Name = "TbxAlamat"
        Me.TbxAlamat.Size = New System.Drawing.Size(221, 20)
        Me.TbxAlamat.TabIndex = 4
        '
        'TbxNama
        '
        Me.TbxNama.Location = New System.Drawing.Point(88, 148)
        Me.TbxNama.Name = "TbxNama"
        Me.TbxNama.Size = New System.Drawing.Size(221, 20)
        Me.TbxNama.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(88, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(221, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Dgv1
        '
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Location = New System.Drawing.Point(57, 305)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.Size = New System.Drawing.Size(557, 133)
        Me.Dgv1.TabIndex = 2
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(278, 259)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(89, 32)
        Me.ButtonDelete.TabIndex = 9
        Me.ButtonDelete.Text = "Hapus"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.Location = New System.Drawing.Point(183, 258)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(89, 32)
        Me.ButtonUpdate.TabIndex = 8
        Me.ButtonUpdate.Text = "Edit"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(88, 258)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(89, 32)
        Me.ButtonAdd.TabIndex = 7
        Me.ButtonAdd.Text = "Tambah"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(383, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cari User"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(368, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Password"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(85, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Telpon"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(368, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "User Name"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(368, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Alamat"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipe User"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(267, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kelola User"
        '
        'LabelIdUser
        '
        Me.LabelIdUser.AutoSize = True
        Me.LabelIdUser.Location = New System.Drawing.Point(270, 378)
        Me.LabelIdUser.Name = "LabelIdUser"
        Me.LabelIdUser.Size = New System.Drawing.Size(39, 13)
        Me.LabelIdUser.TabIndex = 5
        Me.LabelIdUser.Text = "Label9"
        '
        'BtnLogout
        '
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Location = New System.Drawing.Point(12, 397)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(126, 41)
        Me.BtnLogout.TabIndex = 14
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnKeloLaporan
        '
        Me.BtnKeloLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeloLaporan.Location = New System.Drawing.Point(12, 351)
        Me.BtnKeloLaporan.Name = "BtnKeloLaporan"
        Me.BtnKeloLaporan.Size = New System.Drawing.Size(126, 41)
        Me.BtnKeloLaporan.TabIndex = 13
        Me.BtnKeloLaporan.Text = "Kelola Laporan"
        Me.BtnKeloLaporan.UseVisualStyleBackColor = True
        '
        'BtnKeloObat
        '
        Me.BtnKeloObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeloObat.Location = New System.Drawing.Point(12, 305)
        Me.BtnKeloObat.Name = "BtnKeloObat"
        Me.BtnKeloObat.Size = New System.Drawing.Size(126, 41)
        Me.BtnKeloObat.TabIndex = 12
        Me.BtnKeloObat.Text = "Kelola Obat"
        Me.BtnKeloObat.UseVisualStyleBackColor = True
        '
        'ButtonKeloUser
        '
        Me.ButtonKeloUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKeloUser.Location = New System.Drawing.Point(12, 258)
        Me.ButtonKeloUser.Name = "ButtonKeloUser"
        Me.ButtonKeloUser.Size = New System.Drawing.Size(126, 41)
        Me.ButtonKeloUser.TabIndex = 11
        Me.ButtonKeloUser.Text = "Kelola User"
        Me.ButtonKeloUser.UseVisualStyleBackColor = True
        '
        'CheckBoxMata
        '
        Me.CheckBoxMata.AutoSize = True
        Me.CheckBoxMata.Location = New System.Drawing.Point(595, 216)
        Me.CheckBoxMata.Name = "CheckBoxMata"
        Me.CheckBoxMata.Size = New System.Drawing.Size(56, 17)
        Me.CheckBoxMata.TabIndex = 15
        Me.CheckBoxMata.Text = "MATA"
        Me.CheckBoxMata.UseVisualStyleBackColor = True
        '
        'KelolaUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnKeloLaporan)
        Me.Controls.Add(Me.BtnKeloObat)
        Me.Controls.Add(Me.ButtonKeloUser)
        Me.Name = "KelolaUserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KelolaUserForm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Dgv1 As DataGridView
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnKeloLaporan As Button
    Friend WithEvents BtnKeloObat As Button
    Friend WithEvents ButtonKeloUser As Button
    Friend WithEvents TbxTelpon As TextBox
    Friend WithEvents TbxPassword As TextBox
    Friend WithEvents TbxUsername As TextBox
    Friend WithEvents TbxAlamat As TextBox
    Friend WithEvents TbxNama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbxSearch As TextBox
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelIdUser As Label
    Friend WithEvents CheckBoxMata As CheckBox
End Class
