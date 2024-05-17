Public Class LoginAdmin

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        If username.Text = "admin" And password.Text = "123" Then
            username.Clear()
            password.Clear()
            FMenu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau Password salah", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            username.Clear()
            password.Clear()
            username.Focus()
        End If
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Homepage.Show()
        Me.Close()
    End Sub
End Class
