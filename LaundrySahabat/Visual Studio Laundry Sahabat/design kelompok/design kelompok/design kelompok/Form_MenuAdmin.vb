Public Class Form_MenuAdmin

    Private Sub btn_tambah_adm_Click(sender As Object, e As EventArgs) Handles btn_tambah_adm.Click
        Form_tbhCucian.Show()
    End Sub

    Private Sub btn_ambil_adm_Click(sender As Object, e As EventArgs) Handles btn_ambil_adm.Click
        Form_ambilLaundry.Show()
    End Sub

    Private Sub btn_datalaundry_adm_Click(sender As Object, e As EventArgs) Handles btn_datalaundry_adm.Click
        Form_DataLaundry_Adm.Show()
    End Sub

    Private Sub btn_logout_adm_Click(sender As Object, e As EventArgs) Handles btn_logout_adm.Click
        Form_Logout.Show()
    End Sub
End Class