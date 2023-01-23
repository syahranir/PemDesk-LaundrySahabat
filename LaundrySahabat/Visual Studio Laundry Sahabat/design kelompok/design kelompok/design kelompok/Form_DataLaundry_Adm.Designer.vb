<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_DataLaundry_Adm
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
        Me.btn_refresh_dladm = New System.Windows.Forms.Button()
        Me.btn_totalpemasukan_dladm = New System.Windows.Forms.Button()
        Me.dgv_datalaundry_adm = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_totalPemasukan_adm = New System.Windows.Forms.TextBox()
        Me.txt_cari_dladm = New System.Windows.Forms.TextBox()
        Me.btn_cari_dladm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_kembali_dladm = New System.Windows.Forms.Button()
        CType(Me.dgv_datalaundry_adm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_refresh_dladm
        '
        Me.btn_refresh_dladm.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_refresh_dladm.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh_dladm.Location = New System.Drawing.Point(430, 125)
        Me.btn_refresh_dladm.Name = "btn_refresh_dladm"
        Me.btn_refresh_dladm.Size = New System.Drawing.Size(75, 23)
        Me.btn_refresh_dladm.TabIndex = 51
        Me.btn_refresh_dladm.Text = "REFRESH"
        Me.btn_refresh_dladm.UseVisualStyleBackColor = True
        '
        'btn_totalpemasukan_dladm
        '
        Me.btn_totalpemasukan_dladm.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_totalpemasukan_dladm.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_totalpemasukan_dladm.Location = New System.Drawing.Point(11, 451)
        Me.btn_totalpemasukan_dladm.Name = "btn_totalpemasukan_dladm"
        Me.btn_totalpemasukan_dladm.Size = New System.Drawing.Size(140, 40)
        Me.btn_totalpemasukan_dladm.TabIndex = 50
        Me.btn_totalpemasukan_dladm.Text = "TOTAL PEMASUKAN"
        Me.btn_totalpemasukan_dladm.UseVisualStyleBackColor = True
        '
        'dgv_datalaundry_adm
        '
        Me.dgv_datalaundry_adm.BackgroundColor = System.Drawing.Color.Beige
        Me.dgv_datalaundry_adm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datalaundry_adm.Location = New System.Drawing.Point(11, 172)
        Me.dgv_datalaundry_adm.Name = "dgv_datalaundry_adm"
        Me.dgv_datalaundry_adm.Size = New System.Drawing.Size(868, 261)
        Me.dgv_datalaundry_adm.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(158, 461)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 14)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Rp."
        '
        'txt_totalPemasukan_adm
        '
        Me.txt_totalPemasukan_adm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalPemasukan_adm.Location = New System.Drawing.Point(190, 451)
        Me.txt_totalPemasukan_adm.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_totalPemasukan_adm.Multiline = True
        Me.txt_totalPemasukan_adm.Name = "txt_totalPemasukan_adm"
        Me.txt_totalPemasukan_adm.ReadOnly = True
        Me.txt_totalPemasukan_adm.Size = New System.Drawing.Size(256, 40)
        Me.txt_totalPemasukan_adm.TabIndex = 46
        '
        'txt_cari_dladm
        '
        Me.txt_cari_dladm.Location = New System.Drawing.Point(85, 126)
        Me.txt_cari_dladm.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cari_dladm.Name = "txt_cari_dladm"
        Me.txt_cari_dladm.Size = New System.Drawing.Size(247, 20)
        Me.txt_cari_dladm.TabIndex = 45
        '
        'btn_cari_dladm
        '
        Me.btn_cari_dladm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_cari_dladm.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_cari_dladm.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_dladm.Location = New System.Drawing.Point(353, 125)
        Me.btn_cari_dladm.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cari_dladm.Name = "btn_cari_dladm"
        Me.btn_cari_dladm.Size = New System.Drawing.Size(76, 23)
        Me.btn_cari_dladm.TabIndex = 48
        Me.btn_cari_dladm.Text = "PILIH"
        Me.btn_cari_dladm.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "SEARCH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 36)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "REKAP DATA LAUNDRY"
        '
        'btn_kembali_dladm
        '
        Me.btn_kembali_dladm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_kembali_dladm.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_kembali_dladm.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kembali_dladm.Location = New System.Drawing.Point(787, 451)
        Me.btn_kembali_dladm.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kembali_dladm.Name = "btn_kembali_dladm"
        Me.btn_kembali_dladm.Size = New System.Drawing.Size(92, 41)
        Me.btn_kembali_dladm.TabIndex = 52
        Me.btn_kembali_dladm.Text = "KEMBALI"
        Me.btn_kembali_dladm.UseVisualStyleBackColor = False
        '
        'Data_Laundry_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(890, 501)
        Me.Controls.Add(Me.btn_kembali_dladm)
        Me.Controls.Add(Me.btn_refresh_dladm)
        Me.Controls.Add(Me.btn_totalpemasukan_dladm)
        Me.Controls.Add(Me.dgv_datalaundry_adm)
        Me.Controls.Add(Me.btn_cari_dladm)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_totalPemasukan_adm)
        Me.Controls.Add(Me.txt_cari_dladm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Data_Laundry_adm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data_Laundry_adm"
        CType(Me.dgv_datalaundry_adm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_refresh_dladm As Button
    Friend WithEvents btn_totalpemasukan_dladm As Button
    Friend WithEvents dgv_datalaundry_adm As DataGridView
    Friend WithEvents btn_cari_dladm As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_totalPemasukan_adm As TextBox
    Friend WithEvents txt_cari_dladm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_kembali_dladm As Button
End Class
