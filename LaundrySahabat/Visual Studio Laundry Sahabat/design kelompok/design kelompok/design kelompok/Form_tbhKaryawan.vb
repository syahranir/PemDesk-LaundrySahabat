Public Class Form_tbhKaryawan
    Private Sub btn_tambahpgw_tk_Click(sender As Object, e As EventArgs) Handles btn_tambahpgw_tk.Click
        Form_tbhPegawai.Show()
        Me.Hide()
    End Sub

    Private Sub btn_tambahadm_tk_Click(sender As Object, e As EventArgs) Handles btn_tambahadm_tk.Click
        Form_tbhAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btn_kembali_tk_Click(sender As Object, e As EventArgs) Handles btn_kembali_tk.Click
        Form_MenuManager.Show()
        Me.Hide()
    End Sub

End Class