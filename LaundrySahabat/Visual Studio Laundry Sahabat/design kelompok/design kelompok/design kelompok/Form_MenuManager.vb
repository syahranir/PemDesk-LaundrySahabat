Public Class Form_MenuManager
    Private Sub btn_datapgw_mg_Click(sender As Object, e As EventArgs) Handles btn_datapgw_mg.Click
        Form_DataPegawai.Show()

    End Sub

    Private Sub btn_tmbhkaryawan_mg_Click(sender As Object, e As EventArgs) Handles btn_tmbhkaryawan_mg.Click
        Form_tbhKaryawan.Show()

    End Sub

    Private Sub btn_dataadm_mg_Click(sender As Object, e As EventArgs) Handles btn_dataadm_mg.Click
        Form_DataAdmin.Show()

    End Sub

    Private Sub btn_datalaundry_mg_Click(sender As Object, e As EventArgs) Handles btn_datalaundry_mg.Click
        Form_DataLaundry_Mng.Show()

    End Sub

    Private Sub btn_logout_mg_Click(sender As Object, e As EventArgs) Handles btn_logout_mg.Click
        Form_Logout.Show()

    End Sub

    Private Sub Menu_Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class