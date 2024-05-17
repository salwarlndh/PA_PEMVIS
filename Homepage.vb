Public Class Homepage

    Private Sub btnBeli_Click(sender As Object, e As EventArgs) Handles btnBeli.Click
        BeliTiket.Show()
        Me.Hide()
    End Sub

    Private Sub FlowLayoutPanel1_Click(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.Click
        LoginAdmin.Show()
        Me.Hide()
    End Sub
End Class