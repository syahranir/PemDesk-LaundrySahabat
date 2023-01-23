Imports System.Data.SqlClient
Public Class Form_DataPegawai
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
    Private Sub dataPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        comm = New SqlCommand("SELECT * FROM TBL_PEGAWAI", conn)
        Da = New SqlDataAdapter
        Da.SelectCommand = comm
        Ds = New DataSet
        Da.Fill(Ds, "c")
        dgv_datapegawai.DataSource = Ds
        dgv_datapegawai.DataMember = "c"
    End Sub

    'perintah untuk tombol cari, dengan memasukkan ID pegawai, menekan tombol cari, jika data ada maka akan ditampilkan datanya, jika tidak akan muncul msgbox ID tidak ada
    Private Sub btn_caripegawai_dP_Click(sender As Object, e As EventArgs) Handles btn_caripegawai_dP.Click
        Call koneksi()
        comm = New SqlCommand("select * from TBL_PEGAWAI where id_pegawai = '" & txt_caripegawai_dk.Text & "'", conn)
        Dr = comm.ExecuteReader()
        Dr.Read()
        If Dr.HasRows Then
            Call koneksi()
            Da = New SqlDataAdapter("select * from TBL_PEGAWAI where id_pegawai = '" & txt_caripegawai_dk.Text & "'", conn)
            Ds = New DataSet
            Da.Fill(Ds)
            dgv_datapegawai.DataSource = Ds.Tables(0)
        Else
            MsgBox("ID tidak ada!")
        End If
    End Sub

    'perintah untuk tombol refresh yang akan kembali memunculkan semua data di gridview 
    Private Sub btn_refresh_dp_Click(sender As Object, e As EventArgs) Handles btn_refresh_dp.Click
        Call koneksi()
        comm = New SqlCommand("SELECT * FROM TBL_PEGAWAI", conn)
        Da = New SqlDataAdapter
        Da.SelectCommand = comm
        Ds = New DataSet
        Da.Fill(Ds, "c")
        dgv_datapegawai.DataSource = Ds
        dgv_datapegawai.DataMember = "c"
    End Sub

    'perintah untuk tombol kembali
    Private Sub btn_kembali_dp_Click(sender As Object, e As EventArgs) Handles btn_kembali_dp.Click
        Form_MenuManager.Show()
        Me.Hide()
    End Sub
End Class