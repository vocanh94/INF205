<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class San_pham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(San_pham))
        Me.txt_tensanpham = New System.Windows.Forms.TextBox()
        Me.grv_danhsachsanpham = New System.Windows.Forms.DataGridView()
        Me.txt_giasanpham = New System.Windows.Forms.TextBox()
        Me.grv_loaisanpham = New System.Windows.Forms.DataGridView()
        Me.txt_loaisanpham = New System.Windows.Forms.TextBox()
        Me.btn_clear_cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_thoat = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_soluong = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_error = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_soluong = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_chitiet = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grv_danhsachsanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv_loaisanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_soluong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_tensanpham
        '
        Me.txt_tensanpham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tensanpham.Location = New System.Drawing.Point(109, 21)
        Me.txt_tensanpham.MaxLength = 49
        Me.txt_tensanpham.Name = "txt_tensanpham"
        Me.txt_tensanpham.Size = New System.Drawing.Size(159, 20)
        Me.txt_tensanpham.TabIndex = 1
        '
        'grv_danhsachsanpham
        '
        Me.grv_danhsachsanpham.AllowUserToAddRows = False
        Me.grv_danhsachsanpham.AllowUserToDeleteRows = False
        Me.grv_danhsachsanpham.AllowUserToResizeColumns = False
        Me.grv_danhsachsanpham.AllowUserToResizeRows = False
        Me.grv_danhsachsanpham.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.grv_danhsachsanpham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.grv_danhsachsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grv_danhsachsanpham.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grv_danhsachsanpham.Location = New System.Drawing.Point(6, 19)
        Me.grv_danhsachsanpham.Name = "grv_danhsachsanpham"
        Me.grv_danhsachsanpham.RowHeadersVisible = False
        Me.grv_danhsachsanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grv_danhsachsanpham.Size = New System.Drawing.Size(629, 358)
        Me.grv_danhsachsanpham.TabIndex = 12
        '
        'txt_giasanpham
        '
        Me.txt_giasanpham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_giasanpham.Location = New System.Drawing.Point(109, 64)
        Me.txt_giasanpham.MaxLength = 12
        Me.txt_giasanpham.Name = "txt_giasanpham"
        Me.txt_giasanpham.Size = New System.Drawing.Size(123, 20)
        Me.txt_giasanpham.TabIndex = 2
        '
        'grv_loaisanpham
        '
        Me.grv_loaisanpham.AllowUserToAddRows = False
        Me.grv_loaisanpham.AllowUserToDeleteRows = False
        Me.grv_loaisanpham.AllowUserToResizeColumns = False
        Me.grv_loaisanpham.AllowUserToResizeRows = False
        Me.grv_loaisanpham.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.grv_loaisanpham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.grv_loaisanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grv_loaisanpham.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grv_loaisanpham.Location = New System.Drawing.Point(6, 45)
        Me.grv_loaisanpham.Name = "grv_loaisanpham"
        Me.grv_loaisanpham.RowHeadersVisible = False
        Me.grv_loaisanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grv_loaisanpham.Size = New System.Drawing.Size(241, 148)
        Me.grv_loaisanpham.TabIndex = 7
        '
        'txt_loaisanpham
        '
        Me.txt_loaisanpham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_loaisanpham.Enabled = False
        Me.txt_loaisanpham.Location = New System.Drawing.Point(6, 19)
        Me.txt_loaisanpham.Name = "txt_loaisanpham"
        Me.txt_loaisanpham.Size = New System.Drawing.Size(241, 20)
        Me.txt_loaisanpham.TabIndex = 6
        '
        'btn_clear_cancel
        '
        Me.btn_clear_cancel.Location = New System.Drawing.Point(274, 62)
        Me.btn_clear_cancel.Name = "btn_clear_cancel"
        Me.btn_clear_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear_cancel.TabIndex = 5
        Me.btn_clear_cancel.Text = "Nhập lại"
        Me.btn_clear_cancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tên sản phẩm:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Giá sản phẩm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Số lượng:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Chi tiết sản phẩm:"
        '
        'btn_them
        '
        Me.btn_them.Location = New System.Drawing.Point(274, 19)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(75, 23)
        Me.btn_them.TabIndex = 8
        Me.btn_them.Text = "Thêm >"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.Location = New System.Drawing.Point(274, 105)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(75, 23)
        Me.btn_sua.TabIndex = 9
        Me.btn_sua.Text = "< Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Location = New System.Drawing.Point(274, 148)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_xoa.TabIndex = 10
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_thoat
        '
        Me.btn_thoat.Location = New System.Drawing.Point(276, 379)
        Me.btn_thoat.Name = "btn_thoat"
        Me.btn_thoat.Size = New System.Drawing.Size(75, 23)
        Me.btn_thoat.TabIndex = 11
        Me.btn_thoat.Text = "Thoát"
        Me.btn_thoat.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_soluong, Me.lbl_error})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 414)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1010, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_soluong
        '
        Me.lbl_soluong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_soluong.Name = "lbl_soluong"
        Me.lbl_soluong.Size = New System.Drawing.Size(109, 17)
        Me.lbl_soluong.Text = "Số lượng sản phẩm"
        '
        'lbl_error
        '
        Me.lbl_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grv_loaisanpham)
        Me.GroupBox1.Controls.Add(Me.txt_loaisanpham)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 199)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loại sản phẩm"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grv_danhsachsanpham)
        Me.GroupBox2.Location = New System.Drawing.Point(357, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 383)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Danh sách sản phẩm"
        '
        'txt_soluong
        '
        Me.txt_soluong.Location = New System.Drawing.Point(109, 108)
        Me.txt_soluong.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txt_soluong.Name = "txt_soluong"
        Me.txt_soluong.Size = New System.Drawing.Size(86, 20)
        Me.txt_soluong.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "VNĐ"
        '
        'txt_chitiet
        '
        Me.txt_chitiet.Location = New System.Drawing.Point(109, 150)
        Me.txt_chitiet.MaxLength = 49
        Me.txt_chitiet.Name = "txt_chitiet"
        Me.txt_chitiet.Size = New System.Drawing.Size(159, 20)
        Me.txt_chitiet.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Organize
        Me.PictureBox1.Location = New System.Drawing.Point(274, 248)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'San_pham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1010, 436)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_chitiet)
        Me.Controls.Add(Me.btn_clear_cancel)
        Me.Controls.Add(Me.txt_soluong)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_thoat)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.btn_them)
        Me.Controls.Add(Me.txt_giasanpham)
        Me.Controls.Add(Me.txt_tensanpham)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "San_pham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách sản phẩm"
        CType(Me.grv_danhsachsanpham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv_loaisanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txt_soluong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_tensanpham As System.Windows.Forms.TextBox
    Friend WithEvents grv_danhsachsanpham As System.Windows.Forms.DataGridView
    Friend WithEvents txt_giasanpham As System.Windows.Forms.TextBox
    Friend WithEvents grv_loaisanpham As System.Windows.Forms.DataGridView
    Friend WithEvents txt_loaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents btn_clear_cancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents btn_thoat As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_soluong As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_soluong As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_error As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txt_chitiet As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
