<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KelolaLaporanForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KelolaLaporanForm))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnKeloObat = New System.Windows.Forms.Button()
        Me.BtnKeloLaporan = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonGenerete = New System.Windows.Forms.Button()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonKeloUser = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'BtnKeloObat
        '
        Me.BtnKeloObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeloObat.Location = New System.Drawing.Point(7, 304)
        Me.BtnKeloObat.Name = "BtnKeloObat"
        Me.BtnKeloObat.Size = New System.Drawing.Size(126, 41)
        Me.BtnKeloObat.TabIndex = 6
        Me.BtnKeloObat.Text = "Kelola Obat"
        Me.BtnKeloObat.UseVisualStyleBackColor = True
        '
        'BtnKeloLaporan
        '
        Me.BtnKeloLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeloLaporan.Location = New System.Drawing.Point(7, 350)
        Me.BtnKeloLaporan.Name = "BtnKeloLaporan"
        Me.BtnKeloLaporan.Size = New System.Drawing.Size(126, 41)
        Me.BtnKeloLaporan.TabIndex = 7
        Me.BtnKeloLaporan.Text = "Kelola Laporan"
        Me.BtnKeloLaporan.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Location = New System.Drawing.Point(7, 396)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(126, 41)
        Me.BtnLogout.TabIndex = 8
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kelola Laporan"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(85, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Dari Tgl"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Chart1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Dgv1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ButtonGenerete)
        Me.Panel1.Controls.Add(Me.ButtonLoad)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(151, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 450)
        Me.Panel1.TabIndex = 24
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(67, 252)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(349, 186)
        Me.Chart1.TabIndex = 6
        Me.Chart1.Text = "Chart1"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(407, 84)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(122, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(167, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(122, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Dgv1
        '
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Location = New System.Drawing.Point(67, 113)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.Size = New System.Drawing.Size(557, 133)
        Me.Dgv1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(307, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sampai Tgl"
        '
        'ButtonGenerete
        '
        Me.ButtonGenerete.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonGenerete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenerete.Location = New System.Drawing.Point(500, 327)
        Me.ButtonGenerete.Name = "ButtonGenerete"
        Me.ButtonGenerete.Size = New System.Drawing.Size(109, 31)
        Me.ButtonGenerete.TabIndex = 4
        Me.ButtonGenerete.Text = "Generete"
        Me.ButtonGenerete.UseVisualStyleBackColor = False
        '
        'ButtonLoad
        '
        Me.ButtonLoad.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLoad.Location = New System.Drawing.Point(548, 76)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(76, 31)
        Me.ButtonLoad.TabIndex = 3
        Me.ButtonLoad.Text = "Load"
        Me.ButtonLoad.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kelola Penjualan"
        '
        'ButtonKeloUser
        '
        Me.ButtonKeloUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKeloUser.Location = New System.Drawing.Point(12, 257)
        Me.ButtonKeloUser.Name = "ButtonKeloUser"
        Me.ButtonKeloUser.Size = New System.Drawing.Size(126, 41)
        Me.ButtonKeloUser.TabIndex = 5
        Me.ButtonKeloUser.Text = "Kelola User"
        Me.ButtonKeloUser.UseVisualStyleBackColor = True
        '
        'KelolaLaporanForm
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
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "KelolaLaporanForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KelolaLaporanForm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnKeloObat As Button
    Friend WithEvents BtnKeloLaporan As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dgv1 As DataGridView
    Friend WithEvents ButtonKeloUser As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonGenerete As Button
    Friend WithEvents ButtonLoad As Button
    Friend WithEvents Label2 As Label
End Class
