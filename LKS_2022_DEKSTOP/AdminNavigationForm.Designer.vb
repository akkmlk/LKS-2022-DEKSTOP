<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminNavigationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminNavigationForm))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.ButtonLog = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonKeloUser = New System.Windows.Forms.Button()
        Me.BtnKeloObat = New System.Windows.Forms.Button()
        Me.BtnKeloLaporan = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(23, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Dgv1)
        Me.Panel1.Controls.Add(Me.ButtonLog)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(151, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 450)
        Me.Panel1.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(187, 380)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(221, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Dgv1
        '
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Location = New System.Drawing.Point(61, 45)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.Size = New System.Drawing.Size(557, 309)
        Me.Dgv1.TabIndex = 7
        '
        'ButtonLog
        '
        Me.ButtonLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLog.Location = New System.Drawing.Point(462, 380)
        Me.ButtonLog.Name = "ButtonLog"
        Me.ButtonLog.Size = New System.Drawing.Size(108, 32)
        Me.ButtonLog.TabIndex = 2
        Me.ButtonLog.Text = "Load"
        Me.ButtonLog.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tampilkan Per"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(267, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Log Activity"
        '
        'ButtonKeloUser
        '
        Me.ButtonKeloUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKeloUser.Location = New System.Drawing.Point(12, 258)
        Me.ButtonKeloUser.Name = "ButtonKeloUser"
        Me.ButtonKeloUser.Size = New System.Drawing.Size(126, 41)
        Me.ButtonKeloUser.TabIndex = 3
        Me.ButtonKeloUser.Text = "Kelola User"
        Me.ButtonKeloUser.UseVisualStyleBackColor = True
        '
        'BtnKeloObat
        '
        Me.BtnKeloObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeloObat.Location = New System.Drawing.Point(12, 305)
        Me.BtnKeloObat.Name = "BtnKeloObat"
        Me.BtnKeloObat.Size = New System.Drawing.Size(126, 41)
        Me.BtnKeloObat.TabIndex = 4
        Me.BtnKeloObat.Text = "Kelola Obat"
        Me.BtnKeloObat.UseVisualStyleBackColor = True
        '
        'BtnKeloLaporan
        '
        Me.BtnKeloLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeloLaporan.Location = New System.Drawing.Point(12, 351)
        Me.BtnKeloLaporan.Name = "BtnKeloLaporan"
        Me.BtnKeloLaporan.Size = New System.Drawing.Size(126, 41)
        Me.BtnKeloLaporan.TabIndex = 5
        Me.BtnKeloLaporan.Text = "Kelola Laporan"
        Me.BtnKeloLaporan.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Location = New System.Drawing.Point(12, 397)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(126, 41)
        Me.BtnLogout.TabIndex = 6
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'AdminNavigationForm
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
        Me.Name = "AdminNavigationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminNavigationForm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonLog As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Dgv1 As DataGridView
    Friend WithEvents ButtonKeloUser As Button
    Friend WithEvents BtnKeloObat As Button
    Friend WithEvents BtnKeloLaporan As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
