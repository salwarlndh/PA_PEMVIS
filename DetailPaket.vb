Imports MySql.Data.MySqlClient

Public Class DetailPaket

    Sub tampilDetailPaket()
        DA = New MySqlDataAdapter("select paket.nama, wahana.nama from detailpaket inner join wahana on wahana.id = detailpaket.id_wahana inner join paket on paket.id = detailpaket.id_paket where detailpaket.id_paket in (select id from paket where nama = '" & nmWahana.Text & "');", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "wahana")
        DataGridView1.DataSource = DS.Tables("wahana")
        DataGridView1.Refresh()

        With DataGridView1
            .Columns(0).HeaderText = "Nama Paket"
            .Columns(1).HeaderText = "Nama Wahana"

            .Columns(0).Width = 165
            .Columns(1).Width = 165
        End With
    End Sub

    Sub tampilWahana()
        CMD = New MySqlCommand("select nama from wahana", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            ComboBox1.Items.Add(RD.Item(0))
        Loop
        RD.Close()
    End Sub

    Sub tampilPaket()
        CMD = New MySqlCommand("select nama from paket", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            nmWahana.Items.Add(RD.Item(0))
        Loop
        RD.Close()
    End Sub

    Private Sub DetailPaket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilDetailPaket()
        tampilWahana()
        tampilPaket()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            If row.Index < DataGridView1.RowCount - 1 And row.Index >= 0 Then
                nmWahana.Text = row.Cells(0).Value
                ComboBox1.Text = row.Cells(1).Value

                nmWahana.Enabled = False
                ComboBox1.Enabled = False

                btnHapus.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If nmWahana.Text = "" Then
            Me.Hide()
            FMenu.Show()
        Else
            CMD = New MySqlCommand("select * from detailpaket where id_paket in (select id from paket where nama = '" & nmWahana.Text & "')", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                MessageBox.Show("Minimal isi satu wahana per-paket", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                RD.Close()
                nmWahana.Text = Nothing
                ComboBox1.Text = Nothing
                Me.Hide()
                FMenu.Show()
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If nmWahana.Text = "" Or ComboBox1.Text = Nothing Then
            MessageBox.Show("Pastikan semua data sudah diisi", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim id_paket As Integer
            Dim id_wahana As Integer
            CMD = New MySqlCommand("select id from paket where nama = '" & nmWahana.Text & "'", CONN)
            RD = CMD.ExecuteReader
            Do While RD.Read
                id_paket = RD.Item(0)
            Loop
            RD.Close()
            CMD = New MySqlCommand("select id from wahana where nama = '" & ComboBox1.Text & "'", CONN)
            RD = CMD.ExecuteReader
            Do While RD.Read
                id_wahana = RD.Item(0)
            Loop
            RD.Close()

            CMD = New MySqlCommand("select * from detailpaket where id_paket = '" & id_paket & "' and id_wahana = '" & id_wahana & "'", CONN)
            RD = CMD.ExecuteReader
            If Not RD.HasRows Then
                RD.Close()

                Dim simpan As String = "insert into detailpaket values ('', @id_paket, @id_wahana)"
                CMD = New MySqlCommand(simpan, CONN)
                CMD.Parameters.AddWithValue("@nama", nmWahana.Text)
                CMD.Parameters.AddWithValue("@id_paket", id_paket)
                CMD.Parameters.AddWithValue("@id_wahana", id_wahana)
                CMD.ExecuteNonQuery()

                tampilDetailPaket()
                nmWahana.Enabled = True
            Else
                RD.Close()
                MessageBox.Show("Wahana sudah tersedia!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub nmWahana_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nmWahana.SelectedIndexChanged
        tampilDetailPaket()
        CMD = New MySqlCommand("select * from detailpaket where id_paket in (select id from paket where nama = '" & nmWahana.Text & "')", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            RD.Close()
            nmWahana.Enabled = False
        Else
            RD.Close()
            nmWahana.Enabled = True
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim hapus As String = "delete from detailpaket where id_paket in (select id from paket where nama = '" & nmWahana.Text & "') and id_wahana in (select id from wahana where nama = '" & ComboBox1.Text & "')"
        CMD = New MySqlCommand(hapus, CONN)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Data berhasil dihapus", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CMD = New MySqlCommand("select * from detailpaket where id_paket in (select id from paket where nama = '" & nmWahana.Text & "')", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            RD.Close()
            nmWahana.Enabled = True
        Else
            RD.Close()
        End If

        ComboBox1.Enabled = True
        btnHapus.Enabled = False
        ComboBox1.Text = Nothing
        tampilDetailPaket()
    End Sub
End Class