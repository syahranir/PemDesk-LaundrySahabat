Imports System.Data.SqlClient

Public Class Form_tbhPegawai
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
        cb_jk_pegawai.Text = ""
    End Sub

    'koneksi dengan database
    Sub koneksi()
        MyDB = "data source=DESKTOP-J44KVH6\SQLEXPRESS;initial catalog=DB_LAUNDRY;integrated security=true"
        conn = New SqlConnection(MyDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    'membuat kondisi awal
    Sub KondisiAwal()
        LV_pegawai.Items.Clear()
        comm = New SqlCommand("SELECT id_pegawai, nama_pegawai, tgl_masuk_pegawai, jk_pegawai, alamat_pegawai, telp_pegawai FROM TBL_PEGAWAI", conn)
        Dr = comm.ExecuteReader()
        If Dr.HasRows Then
            While Dr.Read()
                LV_pegawai.Items.Add(Dr.Item(0))
                LV_pegawai.Items(LV_pegawai.Items.Count - 1).SubItems.Add(Dr.Item(1))
                LV_pegawai.Items(LV_pegawai.Items.Count - 1).SubItems.Add(Dr.Item(2))
                LV_pegawai.Items(LV_pegawai.Items.Count - 1).SubItems.Add(Dr.Item(3))
                LV_pegawai.Items(LV_pegawai.Items.Count - 1).SubItems.Add(Dr.Item(4))
                LV_pegawai.Items(LV_pegawai.Items.Count - 1).SubItems.Add(Dr.Item(5))
            End While
            Dr.Close()
        End If
        Dr.Close()
        comm.Dispose()
        Call KosongkanData()
    End Sub
    'form load
    Private Sub Form_tbhPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_id_pegawai.Select()
        cb_jk_pegawai.Items.Clear()
        cb_jk_pegawai.Items.Add("Laki-Laki")
        cb_jk_pegawai.Items.Add("Perempuan")

        Call koneksi()
        Call KondisiAwal()
    End Sub

    'perintah untuk tombol simpan
    Private Sub btn_simpan_pegawai_Click(sender As Object, e As EventArgs) Handles btn_simpan_pegawai.Click
        If txt_id_pegawai.Text = "" Or txt_nama_pegawai.Text = "" Or dtp_tgl_pegawai.Text = "" Or cb_jk_pegawai.Text = "" Or txt_alamat_pegawai.Text = "" Or txt_telp_pegawai.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan isi semua field", vbInformation, "Hint")
        Else
            Call koneksi()
            Dim InputData As String = "insert into TBL_PEGAWAI values ('" & txt_id_pegawai.Text & "', '" & txt_nama_pegawai.Text & "', '" & dtp_tgl_pegawai.Value.ToString("yyyy-MM-dd") & "', '" & cb_jk_pegawai.Text & "', '" & txt_alamat_pegawai.Text & "' , '" & txt_telp_pegawai.Text & "')"
            comm = New SqlCommand(InputData, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Diinput")

            Call KondisiAwal()
        End If

    End Sub

    'peritah untuk tombol edit
    Private Sub btn_edit_pegawai_Click(sender As Object, e As EventArgs) Handles btn_edit_pegawai.Click
        If txt_id_pegawai.Text = "" Or txt_nama_pegawai.Text = "" Or dtp_tgl_pegawai.Text = "" Or cb_jk_pegawai.Text = "" Or txt_alamat_pegawai.Text = "" Or txt_telp_pegawai.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan isi semua field", vbInformation, "Hint")
        Else
            Call koneksi()
            Dim EditData As String = "update TBL_PEGAWAI set nama_pegawai ='" & txt_nama_pegawai.Text & "', tgl_masuk_pegawai ='" & dtp_tgl_pegawai.Value.ToString("yyyy-MM-dd") & "',jk_pegawai ='" & cb_jk_pegawai.Text & "', alamat_pegawai = '" & txt_alamat_pegawai.Text & "', telp_pegawai = '" & txt_telp_pegawai.Text & "' where id_pegawai = '" & txt_id_pegawai.Text & "'"
            comm = New SqlCommand(EditData, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Diedit")

            Call KondisiAwal()
        End If

    End Sub

    'perintah untuk tombol reset
    Private Sub btn_reset_pegawai_Click(sender As Object, e As EventArgs) Handles btn_reset_pegawai.Click
        Call KosongkanData()
    End Sub

    'perintah untuk tombol hapus
    Private Sub btn_hapus_pegawai_Click(sender As Object, e As EventArgs) Handles btn_hapus_pegawai.Click
        If txt_id_pegawai.Text = "" Or txt_nama_pegawai.Text = "" Or dtp_tgl_pegawai.Text = "" Or cb_jk_pegawai.Text = "" Or txt_alamat_pegawai.Text = "" Or txt_telp_pegawai.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan isi semua field", vbInformation, "Hint")
        Else
            Call koneksi()
            Dim HapusData As String = "delete TBL_PEGAWAI where id_pegawai = '" & txt_id_pegawai.Text & "'"
            comm = New SqlCommand(HapusData, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Dihapus")

            Call KondisiAwal()
        End If
    End Sub

    'perintah untuk mengeluarkan isi semua textbox secara otomatis dengan mengisikan id pegawai dan menekan enter di keyboard
    Private Sub txt_id_pegawai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_id_pegawai.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            comm = New SqlCommand("select * from TBL_PEGAWAI where id_pegawai = '" & txt_id_pegawai.Text & "'", conn)
            Dr = comm.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                txt_nama_pegawai.Text = Dr.Item("nama_pegawai")
                dtp_tgl_pegawai.Text = Dr.Item("tgl_masuk_pegawai")
                cb_jk_pegawai.Text = Dr.Item("jk_pegawai")
                txt_alamat_pegawai.Text = Dr.Item("alamat_pegawai")
                txt_telp_pegawai.Text = Dr.Item("telp_pegawai")
            Else
                MsgBox("Data tidak ada!")
            End If
        End If
    End Sub

    'perintah untuk tombol kembali
    Private Sub btn_back_pegawai_Click(sender As Object, e As EventArgs) Handles btn_back_pegawai.Click
        Form_tbhKaryawan.Show()
        Me.Hide()
    End Sub

End Class