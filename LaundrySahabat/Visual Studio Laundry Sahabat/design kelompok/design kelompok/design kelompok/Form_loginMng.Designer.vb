<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_loginMng
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
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_backlogin_mgr = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_userlogin_mgr = New System.Windows.Forms.TextBox()
        Me.txt_passlogin_mgr = New System.Windows.Forms.TextBox()
        Me.btn_login_mgr = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(63, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(312, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LOGIN MANAGER"
        '
        'btn_backlogin_mgr
        '
        Me.btn_backlogin_mgr.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backlogin_mgr.Image = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_backlogin_mgr.Location = New System.Drawing.Point(61, 226)
        Me.btn_backlogin_mgr.Name = "btn_backlogin_mgr"
        Me.btn_backlogin_mgr.Size = New System.Drawing.Size(75, 23)
        Me.btn_backlogin_mgr.TabIndex = 3
        Me.btn_backlogin_mgr.Text = "KEMBALI"
        Me.btn_backlogin_mgr.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Beige
        Me.Label12.Location = New System.Drawing.Point(61, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(482, 126)
        Me.Label12.TabIndex = 32
        '
        'txt_userlogin_mgr
        '
        Me.txt_userlogin_mgr.BackColor = System.Drawing.SystemColors.Window
        Me.txt_userlogin_mgr.Location = New System.Drawing.Point(154, 110)
        Me.txt_userlogin_mgr.Name = "txt_userlogin_mgr"
        Me.txt_userlogin_mgr.Size = New System.Drawing.Size(380, 20)
        Me.txt_userlogin_mgr.TabIndex = 1
        '
        'txt_passlogin_mgr
        '
        Me.txt_passlogin_mgr.BackColor = System.Drawing.SystemColors.Window
        Me.txt_passlogin_mgr.Location = New System.Drawing.Point(154, 138)
        Me.txt_passlogin_mgr.Name = "txt_passlogin_mgr"
        Me.txt_passlogin_mgr.Size = New System.Drawing.Size(380, 20)
        Me.txt_passlogin_mgr.TabIndex = 1
        Me.txt_passlogin_mgr.UseSystemPasswordChar = True
        '
        'btn_login_mgr
        '
        Me.btn_login_mgr.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_mgr.Image = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_login_mgr.Location = New System.Drawing.Point(461, 181)
        Me.btn_login_mgr.Name = "btn_login_mgr"
        Me.btn_login_mgr.Size = New System.Drawing.Size(75, 23)
        Me.btn_login_mgr.TabIndex = 3
        Me.btn_login_mgr.Text = "LOGIN"
        Me.btn_login_mgr.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Beige
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(67, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "USERNAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Beige
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(67, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "PASSWORD"
        '
        'Form_loginMng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.btn_backlogin_mgr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_login_mgr)
        Me.Controls.Add(Me.txt_userlogin_mgr)
        Me.Controls.Add(Me.txt_passlogin_mgr)
        Me.Controls.Add(Me.Label12)
        Me.DoubleBuffered = True
        Me.Name = "Form_loginMng"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Sebagai Manager"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_backlogin_mgr As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_login_mgr As Button
    Friend WithEvents txt_userlogin_mgr As TextBox
    Friend WithEvents txt_passlogin_mgr As TextBox
    Friend WithEvents Label12 As Label
End Class
