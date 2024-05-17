Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class BeliTiket2
    Dim CONN As New MySqlConnection("server=localhost;userid=root;password=;database=dbwisata")
    Dim total_harga As Double

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            lanjut.Enabled = True
        Else
            lanjut.Enabled = False
        End If
    End Sub

    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        BeliTiket.Show()
        Me.Hide()
    End Sub

    Private Sub lanjut_Click(sender As Object, e As EventArgs) Handles lanjut.Click
        If nama.Text = "" OrElse email.Text = "" OrElse noTelp.Text = "" OrElse domisili.Text = "" OrElse (Not laki.Checked AndAlso Not perempuan.Checked) Then
            MessageBox.Show("Pastikan semua data sudah diisi", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            CONN.Open()
            Dim harga As String = "0"

            Dim cmd1 As New MySqlCommand("select harga from paket where id = '" & Label12.Text & "'", CONN)
            RD = cmd1.ExecuteReader
            If RD.Read() Then
                harga = RD.Item(0).ToString()
            End If
            RD.Close()

            total_harga = Double.Parse(JT.Text) * Double.Parse(harga)

            Dim currentDateTime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            'CONN.Open()

            Dim sql As String = "INSERT INTO tiket VALUES ('', @nama, @email, @nomorhp, @jmltiket, @kategori, @tanggal, @metode, @tanggal_lahir, @daerah_asal, @jenis_kelamin, @tanggal_beli, @total_harga, @paket)"
            Dim cmd As New MySqlCommand(sql, CONN)

            cmd.Parameters.AddWithValue("@jmltiket", JT.Text)
            cmd.Parameters.AddWithValue("@tanggal_beli", currentDateTime)
            cmd.Parameters.AddWithValue("@kategori", KT.Text)
            cmd.Parameters.AddWithValue("@tanggal", tgl.Text)
            cmd.Parameters.AddWithValue("@metode", medpem.Text)
            cmd.Parameters.AddWithValue("@email", email.Text)
            cmd.Parameters.AddWithValue("@nomorhp", noTelp.Text)
            cmd.Parameters.AddWithValue("@nama", nama.Text)
            cmd.Parameters.AddWithValue("@tanggal_lahir", tglLahir.Value.Date)
            cmd.Parameters.AddWithValue("@daerah_asal", domisili.Text)
            cmd.Parameters.AddWithValue("@jenis_kelamin", If(laki.Checked, "Laki-laki", "Perempuan"))
            cmd.Parameters.AddWithValue("@total_harga", total_harga)
            cmd.Parameters.AddWithValue("@paket", Label12.Text)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Pembelian tiket berhasil. Silahkan cetak tiket Anda.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try

        Dim printPreviewDialog As New PrintPreviewDialog()
        AddHandler printPreviewDialog.FormClosed, AddressOf PrintPreviewDialog_FormClosed
        printPreviewDialog.Document = PrintDocument1
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintPreviewDialog_FormClosed(sender As Object, e As FormClosedEventArgs)
        Dim printPreviewDialog As PrintPreviewDialog = CType(sender, PrintPreviewDialog)
        RemoveHandler printPreviewDialog.FormClosed, AddressOf PrintPreviewDialog_FormClosed
        printPreviewDialog.Document = Nothing
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titleFont As New Font("Century Gothic", 24, FontStyle.Bold)
        Dim subTitleFont As New Font("Century Gothic", 14)
        Dim contentFont As New Font("Arial", 12)

        Dim borderPen As New Pen(Brushes.Gray, 2)

        Dim title As String = "Pembelian Tiket Anda"
        Dim subTitle As String = tgl.Text

        Dim yPos As Single = 100

        Dim titleSize As SizeF = e.Graphics.MeasureString(title, titleFont)
        e.Graphics.DrawString(title, titleFont, Brushes.DarkBlue, (e.PageBounds.Width - titleSize.Width) / 2, yPos)
        yPos += titleSize.Height + 10

        Dim subTitleSize As SizeF = e.Graphics.MeasureString(subTitle, subTitleFont)
        e.Graphics.DrawString(subTitle, subTitleFont, Brushes.Green, (e.PageBounds.Width - subTitleSize.Width) / 2, yPos)
        yPos += subTitleSize.Height + 20

        e.Graphics.DrawLine(borderPen, 100, yPos, e.PageBounds.Width - 100, yPos)
        yPos += 20

        Dim purchaseInfo As String = "Detail Pembelian" & vbCrLf &
                                     "Email : " & email.Text & vbCrLf &
                                     "Nama : " & nama.Text & vbCrLf &
                                     "Jumlah Tiket : " & JT.Text & vbCrLf &
                                     "Paket : " & KT.Text & vbCrLf &
                                     "Metode Pembayaran : " & medpem.Text
        e.Graphics.DrawString(purchaseInfo, contentFont, Brushes.Black, 100, yPos)
        yPos += contentFont.Height * 7

        e.Graphics.DrawLine(borderPen, 100, yPos, e.PageBounds.Width - 100, yPos)
        yPos += 20

        ' QR code
        'Dim qrCodePath As String = "C:\Users\meisy\OneDrive\Documents\PA_PEMVIS\PA_PEMVIS\qrcode.png"
        Dim qrCodePath As String = CurDir() & "\Asset\qrcode.png"
        Dim qrCodeImage As Image = Image.FromFile(qrCodePath)
        Dim qrCodeSize As New Size(250, 250)
        Dim qrCodeLocationX As Integer = (e.PageBounds.Width - qrCodeSize.Width) / 2
        e.Graphics.DrawImage(qrCodeImage, qrCodeLocationX, yPos, qrCodeSize.Width, qrCodeSize.Height)

        yPos += qrCodeSize.Height + 50

        Dim totalHarga As String = total_harga.ToString("C2")
        Dim totalHargaSize As SizeF = e.Graphics.MeasureString(totalHarga, New Font("Arial", 18))
        Dim totalHargaLocationX As Integer = (e.PageBounds.Width - totalHargaSize.Width) / 2
        e.Graphics.DrawString(totalHarga, New Font("Arial", 18), Brushes.Black, totalHargaLocationX, yPos)

        yPos += totalHargaSize.Height + 50

        Dim termsAndConditions As String = "Syarat & Ketentuan:" & vbCrLf &
                                           "1. Tiket ini hanya berlaku untuk tanggal yang tertera." & vbCrLf &
                                           "2. Tiket tidak dapat diuangkan kembali atau ditukar." & vbCrLf &
                                           "3. Tiket ini tidak dapat dipindahtangankan."
        e.Graphics.DrawString(termsAndConditions, contentFont, Brushes.Gray, 100, yPos)
        yPos += contentFont.Height * 6

        e.Graphics.DrawLine(borderPen, 100, yPos, e.PageBounds.Width - 100, yPos)
        yPos += 20

        Dim contactInfo As String = "Kontak Kami: 112-221-222 | M2SR@gmail.com"
        e.Graphics.DrawString(contactInfo, New Font("Arial", 10), Brushes.DarkBlue, 100, yPos)
    End Sub

    Private Sub noTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles noTelp.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If Not (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            e.Handled = True
            MessageBox.Show("No telp harus berupa angka", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub nama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nama.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" _
            OrElse keyascii = Keys.Back _
            OrElse keyascii = Keys.Space _
            OrElse keyascii = Keys.Return _
            OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
            MessageBox.Show("Nama harus berupa huruf", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class