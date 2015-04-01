Imports System.Data.SqlClient

Public Class Login
    '*******************************************
    Public ketnoi As New SqlConnection("workstation id=vocanh1994.mssql.somee.com;packet size=4096;user id=canhvv;pwd=Vocanh02012004;data source=vocanh1994.mssql.somee.com;persist security info=False;initial catalog=vocanh1994")

    Sub ketnoidatabase()
        If 1 < 0 Then
            MessageBox.Show("Không kết nối với Database được, xin hãy kiểm tra kết nối mạng :(", "Không kết nối đuọc", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
    End Sub

    Private Sub btn_thoat_Click(sender As Object, e As EventArgs) Handles btn_thoat.Click
        Me.Close()
    End Sub

    Private Sub btn_dangnhap_Click(sender As Object, e As EventArgs) Handles btn_dangnhap.Click
        '*********************
        Try
            ketnoi.Open()
            ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_nhap_user.Focus()
            Exit Sub
        End Try
        '*********************
        Dim nguoidung As String
        Dim matkhau As String
        nguoidung = txt_nhap_user.Text
        matkhau = txt_nhap_pass.Text
        If nguoidung = "" And matkhau = "" Then
            lbl_error.Text = "Bạn phải nhập dữ liệu"
            txt_nhap_user.Focus()
        ElseIf nguoidung = "" And matkhau <> "" Then
            lbl_error.Text = "Chưa nhập tài khoản người dùng"
            txt_nhap_user.Focus()
        ElseIf nguoidung <> "" And matkhau = "" Then
            lbl_error.Text = "Chưa nhập mật khẩu"
            txt_nhap_pass.Focus()
        Else
            ket_noi_database()
        End If
    End Sub

    Public id_nguoidung As Integer

    Sub ket_noi_database()
        ketnoidatabase()
        Dim sql As New SqlDataAdapter("select * from NGUOI_DUNG where Ten_dang_nhap='" & txt_nhap_user.Text & "' and Mat_khau='" & txt_nhap_pass.Text & "'", ketnoi)
        Dim tb As New DataTable
        ketnoi.Open()
        sql.Fill(tb)
        ketnoi.Close()
        If tb.Rows.Count > 0 Then
            MessageBox.Show("Chào mừng '" & txt_nhap_user.Text & "' đến với hệ thống quản lý bán hàng ^^", "Đăng nhập thành công :)", MessageBoxButtons.OK, MessageBoxIcon.Information)
            id_nguoidung = Convert.ToInt32(tb.Rows(0).Item(0).ToString)
            Quantri.Show()
            Me.Hide()
        Else
            MessageBox.Show("Truy cập bị từ chối, xin hãy kiểm tra lại tài khoản :(", "Thông báo : Sai tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_nhap_user.Text = ""
            txt_nhap_pass.Text = ""
            txt_nhap_user.Focus()
        End If
    End Sub

    Private Sub txt_nhap_user_TextChanged(sender As Object, e As EventArgs) Handles txt_nhap_user.TextChanged
        lbl_error.Text = ""
    End Sub

    Private Sub txt_nhap_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_nhap_pass.TextChanged
        lbl_error.Text = ""
    End Sub
End Class