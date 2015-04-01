<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Them_khach_hang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Them_khach_hang))
        Me.txt_sodienthoai = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_diachi = New System.Windows.Forms.TextBox()
        Me.txt_ten = New System.Windows.Forms.TextBox()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_sodienthoai
        '
        Me.txt_sodienthoai.Location = New System.Drawing.Point(160, 70)
        Me.txt_sodienthoai.MaxLength = 11
        Me.txt_sodienthoai.Name = "txt_sodienthoai"
        Me.txt_sodienthoai.Size = New System.Drawing.Size(199, 20)
        Me.txt_sodienthoai.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tên khách hàng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Số điện thoại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Địa chỉ:"
        '
        'txt_diachi
        '
        Me.txt_diachi.Location = New System.Drawing.Point(160, 111)
        Me.txt_diachi.Name = "txt_diachi"
        Me.txt_diachi.Size = New System.Drawing.Size(199, 20)
        Me.txt_diachi.TabIndex = 3
        '
        'txt_ten
        '
        Me.txt_ten.Location = New System.Drawing.Point(160, 29)
        Me.txt_ten.Name = "txt_ten"
        Me.txt_ten.Size = New System.Drawing.Size(199, 20)
        Me.txt_ten.TabIndex = 1
        '
        'btn_them
        '
        Me.btn_them.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_them.Location = New System.Drawing.Point(265, 167)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(94, 35)
        Me.btn_them.TabIndex = 4
        Me.btn_them.Text = "Thêm"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_error.Location = New System.Drawing.Point(157, 142)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(0, 13)
        Me.lbl_error.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.canhvvps02244_inf205.My.Resources.Resources.WLM
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 153)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Them_khach_hang
        '
        Me.AcceptButton = Me.btn_them
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(415, 226)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_error)
        Me.Controls.Add(Me.btn_them)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_ten)
        Me.Controls.Add(Me.txt_diachi)
        Me.Controls.Add(Me.txt_sodienthoai)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Them_khach_hang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm khách hàng mới"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_sodienthoai As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_diachi As System.Windows.Forms.TextBox
    Friend WithEvents txt_ten As System.Windows.Forms.TextBox
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents lbl_error As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
