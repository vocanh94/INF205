Public Class In_hoa_don

    Private Sub link_inhoadon_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_inhoadon.LinkClicked
        Try
            Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
            Me.PrintForm1.Print()
        Catch ex As Exception
            MessageBox.Show("Không thể in được vì không xác định được máy in mặc định của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub In_hoa_don_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Xem_hoa_don.Enabled = False
    End Sub

    Private Sub In_hoa_don_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Xem_hoa_don.Enabled = True
    End Sub

    Private Sub In_hoa_don_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Xem_hoa_don.Enabled = True
    End Sub
End Class