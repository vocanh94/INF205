<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nguoi_dung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nguoi_dung))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_xem = New System.Windows.Forms.Button()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.XuatDuLieu = New System.Windows.Forms.DataGridView()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.txt_tennguoidung = New System.Windows.Forms.TextBox()
        Me.txt_matkhaucu = New System.Windows.Forms.TextBox()
        Me.txt_taikhoan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_IDnguoidung = New System.Windows.Forms.Label()
        Me.grb_thongtin = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_matkhaumoi = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_tongso = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.XuatDuLieu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_thongtin.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_xem)
        Me.GroupBox1.Controls.Add(Me.btn_them)
        Me.GroupBox1.Controls.Add(Me.btn_sua)
        Me.GroupBox1.Controls.Add(Me.btn_xoa)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'btn_xem
        '
        resources.ApplyResources(Me.btn_xem, "btn_xem")
        Me.btn_xem.Name = "btn_xem"
        Me.btn_xem.UseVisualStyleBackColor = True
        '
        'btn_them
        '
        resources.ApplyResources(Me.btn_them, "btn_them")
        Me.btn_them.Name = "btn_them"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        resources.ApplyResources(Me.btn_sua, "btn_sua")
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        resources.ApplyResources(Me.btn_xoa, "btn_xoa")
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'XuatDuLieu
        '
        Me.XuatDuLieu.AllowUserToAddRows = False
        Me.XuatDuLieu.AllowUserToDeleteRows = False
        Me.XuatDuLieu.AllowUserToResizeColumns = False
        Me.XuatDuLieu.AllowUserToResizeRows = False
        Me.XuatDuLieu.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.XuatDuLieu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.XuatDuLieu.CausesValidation = False
        Me.XuatDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.XuatDuLieu.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.XuatDuLieu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.XuatDuLieu.GridColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.XuatDuLieu, "XuatDuLieu")
        Me.XuatDuLieu.MultiSelect = False
        Me.XuatDuLieu.Name = "XuatDuLieu"
        Me.XuatDuLieu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.XuatDuLieu.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.XuatDuLieu.RowHeadersVisible = False
        Me.XuatDuLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'lbl_error
        '
        resources.ApplyResources(Me.lbl_error, "lbl_error")
        Me.lbl_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_error.Name = "lbl_error"
        '
        'txt_tennguoidung
        '
        resources.ApplyResources(Me.txt_tennguoidung, "txt_tennguoidung")
        Me.txt_tennguoidung.Name = "txt_tennguoidung"
        '
        'txt_matkhaucu
        '
        resources.ApplyResources(Me.txt_matkhaucu, "txt_matkhaucu")
        Me.txt_matkhaucu.Name = "txt_matkhaucu"
        Me.txt_matkhaucu.UseSystemPasswordChar = True
        '
        'txt_taikhoan
        '
        resources.ApplyResources(Me.txt_taikhoan, "txt_taikhoan")
        Me.txt_taikhoan.Name = "txt_taikhoan"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'lbl_IDnguoidung
        '
        resources.ApplyResources(Me.lbl_IDnguoidung, "lbl_IDnguoidung")
        Me.lbl_IDnguoidung.Name = "lbl_IDnguoidung"
        '
        'grb_thongtin
        '
        Me.grb_thongtin.Controls.Add(Me.lbl_IDnguoidung)
        Me.grb_thongtin.Controls.Add(Me.lbl_error)
        Me.grb_thongtin.Controls.Add(Me.Label5)
        Me.grb_thongtin.Controls.Add(Me.txt_tennguoidung)
        Me.grb_thongtin.Controls.Add(Me.Label1)
        Me.grb_thongtin.Controls.Add(Me.Label3)
        Me.grb_thongtin.Controls.Add(Me.txt_matkhaumoi)
        Me.grb_thongtin.Controls.Add(Me.txt_matkhaucu)
        Me.grb_thongtin.Controls.Add(Me.Label4)
        Me.grb_thongtin.Controls.Add(Me.txt_taikhoan)
        resources.ApplyResources(Me.grb_thongtin, "grb_thongtin")
        Me.grb_thongtin.Name = "grb_thongtin"
        Me.grb_thongtin.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txt_matkhaumoi
        '
        resources.ApplyResources(Me.txt_matkhaumoi, "txt_matkhaumoi")
        Me.txt_matkhaumoi.Name = "txt_matkhaumoi"
        Me.txt_matkhaumoi.UseSystemPasswordChar = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_tongso})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.SizingGrip = False
        '
        'lbl_tongso
        '
        Me.lbl_tongso.Name = "lbl_tongso"
        resources.ApplyResources(Me.lbl_tongso, "lbl_tongso")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.XuatDuLieu)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'Nguoi_dung
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grb_thongtin)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Nguoi_dung"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.XuatDuLieu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_thongtin.ResumeLayout(False)
        Me.grb_thongtin.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_xem As System.Windows.Forms.Button
    Friend WithEvents XuatDuLieu As System.Windows.Forms.DataGridView
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents lbl_error As System.Windows.Forms.Label
    Friend WithEvents txt_tennguoidung As System.Windows.Forms.TextBox
    Friend WithEvents txt_matkhaucu As System.Windows.Forms.TextBox
    Friend WithEvents txt_taikhoan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_IDnguoidung As System.Windows.Forms.Label
    Friend WithEvents grb_thongtin As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_tongso As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_matkhaumoi As System.Windows.Forms.TextBox
End Class
