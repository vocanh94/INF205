<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Xem_hoa_don
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Xem_hoa_don))
        Me.grv_hienthi = New System.Windows.Forms.DataGridView()
        Me.btn_print = New System.Windows.Forms.Button()
        CType(Me.grv_hienthi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grv_hienthi
        '
        Me.grv_hienthi.AllowUserToAddRows = False
        Me.grv_hienthi.AllowUserToDeleteRows = False
        Me.grv_hienthi.AllowUserToResizeColumns = False
        Me.grv_hienthi.AllowUserToResizeRows = False
        Me.grv_hienthi.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.grv_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grv_hienthi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grv_hienthi.Location = New System.Drawing.Point(12, 12)
        Me.grv_hienthi.Name = "grv_hienthi"
        Me.grv_hienthi.RowHeadersVisible = False
        Me.grv_hienthi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grv_hienthi.Size = New System.Drawing.Size(693, 355)
        Me.grv_hienthi.TabIndex = 0
        '
        'btn_print
        '
        Me.btn_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Image = Global.canhvvps02244_inf205.My.Resources.Resources.Print
        Me.btn_print.Location = New System.Drawing.Point(571, 373)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(134, 38)
        Me.btn_print.TabIndex = 1
        Me.btn_print.Text = "In hóa đơn"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'Xem_hoa_don
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(717, 423)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.grv_hienthi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Xem_hoa_don"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xem và in hóa đơn của khách hàng"
        CType(Me.grv_hienthi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grv_hienthi As System.Windows.Forms.DataGridView
    Friend WithEvents btn_print As System.Windows.Forms.Button
End Class
