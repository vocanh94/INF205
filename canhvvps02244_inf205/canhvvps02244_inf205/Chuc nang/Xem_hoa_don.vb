Imports System.Data.SqlClient
Public Class Xem_hoa_don

    Private Sub Xem_hoa_don_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        Dim sql As New SqlDataAdapter("select Ma_hoa_don as 'ID',Ten_khach_hang as 'Tên khách hàng',Ten_san_pham as 'Sản phẩm mua',CHI_TIET_HOA_DON.So_luong as 'Số lượng', REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,Don_gia),1), '.00','') as 'Đơn giá (VNĐ)',REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,Tong_tien),1), '.00','') as 'Tổng tiền (VNĐ)',FORMAT(Ngay_lap,'dd/MM/yyyy') as 'Ngày lập hóa đơn',Sdt as 'Điện thoại',Dia_chi as 'Địa chỉ',Ten_dang_nhap as 'Người tạo hóa đơn', Ten_loai as 'Loại' from HOA_DON inner join KHACH_HANG on HOA_DON.KHACH_HANG_Ma_khach_hang = KHACH_HANG.Ma_khach_hang inner join NGUOI_DUNG on HOA_DON.NGUOI_DUNG_Ma_nguoi_dung = NGUOI_DUNG.Ma_nguoi_dung inner join CHI_TIET_HOA_DON on HOA_DON.Ma_hoa_don = CHI_TIET_HOA_DON.HOA_DON_Ma_hoa_don inner join SAN_PHAM on HOA_DON.Ma_hoa_don = CHI_TIET_HOA_DON.HOA_DON_Ma_hoa_don and SAN_PHAM.Ma_san_pham = CHI_TIET_HOA_DON.SAN_PHAM_Ma_san_pham inner join LOAI_SAN_PHAM on HOA_DON.Ma_hoa_don = CHI_TIET_HOA_DON.HOA_DON_Ma_hoa_don and SAN_PHAM.Ma_san_pham = CHI_TIET_HOA_DON.SAN_PHAM_Ma_san_pham and LOAI_SAN_PHAM.Ma_loai = SAN_PHAM.LOAI_SAN_PHAM_Ma_loai ORDER BY ID ASC", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        grv_hienthi.DataSource = tb
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        Try
            In_hoa_don.Show()
            Dim sql As New SqlDataAdapter("select Ma_hoa_don as 'ID',Ten_khach_hang as 'Tên khách hàng',Ten_san_pham as 'Sản phẩm mua',CHI_TIET_HOA_DON.So_luong as 'Số lượng', REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,Don_gia),1), '.00','') as 'Đơn giá (VNĐ)',REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,Tong_tien),1), '.00','') as 'Tổng tiền (VNĐ)',FORMAT(Ngay_lap,'dd/MM/yyyy') as 'Ngày lập hóa đơn',Sdt as 'Điện thoại',Dia_chi as 'Địa chỉ',Ten_dang_nhap as 'Người tạo hóa đơn', Ten_loai as 'Loại' from HOA_DON inner join KHACH_HANG on HOA_DON.KHACH_HANG_Ma_khach_hang = KHACH_HANG.Ma_khach_hang inner join NGUOI_DUNG on HOA_DON.NGUOI_DUNG_Ma_nguoi_dung = NGUOI_DUNG.Ma_nguoi_dung inner join CHI_TIET_HOA_DON on HOA_DON.Ma_hoa_don = CHI_TIET_HOA_DON.HOA_DON_Ma_hoa_don inner join SAN_PHAM on HOA_DON.Ma_hoa_don = CHI_TIET_HOA_DON.HOA_DON_Ma_hoa_don and SAN_PHAM.Ma_san_pham = CHI_TIET_HOA_DON.SAN_PHAM_Ma_san_pham inner join LOAI_SAN_PHAM on HOA_DON.Ma_hoa_don = CHI_TIET_HOA_DON.HOA_DON_Ma_hoa_don and SAN_PHAM.Ma_san_pham = CHI_TIET_HOA_DON.SAN_PHAM_Ma_san_pham and LOAI_SAN_PHAM.Ma_loai = SAN_PHAM.LOAI_SAN_PHAM_Ma_loai ORDER BY ID ASC", Login.ketnoi)
            Dim tb As New DataTable
            Login.ketnoi.Open()
            sql.Fill(tb)
            Login.ketnoi.Close()

            In_hoa_don.lbl_ID.Text = "0" & Convert.ToInt32(tb.Rows(grv_hienthi.CurrentRow.Index()).Item(0).ToString) & ""
            In_hoa_don.lbl_ngayghi.Text = Convert.ToString(tb.Rows(grv_hienthi.CurrentRow.Index()).Item(6).ToString)
            In_hoa_don.lbl_tenKH.Text = Convert.ToString(tb.Rows(grv_hienthi.CurrentRow.Index()).Item(1).ToString)
            In_hoa_don.lbl_sanphammua.Text = Convert.ToString(tb.Rows(grv_hienthi.CurrentRow.Index()).Item(2).ToString)
            In_hoa_don.lbl_soluongmua.Text = Convert.ToString(tb.Rows(grv_hienthi.CurrentRow.Index()).Item(3).ToString)
            In_hoa_don.lbl_loai.Text = Convert.ToString(tb.Rows(grv_hienthi.CurrentRow.Index()).Item(10).ToString)
            In_hoa_don.lbl_dongia.Text = "" & Convert.ToString(tb.Rows(grv_hienthi.CurrentRow.Index()).Item(4).ToString) & " VNĐ"
            In_hoa_don.lbl_sodienthoai.Text = Convert.ToString(tb.Rows(grv_hienthi.CurrentRow.Index()).Item(7).ToString)
            In_hoa_don.lbl_diachi.Text = Convert.ToString(tb.Rows(grv_hienthi.CurrentRow.Index()).Item(8).ToString)
            In_hoa_don.lbl_tongtien.Text = "" & Convert.ToString(tb.Rows(grv_hienthi.CurrentRow.Index()).Item(5).ToString) & " VNĐ"
        Catch ex As Exception
            MessageBox.Show("Bạn chưa cài chương trình 'VisualBasicPowerPacks3', hãy vào ổ đĩa cài đặt cài đặt chương trình lên", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        
    End Sub

    Private Sub Xem_hoa_don_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Quantri.Show()
    End Sub

    Private Sub Xem_hoa_don_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Quantri.Show()
    End Sub
End Class