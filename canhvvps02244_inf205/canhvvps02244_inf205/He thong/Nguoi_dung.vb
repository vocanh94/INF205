Imports System.Data.SqlClient
Public Class Nguoi_dung

    Sub xoatextbox()
        XuatDuLieu.DataSource = Nothing
        txt_taikhoan.Text = ""
        txt_matkhaucu.Text = ""
        txt_matkhaumoi.Text = ""
        txt_tennguoidung.Text = ""
        btn_sua.Enabled = False
        btn_xoa.Enabled = False
        btn_them.Enabled = True
    End Sub

    Private Sub btn_xem_Click(sender As Object, e As EventArgs) Handles btn_xem.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        hienthidulieu()
        laydulieu()
        lbl_tongso.Text = "Có tổng số " & XuatDuLieu.RowCount() & " tài khoản người dùng"
        txt_taikhoan.Focus()
    End Sub

    Dim ID_nguoidung As Integer = 0

    Sub layID()
        lbl_error.Text = ""
        ID_nguoidung = Convert.ToInt32(XuatDuLieu.Rows(XuatDuLieu.CurrentRow.Index).Cells(0).Value.ToString())
    End Sub

    Sub hienthidulieu()
        lbl_error.Text = ""
        Dim sql As New SqlDataAdapter("select Ma_nguoi_dung as 'ID', Ten_dang_nhap as 'User name',replace(Mat_khau, Mat_khau, '*') as 'Password', Ten_nguoi_dung as 'Họ và tên' from NGUOI_DUNG", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        If tb.Rows.Count > 0 Then
            XuatDuLieu.DataSource = tb
        Else
            xoatextbox()
            lbl_tongso.Text = "Không có người dùng trong tài khoản"
            MessageBox.Show("Không có dữ liệu :(", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Sub laydulieu()
        layID()

        lbl_IDnguoidung.Text = "Sửa đổi người dùng có ID là: " & ID_nguoidung & ""
        '***************
        txt_taikhoan.DataBindings.Clear()
        txt_taikhoan.DataBindings.Add("text", XuatDuLieu.DataSource, "User name")
        '***************

        '***************
        txt_tennguoidung.DataBindings.Clear()
        txt_tennguoidung.DataBindings.Add("text", XuatDuLieu.DataSource, "Họ và tên")
        '***************
        btn_sua.Enabled = True
        btn_xoa.Enabled = True
        grb_thongtin.Enabled = True
        btn_them.Enabled = True
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        lbl_error.Text = ""
        layID()
        If txt_taikhoan.Text = "" And txt_matkhaucu.Text = "" And txt_tennguoidung.Text = "'  Then" Then
            lbl_error.Text = "Bạn chưa nhập dữ liệu"
        ElseIf txt_taikhoan.Text = "" Then
            lbl_error.Text = "Bạn chưa nhập tên đăng nhập"
        ElseIf txt_matkhaucu.Text = "" Then
            lbl_error.Text = "Bạn phải xác nhận mật khẩu cũ"
            txt_matkhaucu.Focus()
        Else
            If txt_tennguoidung.Text = "" Then
                txt_tennguoidung.Text = "Null"
            End If
            'Kiem tra tai khoan nguoi dung
            Dim sql_xacnhan As New SqlDataAdapter("select * from NGUOI_DUNG where Ten_dang_nhap = '" & txt_taikhoan.Text & "' and Ma_nguoi_dung <> " & ID_nguoidung & "", Login.ketnoi)
            Dim xacnhan As New DataTable
            Login.ketnoi.Open()
            sql_xacnhan.Fill(xacnhan)
            Login.ketnoi.Close()
            If xacnhan.Rows.Count > 0 Then
                MessageBox.Show("Tên truy cập đã tồn tại :(", "Đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_taikhoan.Focus()
                Exit Sub
            End If
            '*********************
            Dim sql As New SqlDataAdapter("select Mat_khau from NGUOI_DUNG where Ma_nguoi_dung	= " & ID_nguoidung & "", Login.ketnoi)
            Dim tb As New DataTable
            Login.ketnoi.Open()
            sql.Fill(tb)
            Login.ketnoi.Close()
            If txt_matkhaucu.Text <> Convert.ToString(tb.Rows(0).Item(0).ToString()) Then
                lbl_error.Text = "Mật khẩu của bạn sai"
                txt_matkhaucu.Focus()
                Exit Sub
            End If
            '*********************
            suanguoidung()
            hienthidulieu()
            laydulieu()
            lbl_error.Text = "Sửa thành công"
            txt_matkhaucu.Text = ""
            txt_matkhaumoi.Text = ""
        End If
        txt_taikhoan.Focus()
    End Sub

    Sub suanguoidung()
        If txt_matkhaumoi.Text = "" Then
            Dim sql As New SqlDataAdapter("update NGUOI_DUNG set Ten_dang_nhap ='" & txt_taikhoan.Text & "', Ten_nguoi_dung ='" & txt_tennguoidung.Text & "' where Ma_nguoi_dung = " & ID_nguoidung & "", Login.ketnoi)
            Dim tb As New DataTable
            Login.ketnoi.Open()
            sql.Fill(tb)
            Login.ketnoi.Close()
        Else
            Dim sql As New SqlDataAdapter("update NGUOI_DUNG set Ten_dang_nhap ='" & txt_taikhoan.Text & "', Mat_khau='" & txt_matkhaumoi.Text & "', Ten_nguoi_dung ='" & txt_tennguoidung.Text & "' where Ma_nguoi_dung = " & ID_nguoidung & "", Login.ketnoi)
            Dim tb As New DataTable
            Login.ketnoi.Open()
            sql.Fill(tb)
            Login.ketnoi.Close()
        End If
    End Sub

    Private Sub btn_xoa_Click_1(sender As Object, e As EventArgs) Handles btn_xoa.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        lbl_error.Text = ""
        layID()
        If txt_matkhaucu.Text = "" Then
            lbl_error.Text = "Bạn phải xác nhận mật khẩu cũ"
            txt_matkhaucu.Focus()
            Exit Sub
        End If
        '*********************
        Dim kiemtrametkhau As New SqlDataAdapter("select Mat_khau from NGUOI_DUNG where Ma_nguoi_dung	= " & ID_nguoidung & "", Login.ketnoi)
        Dim tb_kiemtrametkhau As New DataTable
        Login.ketnoi.Open()
        kiemtrametkhau.Fill(tb_kiemtrametkhau)
        Login.ketnoi.Close()
        If txt_matkhaucu.Text <> Convert.ToString(tb_kiemtrametkhau.Rows(0).Item(0).ToString()) Then
            lbl_error.Text = "Mật khẩu của bạn sai"
            txt_matkhaucu.Focus()
            Exit Sub
        End If
        '*********************
        If XuatDuLieu.Rows.Count <= 1 Then
            MessageBox.Show("Bạn không được phép xóa hết!", "Không được phép", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            If MessageBox.Show("Bạn có muốn xóa không? Thao tác của bạn sẽ làm mất hết dữ liệu bảng Hóa Đơn và Chi Tiết Hóa Đơn", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            '''''''''''''''''''''''''''
            Dim database_hoadon As New SqlDataAdapter("select * from HOA_DON where NGUOI_DUNG_Ma_nguoi_dung = " & ID_nguoidung & "", Login.ketnoi)
            Dim bang As New DataTable
            Login.ketnoi.Open()
            database_hoadon.Fill(bang)
            Login.ketnoi.Close()
            Dim demdong As Integer = bang.Rows.Count()
            'Vong lap xoa het du lieu lien quan den Chi tiet hoa don
            Dim x As Integer = 0
            Dim mahoadon As Integer = 0
            Do While x < demdong
                mahoadon = Convert.ToInt32(bang.Rows(x).Item(0).ToString())
                '*******Delete chi tiet hoa don
                Dim CSDL As New SqlDataAdapter("delete from CHI_TIET_HOA_DON where HOA_DON_Ma_hoa_don = " & mahoadon & "", Login.ketnoi)
                Dim tb2 As New DataTable
                Login.ketnoi.Open()
                CSDL.Fill(tb2)
                Login.ketnoi.Close()

                x = x + 1
            Loop
            'Vong lap xoa het du lieu lien quan den Hoa don
            Dim y As Integer = 0
            Dim IDhoadon As Integer = 0
            Do While y < demdong
                IDhoadon = Convert.ToInt32(bang.Rows(y).Item(0).ToString())
                '*******Delete Hoa don
                Dim CSDL As New SqlDataAdapter("delete from HOA_DON where Ma_hoa_don = " & IDhoadon & "", Login.ketnoi)
                Dim tb2 As New DataTable
                Login.ketnoi.Open()
                CSDL.Fill(tb2)
                Login.ketnoi.Close()

                y = y + 1
            Loop

            '''''''''''''''''''
            Dim sql As New SqlDataAdapter("delete from NGUOI_DUNG where Ma_nguoi_dung = " & ID_nguoidung & "", Login.ketnoi)
            Dim tb As New DataTable
            Login.ketnoi.Open()
            sql.Fill(tb)
            Login.ketnoi.Close()
            txt_matkhaucu.Text = ""
            txt_matkhaumoi.Text = ""
            ''''''''''
            hienthidulieu()
            laydulieu()
            txt_taikhoan.Focus()
        End If
    End Sub


    Private Sub Nguoi_dung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_sua.Enabled = False
        btn_xoa.Enabled = False
        grb_thongtin.Enabled = False
        btn_them.Enabled = False
    End Sub

    Private Sub XuatDuLieu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles XuatDuLieu.CellClick
        laydulieu()
        txt_matkhaucu.Text = ""
        txt_matkhaumoi.Text = ""
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        lbl_error.Text = ""
        Them.Show()
        Me.Enabled = False
    End Sub

    Private Sub Nguoi_dung_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Quantri.Show()
    End Sub

    Private Sub Nguoi_dung_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Quantri.Show()
    End Sub
End Class