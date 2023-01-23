<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_MenuAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_MenuAdmin))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_logout_adm = New System.Windows.Forms.Button()
        Me.btn_datalaundry_adm = New System.Windows.Forms.Button()
        Me.btn_ambil_adm = New System.Windows.Forms.Button()
        Me.btn_tambah_adm = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(348, 36)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "MAIN MENU ADMIN"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Beige
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.btn_logout_adm)
        Me.GroupBox2.Controls.Add(Me.btn_datalaundry_adm)
        Me.GroupBox2.Controls.Add(Me.btn_ambil_adm)
        Me.GroupBox2.Controls.Add(Me.btn_tambah_adm)
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Controls.Add(Me.PictureBox6)
        Me.GroupBox2.Controls.Add(Me.PictureBox7)
        Me.GroupBox2.Controls.Add(Me.PictureBox8)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(715, 200)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'btn_logout_adm
        '
        Me.btn_logout_adm.BackgroundImage = CType(resources.GetObject("btn_logout_adm.BackgroundImage"), System.Drawing.Image)
        Me.btn_logout_adm.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout_adm.Location = New System.Drawing.Point(566, 153)
        Me.btn_logout_adm.Name = "btn_logout_adm"
        Me.btn_logout_adm.Size = New System.Drawing.Size(120, 30)
        Me.btn_logout_adm.TabIndex = 1
        Me.btn_logout_adm.Text = "LOGOUT"
        Me.btn_logout_adm.UseVisualStyleBackColor = True
        '
        'btn_datalaundry_adm
        '
        Me.btn_datalaundry_adm.BackgroundImage = CType(resources.GetObject("btn_datalaundry_adm.BackgroundImage"), System.Drawing.Image)
        Me.btn_datalaundry_adm.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_datalaundry_adm.Location = New System.Drawing.Point(389, 153)
        Me.btn_datalaundry_adm.Name = "btn_datalaundry_adm"
        Me.btn_datalaundry_adm.Size = New System.Drawing.Size(120, 30)
        Me.btn_datalaundry_adm.TabIndex = 1
        Me.btn_datalaundry_adm.Text = "DATA LAUNDRY"
        Me.btn_datalaundry_adm.UseVisualStyleBackColor = True
        '
        'btn_ambil_adm
        '
        Me.btn_ambil_adm.BackgroundImage = CType(resources.GetObject("btn_ambil_adm.BackgroundImage"), System.Drawing.Image)
        Me.btn_ambil_adm.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ambil_adm.Location = New System.Drawing.Point(211, 153)
        Me.btn_ambil_adm.Name = "btn_ambil_adm"
        Me.btn_ambil_adm.Size = New System.Drawing.Size(120, 30)
        Me.btn_ambil_adm.TabIndex = 1
        Me.btn_ambil_adm.Text = "AMBIL LAUNDRY"
        Me.btn_ambil_adm.UseVisualStyleBackColor = True
        '
        'btn_tambah_adm
        '
        Me.btn_tambah_adm.BackgroundImage = CType(resources.GetObject("btn_tambah_adm.BackgroundImage"), System.Drawing.Image)
        Me.btn_tambah_adm.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tambah_adm.Location = New System.Drawing.Point(36, 153)
        Me.btn_tambah_adm.Name = "btn_tambah_adm"
        Me.btn_tambah_adm.Size = New System.Drawing.Size(120, 30)
        Me.btn_tambah_adm.TabIndex = 1
        Me.btn_tambah_adm.Text = "TAMBAH LAUNDRY"
        Me.btn_tambah_adm.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Beige
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(36, 27)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.BackColor = System.Drawing.Color.Beige
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(211, 27)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Beige
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(389, 27)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Beige
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(566, 27)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 0
        Me.PictureBox8.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tampilan Menu Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_logout_adm As Button
    Friend WithEvents btn_datalaundry_adm As Button
    Friend WithEvents btn_ambil_adm As Button
    Friend WithEvents btn_tambah_adm As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
