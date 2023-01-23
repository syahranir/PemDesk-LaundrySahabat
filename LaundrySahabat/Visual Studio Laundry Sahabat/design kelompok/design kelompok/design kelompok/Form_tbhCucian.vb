Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Form_tbhCucian
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
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
        cb_jk_tc.Text = ""
    End Sub

    'koneksi dengan database
    Sub koneksi()
        MyDB = "data source=DESKTOP-J44KVH6\SQLEXPRESS;initial catalog=DB_LAUNDRY;integrated security=true"
        conn = New SqlConnection(MyDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    'membuat kondisi awal
    Sub KondisiAwal()
        LV_tc.Items.Clear()
        comm = New SqlCommand("SELECT id_cust, nama_cust, alamat_cust, jk_cust, telp_cust, tgl_masuk, tgl_ambil, berat_cucian FROM TBL_CUSTOMER", conn)
        Dr = comm.ExecuteReader()
        If Dr.HasRows Then
            While Dr.Read()
                LV_tc.Items.Add(Dr.Item(0))
                LV_tc.Items(LV_tc.Items.Count - 1).SubItems.Add(Dr.Item(1))
                LV_tc.Items(LV_tc.Items.Count - 1).SubItems.Add(Dr.Item(2))
                LV_tc.Items(LV_tc.Items.Count - 1).SubItems.Add(Dr.Item(3))
                LV_tc.Items(LV_tc.Items.Count - 1).SubItems.Add(Dr.Item(4))
                LV_tc.Items(LV_tc.Items.Count - 1).SubItems.Add(Dr.Item(5))
                LV_tc.Items(LV_tc.Items.Count - 1).SubItems.Add(Dr.Item(6))
                LV_tc.Items(LV_tc.Items.Count - 1).SubItems.Add(Dr.Item(7))
            End While
            Dr.Close()
        End If
        Dr.Close()
        comm.Dispose()
        Call KosongkanData()
    End Sub
    'form load
    Private Sub Form_tbhCucian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_jk_tc.Items.Clear()
        cb_jk_tc.Items.Add("Laki-Laki")
        cb_jk_tc.Items.Add("Perempuan")

        Call koneksi()
        Call KondisiAwal()
    End Sub

    'perintah untuk tombol simpan
    Private Sub btn_simpan_tc_Click(sender As Object, e As EventArgs) Handles btn_simpan_tc.Click
        If txt_idcust_tc.Text = "" Or txt_nama_tc.Text = "" Or txt_almt_tc.Text = "" Or cb_jk_tc.Text = "" Or txt_telp_tc.Text = "" Or dtp_tglmasuk_tc.Text = "" Or dtp_tglambil_tc.Text = "" Or txt_berat_tc.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan isi semua field", vbInformation, "Hint")
        Else
            Call koneksi()
            Dim InputData As String = "insert into TBL_CUSTOMER values ('" & txt_idcust_tc.Text & "', '" & txt_nama_tc.Text & "', '" & txt_almt_tc.Text & "','" & cb_jk_tc.Text & "',  '" & txt_telp_tc.Text & "', '" & dtp_tglmasuk_tc.Value.ToString("yyyy-MM-dd") & "', '" & dtp_tglambil_tc.Value.ToString("yyyy-MM-dd") & "','" & txt_berat_tc.Text & "' )"
            comm = New SqlCommand(InputData, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Diinput")

            Call KondisiAwal()
        End If
    End Sub

    'perintah untuk tombol edit
    Private Sub btn_edit_tc_Click(sender As Object, e As EventArgs) Handles btn_edit_tc.Click
        If txt_idcust_tc.Text = "" Or txt_nama_tc.Text = "" Or txt_almt_tc.Text = "" Or cb_jk_tc.Text = "" Or txt_telp_tc.Text = "" Or dtp_tglmasuk_tc.Text = "" Or dtp_tglambil_tc.Text = "" Or txt_berat_tc.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan isi semua field", vbInformation, "Hint")
        Else
            Call koneksi()
            Dim EditData As String = "update TBL_CUSTOMER set nama_cust ='" & txt_nama_tc.Text & "', alamat_cust ='" & txt_almt_tc.Text & "', jk_cust ='" & cb_jk_tc.Text & "', telp_cust = '" & txt_telp_tc.Text & "', tgl_masuk ='" & dtp_tglmasuk_tc.Value.ToString("yyyy-MM-dd") & "', tgl_ambil = '" & dtp_tglambil_tc.Value.ToString("yyyy-MM-dd") & "', berat_cucian = '" & txt_berat_tc.Text & "' where id_cust = '" & txt_idcust_tc.Text & "'"
            comm = New SqlCommand(EditData, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Diedit")

            Call KondisiAwal()
        End If
    End Sub

    'perintah untuk tombol reset
    Private Sub btn_reset_tc_Click(sender As Object, e As EventArgs) Handles btn_reset_tc.Click
        Call KosongkanData()
    End Sub

    'perintah untuk tombol hapus
    Private Sub btn_hapus_tc_Click(sender As Object, e As EventArgs) Handles btn_hapus_tc.Click
        If txt_idcust_tc.Text = "" Or txt_nama_tc.Text = "" Or txt_almt_tc.Text = "" Or cb_jk_tc.Text = "" Or txt_telp_tc.Text = "" Or dtp_tglmasuk_tc.Text = "" Or dtp_tglambil_tc.Text = "" Or txt_berat_tc.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan isi semua field", vbInformation, "Hint")
        Else
            Call koneksi()
            Dim HapusData As String = "delete TBL_CUSTOMER where id_cust = '" & txt_idcust_tc.Text & "'"
            comm = New SqlCommand(HapusData, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Dihapus")
            Call KondisiAwal()
        End If
    End Sub

    'perintah untuk format tampilan yang ada di struk
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("comic sans MS", 7, FontStyle.Regular)
        Dim f10 As New Font("comic sans MS", 9, FontStyle.Regular)
        Dim f10b As New Font("comic sans MS", 9, FontStyle.Bold)
        Dim f14 As New Font("comic sans MS", 13, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "--------------------------------------------------------------------------"
        e.Graphics.DrawString("LAUNDRY SAHABAT", f14, Brushes.DarkBlue, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl. Wahid Hasyim No.124", f8, Brushes.DarkBlue, centermargin, 27, tengah)
        e.Graphics.DrawString("No.Telp : 0321-1234-5678", f8, Brushes.DarkBlue, centermargin, 40, tengah)

        e.Graphics.DrawString("ID Pelanggan", f10, Brushes.Black, 0, 70)
        e.Graphics.DrawString(":", f10, Brushes.Black, 95, 70)
        e.Graphics.DrawString(txt_idcust_tc.Text, f10, Brushes.Black, 105, 70)

        e.Graphics.DrawString("Nama Pelanggan", f10, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f10, Brushes.Black, 95, 85)
        e.Graphics.DrawString(txt_nama_tc.Text, f10, Brushes.Black, 105, 85)

        e.Graphics.DrawString("Tgl Masuk", f10, Brushes.Black, 0, 115)
        e.Graphics.DrawString(":", f10, Brushes.Black, 95, 115)
        e.Graphics.DrawString(dtp_tglmasuk_tc.Text, f10, Brushes.Black, 105, 115)

        e.Graphics.DrawString("Tgl Ambil", f10, Brushes.Black, 0, 130)
        e.Graphics.DrawString(":", f10, Brushes.Black, 95, 130)
        e.Graphics.DrawString(dtp_tglambil_tc.Text, f10, Brushes.Black, 105, 130)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 150)

        LV_tc.AllowColumnReorder = True

        Dim tinggi As Integer
        tinggi += 100
        e.Graphics.DrawString("Berat Cucian", f10b, Brushes.Black, 50, 90 + tinggi)
        e.Graphics.DrawString(txt_berat_tc.Text & " kg", f10, Brushes.Black, 160, 90 + tinggi)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 130 + tinggi)

        e.Graphics.DrawString("Pelanggan dimohon mengambil cucian", f8, Brushes.DarkBlue, centermargin, 180 + tinggi, tengah)
        e.Graphics.DrawString("pada tanggal ambil yang sesuai dengan struk", f8, Brushes.DarkBlue, centermargin, 195 + tinggi, tengah)
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("costum", 250, 325)
        PD.DefaultPageSettings = pagesetup
    End Sub

    'perintah untuk tombol cetak struk
    Private Sub btn_struk_tc_Click(sender As Object, e As EventArgs) Handles btn_struk_tc.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    'perintah untuk mengeluarkan isi semua textbox secara otomatis dengan mengisikan id cust dan menekan enter di keyboard
    Private Sub txt_idcust_tc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idcust_tc.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            comm = New SqlCommand("select * from TBL_CUSTOMER where id_cust = '" & txt_idcust_tc.Text & "'", conn)
            Dr = comm.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                txt_nama_tc.Text = Dr.Item("nama_cust")
                txt_almt_tc.Text = Dr.Item("alamat_cust")
                cb_jk_tc.Text = Dr.Item("jk_cust")
                txt_telp_tc.Text = Dr.Item("telp_cust")
                dtp_tglmasuk_tc.Text = Dr.Item("tgl_masuk")
                dtp_tglambil_tc.Text = Dr.Item("tgl_ambil")
                txt_berat_tc.Text = Dr.Item("berat_cucian")
            Else
                MsgBox("Data tidak ada!")
            End If
        End If
    End Sub

    'perintah untuk tombol kembali
    Private Sub btn_kembali_tc_Click(sender As Object, e As EventArgs) Handles btn_kembali_tc.Click
        Form_MenuAdmin.Show()
        Me.Hide()
    End Sub

End Class