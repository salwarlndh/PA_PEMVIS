<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeliTiket2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BeliTiket2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tgl = New System.Windows.Forms.Label()
        Me.judul = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.noTelp = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.laki = New System.Windows.Forms.RadioButton()
        Me.perempuan = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tglLahir = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.domisili = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.lanjut = New System.Windows.Forms.Button()
        Me.kembali = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.JT = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.KT = New System.Windows.Forms.Label()
        Me.medpem = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.tgl)
        Me.Panel1.Controls.Add(Me.judul)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 100)
        Me.Panel1.TabIndex = 0
        '
        'tgl
        '
        Me.tgl.AutoSize = True
        Me.tgl.BackColor = System.Drawing.Color.Transparent
        Me.tgl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.tgl.ForeColor = System.Drawing.Color.SeaShell
        Me.tgl.Location = New System.Drawing.Point(310, 69)
        Me.tgl.Name = "tgl"
        Me.tgl.Size = New System.Drawing.Size(0, 23)
        Me.tgl.TabIndex = 4
        '
        'judul
        '
        Me.judul.AutoSize = True
        Me.judul.BackColor = System.Drawing.Color.Transparent
        Me.judul.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judul.ForeColor = System.Drawing.Color.SeaShell
        Me.judul.Location = New System.Drawing.Point(19, 9)
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(0, 34)
        Me.judul.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.ForeColor = System.Drawing.Color.SeaShell
        Me.Panel2.Location = New System.Drawing.Point(534, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 80)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(21, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ringkasan Pembelian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(22, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Informasi Pembeli"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.Label3.Location = New System.Drawing.Point(23, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(261, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tiket akan dikirimkan ke alamat email ini"
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.email.Location = New System.Drawing.Point(25, 305)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(270, 23)
        Me.email.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.Label5.Location = New System.Drawing.Point(23, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No Telepon"
        '
        'noTelp
        '
        Me.noTelp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.noTelp.Location = New System.Drawing.Point(26, 375)
        Me.noTelp.Name = "noTelp"
        Me.noTelp.Size = New System.Drawing.Size(270, 23)
        Me.noTelp.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(26, 403)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(254, 21)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Kirim tiket melalui WhatsApp di atas"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.Label6.Location = New System.Drawing.Point(23, 442)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nama"
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.nama.Location = New System.Drawing.Point(26, 464)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(270, 23)
        Me.nama.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.Label7.Location = New System.Drawing.Point(23, 513)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Jenis Kelamin"
        '
        'laki
        '
        Me.laki.AutoSize = True
        Me.laki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.laki.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laki.Location = New System.Drawing.Point(26, 534)
        Me.laki.Name = "laki"
        Me.laki.Size = New System.Drawing.Size(81, 21)
        Me.laki.TabIndex = 14
        Me.laki.TabStop = True
        Me.laki.Text = "Laki-laki"
        Me.laki.UseVisualStyleBackColor = True
        '
        'perempuan
        '
        Me.perempuan.AutoSize = True
        Me.perempuan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.perempuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perempuan.Location = New System.Drawing.Point(188, 534)
        Me.perempuan.Name = "perempuan"
        Me.perempuan.Size = New System.Drawing.Size(102, 21)
        Me.perempuan.TabIndex = 15
        Me.perempuan.TabStop = True
        Me.perempuan.Text = "Perempuan"
        Me.perempuan.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(338, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(211, 23)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Informasi Tambahan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.Label9.Location = New System.Drawing.Point(340, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tanggal Lahir"
        '
        'tglLahir
        '
        Me.tglLahir.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglLahir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglLahir.Location = New System.Drawing.Point(343, 287)
        Me.tglLahir.Name = "tglLahir"
        Me.tglLahir.Size = New System.Drawing.Size(270, 22)
        Me.tglLahir.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.Label10.Location = New System.Drawing.Point(340, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Daerah Asal"
        '
        'domisili
        '
        Me.domisili.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.domisili.Location = New System.Drawing.Point(343, 354)
        Me.domisili.Name = "domisili"
        Me.domisili.Size = New System.Drawing.Size(270, 23)
        Me.domisili.TabIndex = 20
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(343, 403)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(291, 38)
        Me.CheckBox2.TabIndex = 21
        Me.CheckBox2.Text = "Saya setuju terhadap , Syarat Ketentuan," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dan Kebijakan Privasi"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'lanjut
        '
        Me.lanjut.BackColor = System.Drawing.Color.MidnightBlue
        Me.lanjut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lanjut.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.lanjut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lanjut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lanjut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.lanjut.ForeColor = System.Drawing.Color.White
        Me.lanjut.Location = New System.Drawing.Point(520, 519)
        Me.lanjut.Name = "lanjut"
        Me.lanjut.Size = New System.Drawing.Size(93, 36)
        Me.lanjut.TabIndex = 22
        Me.lanjut.Text = "Lanjutkan"
        Me.lanjut.UseVisualStyleBackColor = False
        '
        'kembali
        '
        Me.kembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kembali.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kembali.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.kembali.Location = New System.Drawing.Point(421, 519)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(93, 36)
        Me.kembali.TabIndex = 23
        Me.kembali.Text = "Kembali"
        Me.kembali.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(23, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Jumlah Tiket"
        '
        'JT
        '
        Me.JT.AutoSize = True
        Me.JT.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.JT.Location = New System.Drawing.Point(205, 158)
        Me.JT.Name = "JT"
        Me.JT.Size = New System.Drawing.Size(0, 17)
        Me.JT.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(22, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Paket"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(22, 197)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(157, 17)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Metode Pembayaran"
        '
        'KT
        '
        Me.KT.AutoSize = True
        Me.KT.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.KT.Location = New System.Drawing.Point(205, 179)
        Me.KT.Name = "KT"
        Me.KT.Size = New System.Drawing.Size(0, 17)
        Me.KT.TabIndex = 28
        '
        'medpem
        '
        Me.medpem.AutoSize = True
        Me.medpem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.medpem.Location = New System.Drawing.Point(205, 200)
        Me.medpem.Name = "medpem"
        Me.medpem.Size = New System.Drawing.Size(0, 17)
        Me.medpem.TabIndex = 29
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(23, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 17)
        Me.Label12.TabIndex = 30
        Me.Label12.Visible = False
        '
        'BeliTiket2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(648, 613)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.medpem)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.KT)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.JT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.lanjut)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.domisili)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tglLahir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.perempuan)
        Me.Controls.Add(Me.laki)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.noTelp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BeliTiket2"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents noTelp As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents laki As System.Windows.Forms.RadioButton
    Friend WithEvents perempuan As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tglLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents domisili As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents lanjut As System.Windows.Forms.Button
    Friend WithEvents kembali As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents JT As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents KT As System.Windows.Forms.Label
    Friend WithEvents medpem As System.Windows.Forms.Label
    Friend WithEvents tgl As System.Windows.Forms.Label
    Friend WithEvents judul As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
