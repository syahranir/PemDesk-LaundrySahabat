Imports System.Data.SqlClient
Public Class Form_DataAdmin
    Dim conn As New SqlConnection
    Dim Da As SqlDataAdapter
    Dim comm As New SqlCommand
    Dim Dr As SqlDataReader
    Dim Ds As DataSet
    Dim MyDB As String
    Dim ctr As Control
    Public sql As String
    Dim Dt As New DataTable

    'koneksi dengan database
    Sub koneksi()
        MyDB = "data source=DESKTOP-J44KVH6\SQLEXPRESS;initial catalog=DB_LAUNDRY;integrated security=true"
        conn = New SqlConnection(MyDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    'form load, menampilkan data di gridview
    Private Sub DataAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Da = New SqlDataAdapter("SELECT * FROM TBL_ADMIN", conn)
        Ds = New DataSet
        Da.Fill(Ds, "c")
        dgv_dataadm.DataSource = Ds
        dgv_dataadm.DataMember = "c"
    End Sub

    'Mencari id admin yang ada dalam gridview, jika ada akan ditampilkan datanya, jika tidak akan muncul msgbox ID tidak ada
    Sub carikode()
        Call koneksi()
        comm = New SqlCommand("select * from TBL_ADMIN where id_adm = '" & txt_cariadm_da.Text & "'", conn)
        Dr = comm.ExecuteReader()
        Dr.Read()
        If Dr.HasRows Then
            Call koneksi()
            Da = New SqlDataAdapter("select * from TBL_ADMIN where id_adm = '" & txt_cariadm_da.Text & "'", conn)
            Ds = New DataSet
            Da.Fill(Ds)
            dgv_dataadm.DataSource = Ds.Tables(0)
        Else
            MsgBox("ID tidak ada!")
        End If
    End Sub

    'perintah untuk tombol cari
    Private Sub btn_cariadm_da_Click(sender As Object, e As EventArgs) Handles btn_cariadm_da.Click
        Call carikode()
        txt_cariadm_da.Text = ""
    End Sub

    'perintah untuk tombol refresh yang akan kembali memunculkan data semua tabel 
    Private Sub btn_refresh_da_Click(sender As Object, e As EventArgs) Handles btn_refresh_da.Click
        Call koneksi()
        comm = New SqlCommand("SELECT * FROM TBL_ADMIN", conn)
        Da = New SqlDataAdapter
        Da.SelectCommand = comm
        Ds = New DataSet
        Da.Fill(Ds, "c")
        dgv_dataadm.DataSource = Ds
        dgv_dataadm.DataMember = "c"
    End Sub

    'perintah untuk tombol kembali
    Private Sub btn_kembali_da_Click(sender As Object, e As EventArgs) Handles btn_kembali_da.Click
        Form_MenuManager.Show()
        Me.Hide()
    End Sub

End Class