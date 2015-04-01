<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Khach_hang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Khach_hang))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_soluongkhachhang = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grv_Danhsachkhachhang = New System.Windows.Forms.DataGridView()
        Me.grb_1 = New System.Windows.Forms.GroupBox()
        Me.btn_Xoa = New System.Windows.Forms.Button()
        Me.btn_Sua = New System.Windows.Forms.Button()
        Me.btn_Them = New System.Windows.Forms.Button()
        Me.btn_Xem = New System.Windows.Forms.Button()
        Me.grv_Danhsachhoadon = New System.Windows.Forms.DataGridView()
        Me.grb_2 = New System.Windows.Forms.GroupBox()
        Me.txt_Tenkhachhang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Sodienthoai = New System.Windows.Forms.TextBox()
        Me.txt_Diachi = New System.Windows.Forms.TextBox()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.grb_3 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.grv_Danhsachkhachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_1.SuspendLayout()
        CType(Me.grv_Danhsachhoadon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_2.SuspendLayout()
        Me.grb_3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_soluongkhachhang})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 409)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(776, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_soluongkhachhang
        '
        Me.lbl_soluongkhachhang.Name = "lbl_soluongkhachhang"
        Me.lbl_soluongkhachhang.Size = New System.Drawing.Size(119, 17)
        Me.lbl_soluongkhachhang.Text = "Số lượng khách hàng"
        '
        'grv_Danhsachkhachhang
        '
        Me.grv_Danhsachkhachhang.AllowUserToAddRows = False
        Me.grv_Danhsachkhachhang.AllowUserToDeleteRows = False
        Me.grv_Danhsachkhachhang.AllowUserToResizeColumns = False
        Me.grv_Danhsachkhachhang.AllowUserToResizeRows = False
        Me.grv_Danhsachkhachhang.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.grv_Danhsachkhachhang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grv_Danhsachkhachhang.CausesValidation = False
        Me.grv_Danhsachkhachhang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grv_Danhsachkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grv_Danhsachkhachhang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grv_Danhsachkhachhang.GridColor = System.Drawing.Color.WhiteSmoke
        Me.grv_Danhsachkhachhang.Location = New System.Drawing.Point(6, 19)
        Me.grv_Danhsachkhachhang.MultiSelect = False
        Me.grv_Danhsachkhachhang.Name = "grv_Danhsachkhachhang"
        Me.grv_Danhsachkhachhang.RowHeadersVisible = False
        Me.grv_Danhsachkhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grv_Danhsachkhachhang.Size = New System.Drawing.Size(421, 351)
        Me.grv_Danhsachkhachhang.TabIndex = 9
        '
        'grb_1
        '
        Me.grb_1.Controls.Add(Me.grv_Danhsachkhachhang)
        Me.grb_1.Location = New System.Drawing.Point(332, 12)
        Me.grb_1.Name = "grb_1"
        Me.grb_1.Size = New System.Drawing.Size(433, 376)
        Me.grb_1.TabIndex = 2
        Me.grb_1.TabStop = False
        Me.grb_1.Text = "Danh sách khách hàng"
        '
        'btn_Xoa
        '
        Me.btn_Xoa.Location = New System.Drawing.Point(8, 12)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_Xoa.TabIndex = 4
        Me.btn_Xoa.Text = "Xóa"
        Me.btn_Xoa.UseVisualStyleBackColor = True
        '
        'btn_Sua
        '
        Me.btn_Sua.Location = New System.Drawing.Point(89, 12)
        Me.btn_Sua.Name = "btn_Sua"
        Me.btn_Sua.Size = New System.Drawing.Size(75, 23)
        Me.btn_Sua.TabIndex = 3
        Me.btn_Sua.Text = "Sửa"
        Me.btn_Sua.UseVisualStyleBackColor = True
        '
        'btn_Them
        '
        Me.btn_Them.Location = New System.Drawing.Point(170, 12)
        Me.btn_Them.Name = "btn_Them"
        Me.btn_Them.Size = New System.Drawing.Size(75, 23)
        Me.btn_Them.TabIndex = 2
        Me.btn_Them.Text = "Thêm"
        Me.btn_Them.UseVisualStyleBackColor = True
        '
        'btn_Xem
        '
        Me.btn_Xem.Location = New System.Drawing.Point(251, 12)
        Me.btn_Xem.Name = "btn_Xem"
        Me.btn_Xem.Size = New System.Drawing.Size(75, 23)
        Me.btn_Xem.TabIndex = 1
        Me.btn_Xem.Text = "Xem"
        Me.btn_Xem.UseVisualStyleBackColor = True
        '
        'grv_Danhsachhoadon
        '
        Me.grv_Danhsachhoadon.AllowUserToAddRows = False
        Me.grv_Danhsachhoadon.AllowUserToDeleteRows = False
        Me.grv_Danhsachhoadon.AllowUserToResizeColumns = False
        Me.grv_Danhsachhoadon.AllowUserToResizeRows = False
        Me.grv_Danhsachhoadon.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.grv_Danhsachhoadon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grv_Danhsachhoadon.CausesValidation = False
        Me.grv_Danhsachhoadon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grv_Danhsachhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grv_Danhsachhoadon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grv_Danhsachhoadon.GridColor = System.Drawing.Color.WhiteSmoke
        Me.grv_Danhsachhoadon.Location = New System.Drawing.Point(6, 19)
        Me.grv_Danhsachhoadon.Name = "grv_Danhsachhoadon"
        Me.grv_Danhsachhoadon.RowHeadersVisible = False
        Me.grv_Danhsachhoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grv_Danhsachhoadon.Size = New System.Drawing.Size(222, 159)
        Me.grv_Danhsachhoadon.TabIndex = 8
        '
        'grb_2
        '
        Me.grb_2.Controls.Add(Me.grv_Danhsachhoadon)
        Me.grb_2.Location = New System.Drawing.Point(51, 204)
        Me.grb_2.Name = "grb_2"
        Me.grb_2.Size = New System.Drawing.Size(234, 184)
        Me.grb_2.TabIndex = 5
        Me.grb_2.TabStop = False
        Me.grb_2.Text = "Danh mục hóa đơn của khách hàng"
        '
        'txt_Tenkhachhang
        '
        Me.txt_Tenkhachhang.Location = New System.Drawing.Point(101, 19)
        Me.txt_Tenkhachhang.MaxLength = 49
        Me.txt_Tenkhachhang.Name = "txt_Tenkhachhang"
        Me.txt_Tenkhachhang.Size = New System.Drawing.Size(207, 20)
        Me.txt_Tenkhachhang.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tên khách hàng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Số điện thoại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Địa chỉ:"
        '
        'txt_Sodienthoai
        '
        Me.txt_Sodienthoai.Location = New System.Drawing.Point(101, 59)
        Me.txt_Sodienthoai.MaxLength = 11
        Me.txt_Sodienthoai.Name = "txt_Sodienthoai"
        Me.txt_Sodienthoai.Size = New System.Drawing.Size(207, 20)
        Me.txt_Sodienthoai.TabIndex = 6
        '
        'txt_Diachi
        '
        Me.txt_Diachi.Location = New System.Drawing.Point(101, 98)
        Me.txt_Diachi.MaxLength = 49
        Me.txt_Diachi.Name = "txt_Diachi"
        Me.txt_Diachi.Size = New System.Drawing.Size(207, 20)
        Me.txt_Diachi.TabIndex = 7
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_error.Location = New System.Drawing.Point(98, 132)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(0, 13)
        Me.lbl_error.TabIndex = 6
        '
        'grb_3
        '
        Me.grb_3.Controls.Add(Me.lbl_error)
        Me.grb_3.Controls.Add(Me.Label1)
        Me.grb_3.Controls.Add(Me.txt_Tenkhachhang)
        Me.grb_3.Controls.Add(Me.Label3)
        Me.grb_3.Controls.Add(Me.txt_Sodienthoai)
        Me.grb_3.Controls.Add(Me.Label2)
        Me.grb_3.Controls.Add(Me.txt_Diachi)
        Me.grb_3.Location = New System.Drawing.Point(12, 41)
        Me.grb_3.Name = "grb_3"
        Me.grb_3.Size = New System.Drawing.Size(314, 157)
        Me.grb_3.TabIndex = 8
        Me.grb_3.TabStop = False
        Me.grb_3.Text = "Nhập dữ liệu"
        '
        'Khach_hang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(776, 431)
        Me.Controls.Add(Me.grb_3)
        Me.Controls.Add(Me.grb_2)
        Me.Controls.Add(Me.btn_Xem)
        Me.Controls.Add(Me.btn_Them)
        Me.Controls.Add(Me.btn_Sua)
        Me.Controls.Add(Me.btn_Xoa)
        Me.Controls.Add(Me.grb_1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Khach_hang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách khách hàng"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.grv_Danhsachkhachhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_1.ResumeLayout(False)
        CType(Me.grv_Danhsachhoadon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_2.ResumeLayout(False)
        Me.grb_3.ResumeLayout(False)
        Me.grb_3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_soluongkhachhang As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents grb_1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Xoa As System.Windows.Forms.Button
    Friend WithEvents btn_Sua As System.Windows.Forms.Button
    Friend WithEvents btn_Them As System.Windows.Forms.Button
    Friend WithEvents btn_Xem As System.Windows.Forms.Button
    Friend WithEvents grb_2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Tenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Sodienthoai As System.Windows.Forms.TextBox
    Friend WithEvents txt_Diachi As System.Windows.Forms.TextBox
    Friend WithEvents lbl_error As System.Windows.Forms.Label
    Friend WithEvents grv_Danhsachkhachhang As System.Windows.Forms.DataGridView
    Friend WithEvents grv_Danhsachhoadon As System.Windows.Forms.DataGridView
    Friend WithEvents grb_3 As System.Windows.Forms.GroupBox
End Class
