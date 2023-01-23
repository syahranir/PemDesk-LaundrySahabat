<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_tbhPegawai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_tbhPegawai))
        Me.btn_back_pegawai = New System.Windows.Forms.Button()
        Me.btn_simpan_pegawai = New System.Windows.Forms.Button()
        Me.btn_edit_pegawai = New System.Windows.Forms.Button()
        Me.btn_reset_pegawai = New System.Windows.Forms.Button()
        Me.cb_jk_pegawai = New System.Windows.Forms.ComboBox()
        Me.txt_alamat_pegawai = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id_pegawai = New System.Windows.Forms.TextBox()
        Me.txt_nama_pegawai = New System.Windows.Forms.TextBox()
        Me.txt_telp_pegawai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_hapus_pegawai = New System.Windows.Forms.Button()
        Me.Label_tgl_pegawai = New System.Windows.Forms.Label()
        Me.LV_pegawai = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dtp_tgl_pegawai = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btn_back_pegawai
        '
        Me.btn_back_pegawai.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_back_pegawai.BackgroundImage = CType(resources.GetObject("btn_back_pegawai.BackgroundImage"), System.Drawing.Image)
        Me.btn_back_pegawai.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_pegawai.Location = New System.Drawing.Point(777, 452)
        Me.btn_back_pegawai.Name = "btn_back_pegawai"
        Me.btn_back_pegawai.Size = New System.Drawing.Size(101, 41)
        Me.btn_back_pegawai.TabIndex = 15
        Me.btn_back_pegawai.Text = "KEMBALI"
        Me.btn_back_pegawai.UseVisualStyleBackColor = False
        '
        'btn_simpan_pegawai
        '
        Me.btn_simpan_pegawai.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan_pegawai.BackgroundImage = CType(resources.GetObject("btn_simpan_pegawai.BackgroundImage"), System.Drawing.Image)
        Me.btn_simpan_pegawai.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan_pegawai.Location = New System.Drawing.Point(521, 198)
        Me.btn_simpan_pegawai.Name = "btn_simpan_pegawai"
        Me.btn_simpan_pegawai.Size = New System.Drawing.Size(75, 33)
        Me.btn_simpan_pegawai.TabIndex = 7
        Me.btn_simpan_pegawai.Text = "SIMPAN"
        Me.btn_simpan_pegawai.UseVisualStyleBackColor = False
        '
        'btn_edit_pegawai
        '
        Me.btn_edit_pegawai.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit_pegawai.BackgroundImage = CType(resources.GetObject("btn_edit_pegawai.BackgroundImage"), System.Drawing.Image)
        Me.btn_edit_pegawai.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_pegawai.Location = New System.Drawing.Point(606, 198)
        Me.btn_edit_pegawai.Name = "btn_edit_pegawai"
        Me.btn_edit_pegawai.Size = New System.Drawing.Size(75, 33)
        Me.btn_edit_pegawai.TabIndex = 8
        Me.btn_edit_pegawai.Text = "EDIT"
        Me.btn_edit_pegawai.UseVisualStyleBackColor = False
        '
        'btn_reset_pegawai
        '
        Me.btn_reset_pegawai.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_reset_pegawai.BackgroundImage = CType(resources.GetObject("btn_reset_pegawai.BackgroundImage"), System.Drawing.Image)
        Me.btn_reset_pegawai.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_pegawai.Location = New System.Drawing.Point(691, 198)
        Me.btn_reset_pegawai.Name = "btn_reset_pegawai"
        Me.btn_reset_pegawai.Size = New System.Drawing.Size(75, 33)
        Me.btn_reset_pegawai.TabIndex = 9
        Me.btn_reset_pegawai.Text = "RESET"
        Me.btn_reset_pegawai.UseVisualStyleBackColor = False
        '
        'cb_jk_pegawai
        '
        Me.cb_jk_pegawai.FormattingEnabled = True
        Me.cb_jk_pegawai.Location = New System.Drawing.Point(204, 185)
        Me.cb_jk_pegawai.Name = "cb_jk_pegawai"
        Me.cb_jk_pegawai.Size = New System.Drawing.Size(250, 21)
        Me.cb_jk_pegawai.TabIndex = 10
        '
        'txt_alamat_pegawai
        '
        Me.txt_alamat_pegawai.Location = New System.Drawing.Point(582, 135)
        Me.txt_alamat_pegawai.Name = "txt_alamat_pegawai"
        Me.txt_alamat_pegawai.Size = New System.Drawing.Size(149, 20)
        Me.txt_alamat_pegawai.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 36)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "TAMBAH PEGAWAI"
        '
        'txt_id_pegawai
        '
        Me.txt_id_pegawai.Location = New System.Drawing.Point(204, 135)
        Me.txt_id_pegawai.Name = "txt_id_pegawai"
        Me.txt_id_pegawai.Size = New System.Drawing.Size(250, 20)
        Me.txt_id_pegawai.TabIndex = 8
        '
        'txt_nama_pegawai
        '
        Me.txt_nama_pegawai.Location = New System.Drawing.Point(204, 160)
        Me.txt_nama_pegawai.Name = "txt_nama_pegawai"
        Me.txt_nama_pegawai.Size = New System.Drawing.Size(250, 20)
        Me.txt_nama_pegawai.TabIndex = 7
        '
        'txt_telp_pegawai
        '
        Me.txt_telp_pegawai.Location = New System.Drawing.Point(582, 160)
        Me.txt_telp_pegawai.Name = "txt_telp_pegawai"
        Me.txt_telp_pegawai.Size = New System.Drawing.Size(149, 20)
        Me.txt_telp_pegawai.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(470, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "ALAMAT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(470, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 14)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "NO. TELEPON"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(77, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "JENIS KELAMIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "NAMA PEGAWAI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID PEGAWAI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "TANGGAL"
        '
        'btn_hapus_pegawai
        '
        Me.btn_hapus_pegawai.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_hapus_pegawai.BackgroundImage = CType(resources.GetObject("btn_hapus_pegawai.BackgroundImage"), System.Drawing.Image)
        Me.btn_hapus_pegawai.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus_pegawai.Location = New System.Drawing.Point(776, 198)
        Me.btn_hapus_pegawai.Name = "btn_hapus_pegawai"
        Me.btn_hapus_pegawai.Size = New System.Drawing.Size(75, 33)
        Me.btn_hapus_pegawai.TabIndex = 9
        Me.btn_hapus_pegawai.Text = "HAPUS"
        Me.btn_hapus_pegawai.UseVisualStyleBackColor = False
        '
        'Label_tgl_pegawai
        '
        Me.Label_tgl_pegawai.AutoSize = True
        Me.Label_tgl_pegawai.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_tgl_pegawai.Location = New System.Drawing.Point(28, 107)
        Me.Label_tgl_pegawai.Name = "Label_tgl_pegawai"
        Me.Label_tgl_pegawai.Size = New System.Drawing.Size(0, 13)
        Me.Label_tgl_pegawai.TabIndex = 24
        '
        'LV_pegawai
        '
        Me.LV_pegawai.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.LV_pegawai.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV_pegawai.FullRowSelect = True
        Me.LV_pegawai.GridLines = True
        Me.LV_pegawai.HideSelection = False
        Me.LV_pegawai.Location = New System.Drawing.Point(21, 237)
        Me.LV_pegawai.Name = "LV_pegawai"
        Me.LV_pegawai.Size = New System.Drawing.Size(845, 209)
        Me.LV_pegawai.TabIndex = 26
        Me.LV_pegawai.UseCompatibleStateImageBehavior = False
        Me.LV_pegawai.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID PEGAWAI"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NAMA"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "TANGGAL MASUK"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 110
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "JENIS KELAMIN"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ALAMAT"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 300
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "TELEPON"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 100
        '
        'dtp_tgl_pegawai
        '
        Me.dtp_tgl_pegawai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_tgl_pegawai.Location = New System.Drawing.Point(204, 80)
        Me.dtp_tgl_pegawai.Name = "dtp_tgl_pegawai"
        Me.dtp_tgl_pegawai.Size = New System.Drawing.Size(250, 20)
        Me.dtp_tgl_pegawai.TabIndex = 27
        '
        'Form_tbhPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(890, 501)
        Me.Controls.Add(Me.dtp_tgl_pegawai)
        Me.Controls.Add(Me.LV_pegawai)
        Me.Controls.Add(Me.Label_tgl_pegawai)
        Me.Controls.Add(Me.btn_back_pegawai)
        Me.Controls.Add(Me.btn_simpan_pegawai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_edit_pegawai)
        Me.Controls.Add(Me.btn_hapus_pegawai)
        Me.Controls.Add(Me.btn_reset_pegawai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_jk_pegawai)
        Me.Controls.Add(Me.txt_alamat_pegawai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_id_pegawai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nama_pegawai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_telp_pegawai)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form_tbhPegawai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Pegawai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back_pegawai As Button
    Friend WithEvents btn_simpan_pegawai As Button
    Friend WithEvents btn_edit_pegawai As Button
    Friend WithEvents btn_reset_pegawai As Button
    Friend WithEvents cb_jk_pegawai As ComboBox
    Friend WithEvents txt_alamat_pegawai As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id_pegawai As TextBox
    Friend WithEvents txt_nama_pegawai As TextBox
    Friend WithEvents txt_telp_pegawai As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_hapus_pegawai As Button
    Friend WithEvents Label_tgl_pegawai As Label
    Friend WithEvents LV_pegawai As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents dtp_tgl_pegawai As DateTimePicker
End Class
