Imports System.Data.SqlClient
Public Class Form_tbhAdmin
    Dim conn As New SqlConnection
    Dim Da As SqlDataAdapter
    Dim comm As New SqlCommand
    Dim Dr As SqlDataReader
    Dim Ds As DataSet
    Dim MyDB As String
    Dim ctr As Control

    'kosongkan data untuk mengosongkan semua textbox dan combobox yang akan digunakan pada tombol reset
    Sub KosongkanData()
        For Each ctr In Me.Controls
            If TypeOf (ctr) Is TextBox Then
                ctr.Text = ""
            End If
        Next
        cb_jk_adm.Text = ""
    End Sub

    'koneksi dengan database
    Sub koneksi()
        MyDB = "data source=DESKTOP-J44KVH6\SQLEXPRESS;initial catalog=DB_LAUNDRY;integrated security=true"
        conn = New SqlConnection(MyDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    'membuat kondisi awal
    Sub KondisiAwal()
        LV_adm.Items.Clear()
        comm = New SqlCommand("SELECT id_adm, usn_adm, pass_adm, nama_adm, tgl_masuk_adm, jk_adm, telp_adm, alamat_adm FROM TBL_ADMIN", conn)
        Dr = comm.ExecuteReader()
        If Dr.HasRows Then
            While Dr.Read()
                LV_adm.Items.Add(Dr.Item(0))
                LV_adm.Items(LV_adm.Items.Count - 1).SubItems.Add(Dr.Item(1))
                LV_adm.Items(LV_adm.Items.Count - 1).SubItems.Add(Dr.Item(2))
                LV_adm.Items(LV_adm.Items.Count - 1).SubItems.Add(Dr.Item(3))
                LV_adm.Items(LV_adm.Items.Count - 1).SubItems.Add(Dr.Item(4))
                LV_adm.Items(LV_adm.Items.Count - 1).SubItems.Add(Dr.Item(5))
                LV_adm.Items(LV_adm.Items.Count - 1).SubItems.Add(Dr.Item(6))
                LV_adm.Items(LV_adm.Items.Count - 1).SubItems.Add(Dr.Item(7))

            End While
            Dr.Close()
        End If
        Dr.Close()
        comm.Dispose()
        Call KosongkanData()
    End Sub
    'form load
    Private Sub Form_tbhAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_id_adm.Select()
        cb_jk_adm.Items.Clear()
        cb_jk_adm.Items.Add("Laki-Laki")
        cb_jk_adm.Items.Add("Perempuan")
        Call koneksi()
        Call KondisiAwal()
    End Sub

    'perintah untuk tombol simpan
    Public Sub btn_simpan_adm_Click(sender As Object, e As EventArgs) Handles btn_simpan_adm.Click
        If txt_id_adm.Text = "" Or txt_user_adm.Text = "" Or txt_pw_adm.Text = "" Or txt_nama_adm.Text = "" Or dtp_tgl_adm.Text = "" Or cb_jk_adm.Text = "" Or txt_telp_adm.Text = "" Or txt_alamat_adm.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan isi semua field", vbInformation, "Hint")
        Else Call koneksi()
            Dim InputData As String = "insert into TBL_ADMIN values ('" & txt_id_adm.Text & "', '" & txt_user_adm.Text & "', '" & txt_pw_adm.Text & "', '" & txt_nama_adm.Text & "', '" & dtp_tgl_adm.Value.ToString("yyyy-MM-dd") & "', '" & cb_jk_adm.Text & "', '" & txt_telp_adm.Text & "' , '" & txt_alamat_adm.Text & "')"
            comm = New SqlCommand(InputData, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Diinput")
            Call KondisiAwal()
        End If
    End Sub

    'perintah untuk tombol edit
    Private Sub btn_edit_adm_Click(sender As Object, e As EventArgs) Handles btn_edit_adm.Click
        If txt_id_adm.Text = "" Or txt_user_adm.Text = "" Or txt_pw_adm.Text = "" Or txt_nama_adm.Text = "" Or dtp_tgl_adm.Text = "" Or cb_jk_adm.Text = "" Or txt_telp_adm.Text = "" Or txt_alamat_adm.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan isi semua field", vbInformation, "Hint")
        Else
            Call koneksi()
            Dim EditData As String = "update TBL_ADMIN set usn_adm ='" & txt_user_adm.Text & "', pass_adm ='" & txt_pw_adm.Text & "', nama_adm ='" & txt_nama_adm.Text & "', tgl_masuk_adm ='" & dtp_tgl_adm.Value.ToString("yyyy-MM-dd") & "',jk_adm ='" & cb_jk_adm.Text & "', telp_adm = '" & txt_telp_adm.Text & "', alamat_adm = '" & txt_alamat_adm.Text & "' where id_adm = '" & txt_id_adm.Text & "'"
            comm = New SqlCommand(EditData, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Diedit")

            Call KondisiAwal()
        End If

    End Sub

    'perintah utuk tombol reset
    Private Sub btn_reset_adm_Click(sender As Object, e As EventArgs) Handles btn_reset_adm.Click
        Call KosongkanData()
    End Sub

    'perintah untuk tombol hapus
    Private Sub btn_hapus_adm_Click(sender As Object, e As EventArgs) Handles btn_hapus_adm.Click
        If txt_id_adm.Text = "" Or txt_user_adm.Text = "" Or txt_pw_adm.Text = "" Or txt_nama_adm.Text = "" Or dtp_tgl_adm.Text = "" Or cb_jk_adm.Text = "" Or txt_telp_adm.Text = "" Or txt_alamat_adm.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan isi semua field", vbInformation, "Hint")
        Else
            Call koneksi()
            Dim HapusData As String = "delete TBL_ADMIN where id_adm = '" & txt_id_adm.Text & "'"
            comm = New SqlCommand(HapusData, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Dihapus")

            Call KondisiAwal()
        End If

    End Sub

    'perintah untuk mengeluarkan isi semua textbox secara otomatis dengan mengisikan id admin dan menekan enter di keyboard
    Private Sub txt_id_adm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_id_adm.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            comm = New SqlCommand("select * from TBL_ADMIN where id_adm = '" & txt_id_adm.Text & "'", conn)
            Dr = comm.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                txt_user_adm.Text = Dr.Item("usn_adm")
                txt_pw_adm.Text = Dr.Item("pass_adm")
                txt_nama_adm.Text = Dr.Item("nama_adm")
                dtp_tgl_adm.Text = Dr.Item("tgl_masuk_adm")
                cb_jk_adm.Text = Dr.Item("jk_adm")
                txt_telp_adm.Text = Dr.Item("telp_adm")
                txt_alamat_adm.Text = Dr.Item("alamat_adm")
            Else
                MsgBox("Data tidak ada!")
            End If
        End If
    End Sub

    'perintah untuk tombol kembali
    Private Sub btn_back_admin_Click(sender As Object, e As EventArgs) Handles btn_back_admin.Click
        Form_tbhKaryawan.Show()
        Me.Hide()
    End Sub
End Class