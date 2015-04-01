<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class In_hoa_don
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(In_hoa_don))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.lbl_tenKH = New System.Windows.Forms.Label()
        Me.lbl_sanphammua = New System.Windows.Forms.Label()
        Me.lbl_soluongmua = New System.Windows.Forms.Label()
        Me.lbl_loai = New System.Windows.Forms.Label()
        Me.lbl_dongia = New System.Windows.Forms.Label()
        Me.lbl_sodienthoai = New System.Windows.Forms.Label()
        Me.lbl_diachi = New System.Windows.Forms.Label()
        Me.lbl_tongtien = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.lbl_ngayghi = New System.Windows.Forms.Label()
        Me.link_inhoadon = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'lbl_tenKH
        '
        Me.lbl_tenKH.AutoSize = True
        Me.lbl_tenKH.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tenKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tenKH.Location = New System.Drawing.Point(184, 109)
        Me.lbl_tenKH.Name = "lbl_tenKH"
        Me.lbl_tenKH.Size = New System.Drawing.Size(94, 18)
        Me.lbl_tenKH.TabIndex = 7
        Me.lbl_tenKH.Text = "Võ Văn Cảnh"
        '
        'lbl_sanphammua
        '
        Me.lbl_sanphammua.AutoSize = True
        Me.lbl_sanphammua.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sanphammua.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sanphammua.Location = New System.Drawing.Point(155, 139)
        Me.lbl_sanphammua.Name = "lbl_sanphammua"
        Me.lbl_sanphammua.Size = New System.Drawing.Size(142, 18)
        Me.lbl_sanphammua.TabIndex = 7
        Me.lbl_sanphammua.Text = "Samsung Galaxy S6"
        '
        'lbl_soluongmua
        '
        Me.lbl_soluongmua.AutoSize = True
        Me.lbl_soluongmua.BackColor = System.Drawing.Color.Transparent
        Me.lbl_soluongmua.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_soluongmua.Location = New System.Drawing.Point(140, 170)
        Me.lbl_soluongmua.Name = "lbl_soluongmua"
        Me.lbl_soluongmua.Size = New System.Drawing.Size(24, 18)
        Me.lbl_soluongmua.TabIndex = 7
        Me.lbl_soluongmua.Text = "15"
        '
        'lbl_loai
        '
        Me.lbl_loai.AutoSize = True
        Me.lbl_loai.BackColor = System.Drawing.Color.Transparent
        Me.lbl_loai.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loai.Location = New System.Drawing.Point(104, 200)
        Me.lbl_loai.Name = "lbl_loai"
        Me.lbl_loai.Size = New System.Drawing.Size(95, 18)
        Me.lbl_loai.TabIndex = 7
        Me.lbl_loai.Text = "Smart Phone"
        '
        'lbl_dongia
        '
        Me.lbl_dongia.AutoSize = True
        Me.lbl_dongia.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dongia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dongia.Location = New System.Drawing.Point(104, 229)
        Me.lbl_dongia.Name = "lbl_dongia"
        Me.lbl_dongia.Size = New System.Drawing.Size(115, 18)
        Me.lbl_dongia.TabIndex = 7
        Me.lbl_dongia.Text = "16,590,000 VNĐ"
        '
        'lbl_sodienthoai
        '
        Me.lbl_sodienthoai.AutoSize = True
        Me.lbl_sodienthoai.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sodienthoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sodienthoai.Location = New System.Drawing.Point(184, 260)
        Me.lbl_sodienthoai.Name = "lbl_sodienthoai"
        Me.lbl_sodienthoai.Size = New System.Drawing.Size(88, 18)
        Me.lbl_sodienthoai.TabIndex = 7
        Me.lbl_sodienthoai.Text = "0969272170"
        '
        'lbl_diachi
        '
        Me.lbl_diachi.AutoSize = True
        Me.lbl_diachi.BackColor = System.Drawing.Color.Transparent
        Me.lbl_diachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diachi.Location = New System.Drawing.Point(174, 290)
        Me.lbl_diachi.Name = "lbl_diachi"
        Me.lbl_diachi.Size = New System.Drawing.Size(90, 18)
        Me.lbl_diachi.TabIndex = 7
        Me.lbl_diachi.Text = "Ho Chi Minh"
        '
        'lbl_tongtien
        '
        Me.lbl_tongtien.AutoSize = True
        Me.lbl_tongtien.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tongtien.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tongtien.Location = New System.Drawing.Point(403, 321)
        Me.lbl_tongtien.Name = "lbl_tongtien"
        Me.lbl_tongtien.Size = New System.Drawing.Size(115, 18)
        Me.lbl_tongtien.TabIndex = 7
        Me.lbl_tongtien.Text = "16,540,000 VNĐ"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ID.Location = New System.Drawing.Point(544, 12)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(21, 15)
        Me.lbl_ID.TabIndex = 7
        Me.lbl_ID.Text = "15"
        '
        'lbl_ngayghi
        '
        Me.lbl_ngayghi.AutoSize = True
        Me.lbl_ngayghi.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ngayghi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ngayghi.Location = New System.Drawing.Point(521, 34)
        Me.lbl_ngayghi.Name = "lbl_ngayghi"
        Me.lbl_ngayghi.Size = New System.Drawing.Size(65, 13)
        Me.lbl_ngayghi.TabIndex = 7
        Me.lbl_ngayghi.Text = "06/02/1994"
        '
        'link_inhoadon
        '
        Me.link_inhoadon.AutoSize = True
        Me.link_inhoadon.Location = New System.Drawing.Point(562, 469)
        Me.link_inhoadon.Name = "link_inhoadon"
        Me.link_inhoadon.Size = New System.Drawing.Size(59, 13)
        Me.link_inhoadon.TabIndex = 8
        Me.link_inhoadon.TabStop = True
        Me.link_inhoadon.Text = "In hóa đơn"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Untitled1
        Me.PictureBox1.Location = New System.Drawing.Point(12, -16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(609, 446)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'In_hoa_don
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(627, 491)
        Me.Controls.Add(Me.link_inhoadon)
        Me.Controls.Add(Me.lbl_tongtien)
        Me.Controls.Add(Me.lbl_diachi)
        Me.Controls.Add(Me.lbl_sodienthoai)
        Me.Controls.Add(Me.lbl_dongia)
        Me.Controls.Add(Me.lbl_loai)
        Me.Controls.Add(Me.lbl_ngayghi)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.lbl_soluongmua)
        Me.Controls.Add(Me.lbl_sanphammua)
        Me.Controls.Add(Me.lbl_tenKH)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "In_hoa_don"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In_hoa_don"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_tenKH As System.Windows.Forms.Label
    Friend WithEvents lbl_tongtien As System.Windows.Forms.Label
    Friend WithEvents lbl_diachi As System.Windows.Forms.Label
    Friend WithEvents lbl_sodienthoai As System.Windows.Forms.Label
    Friend WithEvents lbl_dongia As System.Windows.Forms.Label
    Friend WithEvents lbl_loai As System.Windows.Forms.Label
    Friend WithEvents lbl_soluongmua As System.Windows.Forms.Label
    Friend WithEvents lbl_sanphammua As System.Windows.Forms.Label
    Friend WithEvents lbl_ID As System.Windows.Forms.Label
    Friend WithEvents lbl_ngayghi As System.Windows.Forms.Label
    Friend WithEvents link_inhoadon As System.Windows.Forms.LinkLabel
End Class
