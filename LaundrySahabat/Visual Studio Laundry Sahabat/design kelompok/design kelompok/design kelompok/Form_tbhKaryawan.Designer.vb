<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_tbhKaryawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_tbhKaryawan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_tambahadm_tk = New System.Windows.Forms.Button()
        Me.btn_tambahpgw_tk = New System.Windows.Forms.Button()
        Me.btn_kembali_tk = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TAMBAH KARYAWAN"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Beige
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btn_tambahadm_tk)
        Me.GroupBox1.Controls.Add(Me.btn_tambahpgw_tk)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 200)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(176, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btn_tambahadm_tk
        '
        Me.btn_tambahadm_tk.BackgroundImage = CType(resources.GetObject("btn_tambahadm_tk.BackgroundImage"), System.Drawing.Image)
        Me.btn_tambahadm_tk.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tambahadm_tk.Location = New System.Drawing.Point(176, 155)
        Me.btn_tambahadm_tk.Name = "btn_tambahadm_tk"
        Me.btn_tambahadm_tk.Size = New System.Drawing.Size(120, 30)
        Me.btn_tambahadm_tk.TabIndex = 0
        Me.btn_tambahadm_tk.Text = "TAMBAH ADMIN"
        Me.btn_tambahadm_tk.UseVisualStyleBackColor = True
        '
        'btn_tambahpgw_tk
        '
        Me.btn_tambahpgw_tk.BackgroundImage = CType(resources.GetObject("btn_tambahpgw_tk.BackgroundImage"), System.Drawing.Image)
        Me.btn_tambahpgw_tk.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tambahpgw_tk.Location = New System.Drawing.Point(28, 155)
        Me.btn_tambahpgw_tk.Name = "btn_tambahpgw_tk"
        Me.btn_tambahpgw_tk.Size = New System.Drawing.Size(120, 30)
        Me.btn_tambahpgw_tk.TabIndex = 0
        Me.btn_tambahpgw_tk.Text = "TAMBAH PEGAWAI"
        Me.btn_tambahpgw_tk.UseVisualStyleBackColor = True
        '
        'btn_kembali_tk
        '
        Me.btn_kembali_tk.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_kembali_tk.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_kembali_tk.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kembali_tk.Location = New System.Drawing.Point(254, 319)
        Me.btn_kembali_tk.Name = "btn_kembali_tk"
        Me.btn_kembali_tk.Size = New System.Drawing.Size(101, 43)
        Me.btn_kembali_tk.TabIndex = 15
        Me.btn_kembali_tk.Text = "KEMBALI"
        Me.btn_kembali_tk.UseVisualStyleBackColor = False
        '
        'tambahKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(384, 374)
        Me.Controls.Add(Me.btn_kembali_tk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "tambahKaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Karyawan "
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_tambahadm_tk As Button
    Friend WithEvents btn_tambahpgw_tk As Button
    Friend WithEvents btn_kembali_tk As Button
End Class
