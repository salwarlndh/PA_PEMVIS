Imports MySql.Data.MySqlClient

Public Class DataPaket
    Dim id_row As Integer

    Sub tampilPaket()
        DA = New MySqlDataAdapter("select * from paket", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "wahana")
        DataGridView1.DataSource = DS.Tables("wahana")
        DataGridView1.Refresh()
    End Sub

    Sub kosong()
        nmWahana.Clear()
        durasi.Clear()
        harga.Clear()
        deskripsi.Clear()
    End Sub

    Private Function cekInput() As Boolean
        If nmWahana.Text = "" Or durasi.Text = "" Or harga.Text = "" Or deskripsi.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            If row.Index < DataGridView1.RowCount - 1 And row.Index >= 0 Then
                nmWahana.Text = row.Cells(1).Value
                durasi.Text = row.Cells(2).Value
                harga.Text = row.Cells(3).Value
                deskripsi.Text = row.Cells(4).Value

                id_row = row.Cells(0).Value

                btnHapus.Enabled = True
                btnUbah.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cekInput() Then
            CMD = New MySqlCommand("select * from paket where nama = '" & nmWahana.Text & "'", CONN)
            RD = CMD.ExecuteReader
            If Not RD.HasRows Then
                RD.Close()

                Dim simpan As String = "INSERT INTO paket VALUES ('', @nama, @durasi, @harga, @deskripsi)"
                CMD = New MySqlCommand(simpan, CONN)

                CMD.Parameters.AddWithValue("@nama", nmWahana.Text)
                CMD.Parameters.AddWithValue("@durasi", durasi.Text)
                CMD.Parameters.AddWithValue("@harga", harga.Text)
                CMD.Parameters.AddWithValue("@deskripsi", deskripsi.Text)

                CMD.ExecuteNonQuery()
                tampilPaket()
                MessageBox.Show("Data berhasil disimpan", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                DetailPaket.nmWahana.DropDownStyle = ComboBoxStyle.DropDown
                DetailPaket.nmWahana.Text = Me.nmWahana.Text
                DetailPaket.nmWahana.Enabled = False
                DetailPaket.Show()
                Me.Hide()
            Else
                RD.Close()
                MessageBox.Show("Paket sudah tersedia!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Pastikan semua data sudah diisi", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DataPaket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        kosong()
        tampilPaket()
        nmWahana.Focus()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If id_row = Nothing Then
            MessageBox.Show("Silahkan pilih data terlebih dahulu", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'select * from paket where nama = 'Paket A' and nama not in (select nama from paket where id = '23');
            CMD = New MySqlCommand("select * from paket where nama = '" & nmWahana.Text & "' and nama not in (select nama from paket where id = '" & id_row & "')", CONN)
            RD = CMD.ExecuteReader
            If Not RD.HasRows Then
                RD.Close()

                Dim ubah As String = "update paket set nama = '" & nmWahana.Text & "', durasi = '" & durasi.Text & "', harga = '" & harga.Text & "', deskripsi = '" & deskripsi.Text & "' where id = '" & id_row & "'"
                CMD = New MySqlCommand(ubah, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data berhasil diubah", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampilPaket()
                kosong()
                nmWahana.Focus()
                id_row = Nothing
                btnUbah.Enabled = False
                btnHapus.Enabled = False
            Else
                RD.Close()
                MessageBox.Show("Paket sudah tersedia!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If id_row = Nothing Then
            MessageBox.Show("Silahkan pilih data terlebih dahulu", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim hapus_detailpaket As String = "delete from detailpaket where id_paket = '" & id_row & "'"
            CMD = New MySqlCommand(hapus_detailpaket, CONN)
            CMD.ExecuteNonQuery()

            Dim hapus As String = "delete from paket where id = '" & id_row & "'"
            CMD = New MySqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil dihapus", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilPaket()
            kosong()
            nmWahana.Focus()
            id_row = Nothing
            btnUbah.Enabled = False
            btnHapus.Enabled = False
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        kosong()
        id_row = Nothing
        btnHapus.Enabled = False
        btnUbah.Enabled = False
    End Sub

    Private Sub durasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles durasi.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If Not (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Durasi harus berupa angka", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        If tbCari.Text <> Nothing Then
            DA = New MySqlDataAdapter("select * from paket where nama like '%" & tbCari.Text & "%'", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "Dapat")
            DataGridView1.DataSource = DS.Tables("Dapat")
            DataGridView1.ReadOnly = True
        Else
            tampilPaket()
        End If
    End Sub

    Private Sub harga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles harga.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If Not (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Harga harus berupa angka", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class