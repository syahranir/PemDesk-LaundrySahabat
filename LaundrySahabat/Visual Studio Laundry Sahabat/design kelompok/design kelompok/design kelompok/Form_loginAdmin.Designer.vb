<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_loginAdmin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_login_adm = New System.Windows.Forms.Button()
        Me.txt_passlogin_adm = New System.Windows.Forms.TextBox()
        Me.txt_userlogin_adm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_backlogin_adm = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Beige
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Beige
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "USERNAME"
        '
        'btn_login_adm
        '
        Me.btn_login_adm.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_adm.Image = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_login_adm.Location = New System.Drawing.Point(461, 181)
        Me.btn_login_adm.Name = "btn_login_adm"
        Me.btn_login_adm.Size = New System.Drawing.Size(75, 23)
        Me.btn_login_adm.TabIndex = 5
        Me.btn_login_adm.Text = "LOGIN"
        Me.btn_login_adm.UseVisualStyleBackColor = True
        '
        'txt_passlogin_adm
        '
        Me.txt_passlogin_adm.BackColor = System.Drawing.SystemColors.Window
        Me.txt_passlogin_adm.Location = New System.Drawing.Point(154, 138)
        Me.txt_passlogin_adm.Name = "txt_passlogin_adm"
        Me.txt_passlogin_adm.Size = New System.Drawing.Size(372, 20)
        Me.txt_passlogin_adm.TabIndex = 1
        Me.txt_passlogin_adm.UseSystemPasswordChar = True
        '
        'txt_userlogin_adm
        '
        Me.txt_userlogin_adm.BackColor = System.Drawing.SystemColors.Window
        Me.txt_userlogin_adm.Location = New System.Drawing.Point(154, 110)
        Me.txt_userlogin_adm.Name = "txt_userlogin_adm"
        Me.txt_userlogin_adm.Size = New System.Drawing.Size(372, 20)
        Me.txt_userlogin_adm.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 36)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "LOGIN ADMIN"
        '
        'btn_backlogin_adm
        '
        Me.btn_backlogin_adm.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backlogin_adm.Image = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_backlogin_adm.Location = New System.Drawing.Point(61, 226)
        Me.btn_backlogin_adm.Name = "btn_backlogin_adm"
        Me.btn_backlogin_adm.Size = New System.Drawing.Size(75, 23)
        Me.btn_backlogin_adm.TabIndex = 4
        Me.btn_backlogin_adm.Text = "KEMBALI"
        Me.btn_backlogin_adm.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Beige
        Me.Label12.Location = New System.Drawing.Point(61, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(482, 126)
        Me.Label12.TabIndex = 32
        '
        'Form_loginAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.btn_backlogin_adm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_login_adm)
        Me.Controls.Add(Me.txt_passlogin_adm)
        Me.Controls.Add(Me.txt_userlogin_adm)
        Me.Controls.Add(Me.Label12)
        Me.DoubleBuffered = True
        Me.Name = "Form_loginAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Admin "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_passlogin_adm As TextBox
    Friend WithEvents txt_userlogin_adm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_login_adm As Button
    Friend WithEvents btn_backlogin_adm As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
End Class
