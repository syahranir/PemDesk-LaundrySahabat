Imports System.Data.SqlClient
Public Class Form_loginAdmin
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

    'perintah untuk tombol login admin yang username dan passwordnya dibuat dari tambah admin
    Private Sub btn_login_adm_Click(sender As Object, e As EventArgs) Handles btn_login_adm.Click
        Call koneksi()
        Dim InputData As String = "select * from tbl_admin where usn_adm = '" & Trim(txt_userlogin_adm.Text) & "'"
        comm = New SqlCommand(InputData, conn)
        comm.ExecuteNonQuery()
        comm = New SqlCommand(InputData, conn)
        Dr = comm.ExecuteReader()
        If Dr.HasRows = False Then
            MsgBox("Username Tidak Ditemukan!", vbCritical + vbOKOnly, "Error")
            txt_userlogin_adm.Focus()
            txt_userlogin_adm.Text = ""
            txt_passlogin_adm.Text = ""
            Exit Sub
        End If
        Dr.Close()
        comm.Dispose()

        InputData = "select * from tbl_admin where usn_adm = '" & Trim(txt_userlogin_adm.Text) & "' and pass_adm = '" & Trim(txt_passlogin_adm.Text) & "'"
        comm = New SqlCommand(InputData, conn)
        comm.ExecuteNonQuery()
        comm = New SqlCommand(InputData, conn)
        Dr = comm.ExecuteReader()
        If Dr.HasRows = False Then
            MsgBox("Password Salah!", vbCritical + vbOKOnly, "Error")
            txt_passlogin_adm.Focus()
            txt_passlogin_adm.Text = ""
            txt_userlogin_adm.Text = ""
            Exit Sub
        Else
            Form_MenuAdmin.Show()
            Me.Hide()
        End If
        Dr.Close()
        comm.Dispose()

        txt_passlogin_adm.Text = ""
        txt_userlogin_adm.Text = ""
    End Sub

    'perintah untuk tombol kembali
    Private Sub btn_backlogin_adm_Click(sender As Object, e As EventArgs) Handles btn_backlogin_adm.Click
        Form_Login.Show()
        Me.Hide()
    End Sub


End Class