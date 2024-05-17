<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPaket
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.tbCari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.deskripsi = New System.Windows.Forms.RichTextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.durasi = New System.Windows.Forms.TextBox()
        Me.nmWahana = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Goldenrod
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.SeaShell
        Me.btnBack.Location = New System.Drawing.Point(49, 476)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 39)
        Me.btnBack.TabIndex = 54
        Me.btnBack.Text = "Kembali"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label16.Location = New System.Drawing.Point(544, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 23)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Search"
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Gray
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.btnBatal.ForeColor = System.Drawing.Color.SeaShell
        Me.btnBatal.Location = New System.Drawing.Point(562, 476)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(104, 39)
        Me.btnBatal.TabIndex = 52
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
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
        Me.btnHapus.Location = New System.Drawing.Point(672, 476)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(104, 39)
        Me.btnHapus.TabIndex = 51
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUbah.Enabled = False
        Me.btnUbah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.btnUbah.ForeColor = System.Drawing.Color.SeaShell
        Me.btnUbah.Location = New System.Drawing.Point(782, 476)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(104, 39)
        Me.btnUbah.TabIndex = 50
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'tbCari
        '
        Me.tbCari.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.tbCari.Location = New System.Drawing.Point(630, 114)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.Size = New System.Drawing.Size(366, 31)
        Me.tbCari.TabIndex = 49
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SeaShell
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.MidnightBlue
        Me.DataGridView1.Location = New System.Drawing.Point(548, 162)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(448, 295)
        Me.DataGridView1.TabIndex = 48
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Green
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.btnSimpan.ForeColor = System.Drawing.Color.SeaShell
        Me.btnSimpan.Location = New System.Drawing.Point(892, 476)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(104, 39)
        Me.btnSimpan.TabIndex = 47
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'deskripsi
        '
        Me.deskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.deskripsi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.deskripsi.Location = New System.Drawing.Point(220, 270)
        Me.deskripsi.Name = "deskripsi"
        Me.deskripsi.Size = New System.Drawing.Size(287, 187)
        Me.deskripsi.TabIndex = 46
        Me.deskripsi.Text = ""
        '
        'harga
        '
        Me.harga.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.harga.Location = New System.Drawing.Point(220, 218)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(287, 31)
        Me.harga.TabIndex = 44
        '
        'durasi
        '
        Me.durasi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.durasi.Location = New System.Drawing.Point(220, 168)
        Me.durasi.Name = "durasi"
        Me.durasi.Size = New System.Drawing.Size(287, 31)
        Me.durasi.TabIndex = 43
        '
        'nmWahana
        '
        Me.nmWahana.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.nmWahana.Location = New System.Drawing.Point(220, 114)
        Me.nmWahana.Name = "nmWahana"
        Me.nmWahana.Size = New System.Drawing.Size(287, 31)
        Me.nmWahana.TabIndex = 42
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label15.Location = New System.Drawing.Point(175, 270)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 23)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(176, 221)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 23)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Location = New System.Drawing.Point(176, 171)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 23)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(176, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 23)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(45, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 23)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(44, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 23)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Deskripsi "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(45, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Durasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(45, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(437, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 29)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Data Paket"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 92)
        Me.Panel1.TabIndex = 55
        '
        'DataPaket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(1017, 545)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.tbCari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.deskripsi)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.durasi)
        Me.Controls.Add(Me.nmWahana)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Name = "DataPaket"
        Me.Text = "Form5"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents tbCari As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents deskripsi As System.Windows.Forms.RichTextBox
    Friend WithEvents harga As System.Windows.Forms.TextBox
    Friend WithEvents durasi As System.Windows.Forms.TextBox
    Friend WithEvents nmWahana As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
