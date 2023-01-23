Public Class Form_Logout

    Private Sub btn_ya_logout_Click(sender As Object, e As EventArgs) Handles btn_ya_logout.Click
        Form_Login.Show()
        Me.Close()
        Form_MenuAdmin.Close()
        Form_MenuManager.Close()
    End Sub

    Private Sub btn_tidak_logout_Click(sender As Object, e As EventArgs) Handles btn_tidak_logout.Click
        Me.Close()
    End Sub
End Class