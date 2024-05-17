<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailPaket
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nmWahana = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(205, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 23)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(74, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(205, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(74, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Wahana"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(252, 160)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(322, 31)
        Me.ComboBox1.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SeaShell
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(79, 262)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(495, 235)
        Me.DataGridView1.TabIndex = 24
        '
        'nmWahana
        '
        Me.nmWahana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nmWahana.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.nmWahana.FormattingEnabled = True
        Me.nmWahana.Location = New System.Drawing.Point(252, 109)
        Me.nmWahana.Name = "nmWahana"
        Me.nmWahana.Size = New System.Drawing.Size(322, 31)
        Me.nmWahana.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 92)
        Me.Panel1.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(247, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 29)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Detail Paket"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Goldenrod
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.SeaShell
        Me.btnBack.Location = New System.Drawing.Point(252, 207)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 39)
        Me.btnBack.TabIndex = 55
        Me.btnBack.Text = "Kembali"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Red
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Enabled = False
        Me.btnHapus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.btnHapus.ForeColor = System.Drawing.Color.SeaShell
        Me.btnHapus.Location = New System.Drawing.Point(360, 207)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(104, 39)
        Me.btnHapus.TabIndex = 57
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Green
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.btnSimpan.ForeColor = System.Drawing.Color.SeaShell
        Me.btnSimpan.Location = New System.Drawing.Point(470, 207)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(104, 39)
        Me.btnSimpan.TabIndex = 58
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'DetailPaket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(647, 517)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.nmWahana)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Name = "DetailPaket"
        Me.Text = "DetailPaket"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents nmWahana As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
End Class
