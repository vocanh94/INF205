Imports System.Data.SqlClient
Public Class Them_khach_hang


    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        Dim kiemtra As New SqlDataAdapter("select * from KHACH_HANG where Ten_khach_hang = '" & txt_ten.Text & "'", Login.ketnoi)
        Dim tb_kiemtra As New DataTable
        Login.ketnoi.Open()
        kiemtra.Fill(tb_kiemtra)
        Login.ketnoi.Close()
        If txt_ten.Text = "" And txt_sodienthoai.Text = "" And txt_diachi.Text = "" Then
            MessageBox.Show("Bạn chưa nhập gì cả :(", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txt_ten.Text = "" Then
            MessageBox.Show("Bạn chưa nhập tên khách hàng :(", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf tb_kiemtra.Rows.Count() > 0 Then
            MessageBox.Show("Người dùng đã tồn tại :(", "Rất tiết !", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_ten.Focus()
        Else
            If txt_sodienthoai.Text = "" Then
                txt_sodienthoai.Text = "Null"
            End If

            If txt_diachi.Text = "" Then
                txt_diachi.Text = "Null"
            End If

            Dim sql As New SqlDataAdapter("insert into KHACH_HANG values ('" & txt_ten.Text & "','" & txt_sodienthoai.Text & "','" & txt_diachi.Text & "')", Login.ketnoi)
            Dim tb As New DataTable
            Login.ketnoi.Open()
            sql.Fill(tb)
            Login.ketnoi.Close()
            MessageBox.Show("Thêm thông tin khách hàng thành công", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_ten.Text = ""
            txt_sodienthoai.Text = ""
            txt_diachi.Text = ""
        End If
    End Sub

    Private Sub txt_sodienthoai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sodienthoai.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            lbl_error.Text = ""
            Exit Sub
        End If
        lbl_error.Text = "Bạn phải nhập số điện thoại"
        txt_sodienthoai.Clear()
    End Sub

    Private Sub Them_khach_hang_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Khach_hang.Enabled = True
        Khach_hang.btn_Xem.PerformClick()
    End Sub

    Private Sub Them_khach_hang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Khach_hang.Enabled = True
        Khach_hang.btn_Xem.PerformClick()
    End Sub

End Class