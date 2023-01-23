<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_DataAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DataAdmin))
        Me.btn_cariadm_da = New System.Windows.Forms.Button()
        Me.txt_cariadm_da = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_kembali_da = New System.Windows.Forms.Button()
        Me.dgv_dataadm = New System.Windows.Forms.DataGridView()
        Me.btn_refresh_da = New System.Windows.Forms.Button()
        CType(Me.dgv_dataadm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cariadm_da
        '
        Me.btn_cariadm_da.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_cariadm_da.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cariadm_da.Image = CType(resources.GetObject("btn_cariadm_da.Image"), System.Drawing.Image)
        Me.btn_cariadm_da.Location = New System.Drawing.Point(354, 125)
        Me.btn_cariadm_da.Name = "btn_cariadm_da"
        Me.btn_cariadm_da.Size = New System.Drawing.Size(91, 25)
        Me.btn_cariadm_da.TabIndex = 32
        Me.btn_cariadm_da.Text = "PILIH"
        Me.btn_cariadm_da.UseVisualStyleBackColor = False
        '
        'txt_cariadm_da
        '
        Me.txt_cariadm_da.Location = New System.Drawing.Point(101, 126)
        Me.txt_cariadm_da.Name = "txt_cariadm_da"
        Me.txt_cariadm_da.Size = New System.Drawing.Size(247, 20)
        Me.txt_cariadm_da.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 14)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "ID ADMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 36)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "DATA ADMIN"
        '
        'btn_kembali_da
        '
        Me.btn_kembali_da.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_kembali_da.BackgroundImage = Global.design_kelompok.My.Resources.Resources.Untitled_design__1_
        Me.btn_kembali_da.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kembali_da.Location = New System.Drawing.Point(787, 451)
        Me.btn_kembali_da.Name = "btn_kembali_da"
        Me.btn_kembali_da.Size = New System.Drawing.Size(92, 41)
        Me.btn_kembali_da.TabIndex = 34
        Me.btn_kembali_da.Text = "KEMBALI"
        Me.btn_kembali_da.UseVisualStyleBackColor = False
        '
        'dgv_dataadm
        '
        Me.dgv_dataadm.BackgroundColor = System.Drawing.Color.Beige
        Me.dgv_dataadm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dataadm.Location = New System.Drawing.Point(12, 161)
        Me.dgv_dataadm.Name = "dgv_dataadm"
        Me.dgv_dataadm.Size = New System.Drawing.Size(868, 284)
        Me.dgv_dataadm.TabIndex = 35
        '
        'btn_refresh_da
        '
        Me.btn_refresh_da.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh_da.Image = CType(resources.GetObject("btn_refresh_da.Image"), System.Drawing.Image)
        Me.btn_refresh_da.Location = New System.Drawing.Point(451, 125)
        Me.btn_refresh_da.Name = "btn_refresh_da"
        Me.btn_refresh_da.Size = New System.Drawing.Size(91, 25)
        Me.btn_refresh_da.TabIndex = 36
        Me.btn_refresh_da.Text = "REFRESH"
        Me.btn_refresh_da.UseVisualStyleBackColor = True
        '
        'DataAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(890, 501)
        Me.Controls.Add(Me.btn_refresh_da)
        Me.Controls.Add(Me.dgv_dataadm)
        Me.Controls.Add(Me.btn_kembali_da)
        Me.Controls.Add(Me.btn_cariadm_da)
        Me.Controls.Add(Me.txt_cariadm_da)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "DataAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataAdmin"
        CType(Me.dgv_dataadm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cariadm_da As Button
    Friend WithEvents txt_cariadm_da As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_kembali_da As Button
    Friend WithEvents dgv_dataadm As DataGridView
    Friend WithEvents btn_refresh_da As Button
End Class
