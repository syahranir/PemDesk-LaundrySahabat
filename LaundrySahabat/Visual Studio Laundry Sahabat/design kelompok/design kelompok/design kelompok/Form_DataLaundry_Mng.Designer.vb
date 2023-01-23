<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_DataLaundry_Mng
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DataLaundry_Mng))
        Me.btn_cari_dl = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_totalPemasukan = New System.Windows.Forms.TextBox()
        Me.btn_kembali_dl = New System.Windows.Forms.Button()
        Me.txt_cari_dl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_datalaundry = New System.Windows.Forms.DataGridView()
        Me.btn_totalpemasukan_dl = New System.Windows.Forms.Button()
        Me.btn_refresh_dl = New System.Windows.Forms.Button()
        CType(Me.dgv_datalaundry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cari_dl
        '
        Me.btn_cari_dl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_cari_dl.BackgroundImage = CType(resources.GetObject("btn_cari_dl.BackgroundImage"), System.Drawing.Image)
        Me.btn_cari_dl.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_dl.Image = CType(resources.GetObject("btn_cari_dl.Image"), System.Drawing.Image)
        Me.btn_cari_dl.Location = New System.Drawing.Point(353, 108)
        Me.btn_cari_dl.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cari_dl.Name = "btn_cari_dl"
        Me.btn_cari_dl.Size = New System.Drawing.Size(76, 23)
        Me.btn_cari_dl.TabIndex = 39
        Me.btn_cari_dl.Text = "CARI"
        Me.btn_cari_dl.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(154, 417)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 14)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Rp."
        '
        'txt_totalPemasukan
        '
        Me.txt_totalPemasukan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalPemasukan.Location = New System.Drawing.Point(186, 403)
        Me.txt_totalPemasukan.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_totalPemasukan.Multiline = True
        Me.txt_totalPemasukan.Name = "txt_totalPemasukan"
        Me.txt_totalPemasukan.ReadOnly = True
        Me.txt_totalPemasukan.Size = New System.Drawing.Size(256, 40)
        Me.txt_totalPemasukan.TabIndex = 35
        '
        'btn_kembali_dl
        '
        Me.btn_kembali_dl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_kembali_dl.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kembali_dl.Image = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_kembali_dl.Location = New System.Drawing.Point(774, 403)
        Me.btn_kembali_dl.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kembali_dl.Name = "btn_kembali_dl"
        Me.btn_kembali_dl.Size = New System.Drawing.Size(91, 39)
        Me.btn_kembali_dl.TabIndex = 38
        Me.btn_kembali_dl.Text = "KEMBALI"
        Me.btn_kembali_dl.UseVisualStyleBackColor = False
        '
        'txt_cari_dl
        '
        Me.txt_cari_dl.Location = New System.Drawing.Point(85, 109)
        Me.txt_cari_dl.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cari_dl.Name = "txt_cari_dl"
        Me.txt_cari_dl.Size = New System.Drawing.Size(247, 20)
        Me.txt_cari_dl.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 23
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
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "REKAP DATA LAUNDRY"
        '
        'dgv_datalaundry
        '
        Me.dgv_datalaundry.BackgroundColor = System.Drawing.Color.Beige
        Me.dgv_datalaundry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datalaundry.Location = New System.Drawing.Point(11, 137)
        Me.dgv_datalaundry.Name = "dgv_datalaundry"
        Me.dgv_datalaundry.Size = New System.Drawing.Size(868, 234)
        Me.dgv_datalaundry.TabIndex = 40
        '
        'btn_totalpemasukan_dl
        '
        Me.btn_totalpemasukan_dl.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_totalpemasukan_dl.Image = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_totalpemasukan_dl.Location = New System.Drawing.Point(10, 403)
        Me.btn_totalpemasukan_dl.Name = "btn_totalpemasukan_dl"
        Me.btn_totalpemasukan_dl.Size = New System.Drawing.Size(140, 40)
        Me.btn_totalpemasukan_dl.TabIndex = 41
        Me.btn_totalpemasukan_dl.Text = "TOTAL PEMASUKAN"
        Me.btn_totalpemasukan_dl.UseVisualStyleBackColor = True
        '
        'btn_refresh_dl
        '
        Me.btn_refresh_dl.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh_dl.Image = CType(resources.GetObject("btn_refresh_dl.Image"), System.Drawing.Image)
        Me.btn_refresh_dl.Location = New System.Drawing.Point(430, 108)
        Me.btn_refresh_dl.Name = "btn_refresh_dl"
        Me.btn_refresh_dl.Size = New System.Drawing.Size(75, 23)
        Me.btn_refresh_dl.TabIndex = 42
        Me.btn_refresh_dl.Text = "REFRESH"
        Me.btn_refresh_dl.UseVisualStyleBackColor = True
        '
        'Form_rekapData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(890, 467)
        Me.Controls.Add(Me.btn_refresh_dl)
        Me.Controls.Add(Me.btn_totalpemasukan_dl)
        Me.Controls.Add(Me.dgv_datalaundry)
        Me.Controls.Add(Me.btn_cari_dl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_totalPemasukan)
        Me.Controls.Add(Me.btn_kembali_dl)
        Me.Controls.Add(Me.txt_cari_dl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_rekapData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rekap Data Laundry"
        CType(Me.dgv_datalaundry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cari_dl As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_totalPemasukan As TextBox
    Friend WithEvents btn_kembali_dl As Button
    Friend WithEvents txt_cari_dl As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_datalaundry As DataGridView
    Friend WithEvents btn_totalpemasukan_dl As Button
    Friend WithEvents btn_refresh_dl As Button
End Class
