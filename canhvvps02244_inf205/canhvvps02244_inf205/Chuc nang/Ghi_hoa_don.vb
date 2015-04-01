Imports System.Data.SqlClient
Public Class Ghi_hoa_don

    Private Sub Ghi_hoa_don_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Quantri.Show()
    End Sub

    Private Sub Ghi_hoa_don_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Quantri.Show()
    End Sub

    'Khi form khởi động lên
    Private Sub Ghi_hoa_don_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        hienthintensanpham()
        hienthitenkhachhang()
        xoanhaplieuform()
        demsoluongKH()
        kiemtraghi()
        hienthihoadon()
        btn_sua.Enabled = True
        tinhsohoadon()
        txt_sodienthoai.Enabled = False
        txt_diachi.Enabled = False
        btn_xoa.Enabled = False
        If grv_hoadon.Rows.Count() < 1 Then
            btn_sua.Enabled = False
            btn_capnhathethong.Enabled = False
        End If
    End Sub

    'Cập nhật danh sách sản phẩm
    Private Sub btn_capnhatSP_Click(sender As Object, e As EventArgs)
        '********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        hienthintensanpham()
    End Sub

    'Cập nhật danh sách khách hàng
    Private Sub btn_capnhatKH_Click(sender As Object, e As EventArgs) Handles btn_capnhathethong.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        hienthitenkhachhang()
        hienthihoadon()
        hienthintensanpham()
        tinhsohoadon()
        MessageBox.Show("Cập nhật dữ liệu thành công :)", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    '*********************
    'Thiết lập thông số sản phẩm
    '*********************

    Private Sub btn_them_SP_Click(sender As Object, e As EventArgs) Handles btn_them_SP.Click
        lbl_error.Text = ""
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        txt_sanpham.Text = Convert.ToString(grv_sanpham.Rows(grv_sanpham.CurrentRow.Index()).Cells(0).Value.ToString())
        btn_xoa_SP.Enabled = True
        btn_them_SP.Enabled = False
        grv_sanpham.Enabled = False
        txt_soluongmua.Enabled = True
        txt_soluongmua.Value = 1
        'hiển thị chi tiết sản phẩm
        Dim sql As New SqlDataAdapter("select Chi_tiet_san_pham, Don_gia from SAN_PHAM where Ten_san_pham='" & txt_sanpham.Text & "'", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        lbl_chitiet.Text = Convert.ToString(tb.Rows(0).Item(0).ToString())
        '''''
        demsoluongSP()
        tinhtien()
        kiemtraghi()
        kiemtrasua()
    End Sub

    Private Sub btn_xoa_SP_Click(sender As Object, e As EventArgs) Handles btn_xoa_SP.Click
        lbl_error.Text = ""
        btn_xoa_SP.Enabled = False
        btn_them_SP.Enabled = True
        grv_sanpham.Enabled = True
        xoadulieuhienthiSP()
        kiemtraghi()
        kiemtrasua()
        lbl_soluongSP.Text = "0"
    End Sub

    Private Sub txt_soluongmua_ValueChanged(sender As Object, e As EventArgs) Handles txt_soluongmua.ValueChanged
        tinhtien()
    End Sub

    '*********************
    'Thiết lập thông số khách hàng
    '*********************

    Private Sub rdb_nhapten_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_nhapten.CheckedChanged
        kiemtracheck()
        lbl_error.Text = ""
    End Sub

    Private Sub rdb_chonten_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_chonten.CheckedChanged
        kiemtracheck()
        lbl_error.Text = ""
    End Sub

    Private Sub btn_them_KH_Click(sender As Object, e As EventArgs) Handles btn_them_KH.Click
        lbl_error.Text = ""
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        If rdb_nhapten.Checked = True Then
            lbl_error.Text = ""
            If txt_nhaptenKH.Text = "" Then
                lbl_error.Text = "Bạn chưa nhập tên khách hàng :("
                Exit Sub
            End If
            txt_khachhang.Text = txt_nhaptenKH.Text
            kiemtrakhachhang()
        ElseIf rdb_chonten.Checked = True Then
            If grv_khachhang.Rows.Count() < 1 Then
                lbl_error.Text = "Bạn chưa có khách hàng trong danh sách !"
                Exit Sub
            End If
            lbl_error.Text = ""
            txt_khachhang.Text = Convert.ToString(grv_khachhang.Rows(grv_khachhang.CurrentRow.Index).Cells(0).Value.ToString())
            kiemtrakhachhang()
        Else
            lbl_error.Text = "Bạn chưa chọn cách thức lấy khách hàng :("
            Exit Sub
        End If
        btn_them_KH.Enabled = False
        btn_xoa_KH.Enabled = True
        grv_khachhang.Enabled = False
        txt_nhaptenKH.Enabled = False
        rdb_chonten.Enabled = False
        rdb_nhapten.Enabled = False
        kiemtraghi()
        kiemtrasua()
        txt_sodienthoai.Enabled = True
        txt_diachi.Enabled = True
    End Sub

    Private Sub btn_xoa_KH_Click(sender As Object, e As EventArgs) Handles btn_xoa_KH.Click
        lbl_error.Text = ""
        btn_them_KH.Enabled = True
        btn_xoa_KH.Enabled = False

        rdb_nhapten.Checked = False
        rdb_chonten.Checked = False
        kiemtracheck()
        rdb_chonten.Enabled = True
        rdb_nhapten.Enabled = True
        txt_khachhang.Text = ""
        txt_sodienthoai.Text = ""
        txt_diachi.Text = ""
        txt_nhaptenKH.Text = ""
        kiemtraghi()
        kiemtrasua()
    End Sub

    'Các nút chức năng quan trọng
    'Nút Ghi
    Private Sub btn_ghi_Click(sender As Object, e As EventArgs) Handles btn_ghi.Click
        '***********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '************************
        Dim sql_kiemtramua As New SqlDataAdapter("select So_luong from SAN_PHAM where Ten_san_pham='" & txt_sanpham.Text & "'", Login.ketnoi)
        Dim tb_kiemtramua As New DataTable
        Login.ketnoi.Open()
        sql_kiemtramua.Fill(tb_kiemtramua)
        Login.ketnoi.Close()

        If txt_soluongmua.Value() > Convert.ToInt32(tb_kiemtramua.Rows(0).Item(0).ToString()) Then
            MessageBox.Show("Số lượng chọn mua nhiều hơn trong kho " & txt_soluongmua.Value() - Convert.ToInt32(tb_kiemtramua.Rows(0).Item(0).ToString()) & " sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txt_sodienthoai.Text = "" Then
            txt_sodienthoai.Text = "Null"
        End If
        If txt_diachi.Text = "" Then
            txt_diachi.Text = "Null"
        End If
        '*********************Kiểm tra khách hàng
        Dim sql_kiemtra As New SqlDataAdapter("select * from KHACH_HANG where Ten_khach_hang = '" & txt_khachhang.Text & "'", Login.ketnoi)
        Dim tb_kiemtra As New DataTable
        Login.ketnoi.Open()
        sql_kiemtra.Fill(tb_kiemtra)
        Login.ketnoi.Close()

        If tb_kiemtra.Rows.Count() < 1 Then
            Dim sql_themKH As New SqlDataAdapter("insert into KHACH_HANG values('" & txt_khachhang.Text & "','" & txt_sodienthoai.Text & "','" & txt_diachi.Text & "')", Login.ketnoi)
            Dim tb_themKH As New DataTable
            Login.ketnoi.Open()
            sql_themKH.Fill(tb_themKH)
            Login.ketnoi.Close()
        Else
            Dim sql_themKH As New SqlDataAdapter("update KHACH_HANG set Ten_khach_hang = '" & txt_khachhang.Text & "', Sdt = '" & txt_sodienthoai.Text & "', Dia_chi = '" & txt_diachi.Text & "' where Ten_khach_hang ='" & txt_khachhang.Text & "'", Login.ketnoi)
            Dim tb_themKH As New DataTable
            Login.ketnoi.Open()
            sql_themKH.Fill(tb_themKH)
            Login.ketnoi.Close()
        End If

        '*********************
        Dim sql_tinhtien As New SqlDataAdapter("select Don_gia , Ma_san_pham from SAN_PHAM where Ten_san_pham='" & txt_sanpham.Text & "'", Login.ketnoi)
        Dim tb_tinhtien As New DataTable
        Login.ketnoi.Open()
        sql_tinhtien.Fill(tb_tinhtien)
        Login.ketnoi.Close()
        Dim gia As String = Convert.ToString(tb_tinhtien.Rows(0).Item(0).ToString())

        Dim sql_maKH As New SqlDataAdapter("select Ma_khach_hang from KHACH_HANG where Ten_khach_hang='" & txt_khachhang.Text & "'", Login.ketnoi)
        Dim tb_maKH As New DataTable
        Login.ketnoi.Open()
        sql_maKH.Fill(tb_maKH)
        Login.ketnoi.Close()

        Dim idnguoidung As Integer = 0
        idnguoidung = Login.id_nguoidung
        If idnguoidung < 1 Then
            idnguoidung += 1
        End If

        Dim sql As New SqlDataAdapter("insert into HOA_DON values(" & CInt(Int(gia)) * txt_soluongmua.Value() & ",'" & String.Format("{0:MM/dd/yyyy}", ngaylap.Value) & "'," & tb_maKH.Rows(0).Item(0).ToString() & ", " & idnguoidung & ")", Login.ketnoi) 'Thông số của người dùng
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()

        Dim sql_vitri As New SqlDataAdapter("select Ma_hoa_don from HOA_DON", Login.ketnoi)
        Dim tb_vitri As New DataTable
        Login.ketnoi.Open()
        sql_vitri.Fill(tb_vitri)
        Login.ketnoi.Close()
        Dim vitri As Integer = Convert.ToInt32(tb_vitri.Rows((tb_vitri.Rows.Count()) - 1).Item(0).ToString())

        Dim sql_ghichitiet As New SqlDataAdapter("insert into CHI_TIET_HOA_DON values(" & txt_soluongmua.Value() & "," & vitri & ", " & Convert.ToInt32(tb_tinhtien.Rows(0).Item(1).ToString()) & ")", Login.ketnoi)
        Dim tb_ghichitiet As New DataTable
        Login.ketnoi.Open()
        sql_ghichitiet.Fill(tb_ghichitiet)
        Login.ketnoi.Close()
        xoanhaplieu()
        hienthihoadon()
        hienthitenkhachhang()
        btn_ghi.Enabled = False
        rdb_nhapten.Enabled = True
        rdb_chonten.Enabled = True
        lbl_error.Text = "Ghi hóa đơn thành công :)"
        txt_sodienthoai.Enabled = False
        txt_diachi.Enabled = False
        lbl_soluongSP.Text = "0"
        tinhsohoadon()
    End Sub

    Sub xoanhaplieu()
        txt_sanpham.Text = ""
        lbl_chitiet.Text = ""
        lbl_tongtien.Text = ""
        txt_nhaptenKH.Text = ""
        txt_khachhang.Text = ""
        txt_sodienthoai.Text = ""
        txt_diachi.Text = ""
        rdb_nhapten.Checked = False
        rdb_chonten.Checked = False
        btn_them_SP.Enabled = True
        btn_them_KH.Enabled = True
        btn_xoa_SP.Enabled = False
        btn_xoa_KH.Enabled = False
        grv_sanpham.Enabled = True
        btn_ghi.Enabled = False
    End Sub

    'Nút Sửa
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
        If btn_sua.Text = "Sửa hóa đơn" Then 'Đưa dữ liệu lên
            btn_sua.Text = "Cập nhật"
            txt_sanpham.Text = grv_hoadon.Rows(grv_hoadon.CurrentRow.Index).Cells(2).Value.ToString()
            txt_soluongmua.Value = grv_hoadon.Rows(grv_hoadon.CurrentRow.Index).Cells(3).Value.ToString()
            'hiển thị chi tiết sản phẩm
            Dim sql As New SqlDataAdapter("select Chi_tiet_san_pham, Don_gia from SAN_PHAM where Ten_san_pham='" & txt_sanpham.Text & "'", Login.ketnoi)
            Dim tb As New DataTable
            Login.ketnoi.Open()
            sql.Fill(tb)
            Login.ketnoi.Close()
            lbl_chitiet.Text = Convert.ToString(tb.Rows(0).Item(0).ToString())
            '**********************
            txt_khachhang.Text = grv_hoadon.Rows(grv_hoadon.CurrentRow.Index).Cells(1).Value.ToString()

            Dim sql2 As New SqlDataAdapter("select * from KHACH_HANG where Ten_khach_hang='" & txt_khachhang.Text & "'", Login.ketnoi)
            Dim tb2 As New DataTable
            Login.ketnoi.Open()
            sql2.Fill(tb2)
            Login.ketnoi.Close()
            txt_sodienthoai.Text = Convert.ToString(tb2.Rows(0).Item(2).ToString())
            txt_diachi.Text = Convert.ToString(tb2.Rows(0).Item(3).ToString())

            ngaylap.Value = grv_hoadon.Rows(grv_hoadon.CurrentRow.Index).Cells(5).Value.ToString()
            '**********************
            rdb_nhapten.Checked = False
            rdb_chonten.Checked = False
            btn_them_SP.Enabled = False
            btn_them_KH.Enabled = False
            btn_xoa_SP.Enabled = True
            btn_xoa_KH.Enabled = True
            txt_soluongmua.Enabled = True
            grv_hoadon.Enabled = False
            btn_xoa.Enabled = True
            btn_ghi.Enabled = False
            kiemtraghi()
            btn_capnhathethong.Enabled = False
            lbl_error.Text = "Đang sửa hóa đơn ..."
            txt_sodienthoai.Enabled = True
            txt_diachi.Enabled = True
        ElseIf btn_sua.Text = "Cập nhật" Then 'Cập nhật dữ liệu xuống

            Dim sql As New SqlDataAdapter("select Ma_san_pham from SAN_PHAM where Ten_san_pham ='" & txt_sanpham.Text & "'", Login.ketnoi)
            Dim tb As New DataTable
            Login.ketnoi.Open()
            sql.Fill(tb)
            Login.ketnoi.Close()

            Dim sql2 As New SqlDataAdapter("update CHI_TIET_HOA_DON set So_luong = " & txt_soluongmua.Value() & ", HOA_DON_Ma_hoa_don = " & grv_hoadon.Rows(grv_hoadon.CurrentRow.Index).Cells(0).Value.ToString() & ",  SAN_PHAM_Ma_san_pham = " & tb.Rows(0).Item(0).ToString() & " where HOA_DON_Ma_hoa_don = " & grv_hoadon.Rows(grv_hoadon.CurrentRow.Index).Cells(0).Value.ToString() & "", Login.ketnoi)
            Dim tb2 As New DataTable
            Login.ketnoi.Open()
            sql2.Fill(tb2)
            Login.ketnoi.Close()

            'Tính tiền
            Dim sql_tinhtien As New SqlDataAdapter("select Don_gia , Ma_san_pham from SAN_PHAM where Ten_san_pham='" & txt_sanpham.Text & "'", Login.ketnoi)
            Dim tb_tinhtien As New DataTable
            Login.ketnoi.Open()
            sql_tinhtien.Fill(tb_tinhtien)
            Login.ketnoi.Close()
            Dim gia As String = Convert.ToString(tb_tinhtien.Rows(0).Item(0).ToString())

            Dim sql_maKH As New SqlDataAdapter("select Ma_khach_hang from KHACH_HANG where Ten_khach_hang='" & txt_khachhang.Text & "'", Login.ketnoi)
            Dim tb_maKH As New DataTable
            Login.ketnoi.Open()
            sql_maKH.Fill(tb_maKH)
            Login.ketnoi.Close()

            Dim sql3 As New SqlDataAdapter("update HOA_DON set Tong_tien = " & CInt(Int(gia)) * txt_soluongmua.Value() & ", Ngay_lap='" & String.Format("{0:MM/dd/yyyy}", ngaylap.Value) & "', KHACH_HANG_Ma_khach_hang = " & tb_maKH.Rows(0).Item(0).ToString() & " where Ma_hoa_don = " & grv_hoadon.Rows(grv_hoadon.CurrentRow.Index).Cells(0).Value.ToString() & "", Login.ketnoi)
            Dim tb3 As New DataTable
            Login.ketnoi.Open()
            sql3.Fill(tb3)
            Login.ketnoi.Close()

            '*****************

            Dim sql4 As New SqlDataAdapter("update KHACH_HANG set Ten_khach_hang = '" & txt_khachhang.Text & "', Sdt = '" & txt_sodienthoai.Text & "', Dia_chi = '" & txt_diachi.Text & "' where Ma_khach_hang=  " & tb_maKH.Rows(0).Item(0).ToString() & "", Login.ketnoi)
            Dim tb4 As New DataTable
            Login.ketnoi.Open()
            sql4.Fill(tb4)
            Login.ketnoi.Close()
            '*****************
            btn_sua.Text = "Sửa hóa đơn"
            hienthihoadon()
            grv_hoadon.Enabled = True
            rdb_chonten.Enabled = True
            rdb_nhapten.Enabled = True
            btn_xoa.Enabled = False
            xoanhaplieu()
            kiemtraghi()
            tinhsohoadon()
            btn_capnhathethong.Enabled = True
            lbl_error.Text = "Cập nhật thành công :)"
            txt_sodienthoai.Enabled = False
            txt_diachi.Enabled = False
        End If
        kiemtrasua()

    End Sub

    'Nút Xóa
    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        If MessageBox.Show("Bạn có muốn xóa hóa đơn có ID là " & grv_hoadon.Rows(grv_hoadon.CurrentRow.Index).Cells(0).Value.ToString() & " này không ?", "Xác nhận ?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************

        Dim sql1 As New SqlDataAdapter("delete from CHI_TIET_HOA_DON where HOA_DON_Ma_hoa_don= " & grv_hoadon.Rows(grv_hoadon.CurrentRow.Index).Cells(0).Value.ToString() & "", Login.ketnoi)
        Dim tb1 As New DataTable
        Login.ketnoi.Open()
        sql1.Fill(tb1)
        Login.ketnoi.Close()

        Dim sql2 As New SqlDataAdapter("delete from HOA_DON where Ma_hoa_don= " & grv_hoadon.Rows(grv_hoadon.CurrentRow.Index).Cells(0).Value.ToString() & "", Login.ketnoi)
        Dim tb2 As New DataTable
        Login.ketnoi.Open()
        sql2.Fill(tb2)
        Login.ketnoi.Close()
        xoanhaplieu()
        btn_sua.Text = "Sửa hóa đơn"
        grv_hoadon.Enabled = True
        ''''''''''''''''''''''''''''''''
        hienthitenkhachhang()
        hienthihoadon()
        hienthintensanpham()
        tinhsohoadon()
        btn_xoa.Enabled = False
        btn_capnhathethong.Enabled = True
        lbl_error.Text = "Xóa thành công :)"
        If grv_hoadon.Rows.Count() < 1 Then
            btn_sua.Enabled = False
            btn_ghi.Enabled = False
            btn_capnhathethong.Enabled = False
            rdb_chonten.Enabled = False
            rdb_nhapten.Enabled = False
            btn_them_SP.Enabled = False
        End If
        txt_sodienthoai.Enabled = False
        txt_diachi.Enabled = False
    End Sub

    '*********************
    'Thiết lập thông số
    '*********************
    Sub tinhsohoadon()
        hienthihoadon()
        lbl_demsohoadon.Text = "Trong danh sách có : " & grv_hoadon.Rows.Count() & " hóa đơn"
    End Sub

    Sub kiemtrasua()
        If btn_sua.Text = "Sửa hóa đơn" Then
            Exit Sub
        ElseIf btn_sua.Text = "Cập nhật" Then
            If txt_sanpham.Text = "" Or txt_khachhang.Text = "" Then
                btn_sua.Enabled = False
                Exit Sub
            ElseIf txt_sanpham.Text <> "" And txt_khachhang.Text <> "" Then
                btn_sua.Enabled = True
                Exit Sub
            End If
        End If
    End Sub

    Sub kiemtraghi()
        '''''''''''''''''''
        If txt_sanpham.Text = "" Or txt_khachhang.Text = "" Then
            btn_ghi.Enabled = False
            Exit Sub
        ElseIf txt_sanpham.Text <> "" And txt_khachhang.Text <> "" Then
            If btn_sua.Text = "Cập nhật" Then
                btn_ghi.Enabled = False
                Exit Sub
            End If
            btn_ghi.Enabled = True
            Exit Sub
        End If
    End Sub

    Sub kiemtrakhachhang()
        Dim sql As New SqlDataAdapter("select * from KHACH_HANG where Ten_khach_hang ='" & txt_khachhang.Text & "'", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()

        If tb.Rows.Count() < 1 Then
            Exit Sub
        End If
        txt_sodienthoai.Text = Convert.ToString(tb.Rows(0).Item(2).ToString())
        txt_diachi.Text = Convert.ToString(tb.Rows(0).Item(3).ToString())
    End Sub

    Sub kiemtracheck()
        If rdb_nhapten.Checked = True And rdb_chonten.Checked = False Then
            txt_nhaptenKH.Enabled = True
            grv_khachhang.Enabled = False
        ElseIf rdb_nhapten.Checked = False And rdb_chonten.Checked = True Then
            txt_nhaptenKH.Enabled = False
            grv_khachhang.Enabled = True
        ElseIf rdb_nhapten.Checked = False And rdb_chonten.Checked = False Then
            txt_nhaptenKH.Enabled = False
            grv_khachhang.Enabled = False
        End If
    End Sub

    Sub tinhtien()
        If txt_sanpham.Text = "" Then
            Exit Sub
        End If
        Dim sql As New SqlDataAdapter("select Don_gia from SAN_PHAM where Ten_san_pham='" & txt_sanpham.Text & "'", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        Dim gia As String = Convert.ToString(tb.Rows(0).Item(0).ToString())
        lbl_tongtien.Text = String.Format("{0:0,0 VNĐ}", CInt(Int(gia)) * txt_soluongmua.Value())
    End Sub

    Sub demsoluongSP()
        Dim sql As New SqlDataAdapter("select So_luong from SAN_PHAM where Ten_san_pham='" & txt_sanpham.Text & "'", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        lbl_soluongSP.Text = "" & tb.Rows(0).Item(0).ToString() & " Sản phẩm"
    End Sub

    Sub demsoluongKH()
        lbl_soluongKH.Text = "" & grv_khachhang.RowCount() & " Khách hàng"
    End Sub

    'Xóa tất cả thông tin nhập trên form
    Sub xoanhaplieuform()
        btn_xoa_SP.Enabled = False
        btn_xoa_KH.Enabled = False
        txt_sanpham.Clear()
        txt_khachhang.Clear()
        lbl_chitiet.Text = ""
        lbl_tongtien.Text = ""
        txt_nhaptenKH.Enabled = False
        grv_khachhang.Enabled = False
        rdb_nhapten.Checked = False
        rdb_chonten.Checked = False
        txt_sodienthoai.Clear()
        txt_diachi.Clear()
        txt_soluongmua.Enabled = False
    End Sub

    Sub xoadulieuhienthiSP()
        txt_sanpham.Clear()
        txt_soluongmua.Enabled = False
        lbl_chitiet.Text = ""
        lbl_tongtien.Text = "0 VNĐ"
    End Sub

    Sub xoadulieuhienthiKH()
        txt_sanpham.Clear()
        txt_soluongmua.Value = 0
        lbl_chitiet.Text = ""
        lbl_tongtien.Text = "0 VNĐ"
    End Sub

    'Hiển thị danh sách khách hàng lên grv
    Sub hienthitenkhachhang()
        Dim sql As New SqlDataAdapter("select Ten_khach_hang as 'Tên' from KHACH_HANG", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        grv_khachhang.DataSource = tb
    End Sub

    'Hiển thị danh sách sản phẩm lên grv
    Sub hienthintensanpham()
        Dim sql As New SqlDataAdapter("select Ten_san_pham as 'Tên' from SAN_PHAM", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        grv_sanpham.DataSource = tb
    End Sub

    Sub hienthihoadon()
        Dim sql As New SqlDataAdapter("select Ma_hoa_don as 'ID',Ten_khach_hang as 'Tên khách hàng',Ten_san_pham as 'Sản phẩm mua',CHI_TIET_HOA_DON.So_luong as 'Số lượng mua',REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,Tong_tien),1), '.00','') as 'Tổng tiền (VNĐ)',FORMAT(Ngay_lap,'dd/MM/yyyy') as 'Ngày lập hóa đơn',Sdt as 'Điện thoại',Dia_chi as 'Địa chỉ',Ten_dang_nhap as 'Người tạo hóa đơn', Ten_loai as 'Loại' from HOA_DON inner join KHACH_HANG on HOA_DON.KHACH_HANG_Ma_khach_hang = KHACH_HANG.Ma_khach_hang inner join NGUOI_DUNG on HOA_DON.NGUOI_DUNG_Ma_nguoi_dung = NGUOI_DUNG.Ma_nguoi_dung inner join CHI_TIET_HOA_DON on HOA_DON.Ma_hoa_don = CHI_TIET_HOA_DON.HOA_DON_Ma_hoa_don inner join SAN_PHAM on HOA_DON.Ma_hoa_don = CHI_TIET_HOA_DON.HOA_DON_Ma_hoa_don and SAN_PHAM.Ma_san_pham = CHI_TIET_HOA_DON.SAN_PHAM_Ma_san_pham inner join LOAI_SAN_PHAM on HOA_DON.Ma_hoa_don = CHI_TIET_HOA_DON.HOA_DON_Ma_hoa_don and SAN_PHAM.Ma_san_pham = CHI_TIET_HOA_DON.SAN_PHAM_Ma_san_pham and LOAI_SAN_PHAM.Ma_loai = SAN_PHAM.LOAI_SAN_PHAM_Ma_loai ORDER BY ID ASC", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        grv_hoadon.DataSource = tb
    End Sub

    Private Sub grv_sanpham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grv_sanpham.CellClick
        lbl_error.Text = ""
    End Sub

    Private Sub grv_hoadon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grv_hoadon.CellClick
        lbl_error.Text = ""
    End Sub

    Private Sub txt_sodienthoai_TextChanged(sender As Object, e As EventArgs) Handles txt_sodienthoai.TextChanged
        lbl_error.Text = ""
    End Sub

    Private Sub txt_diachi_TextChanged(sender As Object, e As EventArgs) Handles txt_diachi.TextChanged
        lbl_error.Text = ""
    End Sub

    Private Sub ngaylap_ValueChanged(sender As Object, e As EventArgs) Handles ngaylap.ValueChanged
        lbl_error.Text = ""
    End Sub

    Private Sub grv_khachhang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grv_khachhang.CellClick
        lbl_error.Text = ""
    End Sub

    Private Sub txt_sodienthoai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sodienthoai.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            lbl_error.Text = ""
            Exit Sub
        End If
        lbl_error.Text = "Bạn phải nhập số điện thoại"
        txt_sodienthoai.Clear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
End Class