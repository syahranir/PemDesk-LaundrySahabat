<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_tbhCucian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_tbhCucian))
        Me.btn_struk_tc = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_kembali_tc = New System.Windows.Forms.Button()
        Me.txt_idcust_tc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nama_tc = New System.Windows.Forms.TextBox()
        Me.cb_jk_tc = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_edit_tc = New System.Windows.Forms.Button()
        Me.btn_simpan_tc = New System.Windows.Forms.Button()
        Me.txt_telp_tc = New System.Windows.Forms.TextBox()
        Me.btn_reset_tc = New System.Windows.Forms.Button()
        Me.txt_almt_tc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_berat_tc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_hapus_tc = New System.Windows.Forms.Button()
        Me.LV_tc = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtp_tglmasuk_tc = New System.Windows.Forms.DateTimePicker()
        Me.dtp_tglambil_tc = New System.Windows.Forms.DateTimePicker()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'btn_struk_tc
        '
        Me.btn_struk_tc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_struk_tc.BackgroundImage = CType(resources.GetObject("btn_struk_tc.BackgroundImage"), System.Drawing.Image)
        Me.btn_struk_tc.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_struk_tc.Location = New System.Drawing.Point(661, 449)
        Me.btn_struk_tc.Name = "btn_struk_tc"
        Me.btn_struk_tc.Size = New System.Drawing.Size(101, 41)
        Me.btn_struk_tc.TabIndex = 30
        Me.btn_struk_tc.Text = "CETAK STRUK"
        Me.btn_struk_tc.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(77, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 14)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "TANGGAL MASUK"
        '
        'btn_kembali_tc
        '
        Me.btn_kembali_tc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_kembali_tc.BackgroundImage = CType(resources.GetObject("btn_kembali_tc.BackgroundImage"), System.Drawing.Image)
        Me.btn_kembali_tc.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kembali_tc.Location = New System.Drawing.Point(777, 449)
        Me.btn_kembali_tc.Name = "btn_kembali_tc"
        Me.btn_kembali_tc.Size = New System.Drawing.Size(101, 41)
        Me.btn_kembali_tc.TabIndex = 26
        Me.btn_kembali_tc.Text = "KEMBALI"
        Me.btn_kembali_tc.UseVisualStyleBackColor = False
        '
        'txt_idcust_tc
        '
        Me.txt_idcust_tc.Location = New System.Drawing.Point(189, 83)
        Me.txt_idcust_tc.Name = "txt_idcust_tc"
        Me.txt_idcust_tc.Size = New System.Drawing.Size(136, 20)
        Me.txt_idcust_tc.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 36)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "TAMBAH CUCIAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 14)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "ID PELANGGAN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 14)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ALAMAT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NO. TELEPON"
        '
        'txt_nama_tc
        '
        Me.txt_nama_tc.Location = New System.Drawing.Point(189, 154)
        Me.txt_nama_tc.Name = "txt_nama_tc"
        Me.txt_nama_tc.Size = New System.Drawing.Size(305, 20)
        Me.txt_nama_tc.TabIndex = 6
        '
        'cb_jk_tc
        '
        Me.cb_jk_tc.FormattingEnabled = True
        Me.cb_jk_tc.Location = New System.Drawing.Point(189, 219)
        Me.cb_jk_tc.Name = "cb_jk_tc"
        Me.cb_jk_tc.Size = New System.Drawing.Size(305, 21)
        Me.cb_jk_tc.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "JENIS KELAMIN"
        '
        'btn_edit_tc
        '
        Me.btn_edit_tc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit_tc.BackgroundImage = CType(resources.GetObject("btn_edit_tc.BackgroundImage"), System.Drawing.Image)
        Me.btn_edit_tc.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_tc.Location = New System.Drawing.Point(606, 223)
        Me.btn_edit_tc.Name = "btn_edit_tc"
        Me.btn_edit_tc.Size = New System.Drawing.Size(77, 33)
        Me.btn_edit_tc.TabIndex = 12
        Me.btn_edit_tc.Text = "EDIT"
        Me.btn_edit_tc.UseVisualStyleBackColor = False
        '
        'btn_simpan_tc
        '
        Me.btn_simpan_tc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan_tc.BackgroundImage = CType(resources.GetObject("btn_simpan_tc.BackgroundImage"), System.Drawing.Image)
        Me.btn_simpan_tc.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan_tc.Location = New System.Drawing.Point(521, 223)
        Me.btn_simpan_tc.Name = "btn_simpan_tc"
        Me.btn_simpan_tc.Size = New System.Drawing.Size(77, 33)
        Me.btn_simpan_tc.TabIndex = 11
        Me.btn_simpan_tc.Text = "SIMPAN"
        Me.btn_simpan_tc.UseVisualStyleBackColor = False
        '
        'txt_telp_tc
        '
        Me.txt_telp_tc.Location = New System.Drawing.Point(189, 255)
        Me.txt_telp_tc.Name = "txt_telp_tc"
        Me.txt_telp_tc.Size = New System.Drawing.Size(305, 20)
        Me.txt_telp_tc.TabIndex = 7
        '
        'btn_reset_tc
        '
        Me.btn_reset_tc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_reset_tc.BackgroundImage = CType(resources.GetObject("btn_reset_tc.BackgroundImage"), System.Drawing.Image)
        Me.btn_reset_tc.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_tc.Location = New System.Drawing.Point(691, 223)
        Me.btn_reset_tc.Name = "btn_reset_tc"
        Me.btn_reset_tc.Size = New System.Drawing.Size(75, 33)
        Me.btn_reset_tc.TabIndex = 13
        Me.btn_reset_tc.Text = "RESET"
        Me.btn_reset_tc.UseVisualStyleBackColor = False
        '
        'txt_almt_tc
        '
        Me.txt_almt_tc.Location = New System.Drawing.Point(189, 185)
        Me.txt_almt_tc.Name = "txt_almt_tc"
        Me.txt_almt_tc.Size = New System.Drawing.Size(305, 20)
        Me.txt_almt_tc.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(522, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 14)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "BERAT CUCIAN"
        '
        'txt_berat_tc
        '
        Me.txt_berat_tc.Location = New System.Drawing.Point(630, 157)
        Me.txt_berat_tc.Name = "txt_berat_tc"
        Me.txt_berat_tc.Size = New System.Drawing.Size(87, 20)
        Me.txt_berat_tc.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(717, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "kg"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 14)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "NAMA"
        '
        'btn_hapus_tc
        '
        Me.btn_hapus_tc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_hapus_tc.BackgroundImage = CType(resources.GetObject("btn_hapus_tc.BackgroundImage"), System.Drawing.Image)
        Me.btn_hapus_tc.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus_tc.Location = New System.Drawing.Point(776, 223)
        Me.btn_hapus_tc.Name = "btn_hapus_tc"
        Me.btn_hapus_tc.Size = New System.Drawing.Size(77, 33)
        Me.btn_hapus_tc.TabIndex = 13
        Me.btn_hapus_tc.Text = "HAPUS"
        Me.btn_hapus_tc.UseVisualStyleBackColor = False
        '
        'LV_tc
        '
        Me.LV_tc.BackColor = System.Drawing.Color.Beige
        Me.LV_tc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.LV_tc.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV_tc.FullRowSelect = True
        Me.LV_tc.GridLines = True
        Me.LV_tc.HideSelection = False
        Me.LV_tc.Location = New System.Drawing.Point(12, 285)
        Me.LV_tc.Name = "LV_tc"
        Me.LV_tc.Size = New System.Drawing.Size(868, 152)
        Me.LV_tc.TabIndex = 33
        Me.LV_tc.UseCompatibleStateImageBehavior = False
        Me.LV_tc.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "KODE PELANGGAN"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NAMA"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ALAMAT"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 220
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "JENIS KELAMIN"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "TELEPON"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "TGL MASUK"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "TGL AMBIL"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "BERAT"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label9.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(519, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 14)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "TANGGAL AMBIL"
        '
        'dtp_tglmasuk_tc
        '
        Me.dtp_tglmasuk_tc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_tglmasuk_tc.Location = New System.Drawing.Point(189, 110)
        Me.dtp_tglmasuk_tc.Name = "dtp_tglmasuk_tc"
        Me.dtp_tglmasuk_tc.Size = New System.Drawing.Size(136, 20)
        Me.dtp_tglmasuk_tc.TabIndex = 35
        '
        'dtp_tglambil_tc
        '
        Me.dtp_tglambil_tc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_tglambil_tc.Location = New System.Drawing.Point(630, 185)
        Me.dtp_tglambil_tc.Name = "dtp_tglambil_tc"
        Me.dtp_tglambil_tc.Size = New System.Drawing.Size(136, 20)
        Me.dtp_tglambil_tc.TabIndex = 36
        '
        'Form_tbhCucian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(890, 495)
        Me.Controls.Add(Me.dtp_tglambil_tc)
        Me.Controls.Add(Me.dtp_tglmasuk_tc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LV_tc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_struk_tc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_kembali_tc)
        Me.Controls.Add(Me.txt_berat_tc)
        Me.Controls.Add(Me.btn_hapus_tc)
        Me.Controls.Add(Me.btn_reset_tc)
        Me.Controls.Add(Me.btn_edit_tc)
        Me.Controls.Add(Me.btn_simpan_tc)
        Me.Controls.Add(Me.txt_idcust_tc)
        Me.Controls.Add(Me.txt_almt_tc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_telp_tc)
        Me.Controls.Add(Me.txt_nama_tc)
        Me.Controls.Add(Me.cb_jk_tc)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form_tbhCucian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Cucian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_struk_tc As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_kembali_tc As Button
    Friend WithEvents txt_idcust_tc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nama_tc As TextBox
    Friend WithEvents cb_jk_tc As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_edit_tc As Button
    Friend WithEvents btn_simpan_tc As Button
    Friend WithEvents txt_telp_tc As TextBox
    Friend WithEvents btn_reset_tc As Button
    Friend WithEvents txt_almt_tc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_berat_tc As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_hapus_tc As Button
    Friend WithEvents LV_tc As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents dtp_tglmasuk_tc As DateTimePicker
    Friend WithEvents dtp_tglambil_tc As DateTimePicker
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
