<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Logout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Logout))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ya_logout = New System.Windows.Forms.Button()
        Me.btn_tidak_logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ANDA YAKIN INGIN KELUAR?"
        '
        'btn_ya_logout
        '
        Me.btn_ya_logout.BackgroundImage = CType(resources.GetObject("btn_ya_logout.BackgroundImage"), System.Drawing.Image)
        Me.btn_ya_logout.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ya_logout.Location = New System.Drawing.Point(42, 94)
        Me.btn_ya_logout.Name = "btn_ya_logout"
        Me.btn_ya_logout.Size = New System.Drawing.Size(75, 33)
        Me.btn_ya_logout.TabIndex = 1
        Me.btn_ya_logout.Text = "YA"
        Me.btn_ya_logout.UseVisualStyleBackColor = True
        '
        'btn_tidak_logout
        '
        Me.btn_tidak_logout.BackgroundImage = CType(resources.GetObject("btn_tidak_logout.BackgroundImage"), System.Drawing.Image)
        Me.btn_tidak_logout.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tidak_logout.Location = New System.Drawing.Point(261, 94)
        Me.btn_tidak_logout.Name = "btn_tidak_logout"
        Me.btn_tidak_logout.Size = New System.Drawing.Size(75, 33)
        Me.btn_tidak_logout.TabIndex = 1
        Me.btn_tidak_logout.Text = "TIDAK"
        Me.btn_tidak_logout.UseVisualStyleBackColor = True
        '
        'konfirmasiLogout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(384, 161)
        Me.Controls.Add(Me.btn_tidak_logout)
        Me.Controls.Add(Me.btn_ya_logout)
        Me.Controls.Add(Me.Label1)
        Me.Name = "konfirmasiLogout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGOUT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ya_logout As Button
    Friend WithEvents btn_tidak_logout As Button
End Class
