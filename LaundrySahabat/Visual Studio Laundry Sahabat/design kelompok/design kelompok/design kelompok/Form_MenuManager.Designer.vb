<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_MenuManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_MenuManager))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_dataadm_mg = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btn_logout_mg = New System.Windows.Forms.Button()
        Me.btn_tmbhkaryawan_mg = New System.Windows.Forms.Button()
        Me.btn_datalaundry_mg = New System.Windows.Forms.Button()
        Me.btn_datapgw_mg = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(614, 55)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MAIN MENU MANAGER"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Beige
        Me.GroupBox1.Controls.Add(Me.btn_dataadm_mg)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.btn_logout_mg)
        Me.GroupBox1.Controls.Add(Me.btn_tmbhkaryawan_mg)
        Me.GroupBox1.Controls.Add(Me.btn_datalaundry_mg)
        Me.GroupBox1.Controls.Add(Me.btn_datapgw_mg)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 200)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1072, 308)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'btn_dataadm_mg
        '
        Me.btn_dataadm_mg.BackgroundImage = CType(resources.GetObject("btn_dataadm_mg.BackgroundImage"), System.Drawing.Image)
        Me.btn_dataadm_mg.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dataadm_mg.Location = New System.Drawing.Point(30, 235)
        Me.btn_dataadm_mg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_dataadm_mg.Name = "btn_dataadm_mg"
        Me.btn_dataadm_mg.Size = New System.Drawing.Size(180, 46)
        Me.btn_dataadm_mg.TabIndex = 3
        Me.btn_dataadm_mg.Text = "DATA ADMIN"
        Me.btn_dataadm_mg.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Beige
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(30, 42)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(179, 184)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'btn_logout_mg
        '
        Me.btn_logout_mg.BackgroundImage = CType(resources.GetObject("btn_logout_mg.BackgroundImage"), System.Drawing.Image)
        Me.btn_logout_mg.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout_mg.Location = New System.Drawing.Point(864, 240)
        Me.btn_logout_mg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_logout_mg.Name = "btn_logout_mg"
        Me.btn_logout_mg.Size = New System.Drawing.Size(180, 46)
        Me.btn_logout_mg.TabIndex = 1
        Me.btn_logout_mg.Text = "LOGOUT"
        Me.btn_logout_mg.UseVisualStyleBackColor = True
        '
        'btn_tmbhkaryawan_mg
        '
        Me.btn_tmbhkaryawan_mg.BackgroundImage = CType(resources.GetObject("btn_tmbhkaryawan_mg.BackgroundImage"), System.Drawing.Image)
        Me.btn_tmbhkaryawan_mg.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tmbhkaryawan_mg.Location = New System.Drawing.Point(656, 240)
        Me.btn_tmbhkaryawan_mg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_tmbhkaryawan_mg.Name = "btn_tmbhkaryawan_mg"
        Me.btn_tmbhkaryawan_mg.Size = New System.Drawing.Size(180, 46)
        Me.btn_tmbhkaryawan_mg.TabIndex = 1
        Me.btn_tmbhkaryawan_mg.Text = "TAMBAH KARYAWAN"
        Me.btn_tmbhkaryawan_mg.UseVisualStyleBackColor = True
        '
        'btn_datalaundry_mg
        '
        Me.btn_datalaundry_mg.BackgroundImage = CType(resources.GetObject("btn_datalaundry_mg.BackgroundImage"), System.Drawing.Image)
        Me.btn_datalaundry_mg.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_datalaundry_mg.Location = New System.Drawing.Point(447, 240)
        Me.btn_datalaundry_mg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_datalaundry_mg.Name = "btn_datalaundry_mg"
        Me.btn_datalaundry_mg.Size = New System.Drawing.Size(180, 46)
        Me.btn_datalaundry_mg.TabIndex = 1
        Me.btn_datalaundry_mg.Text = "DATA LAUNDRY"
        Me.btn_datalaundry_mg.UseVisualStyleBackColor = True
        '
        'btn_datapgw_mg
        '
        Me.btn_datapgw_mg.BackgroundImage = CType(resources.GetObject("btn_datapgw_mg.BackgroundImage"), System.Drawing.Image)
        Me.btn_datapgw_mg.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_datapgw_mg.Location = New System.Drawing.Point(238, 240)
        Me.btn_datapgw_mg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_datapgw_mg.Name = "btn_datapgw_mg"
        Me.btn_datapgw_mg.Size = New System.Drawing.Size(180, 46)
        Me.btn_datapgw_mg.TabIndex = 1
        Me.btn_datapgw_mg.Text = "DATA PEGAWAI"
        Me.btn_datapgw_mg.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Beige
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(864, 42)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(179, 184)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Beige
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(656, 42)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(179, 184)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Beige
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(447, 42)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(179, 184)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Beige
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(238, 42)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Menu_Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1176, 555)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Menu_Manager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tampilan Menu Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_logout_mg As Button
    Friend WithEvents btn_tmbhkaryawan_mg As Button
    Friend WithEvents btn_datalaundry_mg As Button
    Friend WithEvents btn_datapgw_mg As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btn_dataadm_mg As Button
End Class
