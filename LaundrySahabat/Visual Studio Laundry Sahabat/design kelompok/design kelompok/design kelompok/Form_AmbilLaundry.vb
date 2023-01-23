Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Form_ambilLaundry
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
    End Sub

    'koneksi dengan database
    Sub koneksi()
        MyDB = "data source=DESKTOP-J44KVH6\SQLEXPRESS;initial catalog=DB_LAUNDRY;integrated security=true"
        conn = New SqlConnection(MyDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    'membuat kondisi awal
    Sub KondisiAwal()
        LV_transaksi.Items.Clear()
        comm = New SqlCommand("SELECT kode_transaksi, tgl_transaksi, id_adm , id_cust, total_harga, bayar, kembali FROM TBL_TRANSAKSI_LAUNDRY", conn)
        Dr = comm.ExecuteReader()
        If Dr.HasRows Then
            While Dr.Read()
                LV_transaksi.Items.Add(Dr.Item(0))
                LV_transaksi.Items(LV_transaksi.Items.Count - 1).SubItems.Add(Dr.Item(1))
                LV_transaksi.Items(LV_transaksi.Items.Count - 1).SubItems.Add(Dr.Item(2))
                LV_transaksi.Items(LV_transaksi.Items.Count - 1).SubItems.Add(Dr.Item(3))
                LV_transaksi.Items(LV_transaksi.Items.Count - 1).SubItems.Add(Dr.Item(4))
                LV_transaksi.Items(LV_transaksi.Items.Count - 1).SubItems.Add(Dr.Item(5))
                LV_transaksi.Items(LV_transaksi.Items.Count - 1).SubItems.Add(Dr.Item(6))
            End While
            Dr.Close()
        End If
        Dr.Close()
        comm.Dispose()
        Call KosongkanData()
    End Sub
    'form load
    Private Sub Form_ambilLaundry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call KondisiAwal()
    End Sub

    'perintah untuk tombol simpan
    Private Sub btn_simpan_al_Click(sender As Object, e As EventArgs) Handles btn_simpan_al.Click
        If txt_kodetrans_al.Text = "" Or dtp_tgltrans_al.Text = "" Or txt_idadm_al.Text = "" Or txt_idcust_al.Text = "" Or txt_total_al.Text = "" Or txt_bayar_al.Text = "" Or txt_kembalian_al.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan isi semua field", vbInformation, "Hint")
        Else
            Call koneksi()
            Dim InputData As String = "insert into TBL_TRANSAKSI_LAUNDRY values ('" & txt_kodetrans_al.Text & "', '" & dtp_tgltrans_al.Value.ToString("yyyy-MM-dd") & "', '" & txt_idadm_al.Text & "','" & txt_idcust_al.Text & "', '" & txt_total_al.Text & "',  '" & txt_bayar_al.Text & "', '" & txt_kembalian_al.Text & "' )"
            comm = New SqlCommand(InputData, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Diinput")

            Call KondisiAwal()
        End If
    End Sub

    'perintah untuk tombol edit
    Private Sub btn_edit_al_Click(sender As Object, e As EventArgs) Handles btn_edit_al.Click
        If txt_kodetrans_al.Text = "" Or dtp_tgltrans_al.Text = "" Or txt_idadm_al.Text = "" Or txt_idcust_al.Text = "" Or txt_total_al.Text = "" Or txt_bayar_al.Text = "" Or txt_kembalian_al.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan isi semua field", vbInformation, "Hint")
        Else
            Call koneksi()
            Dim EditData As String = "update TBL_TRANSAKSI_LAUNDRY set tgl_transaksi ='" & dtp_tgltrans_al.Value.ToString("yyyy-MM-dd") & "', id_adm ='" & txt_idadm_al.Text & "',id_cust ='" & txt_idcust_al.Text & "', total_harga = '" & txt_total_al.Text & "', bayar = '" & txt_bayar_al.Text & "', kembali = '" & txt_kembalian_al.Text & "' where kode_transaksi = '" & txt_kodetrans_al.Text & "'"
            comm = New SqlCommand(EditData, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Diedit")

            Call KondisiAwal()
        End If
    End Sub

    'perintah untuk tombol reset
    Private Sub btn_reset_al_Click(sender As Object, e As EventArgs) Handles btn_reset_al.Click
        Call KosongkanData()
    End Sub

    'perintah untuk tombol hapus
    Private Sub btn_hapus_al_Click(sender As Object, e As EventArgs) Handles btn_hapus_al.Click
        If txt_kodetrans_al.Text = "" Or dtp_tgltrans_al.Text = "" Or txt_idadm_al.Text = "" Or txt_idcust_al.Text = "" Or txt_total_al.Text = "" Or txt_bayar_al.Text = "" Or txt_kembalian_al.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan isi semua field", vbInformation, "Hint")
        Else
            Call koneksi()
            Dim HapusData As String = "delete TBL_TRANSAKSI_LAUNDRY where kode_transaksi = '" & txt_kodetrans_al.Text & "'"
            comm = New SqlCommand(HapusData, conn)
            comm.ExecuteNonQuery()
            MsgBox("Data Berhasil Dihapus")

            Call KondisiAwal()
        End If
    End Sub

    'menghitung berat cucian dikalikan dengan harga laundry per kilo
    Sub hitung()
        Dim p, total As Integer
        p = txt_berat_al.Text
        total = p * 7000
        txt_total_al.Text = total
    End Sub

    'menghitung uang kembalian 
    Sub kembalian()
        Dim q, r, kembali As Integer
        q = txt_bayar_al.Text
        r = txt_total_al.Text
        kembali = q - r
        txt_kembalian_al.Text = kembali
    End Sub

    'perintah untuk tombol total dengan memanggil hitung()
    Private Sub btn_total_al_Click(sender As Object, e As EventArgs) Handles btn_total_al.Click
        hitung()
    End Sub

    'perintah untuk tombol kembalian denga memanggil kembalian()
    Private Sub btn_kembalian_al_Click(sender As Object, e As EventArgs) Handles btn_kembalian_al.Click
        kembalian()
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

        e.Graphics.DrawString("Kode Transaksi", f10, Brushes.Black, 0, 70)
        e.Graphics.DrawString(":", f10, Brushes.Black, 95, 70)
        e.Graphics.DrawString(txt_kodetrans_al.Text, f10, Brushes.Black, 105, 70)

        e.Graphics.DrawString("Nama Admin", f10, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f10, Brushes.Black, 95, 85)
        e.Graphics.DrawString(txt_namaadm_al.Text, f10, Brushes.Black, 105, 85)

        e.Graphics.DrawString("Tgl Transaksi", f10, Brushes.Black, 0, 100)
        e.Graphics.DrawString(":", f10, Brushes.Black, 95, 100)
        e.Graphics.DrawString(txt_tglambil_al.Text, f10, Brushes.Black, 105, 100)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 120)

        LV_transaksi.AllowColumnReorder = True

        Dim tinggi As Integer
        tinggi += 15
        e.Graphics.DrawString("Nama Pelanggan : ", f10b, Brushes.Black, 0, 120 + tinggi)
        e.Graphics.DrawString(txt_namacust_al.Text, f10, Brushes.Black, 110, 120 + tinggi)

        e.Graphics.DrawString("Berat Cucian", f10b, Brushes.Black, 40, 150 + tinggi)
        e.Graphics.DrawString("Total", f10b, Brushes.Black, 180, 150 + tinggi)

        e.Graphics.DrawString(txt_berat_al.Text & " kg", f10, Brushes.Black, 70, 170 + tinggi)
        e.Graphics.DrawString(txt_total_al.Text, f10, Brushes.Black, 180, 170 + tinggi)

        tinggi = 190 + tinggi
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, tinggi)
        e.Graphics.DrawString("Total", f10b, Brushes.Black, 135, 15 + tinggi)
        e.Graphics.DrawString(":", f10b, Brushes.Black, 190, 15 + tinggi)
        e.Graphics.DrawString(txt_total_al.Text, f10, Brushes.Black, rightmargin, 15 + tinggi, kanan)
        e.Graphics.DrawString("Bayar", f10b, Brushes.Black, 135, 30 + tinggi)
        e.Graphics.DrawString(":", f10b, Brushes.Black, 190, 30 + tinggi)
        e.Graphics.DrawString(txt_bayar_al.Text, f10, Brushes.Black, rightmargin, 30 + tinggi, kanan)
        e.Graphics.DrawString("Kembali", f10b, Brushes.Black, 135, 45 + tinggi)
        e.Graphics.DrawString(":", f10b, Brushes.Black, 190, 45 + tinggi)
        e.Graphics.DrawString(txt_kembalian_al.Text, f10, Brushes.Black, rightmargin, 45 + tinggi, kanan)

        e.Graphics.DrawString("Terimakasih sudah berkunjung ke laundry kami", f8, Brushes.DarkBlue, centermargin, 90 + tinggi, tengah)
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("costum", 250, 325)
        PD.DefaultPageSettings = pagesetup
    End Sub

    'perintah untuk mengeluarkan isi textbox tgl transaksi, id admin, id cust, total harga, bayar, kembalian secara otomatis dengan mengisikan kode transaksi dan menekan enter di keyboard
    Private Sub txt_kodetrans_al_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_kodetrans_al.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            comm = New SqlCommand("select * from TBL_TRANSAKSI_LAUNDRY where kode_transaksi = '" & txt_kodetrans_al.Text & "'", conn)
            Dr = comm.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                dtp_tgltrans_al.Text = Dr.Item("tgl_transaksi")
                txt_idadm_al.Text = Dr.Item("id_adm")
                txt_idcust_al.Text = Dr.Item("id_cust")
                txt_total_al.Text = Dr.Item("total_harga")
                txt_bayar_al.Text = Dr.Item("bayar")
                txt_kembalian_al.Text = Dr.Item("kembali")
            Else
                MsgBox("Data tidak ada!")
            End If
        End If
    End Sub

    'perintah untuk tombol cetak struk
    Private Sub btn_struk_al_Click(sender As Object, e As EventArgs) Handles btn_struk_al.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    'perintah untuk mengeluarkan isi textbox nama admin secara otomatis dengan mengisikan id admin dan menekan enter di keyboard
    Private Sub txt_idadm_al_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idadm_al.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            comm = New SqlCommand("select * from TBL_ADMIN where id_adm = '" & txt_idadm_al.Text & "'", conn)
            Dr = comm.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                txt_namaadm_al.Text = Dr.Item("nama_adm")
            Else
                MsgBox("Kode Tidak Ada!")
            End If
        End If
    End Sub

    'perintah untuk mengeluarkan isi textbox nama cust, tgl ambil, berat cucian secara otomatis dengan mengisikan id pelanggan dan menekan enter di keyboard
    Private Sub txt_idcust_al_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idcust_al.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            comm = New SqlCommand("select * from TBL_CUSTOMER where id_cust = '" & txt_idcust_al.Text & "'", conn)
            Dr = comm.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                txt_namacust_al.Text = Dr.Item("nama_cust")
                txt_tglambil_al.Text = Dr.Item("tgl_ambil")
                txt_berat_al.Text = Dr.Item("berat_cucian")
            Else
                MsgBox("Data Tidak Ada!")
            End If
        End If
    End Sub

    'perintah untuk tombol kembali
    Private Sub btn_kembali_al_Click(sender As Object, e As EventArgs) Handles btn_kembali_al.Click
        Form_MenuAdmin.Show()
        Me.Hide()
    End Sub

End Class