<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KelolaResepForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KelolaResepForm))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TbxQty = New System.Windows.Forms.TextBox()
        Me.TbxNamaP = New System.Windows.Forms.TextBox()
        Me.TbxSearch = New System.Windows.Forms.TextBox()
        Me.TbxNoR = New System.Windows.Forms.TextBox()
        Me.TbxNamaO = New System.Windows.Forms.TextBox()
        Me.TbxNamaD = New System.Windows.Forms.TextBox()
        Me.TbxTglR = New System.Windows.Forms.TextBox()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.LabelIdResep = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.TbxQty)
        Me.Panel1.Controls.Add(Me.TbxNamaP)
        Me.Panel1.Controls.Add(Me.TbxSearch)
        Me.Panel1.Controls.Add(Me.TbxNoR)
        Me.Panel1.Controls.Add(Me.TbxNamaO)
        Me.Panel1.Controls.Add(Me.TbxNamaD)
        Me.Panel1.Controls.Add(Me.TbxTglR)
        Me.Panel1.Controls.Add(Me.Dgv1)
        Me.Panel1.Controls.Add(Me.ButtonDelete)
        Me.Panel1.Controls.Add(Me.ButtonUpdate)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LabelIdResep)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(151, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 450)
        Me.Panel1.TabIndex = 9
        '
        'TbxQty
        '
        Me.TbxQty.Location = New System.Drawing.Point(483, 188)
        Me.TbxQty.Name = "TbxQty"
        Me.TbxQty.Size = New System.Drawing.Size(99, 20)
        Me.TbxQty.TabIndex = 6
        '
        'TbxNamaP
        '
        Me.TbxNamaP.Location = New System.Drawing.Point(196, 186)
        Me.TbxNamaP.Name = "TbxNamaP"
        Me.TbxNamaP.Size = New System.Drawing.Size(146, 20)
        Me.TbxNamaP.TabIndex = 3
        '
        'TbxSearch
        '
        Me.TbxSearch.Location = New System.Drawing.Point(471, 266)
        Me.TbxSearch.Name = "TbxSearch"
        Me.TbxSearch.Size = New System.Drawing.Size(143, 20)
        Me.TbxSearch.TabIndex = 4
        '
        'TbxNoR
        '
        Me.TbxNoR.Location = New System.Drawing.Point(196, 60)
        Me.TbxNoR.Name = "TbxNoR"
        Me.TbxNoR.Size = New System.Drawing.Size(146, 20)
        Me.TbxNoR.TabIndex = 1
        '
        'TbxNamaO
        '
        Me.TbxNamaO.Location = New System.Drawing.Point(483, 125)
        Me.TbxNamaO.Name = "TbxNamaO"
        Me.TbxNamaO.Size = New System.Drawing.Size(99, 20)
        Me.TbxNamaO.TabIndex = 5
        '
        'TbxNamaD
        '
        Me.TbxNamaD.Location = New System.Drawing.Point(483, 65)
        Me.TbxNamaD.Name = "TbxNamaD"
        Me.TbxNamaD.Size = New System.Drawing.Size(99, 20)
        Me.TbxNamaD.TabIndex = 4
        '
        'TbxTglR
        '
        Me.TbxTglR.Location = New System.Drawing.Point(196, 120)
        Me.TbxTglR.Name = "TbxTglR"
        Me.TbxTglR.Size = New System.Drawing.Size(146, 20)
        Me.TbxTglR.TabIndex = 2
        '
        'Dgv1
        '
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Location = New System.Drawing.Point(57, 305)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.Size = New System.Drawing.Size(557, 133)
        Me.Dgv1.TabIndex = 11
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(253, 259)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(89, 32)
        Me.ButtonDelete.TabIndex = 8
        Me.ButtonDelete.Text = "Hapus"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.Location = New System.Drawing.Point(88, 259)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(89, 32)
        Me.ButtonUpdate.TabIndex = 7
        Me.ButtonUpdate.Text = "Edit"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(408, 266)
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
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(85, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nama Pasien"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(368, 122)
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
        Me.Label1.Location = New System.Drawing.Point(85, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tgl Resep"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No Resep"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(267, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kelola Obat"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "APOTEKER"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 23)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "KELOLA"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 282)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "RESEP"
        '
        'BtnLogout
        '
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Location = New System.Drawing.Point(12, 371)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(126, 41)
        Me.BtnLogout.TabIndex = 10
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'LabelIdResep
        '
        Me.LabelIdResep.AutoSize = True
        Me.LabelIdResep.Location = New System.Drawing.Point(162, 322)
        Me.LabelIdResep.Name = "LabelIdResep"
        Me.LabelIdResep.Size = New System.Drawing.Size(45, 13)
        Me.LabelIdResep.TabIndex = 5
        Me.LabelIdResep.Text = "Label12"
        '
        'KelolaResepForm
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
        Me.Name = "KelolaResepForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KelolaResepForm1vb"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TbxNamaP As TextBox
    Friend WithEvents TbxSearch As TextBox
    Friend WithEvents TbxNoR As TextBox
    Friend WithEvents TbxNamaO As TextBox
    Friend WithEvents TbxNamaD As TextBox
    Friend WithEvents TbxTglR As TextBox
    Friend WithEvents Dgv1 As DataGridView
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbxQty As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnLogout As Button
    Friend WithEvents LabelIdResep As Label
End Class
