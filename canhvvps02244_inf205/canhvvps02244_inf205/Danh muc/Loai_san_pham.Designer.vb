<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loai_san_pham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loai_san_pham))
        Me.btn_them = New System.Windows.Forms.Button()
        Me.grv_hienthi = New System.Windows.Forms.DataGridView()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.txt_nhap = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_error = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_thongbao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grv_hienthi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_them
        '
        Me.btn_them.Location = New System.Drawing.Point(286, 30)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(75, 23)
        Me.btn_them.TabIndex = 2
        Me.btn_them.Text = "Add"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'grv_hienthi
        '
        Me.grv_hienthi.AllowUserToAddRows = False
        Me.grv_hienthi.AllowUserToDeleteRows = False
        Me.grv_hienthi.AllowUserToResizeColumns = False
        Me.grv_hienthi.AllowUserToResizeRows = False
        Me.grv_hienthi.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.grv_hienthi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grv_hienthi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grv_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grv_hienthi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grv_hienthi.Location = New System.Drawing.Point(367, 30)
        Me.grv_hienthi.Name = "grv_hienthi"
        Me.grv_hienthi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grv_hienthi.RowHeadersVisible = False
        Me.grv_hienthi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grv_hienthi.Size = New System.Drawing.Size(232, 197)
        Me.grv_hienthi.TabIndex = 5
        '
        'btn_xoa
        '
        Me.btn_xoa.Location = New System.Drawing.Point(286, 204)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_xoa.TabIndex = 4
        Me.btn_xoa.Text = "Remove"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'txt_nhap
        '
        Me.txt_nhap.Location = New System.Drawing.Point(94, 32)
        Me.txt_nhap.MaxLength = 29
        Me.txt_nhap.Name = "txt_nhap"
        Me.txt_nhap.Size = New System.Drawing.Size(158, 20)
        Me.txt_nhap.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Loại sản phẩm"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_error, Me.lbl_thongbao})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 238)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(610, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_error
        '
        Me.lbl_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(0, 17)
        '
        'lbl_thongbao
        '
        Me.lbl_thongbao.ForeColor = System.Drawing.Color.Blue
        Me.lbl_thongbao.Name = "lbl_thongbao"
        Me.lbl_thongbao.Size = New System.Drawing.Size(0, 17)
        '
        'btn_sua
        '
        Me.btn_sua.Location = New System.Drawing.Point(286, 59)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(75, 23)
        Me.btn_sua.TabIndex = 3
        Me.btn_sua.Text = "Edit"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Misc_Box
        Me.PictureBox1.Location = New System.Drawing.Point(12, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Loai_san_pham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(610, 260)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nhap)
        Me.Controls.Add(Me.grv_hienthi)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.btn_them)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Loai_san_pham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loại sản phẩm"
        CType(Me.grv_hienthi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents grv_hienthi As System.Windows.Forms.DataGridView
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents txt_nhap As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_error As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_thongbao As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
