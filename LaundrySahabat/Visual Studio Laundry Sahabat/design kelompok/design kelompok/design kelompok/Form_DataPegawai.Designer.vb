<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_DataPegawai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DataPegawai))
        Me.btn_kembali_dp = New System.Windows.Forms.Button()
        Me.btn_caripegawai_dP = New System.Windows.Forms.Button()
        Me.txt_caripegawai_dk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_datapegawai = New System.Windows.Forms.DataGridView()
        Me.btn_refresh_dp = New System.Windows.Forms.Button()
        CType(Me.dgv_datapegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_kembali_dp
        '
        Me.btn_kembali_dp.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_kembali_dp.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_kembali_dp.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kembali_dp.Location = New System.Drawing.Point(787, 451)
        Me.btn_kembali_dp.Name = "btn_kembali_dp"
        Me.btn_kembali_dp.Size = New System.Drawing.Size(92, 41)
        Me.btn_kembali_dp.TabIndex = 11
        Me.btn_kembali_dp.Text = "KEMBALI"
        Me.btn_kembali_dp.UseVisualStyleBackColor = False
        '
        'btn_caripegawai_dP
        '
        Me.btn_caripegawai_dP.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_caripegawai_dP.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_caripegawai_dP.Image = CType(resources.GetObject("btn_caripegawai_dP.Image"), System.Drawing.Image)
        Me.btn_caripegawai_dP.Location = New System.Drawing.Point(374, 124)
        Me.btn_caripegawai_dP.Name = "btn_caripegawai_dP"
        Me.btn_caripegawai_dP.Size = New System.Drawing.Size(91, 25)
        Me.btn_caripegawai_dP.TabIndex = 10
        Me.btn_caripegawai_dP.Text = "PILIH"
        Me.btn_caripegawai_dP.UseVisualStyleBackColor = False
        '
        'txt_caripegawai_dk
        '
        Me.txt_caripegawai_dk.Location = New System.Drawing.Point(114, 126)
        Me.txt_caripegawai_dk.Name = "txt_caripegawai_dk"
        Me.txt_caripegawai_dk.Size = New System.Drawing.Size(247, 20)
        Me.txt_caripegawai_dk.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID PEGAWAI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 36)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "DATA PEGAWAI"
        '
        'dgv_datapegawai
        '
        Me.dgv_datapegawai.BackgroundColor = System.Drawing.Color.Beige
        Me.dgv_datapegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datapegawai.Location = New System.Drawing.Point(12, 161)
        Me.dgv_datapegawai.Name = "dgv_datapegawai"
        Me.dgv_datapegawai.Size = New System.Drawing.Size(868, 284)
        Me.dgv_datapegawai.TabIndex = 31
        '
        'btn_refresh_dp
        '
        Me.btn_refresh_dp.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh_dp.Image = CType(resources.GetObject("btn_refresh_dp.Image"), System.Drawing.Image)
        Me.btn_refresh_dp.Location = New System.Drawing.Point(471, 124)
        Me.btn_refresh_dp.Name = "btn_refresh_dp"
        Me.btn_refresh_dp.Size = New System.Drawing.Size(91, 25)
        Me.btn_refresh_dp.TabIndex = 32
        Me.btn_refresh_dp.Text = "REFRESH"
        Me.btn_refresh_dp.UseVisualStyleBackColor = True
        '
        'dataPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(890, 501)
        Me.Controls.Add(Me.btn_refresh_dp)
        Me.Controls.Add(Me.dgv_datapegawai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_kembali_dp)
        Me.Controls.Add(Me.btn_caripegawai_dP)
        Me.Controls.Add(Me.txt_caripegawai_dk)
        Me.Controls.Add(Me.Label1)
        Me.Name = "dataPegawai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pegawai"
        CType(Me.dgv_datapegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_kembali_dp As Button
    Friend WithEvents btn_caripegawai_dP As Button
    Friend WithEvents txt_caripegawai_dk As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_datapegawai As DataGridView
    Friend WithEvents btn_refresh_dp As Button
End Class
