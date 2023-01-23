<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ambilLaundry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_total_al = New System.Windows.Forms.Button()
        Me.txt_bayar_al = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_kembalian_al = New System.Windows.Forms.TextBox()
        Me.txt_kodetrans_al = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_edit_al = New System.Windows.Forms.Button()
        Me.LV_transaksi = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_simpan_al = New System.Windows.Forms.Button()
        Me.btn_reset_al = New System.Windows.Forms.Button()
        Me.btn_struk_al = New System.Windows.Forms.Button()
        Me.btn_kembali_al = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_tgltrans_al = New System.Windows.Forms.DateTimePicker()
        Me.btn_hapus_al = New System.Windows.Forms.Button()
        Me.txt_total_al = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_idcust_al = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_berat_al = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_namacust_al = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_idadm_al = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_namaadm_al = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_tglambil_al = New System.Windows.Forms.TextBox()
        Me.btn_kembalian_al = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'btn_total_al
        '
        Me.btn_total_al.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_total_al.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_total_al.Location = New System.Drawing.Point(535, 348)
        Me.btn_total_al.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_total_al.Name = "btn_total_al"
        Me.btn_total_al.Size = New System.Drawing.Size(76, 27)
        Me.btn_total_al.TabIndex = 41
        Me.btn_total_al.Text = "TOTAL"
        Me.btn_total_al.UseVisualStyleBackColor = True
        '
        'txt_bayar_al
        '
        Me.txt_bayar_al.Location = New System.Drawing.Point(647, 380)
        Me.txt_bayar_al.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_bayar_al.Name = "txt_bayar_al"
        Me.txt_bayar_al.Size = New System.Drawing.Size(232, 20)
        Me.txt_bayar_al.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(553, 381)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "BAYAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(618, 414)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 14)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Rp."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(617, 383)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 14)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Rp."
        '
        'txt_kembalian_al
        '
        Me.txt_kembalian_al.Enabled = False
        Me.txt_kembalian_al.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kembalian_al.Location = New System.Drawing.Point(647, 410)
        Me.txt_kembalian_al.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_kembalian_al.Name = "txt_kembalian_al"
        Me.txt_kembalian_al.Size = New System.Drawing.Size(232, 22)
        Me.txt_kembalian_al.TabIndex = 37
        '
        'txt_kodetrans_al
        '
        Me.txt_kodetrans_al.Location = New System.Drawing.Point(172, 85)
        Me.txt_kodetrans_al.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_kodetrans_al.Name = "txt_kodetrans_al"
        Me.txt_kodetrans_al.Size = New System.Drawing.Size(270, 20)
        Me.txt_kodetrans_al.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 87)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 14)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "KODE TRANSAKSI"
        '
        'btn_edit_al
        '
        Me.btn_edit_al.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_edit_al.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_al.Location = New System.Drawing.Point(165, 348)
        Me.btn_edit_al.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_edit_al.Name = "btn_edit_al"
        Me.btn_edit_al.Size = New System.Drawing.Size(95, 49)
        Me.btn_edit_al.TabIndex = 40
        Me.btn_edit_al.Text = "EDIT"
        Me.btn_edit_al.UseVisualStyleBackColor = False
        '
        'LV_transaksi
        '
        Me.LV_transaksi.BackColor = System.Drawing.Color.Beige
        Me.LV_transaksi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LV_transaksi.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV_transaksi.GridLines = True
        Me.LV_transaksi.HideSelection = False
        Me.LV_transaksi.Location = New System.Drawing.Point(12, 191)
        Me.LV_transaksi.Margin = New System.Windows.Forms.Padding(2)
        Me.LV_transaksi.Name = "LV_transaksi"
        Me.LV_transaksi.Size = New System.Drawing.Size(868, 142)
        Me.LV_transaksi.TabIndex = 26
        Me.LV_transaksi.UseCompatibleStateImageBehavior = False
        Me.LV_transaksi.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "KODE TRANSAKSI"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "TGL TRANSAKSI"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID ADMIN"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ID PELANGGAN"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "TOTAL HARGA"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "BAYAR"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "KEMBALI"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 150
        '
        'btn_simpan_al
        '
        Me.btn_simpan_al.BackColor = System.Drawing.Color.White
        Me.btn_simpan_al.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_simpan_al.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan_al.Location = New System.Drawing.Point(61, 347)
        Me.btn_simpan_al.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_simpan_al.Name = "btn_simpan_al"
        Me.btn_simpan_al.Size = New System.Drawing.Size(95, 49)
        Me.btn_simpan_al.TabIndex = 30
        Me.btn_simpan_al.Text = "SIMPAN"
        Me.btn_simpan_al.UseVisualStyleBackColor = False
        '
        'btn_reset_al
        '
        Me.btn_reset_al.BackColor = System.Drawing.Color.White
        Me.btn_reset_al.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_reset_al.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_al.Location = New System.Drawing.Point(264, 348)
        Me.btn_reset_al.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_reset_al.Name = "btn_reset_al"
        Me.btn_reset_al.Size = New System.Drawing.Size(95, 49)
        Me.btn_reset_al.TabIndex = 29
        Me.btn_reset_al.Text = "RESET"
        Me.btn_reset_al.UseVisualStyleBackColor = False
        '
        'btn_struk_al
        '
        Me.btn_struk_al.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_struk_al.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_struk_al.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_struk_al.Location = New System.Drawing.Point(661, 449)
        Me.btn_struk_al.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_struk_al.Name = "btn_struk_al"
        Me.btn_struk_al.Size = New System.Drawing.Size(101, 41)
        Me.btn_struk_al.TabIndex = 28
        Me.btn_struk_al.Text = "CETAK STRUK"
        Me.btn_struk_al.UseVisualStyleBackColor = False
        '
        'btn_kembali_al
        '
        Me.btn_kembali_al.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_kembali_al.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_kembali_al.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kembali_al.Location = New System.Drawing.Point(787, 449)
        Me.btn_kembali_al.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kembali_al.Name = "btn_kembali_al"
        Me.btn_kembali_al.Size = New System.Drawing.Size(92, 41)
        Me.btn_kembali_al.TabIndex = 27
        Me.btn_kembali_al.Text = "KEMBALI"
        Me.btn_kembali_al.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(63, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(318, 38)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "AMBIL LAUNDRY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(60, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 14)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "TANGGAL"
        '
        'dtp_tgltrans_al
        '
        Me.dtp_tgltrans_al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_tgltrans_al.Location = New System.Drawing.Point(172, 110)
        Me.dtp_tgltrans_al.Name = "dtp_tgltrans_al"
        Me.dtp_tgltrans_al.Size = New System.Drawing.Size(270, 20)
        Me.dtp_tgltrans_al.TabIndex = 43
        '
        'btn_hapus_al
        '
        Me.btn_hapus_al.BackColor = System.Drawing.Color.White
        Me.btn_hapus_al.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_hapus_al.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus_al.Location = New System.Drawing.Point(363, 348)
        Me.btn_hapus_al.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hapus_al.Name = "btn_hapus_al"
        Me.btn_hapus_al.Size = New System.Drawing.Size(95, 49)
        Me.btn_hapus_al.TabIndex = 44
        Me.btn_hapus_al.Text = "HAPUS"
        Me.btn_hapus_al.UseVisualStyleBackColor = False
        '
        'txt_total_al
        '
        Me.txt_total_al.Enabled = False
        Me.txt_total_al.Location = New System.Drawing.Point(647, 350)
        Me.txt_total_al.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total_al.Name = "txt_total_al"
        Me.txt_total_al.Size = New System.Drawing.Size(232, 20)
        Me.txt_total_al.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(617, 353)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 14)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Rp."
        '
        'txt_idcust_al
        '
        Me.txt_idcust_al.Location = New System.Drawing.Point(559, 87)
        Me.txt_idcust_al.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_idcust_al.Name = "txt_idcust_al"
        Me.txt_idcust_al.Size = New System.Drawing.Size(270, 20)
        Me.txt_idcust_al.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label10.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(455, 89)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 14)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "ID PELANGGAN"
        '
        'txt_berat_al
        '
        Me.txt_berat_al.Enabled = False
        Me.txt_berat_al.Location = New System.Drawing.Point(559, 162)
        Me.txt_berat_al.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_berat_al.Name = "txt_berat_al"
        Me.txt_berat_al.Size = New System.Drawing.Size(87, 20)
        Me.txt_berat_al.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label11.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(455, 163)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 14)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "BERAT CUCIAN"
        '
        'txt_namacust_al
        '
        Me.txt_namacust_al.Enabled = False
        Me.txt_namacust_al.Location = New System.Drawing.Point(559, 112)
        Me.txt_namacust_al.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_namacust_al.Name = "txt_namacust_al"
        Me.txt_namacust_al.Size = New System.Drawing.Size(269, 20)
        Me.txt_namacust_al.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label12.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(455, 114)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 14)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "NAMA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label13.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(455, 139)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 14)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "TANGGAL AMBIL"
        '
        'txt_idadm_al
        '
        Me.txt_idadm_al.Location = New System.Drawing.Point(172, 135)
        Me.txt_idadm_al.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_idadm_al.Name = "txt_idadm_al"
        Me.txt_idadm_al.Size = New System.Drawing.Size(270, 20)
        Me.txt_idadm_al.TabIndex = 57
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label14.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(60, 137)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 14)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "ID ADMIN"
        '
        'txt_namaadm_al
        '
        Me.txt_namaadm_al.Enabled = False
        Me.txt_namaadm_al.Location = New System.Drawing.Point(172, 160)
        Me.txt_namaadm_al.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_namaadm_al.Name = "txt_namaadm_al"
        Me.txt_namaadm_al.Size = New System.Drawing.Size(270, 20)
        Me.txt_namaadm_al.TabIndex = 59
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label15.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(60, 162)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 14)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "NAMA"
        '
        'txt_tglambil_al
        '
        Me.txt_tglambil_al.Enabled = False
        Me.txt_tglambil_al.Location = New System.Drawing.Point(559, 137)
        Me.txt_tglambil_al.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_tglambil_al.Name = "txt_tglambil_al"
        Me.txt_tglambil_al.Size = New System.Drawing.Size(269, 20)
        Me.txt_tglambil_al.TabIndex = 60
        '
        'btn_kembalian_al
        '
        Me.btn_kembalian_al.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_kembalian_al.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kembalian_al.Location = New System.Drawing.Point(537, 408)
        Me.btn_kembalian_al.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kembalian_al.Name = "btn_kembalian_al"
        Me.btn_kembalian_al.Size = New System.Drawing.Size(76, 27)
        Me.btn_kembalian_al.TabIndex = 41
        Me.btn_kembalian_al.Text = "KEMBALI"
        Me.btn_kembalian_al.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(650, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "kg"
        '
        'Form_ambilLaundry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(890, 499)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_tglambil_al)
        Me.Controls.Add(Me.txt_namaadm_al)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_idadm_al)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_namacust_al)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_berat_al)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_idcust_al)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_total_al)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_hapus_al)
        Me.Controls.Add(Me.dtp_tgltrans_al)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_kembalian_al)
        Me.Controls.Add(Me.btn_total_al)
        Me.Controls.Add(Me.txt_bayar_al)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_kembalian_al)
        Me.Controls.Add(Me.txt_kodetrans_al)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_edit_al)
        Me.Controls.Add(Me.LV_transaksi)
        Me.Controls.Add(Me.btn_simpan_al)
        Me.Controls.Add(Me.btn_reset_al)
        Me.Controls.Add(Me.btn_struk_al)
        Me.Controls.Add(Me.btn_kembali_al)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Form_ambilLaundry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ambil Laundy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_total_al As Button
    Friend WithEvents txt_bayar_al As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_kembalian_al As TextBox
    Friend WithEvents txt_kodetrans_al As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_edit_al As Button
    Friend WithEvents LV_transaksi As ListView
    Friend WithEvents btn_simpan_al As Button
    Friend WithEvents btn_reset_al As Button
    Friend WithEvents btn_struk_al As Button
    Friend WithEvents btn_kembali_al As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_tgltrans_al As DateTimePicker
    Friend WithEvents btn_hapus_al As Button
    Friend WithEvents txt_total_al As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_idcust_al As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_berat_al As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_namacust_al As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_idadm_al As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_namaadm_al As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_tglambil_al As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents btn_kembalian_al As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
