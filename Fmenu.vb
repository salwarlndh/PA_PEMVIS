Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FMenu
    Dim pageWidth As Integer = 827
    Dim pageHeight As Integer = 1169
    Dim list As New List(Of List(Of String))()
    Dim currentPage, totalPage, totalItem, marginPixels, y, x, marginRight As Integer
    Dim marginInch As Single
    Dim CONN As New MySqlConnection("server=localhost;userid=root;password=;database=dbwisata")
    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader

    Private Sub readDataPengunjung()
        CMD = New MySqlCommand("select * from tiket order by id_pesanan", CONN)
        CONN.Open()
        RD = CMD.ExecuteReader
        totalItem = 0
        Do While RD.Read
            Dim dataPengunjung As New List(Of String)()
            dataPengunjung.Add(RD("id_pesanan").ToString)
            dataPengunjung.Add(RD("nama").ToString)
            dataPengunjung.Add(RD("email").ToString)
            dataPengunjung.Add(RD("nomorhp").ToString)
            dataPengunjung.Add(RD("jumlah_tiket").ToString)
            dataPengunjung.Add(RD("kategori_tiket").ToString)
            dataPengunjung.Add(RD("tanggal_lahir").ToString)
            dataPengunjung.Add(RD("daerah_asal").ToString)
            dataPengunjung.Add(RD("jenis_kelamin").ToString)
            list.Add(dataPengunjung)
            totalItem += 1
        Loop
        totalPage = Math.Ceiling(totalItem / 3)
        RD.Close()
        CONN.Close()
    End Sub

    Private Sub DataPengunjungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPengunjungToolStripMenuItem.Click
        readDataPengunjung()
        currentPage = 1
        PrintPreviewDialog1.Document = PrintPengunjung
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPengunjung_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintPengunjung.PrintPage
        Dim Fheader As New Font("Times New Roman", 24, FontStyle.Bold)
        Dim FBodyB As New Font("Times New Roman", 14, FontStyle.Bold)
        Dim FBody As New Font("Times New Roman", 14, FontStyle.Regular)
        Dim black As SolidBrush = New SolidBrush(Color.Black)

        Dim center As New StringFormat()
        center.Alignment = StringAlignment.Center
        Dim posY, i As Integer

        Dim boxWidth As Integer = e.MarginBounds.Width - 40
        Dim boxHeight As Integer = 270

        x = e.MarginBounds.Left + 20
        y = If(currentPage <= 1, e.MarginBounds.Top + 50, e.MarginBounds.Top)

        Dim hitung As Integer = 0
        If currentPage <= 1 Then
            e.Graphics.DrawString("Data Pengunjung", Fheader, black, pageWidth / 2, y, center)
            posY = y + 70
        Else
            posY = y
        End If

        For i = (currentPage - 1) * 3 To Math.Min((currentPage * 3) - 1, list.Count - 1)
            Dim itemPosY As Integer = posY + ((i - (currentPage - 1) * 3) * (boxHeight + 10))

            e.Graphics.DrawRectangle(Pens.Black, x, itemPosY, boxWidth, boxHeight)

            e.Graphics.DrawString("ID Pesanan", FBody, black, x + 20, itemPosY + 30)
            e.Graphics.DrawString(": " & list(i)(0).ToString, FBody, black, x + 220, itemPosY + 30)
            e.Graphics.DrawString("Nama", FBody, black, x + 20, itemPosY + 60)
            e.Graphics.DrawString(": " & list(i)(1).ToString, FBody, black, x + 220, itemPosY + 60)
            e.Graphics.DrawString("Email", FBody, black, x + 20, itemPosY + 90)
            e.Graphics.DrawString(": " & list(i)(2).ToString, FBody, black, x + 220, itemPosY + 90)
            e.Graphics.DrawString("Nomor HP", FBody, black, x + 20, itemPosY + 120)
            e.Graphics.DrawString(": " & list(i)(3).ToString, FBody, black, x + 220, itemPosY + 120)
            e.Graphics.DrawString("Jumlah Tiket", FBody, black, x + 20, itemPosY + 150)
            e.Graphics.DrawString(": " & list(i)(4).ToString, FBody, black, x + 220, itemPosY + 150)
            e.Graphics.DrawString("Paket", FBody, black, x + 20, itemPosY + 180)
            e.Graphics.DrawString(": " & list(i)(5).ToString, FBody, black, x + 220, itemPosY + 180)
            e.Graphics.DrawString("Tanggal Lahir", FBody, black, x + 20, itemPosY + 210)
            e.Graphics.DrawString(": " & list(i)(6).ToString, FBody, black, x + 220, itemPosY + 210)
            e.Graphics.DrawString("Daerah Asal", FBody, black, x + 20, itemPosY + 240)
            e.Graphics.DrawString(": " & list(i)(7).ToString, FBody, black, x + 220, itemPosY + 240)

            If i Mod 3 < 2 Then
                e.Graphics.DrawLine(Pens.Black, x, itemPosY + boxHeight, x + boxWidth, itemPosY + boxHeight)
            End If
        Next

        If currentPage <= 1 Then
            e.Graphics.DrawLine(Pens.Black, x, y + 70, x, posY + 10)
            e.Graphics.DrawLine(Pens.Black, x + boxWidth, y + 70, x + boxWidth, posY + 10)
        Else
            e.Graphics.DrawLine(Pens.Black, x, y, x, posY + 10)
            e.Graphics.DrawLine(Pens.Black, x + boxWidth, y, x + boxWidth, posY + 10)
        End If
        currentPage += 1
        e.HasMorePages = currentPage <= totalPage
    End Sub

    Private Sub DataPaketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPaketToolStripMenuItem.Click
        CMD = New MySqlCommand("SELECT * FROM wahana", CONN)
        CONN.Open()
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            RD.Close()
            CONN.Close()
            Me.Hide()
            DataPaket.kosong()
            DataPaket.Show()
        Else
            RD.Close()
            CONN.Close()
            MessageBox.Show("Silakan isi data wahana terlebih dahulu", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DataWahana.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DataDetailPaketToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataDetailPaketToolStripMenuItem1.Click
        DetailPaket.nmWahana.Text = Nothing
        DetailPaket.ComboBox1.Text = Nothing
        DetailPaket.nmWahana.Enabled = True
        DetailPaket.ComboBox1.Enabled = True
        DetailPaket.DataGridView1.DataSource = Nothing

        DetailPaket.Show()
        Me.Hide()
    End Sub

    Private Sub FMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
End Class
