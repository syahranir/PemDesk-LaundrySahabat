Imports System.Data.SqlClient
Public Class Form_DataLaundry_Adm
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
    Private Sub Data_Laundry_adm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        comm = New SqlCommand("SELECT * FROM TBL_TRANSAKSI_LAUNDRY", conn)
        Da = New SqlDataAdapter
        Da.SelectCommand = comm
        Ds = New DataSet
        Da.Fill(Ds, "c")
        dgv_datalaundry_adm.DataSource = Ds
        dgv_datalaundry_adm.DataMember = "c"

    End Sub

    'perintah untuk tombol cari, dengan memasukkan kode transaksi, menekan tombol cari, jika data ada maka akan ditampilkan datanya, jika tidak akan muncul msgbox Kode tidak ada
    Private Sub btn_cari_dladm_Click(sender As Object, e As EventArgs) Handles btn_cari_dladm.Click
        Call koneksi()
        comm = New SqlCommand("select * from TBL_TRANSAKSI_LAUNDRY where kode_transaksi = '" & txt_cari_dladm.Text & "'", conn)
        Dr = comm.ExecuteReader()
        Dr.Read()
        If Dr.HasRows Then
            Call koneksi()
            Da = New SqlDataAdapter("select * from TBL_TRANSAKSI_LAUNDRY where kode_transaksi = '" & txt_cari_dladm.Text & "'", conn)
            Ds = New DataSet
            Da.Fill(Ds)
            dgv_datalaundry_adm.DataSource = Ds.Tables(0)
        Else
            MsgBox("Kode tidak ada!")
        End If
        txt_cari_dladm.Text = ""
    End Sub

    'perintah untuk menjumlah semua total yang ada pada gridview
    Sub total()
        Dim total As Double
        total = 0
        For t As Integer = 0 To dgv_datalaundry_adm.Rows.Count - 1
            total = total + Val(dgv_datalaundry_adm.Rows(t).Cells(4).Value)
        Next
        txt_totalPemasukan_adm.Text = total
    End Sub

    'perintah untuk tombol total pemasukan dengan memanggil total()
    Private Sub btn_totalpemasukan_dladm_Click(sender As Object, e As EventArgs) Handles btn_totalpemasukan_dladm.Click
        Call total()
    End Sub

    'perintah untuk tombol refresh yang akan kembali memunculkan semua data di gridview 
    Private Sub btn_refresh_dladm_Click(sender As Object, e As EventArgs) Handles btn_refresh_dladm.Click
        Call koneksi()
        comm = New SqlCommand("SELECT * FROM TBL_TRANSAKSI_LAUNDRY", conn)
        Da = New SqlDataAdapter
        Da.SelectCommand = comm
        Ds = New DataSet
        Da.Fill(Ds, "c")
        dgv_datalaundry_adm.DataSource = Ds
        dgv_datalaundry_adm.DataMember = "c"
    End Sub

    'perintah untuk tombol kembali
    Private Sub btn_kembali_dladm_Click(sender As Object, e As EventArgs) Handles btn_kembali_dladm.Click
        Form_MenuAdmin.Show()
        Me.Hide()
    End Sub
End Class