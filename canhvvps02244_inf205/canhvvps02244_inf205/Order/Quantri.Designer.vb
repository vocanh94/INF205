<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quantri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quantri))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_welcome = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NgườiDùngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhMụcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoạiSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChứcNăngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GhiHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KiểmTraKếtNốiCSDLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrợGiúpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiớiThiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_info, Me.lbl_welcome})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 341)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(726, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_info
        '
        Me.lbl_info.ForeColor = System.Drawing.Color.White
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(191, 17)
        Me.lbl_info.Text = "Copyright 03/2015 by Vo Van Canh"
        '
        'lbl_welcome
        '
        Me.lbl_welcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_welcome.Name = "lbl_welcome"
        Me.lbl_welcome.Size = New System.Drawing.Size(70, 17)
        Me.lbl_welcome.Text = "Chào mừng"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.DanhMụcToolStripMenuItem, Me.ChứcNăngToolStripMenuItem, Me.KiểmTraKếtNốiCSDLToolStripMenuItem, Me.TrợGiúpToolStripMenuItem, Me.GiớiThiệuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(726, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NgườiDùngToolStripMenuItem, Me.ĐăngXuấtToolStripMenuItem})
        Me.HệThốngToolStripMenuItem.Image = Global.canhvvps02244_inf205.My.Resources.Resources.System
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(90, 21)
        Me.HệThốngToolStripMenuItem.Text = "Hệ thống"
        '
        'NgườiDùngToolStripMenuItem
        '
        Me.NgườiDùngToolStripMenuItem.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Tools
        Me.NgườiDùngToolStripMenuItem.Name = "NgườiDùngToolStripMenuItem"
        Me.NgườiDùngToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NgườiDùngToolStripMenuItem.Text = "Người dùng"
        '
        'ĐăngXuấtToolStripMenuItem
        '
        Me.ĐăngXuấtToolStripMenuItem.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Shutdown
        Me.ĐăngXuấtToolStripMenuItem.Name = "ĐăngXuấtToolStripMenuItem"
        Me.ĐăngXuấtToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ĐăngXuấtToolStripMenuItem.Text = "Đăng xuất"
        '
        'DanhMụcToolStripMenuItem
        '
        Me.DanhMụcToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KháchHàngToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem, Me.LoạiSảnPhẩmToolStripMenuItem})
        Me.DanhMụcToolStripMenuItem.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Download
        Me.DanhMụcToolStripMenuItem.Name = "DanhMụcToolStripMenuItem"
        Me.DanhMụcToolStripMenuItem.Size = New System.Drawing.Size(94, 21)
        Me.DanhMụcToolStripMenuItem.Text = "Danh mục"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.Image = Global.canhvvps02244_inf205.My.Resources.Resources.WLM
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.KháchHàngToolStripMenuItem.Text = "Khách hàng"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Misc_Box
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản phẩm"
        '
        'LoạiSảnPhẩmToolStripMenuItem
        '
        Me.LoạiSảnPhẩmToolStripMenuItem.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Organize
        Me.LoạiSảnPhẩmToolStripMenuItem.Name = "LoạiSảnPhẩmToolStripMenuItem"
        Me.LoạiSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.LoạiSảnPhẩmToolStripMenuItem.Text = "Loại sản phẩm"
        '
        'ChứcNăngToolStripMenuItem
        '
        Me.ChứcNăngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GhiHóaĐơnToolStripMenuItem, Me.XemHóaĐơnToolStripMenuItem})
        Me.ChứcNăngToolStripMenuItem.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Stats
        Me.ChứcNăngToolStripMenuItem.Name = "ChứcNăngToolStripMenuItem"
        Me.ChứcNăngToolStripMenuItem.Size = New System.Drawing.Size(98, 21)
        Me.ChứcNăngToolStripMenuItem.Text = "Chức năng"
        '
        'GhiHóaĐơnToolStripMenuItem
        '
        Me.GhiHóaĐơnToolStripMenuItem.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Edit
        Me.GhiHóaĐơnToolStripMenuItem.Name = "GhiHóaĐơnToolStripMenuItem"
        Me.GhiHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.GhiHóaĐơnToolStripMenuItem.Text = "Ghi hóa đơn"
        '
        'XemHóaĐơnToolStripMenuItem
        '
        Me.XemHóaĐơnToolStripMenuItem.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Search
        Me.XemHóaĐơnToolStripMenuItem.Name = "XemHóaĐơnToolStripMenuItem"
        Me.XemHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.XemHóaĐơnToolStripMenuItem.Text = "Xem và In hóa đơn"
        '
        'KiểmTraKếtNốiCSDLToolStripMenuItem
        '
        Me.KiểmTraKếtNốiCSDLToolStripMenuItem.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Internet
        Me.KiểmTraKếtNốiCSDLToolStripMenuItem.Name = "KiểmTraKếtNốiCSDLToolStripMenuItem"
        Me.KiểmTraKếtNốiCSDLToolStripMenuItem.Size = New System.Drawing.Size(162, 21)
        Me.KiểmTraKếtNốiCSDLToolStripMenuItem.Text = "Kiểm tra kết nối CSDL"
        '
        'TrợGiúpToolStripMenuItem
        '
        Me.TrợGiúpToolStripMenuItem.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Info
        Me.TrợGiúpToolStripMenuItem.Name = "TrợGiúpToolStripMenuItem"
        Me.TrợGiúpToolStripMenuItem.Size = New System.Drawing.Size(86, 21)
        Me.TrợGiúpToolStripMenuItem.Text = "Trợ giúp"
        '
        'GiớiThiệuToolStripMenuItem
        '
        Me.GiớiThiệuToolStripMenuItem.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Fav__Star_
        Me.GiớiThiệuToolStripMenuItem.Name = "GiớiThiệuToolStripMenuItem"
        Me.GiớiThiệuToolStripMenuItem.Size = New System.Drawing.Size(91, 21)
        Me.GiớiThiệuToolStripMenuItem.Text = "Giới thiệu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(71, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(586, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hệ thống phần mềm quản lý bán hàng"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.canhvvps02244_inf205.My.Resources.Resources.logo_fpoly
        Me.PictureBox1.Location = New System.Drawing.Point(248, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Quantri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.canhvvps02244_inf205.My.Resources.Resources.Windows_7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(726, 363)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Quantri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý bán hàng"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HệThốngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DanhMụcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChứcNăngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrợGiúpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GiớiThiệuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngXuấtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NgườiDùngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GhiHóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XemHóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoạiSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KiểmTraKếtNốiCSDLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_welcome As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
