Public Class Form_Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_masuk_mgr.Click
        Form_loginMng.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_masuk_adm.Click
        Form_loginAdmin.Show()

    End Sub

    Private Sub btn_end_login_Click(sender As Object, e As EventArgs) Handles btn_end_login.Click
        End
    End Sub


End Class
