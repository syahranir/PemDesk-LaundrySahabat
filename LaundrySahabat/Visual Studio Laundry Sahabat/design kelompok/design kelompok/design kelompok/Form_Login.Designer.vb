<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_masuk_adm = New System.Windows.Forms.Button()
        Me.btn_masuk_mgr = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_end_login = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btn_masuk_adm)
        Me.GroupBox1.Controls.Add(Me.btn_masuk_mgr)
        Me.GroupBox1.Location = New System.Drawing.Point(283, 267)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 342)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(408, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(355, 225)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(47, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(355, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btn_masuk_adm
        '
        Me.btn_masuk_adm.BackColor = System.Drawing.Color.Olive
        Me.btn_masuk_adm.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_masuk_adm.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_masuk_adm.Location = New System.Drawing.Point(408, 270)
        Me.btn_masuk_adm.Name = "btn_masuk_adm"
        Me.btn_masuk_adm.Size = New System.Drawing.Size(355, 46)
        Me.btn_masuk_adm.TabIndex = 0
        Me.btn_masuk_adm.Text = "ADMIN"
        Me.btn_masuk_adm.UseVisualStyleBackColor = False
        '
        'btn_masuk_mgr
        '
        Me.btn_masuk_mgr.BackColor = System.Drawing.Color.Olive
        Me.btn_masuk_mgr.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_masuk_mgr.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_masuk_mgr.Location = New System.Drawing.Point(47, 270)
        Me.btn_masuk_mgr.Name = "btn_masuk_mgr"
        Me.btn_masuk_mgr.Size = New System.Drawing.Size(355, 46)
        Me.btn_masuk_mgr.TabIndex = 0
        Me.btn_masuk_mgr.Text = "MANAGER"
        Me.btn_masuk_mgr.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.LightYellow
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(-226, -84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1345, 194)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SELAMAT DATANG"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_end_login
        '
        Me.btn_end_login.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_end_login.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_end_login.Location = New System.Drawing.Point(283, 621)
        Me.btn_end_login.Name = "btn_end_login"
        Me.btn_end_login.Size = New System.Drawing.Size(800, 40)
        Me.btn_end_login.TabIndex = 2
        Me.btn_end_login.Text = "SELESAI"
        Me.btn_end_login.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(621, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 41)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "LOGIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Olive
        Me.Label3.Location = New System.Drawing.Point(489, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(371, 40)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "LAUNDRY SAHABAT"
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(908, 482)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_end_login)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tampilan Awal Masuk Aplikasi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_masuk_adm As Button
    Friend WithEvents btn_masuk_mgr As Button
    Friend WithEvents btn_end_login As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
