<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeliTiket
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.jmlTiket = New System.Windows.Forms.TextBox()
        Me.cbPaket = New System.Windows.Forms.ComboBox()
        Me.metodePembayaran = New System.Windows.Forms.ComboBox()
        Me.beli = New System.Windows.Forms.Button()
        Me.batal = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbKategori = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(266, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pesan Tiket"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pilih Tanggal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Paket"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jumlah Tiket"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Metode Pembayaran"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(265, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 22)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(265, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(265, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 22)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(265, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 22)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = ":"
        '
        'tanggal
        '
        Me.tanggal.CalendarMonthBackground = System.Drawing.Color.SeaShell
        Me.tanggal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.Location = New System.Drawing.Point(305, 43)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(314, 27)
        Me.tanggal.TabIndex = 14
        '
        'jmlTiket
        '
        Me.jmlTiket.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!)
        Me.jmlTiket.Location = New System.Drawing.Point(305, 112)
        Me.jmlTiket.Name = "jmlTiket"
        Me.jmlTiket.Size = New System.Drawing.Size(314, 27)
        Me.jmlTiket.TabIndex = 15
        '
        'cbPaket
        '
        Me.cbPaket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaket.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!)
        Me.cbPaket.FormattingEnabled = True
        Me.cbPaket.Location = New System.Drawing.Point(305, 172)
        Me.cbPaket.Name = "cbPaket"
        Me.cbPaket.Size = New System.Drawing.Size(314, 28)
        Me.cbPaket.TabIndex = 16
        '
        'metodePembayaran
        '
        Me.metodePembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.metodePembayaran.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!)
        Me.metodePembayaran.FormattingEnabled = True
        Me.metodePembayaran.Items.AddRange(New Object() {"OVO", "GOPAY", "S-PAY", "QRIS", "Indomaret", "Alfamart", "LinkAja", "BNI", "BRI", "BCA", "Mandiri", "Cimb Niaga", "Debit Card"})
        Me.metodePembayaran.Location = New System.Drawing.Point(305, 275)
        Me.metodePembayaran.Name = "metodePembayaran"
        Me.metodePembayaran.Size = New System.Drawing.Size(314, 28)
        Me.metodePembayaran.TabIndex = 17
        '
        'beli
        '
        Me.beli.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.beli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.beli.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.beli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.beli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.beli.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!)
        Me.beli.ForeColor = System.Drawing.Color.White
        Me.beli.Location = New System.Drawing.Point(517, 356)
        Me.beli.Name = "beli"
        Me.beli.Size = New System.Drawing.Size(102, 37)
        Me.beli.TabIndex = 18
        Me.beli.Text = "Pesan"
        Me.beli.UseVisualStyleBackColor = False
        '
        'batal
        '
        Me.batal.BackColor = System.Drawing.Color.Gray
        Me.batal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.batal.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.batal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.batal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batal.ForeColor = System.Drawing.Color.White
        Me.batal.Location = New System.Drawing.Point(409, 356)
        Me.batal.Name = "batal"
        Me.batal.Size = New System.Drawing.Size(102, 36)
        Me.batal.TabIndex = 24
        Me.batal.Text = "Batal"
        Me.batal.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.cbKategori)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnKembali)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.batal)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.beli)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.metodePembayaran)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbPaket)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.jmlTiket)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tanggal)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(24, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 407)
        Me.Panel1.TabIndex = 25
        '
        'cbKategori
        '
        Me.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKategori.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!)
        Me.cbKategori.FormattingEnabled = True
        Me.cbKategori.Items.AddRange(New Object() {"REGULAR", "VIP", "VVIP"})
        Me.cbKategori.Location = New System.Drawing.Point(305, 223)
        Me.cbKategori.Name = "cbKategori"
        Me.cbKategori.Size = New System.Drawing.Size(314, 28)
        Me.cbKategori.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(265, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 22)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 22)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Kategori"
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.White
        Me.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKembali.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKembali.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.Color.Black
        Me.btnKembali.Location = New System.Drawing.Point(301, 356)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(102, 36)
        Me.btnKembali.TabIndex = 25
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'BeliTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(686, 523)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BeliTiket"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents jmlTiket As System.Windows.Forms.TextBox
    Friend WithEvents cbPaket As System.Windows.Forms.ComboBox
    Friend WithEvents metodePembayaran As System.Windows.Forms.ComboBox
    Friend WithEvents beli As System.Windows.Forms.Button
    Friend WithEvents batal As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents cbKategori As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
