Imports MySql.Data.MySqlClient

Public Class BeliTiket
    'Dim CONN As New MySqlConnection("server=localhost;userid=root;password=;database=dbwisata")

    Sub tampilPaket()
        CMD = New MySqlCommand("select nama from paket", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            cbPaket.Items.Add(RD.Item(0))
        Loop
        RD.Close()
    End Sub

    Private Sub batal_Click(sender As Object, e As EventArgs) Handles batal.Click
        tanggal.Text = ""
        jmlTiket.Text = ""
        cbPaket.SelectedIndex = -1
        cbKategori.SelectedIndex = -1
        metodePembayaran.SelectedIndex = -1
    End Sub

    Private Sub beli_Click(sender As Object, e As EventArgs) Handles beli.Click
        If jmlTiket.Text = "" OrElse
           cbPaket.Text = "" OrElse
           cbKategori.Text = "" OrElse
           metodePembayaran.Text = "" OrElse
           tanggal.Text = "" Then

            MessageBox.Show("Pastikan semua data sudah diisi", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        BeliTiket2.JT.Text = jmlTiket.Text
        BeliTiket2.KT.Text = cbPaket.Text

        Dim id_paket As Integer
        CMD = New MySqlCommand("select id from paket where nama = '" & cbPaket.Text & "'", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            id_paket = RD.Item(0)
        Loop
        RD.Close()

        BeliTiket2.Label12.Text = id_paket
        BeliTiket2.medpem.Text = metodePembayaran.Text
        If cbKategori.Text = "VVIP" Then
            BeliTiket2.judul.Text = "Starlight Mirage"
        ElseIf cbKategori.Text = "VIP" Then
            BeliTiket2.judul.Text = "Moonlight Echo"
        ElseIf cbKategori.Text = "REGULAR" Then
            BeliTiket2.judul.Text = "Horizon"
        End If
        BeliTiket2.tgl.Text = tanggal.Text
        BeliTiket2.Show()
    End Sub

    Private Sub beliTiket()
        Try
            CONN.Open()

            Dim sql As String = "INSERT INTO tiket (jumlah_tiket, kategori_tiket, tanggal, metode_pembayaran) VALUES (@jumlah_tiket, @kategori, @tanggal, @metode)"
            Dim cmd As New MySqlCommand(sql, CONN)

            cmd.Parameters.AddWithValue("@jumlah_tiket", jmlTiket.Text)
            cmd.Parameters.AddWithValue("@kategori", cbPaket.Text)
            cmd.Parameters.AddWithValue("@tanggal", tanggal.Text)
            cmd.Parameters.AddWithValue("@metode", metodePembayaran.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data tiket berhasil disimpan ke database", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    Private Sub BeliTiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilPaket()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Homepage.Show()
        Me.Hide()
    End Sub

    Private Sub jmlTiket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jmlTiket.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If Not (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Jumlah tiket harus berupa angka", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Class
