Imports System.Data.SqlClient
Public Class Form_DataLaundry_Mng
    Dim conn As New SqlConnection
    Dim Da As SqlDataAdapter
    Dim comm As New SqlCommand
    Dim Dr As SqlDataReader
    Dim Ds As DataSet
    Dim MyDB As String
    Dim ctr As Control

    'koneksi dengan database
    Sub koneksi()
        MyDB = "data source=DESKTOP-J44KVH6\SQLEXPRESS;initial catalog=DB_LAUNDRY;integrated security=true"
        conn = New SqlConnection(MyDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    'form load, menampilkan data di gridview
    Private Sub Form_rekapData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total()
        Call koneksi()
        Da = New SqlDataAdapter("SELECT * FROM TBL_TRANSAKSI_LAUNDRY", conn)
        Ds = New DataSet
        Da.Fill(Ds, "c")
        dgv_datalaundry.DataSource = Ds
        dgv_datalaundry.DataMember = "c"

    End Sub

    'perintah untuk tombol cari, dengan memasukkan kode transaksi, menekan tombol cari, jika data ada maka akan ditampilkan datanya, jika tidak akan muncul msgbox Kode tidak ada
    Private Sub btn_cari_dl_Click(sender As Object, e As EventArgs) Handles btn_cari_dl.Click
        Call koneksi()
        comm = New SqlCommand("select * from TBL_TRANSAKSI_LAUNDRY where kode_transaksi = '" & txt_cari_dl.Text & "'", conn)
        Dr = comm.ExecuteReader()
        Dr.Read()
        If Dr.HasRows Then
            Call koneksi()
            Da = New SqlDataAdapter("select * from TBL_TRANSAKSI_LAUNDRY where kode_transaksi = '" & txt_cari_dl.Text & "'", conn)
            Ds = New DataSet
            Da.Fill(Ds)
            dgv_datalaundry.DataSource = Ds.Tables(0)
        Else
            MsgBox("Kode tidak ada!")
        End If
        txt_cari_dl.Text = ""

    End Sub

    'perintah untuk menjumlah semua total yang ada pada gridview
    Sub total()
        koneksi()
        Dim total As Double
        total = 0
        For t As Integer = 0 To dgv_datalaundry.Rows.Count - 1
            total = total + Val(dgv_datalaundry.Rows(t).Cells(4).Value)
        Next
        txt_totalPemasukan.Text = total
    End Sub

    'perintah untuk tombol total pemasukan dengan memanggil total()
    Private Sub btn_totalpemasukan_dl_Click(sender As Object, e As EventArgs) Handles btn_totalpemasukan_dl.Click
        Call total()
    End Sub

    'perintah untuk tombol refresh yang akan kembali memunculkan semua data di gridview 
    Private Sub btn_refresh_dl_Click(sender As Object, e As EventArgs) Handles btn_refresh_dl.Click
        Call koneksi()
        comm = New SqlCommand("SELECT * FROM TBL_TRANSAKSI_LAUNDRY", conn)
        Da = New SqlDataAdapter
        Da.SelectCommand = comm
        Ds = New DataSet
        Da.Fill(Ds, "c")
        dgv_datalaundry.DataSource = Ds
        dgv_datalaundry.DataMember = "c"
    End Sub

    'perintah untuk tombol kembali
    Private Sub btn_kembali_dl_Click(sender As Object, e As EventArgs) Handles btn_kembali_dl.Click
        Form_MenuManager.Show()
        Me.Hide()
    End Sub
End Class