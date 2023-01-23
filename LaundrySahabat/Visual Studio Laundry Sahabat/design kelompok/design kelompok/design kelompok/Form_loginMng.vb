Public Class Form_loginMng

    'perintah untuk tombol login mnanger yang username dan passwordnya sudah dibuat di database sebelumnya
    Private Sub btn_login_mgr_Click(sender As Object, e As EventArgs) Handles btn_login_mgr.Click
        If txt_userlogin_mgr.Text = "mgrsyahrani" And txt_passlogin_mgr.Text = "syahrani123" Then
            Me.Hide()
            Form_MenuManager.Show()
        ElseIf txt_userlogin_mgr.Text = "" And txt_passlogin_mgr.Text = "" Then
            MsgBox("Silakan Isi Username dan Password!", vbInformation, "Hint")
        ElseIf txt_userlogin_mgr.Text = "" Then
            MsgBox("Username Kosong", vbCritical, "Error!!")
        ElseIf txt_passlogin_mgr.Text = "" Then
            MsgBox("Password Kosong", vbCritical, "Error!!")
        Else
            MsgBox("Username atau Password salah!", vbCritical, "Error!!")
        End If

        txt_passlogin_mgr.Text = ""
        txt_userlogin_mgr.Text = ""

    End Sub

    'perintah untuk tombol kembali
    Private Sub btn_backlogin_mgr_Click(sender As Object, e As EventArgs) Handles btn_backlogin_mgr.Click
        Form_Login.Show()
        Me.Hide()
    End Sub

End Class