Imports MySql.Data.MySqlClient

Public Class DataWahana
    Dim id_row As Integer

    Sub tampilPaket()
        DA = New MySqlDataAdapter("select * from paket", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "wahana")
        DataGridView1.DataSource = DS.Tables("wahana")
        DataGridView1.Refresh()
    End Sub

    Sub tampilWisata()
        DA = New MySqlDataAdapter("select * from wahana", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "wahana")
        DataGridView1.DataSource = DS.Tables("wahana")
        DataGridView1.Refresh()
    End Sub

    Sub kosong()
        nmWahana.Clear()
        kapasitas.Clear()
        waktu.Clear()
        deskripsi.Clear()
        kategori.Text = Nothing
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilWisata()
        aturGrid()
    End Sub

    Private Function cekInput() As Boolean
        If nmWahana.Text = Nothing Or kapasitas.Text = Nothing Or waktu.Text = Nothing Or kategori.Text = Nothing Or deskripsi.Text = Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cekInput() Then
            CMD = New MySqlCommand("insert into wahana values ('', '" & nmWahana.Text & "', '" & kapasitas.Text & "', '" & waktu.Text & "', '" & kategori.Text & "', '" & deskripsi.Text & "')", CONN)
            CMD.ExecuteNonQuery()
            tampilWisata()
            MessageBox.Show("Data berhasil disimpan", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kosong()
            nmWahana.Focus()
        Else
            MessageBox.Show("Pastikan semua data sudah diisi", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            If row.Index < DataGridView1.RowCount - 1 And row.Index >= 0 Then
                nmWahana.Text = row.Cells(1).Value
                kapasitas.Text = row.Cells(2).Value
                waktu.Text = row.Cells(3).Value
                deskripsi.Text = row.Cells(5).Value
                kategori.Text = row.Cells(4).Value

                id_row = row.Cells(0).Value
            End If
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If id_row = Nothing Then
            MessageBox.Show("Silahkan pilih data terlebih dahulu", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ubah As String = "update wahana set nama = '" & nmWahana.Text & "', kapasitas = '" & kapasitas.Text & "', waktu = '" & waktu.Text & "', kategori = '" & kategori.Text & "', deskripsi = '" & deskripsi.Text & "' where id = '" & id_row & "'"
            CMD = New MySqlCommand(ubah, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diubah", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilWisata()
            kosong()
            nmWahana.Focus()
            id_row = Nothing
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If id_row = Nothing Then
            MessageBox.Show("Silahkan pilih data terlebih dahulu", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim hapus_detailpaket As String = "delete from detailpaket where id_wahana = '" & id_row & "'"
            CMD = New MySqlCommand(hapus_detailpaket, CONN)
            CMD.ExecuteNonQuery()

            Dim hapus As String = "delete from wahana where id = '" & id_row & "'"
            CMD = New MySqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil dihapus", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilWisata()
            kosong()
            nmWahana.Focus()
            id_row = Nothing
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        kosong()
        tampilWisata()
        nmWahana.Focus()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FMenu.Show()
        Me.Hide()
    End Sub

    Private Sub kapasitas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kapasitas.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If Not (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Kapasitas harus berupa angka", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        If tbCari.Text <> Nothing Then
            DA = New MySqlDataAdapter("select * from wahana where nama like '%" & tbCari.Text & "%'", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "Dapat")
            DataGridView1.DataSource = DS.Tables("Dapat")
            DataGridView1.ReadOnly = True
        Else
            tampilWisata()
        End If
    End Sub
End Class