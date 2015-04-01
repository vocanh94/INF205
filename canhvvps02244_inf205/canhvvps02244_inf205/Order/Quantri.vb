Imports System.Data.SqlClient
Imports System.IO
Public Class Quantri

    Private Sub Quantri_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Login.txt_nhap_user.Text = ""
        Login.txt_nhap_pass.Text = ""
        Login.txt_nhap_user.Focus()
        Login.txt_nhap_user.Focus()
        Login.Show()
    End Sub

    Private Sub Quantri_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.txt_nhap_user.Text = ""
        Login.txt_nhap_pass.Text = ""
        Login.txt_nhap_user.Focus()
        Login.txt_nhap_user.Focus()
        Login.Show()
    End Sub

    Private Sub NgườiDùngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NgườiDùngToolStripMenuItem.Click
        Nguoi_dung.Show()
        Me.Hide()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Rất tiếc", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        Dim sql As New SqlDataAdapter("select Ten_dang_nhap from NGUOI_DUNG where Ma_nguoi_dung = " & Login.id_nguoidung & "", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        '**********************
        If MessageBox.Show("Bạn có muốn đăng xuất khỏi tài khoản '" & Convert.ToString(tb.Rows(0).Item(0).ToString()) & "'", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Login.Show()
        Me.Close()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        Khach_hang.Show()
        Me.Hide()
    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click
        Loai_san_pham.Show()
        Me.Hide()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Rất tiếc", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        Dim sql As New SqlDataAdapter("select * from LOAI_SAN_PHAM", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        If tb.Rows.Count() < 1 Then
            MessageBox.Show("Không có loại sản phẩm, Hãy thêm chúng từ menu 'Danh mục > Loại sản phẩm'", "Thông báo :(", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        San_pham.Show()
        Me.Hide()
    End Sub

    Private Sub KiểmTraKếtNốiCSDLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KiểmTraKếtNốiCSDLToolStripMenuItem.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
            MessageBox.Show("Kết nối thành công, Cơ sở dữ liệu đã sẵn sàng :)", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Rất tiếc", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
    End Sub

    Private Sub Quantri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Rất tiếc", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        Dim sql As New SqlDataAdapter("select Ten_dang_nhap from NGUOI_DUNG where Ma_nguoi_dung = " & Login.id_nguoidung & "", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        If Login.id_nguoidung < 1 Then
            Exit Sub
        End If
        ĐăngXuấtToolStripMenuItem.Text = "Đăng xuất (" & Convert.ToString(tb.Rows(0).Item(0).ToString()) & ")"
        lbl_welcome.Text = "- Welcome '" & Convert.ToString(tb.Rows(0).Item(0).ToString()) & "' to My Software"
    End Sub

    Private Sub GhiHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GhiHóaĐơnToolStripMenuItem.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Rất tiếc", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        Dim sql As New SqlDataAdapter("select * from SAN_PHAM", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        If tb.Rows.Count() < 1 Then
            MessageBox.Show("Không có danh sách sản phẩm, Hãy thêm chúng từ menu 'Danh mục > Thêm sản phẩm'", "Thông báo :(", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Ghi_hoa_don.Show()
        Me.Hide()
    End Sub

    Private Sub XemHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemHóaĐơnToolStripMenuItem.Click
        Xem_hoa_don.Show()
        Me.Hide()
    End Sub

    Private Sub GiớiThiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiớiThiệuToolStripMenuItem.Click
        info.Show()
        Me.Enabled = False
    End Sub

    Private Sub TrợGiúpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrợGiúpToolStripMenuItem.Click
        Help.Show()
        Me.Enabled = False
    End Sub
End Class