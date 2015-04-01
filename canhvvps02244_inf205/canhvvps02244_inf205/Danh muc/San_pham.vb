Imports System.Data.SqlClient
Public Class San_pham

    Private Sub San_pham_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Quantri.Show()
    End Sub

    Private Sub San_pham_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Quantri.Show()
    End Sub

    Private Sub btn_thoat_Click(sender As Object, e As EventArgs) Handles btn_thoat.Click
        Me.Close()
    End Sub

    Private Sub San_pham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        resetSP()
        layloaiSP()
        kiemtraxoa()
        laysoluongsanpham()
        If grv_danhsachsanpham.RowCount() < 1 Then
            btn_sua.Enabled = False
        End If
    End Sub

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
        If btn_them.Text = "Thêm >" Then
            If txt_tensanpham.Text = "" Then
                lbl_error.Text = "Chưa nhập tên sản phẩm !"
                txt_tensanpham.Focus()
                Exit Sub
            ElseIf txt_giasanpham.Text = "" Then
                lbl_error.Text = "Chưa nhập giá sản phẩm !"
                txt_giasanpham.Focus()
                Exit Sub
            ElseIf txt_loaisanpham.Text = "" Then
                lbl_error.Text = "Chưa chọn loại sản phẩm !"
                Exit Sub
            Else
                If txt_chitiet.Text = "" Then
                    txt_chitiet.Text = "Null"
                End If
            End If

            layid_loaiSP()
            Dim sql As New SqlDataAdapter("insert into SAN_PHAM values ('" & txt_tensanpham.Text & "', " & txt_giasanpham.Text & ", " & txt_soluong.Value.ToString() & ", '" & txt_chitiet.Text & "', " & ID_loaiSP & ")", Login.ketnoi)
            Dim tb As New DataTable
            Login.ketnoi.Open()
            sql.Fill(tb)
            Login.ketnoi.Close()
            xoaform()
            lbl_error.Text = "Thêm dữ liệu thành công !"
        ElseIf btn_them.Text = "Cập nhật >" Then
            If txt_tensanpham.Text = "" Then
                lbl_error.Text = "Chưa nhập tên sản phẩm !"
                txt_tensanpham.Focus()
                Exit Sub
            ElseIf txt_giasanpham.Text = "" Then
                lbl_error.Text = "Chưa nhập giá sản phẩm !"
                txt_giasanpham.Focus()
                Exit Sub
            Else
                If txt_chitiet.Text = "" Then
                    txt_chitiet.Text = "Null"
                End If
            End If
            layid_SP()
            Dim x As New SqlDataAdapter("select Ma_loai from LOAI_SAN_PHAM where Ten_loai = '" & txt_loaisanpham.Text & "'", Login.ketnoi)
            Dim y As New DataTable
            Login.ketnoi.Open()
            x.Fill(y)
            Login.ketnoi.Close()

            Dim sql As New SqlDataAdapter("update SAN_PHAM set Ten_san_pham	= '" & txt_tensanpham.Text & "', Don_gia = " & txt_giasanpham.Text & ", So_luong = " & txt_soluong.Value & ", Chi_tiet_san_pham ='" & txt_chitiet.Text & "', LOAI_SAN_PHAM_Ma_loai = " & Convert.ToInt32(y.Rows(0).Item(0).ToString()) & " where Ma_san_pham = " & ID_SP & "", Login.ketnoi)
            Dim tb As New DataTable
            Login.ketnoi.Open()
            sql.Fill(tb)
            Login.ketnoi.Close()
            tinhtongtien() '****************
            xoaform()
            lbl_error.Text = "Cập nhật dữ liệu thành công !"
        End If
        resetSP()
        laysoluongsanpham()
        btn_sua.Enabled = True
        grv_danhsachsanpham.Enabled = True
        btn_them.Text = "Thêm >"
        btn_clear_cancel.Text = "Nhập lại"
        kiemtraxoa()
    End Sub

    Sub tinhtongtien()
        layid_SP()
        Dim sql As New SqlDataAdapter("select HOA_DON_Ma_hoa_don, CHI_TIET_HOA_DON.So_luong, SAN_PHAM.Don_gia from CHI_TIET_HOA_DON inner join SAN_PHAM on CHI_TIET_HOA_DON.SAN_PHAM_Ma_san_pham = SAN_PHAM.Ma_san_pham where Ma_san_pham = " & ID_SP & " order by HOA_DON_Ma_hoa_don ASC", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()

        If tb.Rows.Count() < 1 Then
            Exit Sub
        End If

        Dim x As Integer
        x = tb.Rows.Count()
        Dim y As Integer = 0

        Do While y < x
            Dim tonggia As Integer
            tonggia = CInt(Int(Convert.ToString(tb.Rows(y).Item(1).ToString()))) * CInt(Int(Convert.ToString(tb.Rows(y).Item(2).ToString())))
            Dim sql2 As New SqlDataAdapter("update HOA_DON set Tong_tien = " & tonggia & " where Ma_hoa_don = " & CInt(Int(Convert.ToString(tb.Rows(y).Item(0).ToString()))) & "", Login.ketnoi)
            Dim tb2 As New DataTable
            Login.ketnoi.Open()
            sql2.Fill(tb2)
            Login.ketnoi.Close()
            y += 1
        Loop
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
        layid_SP()
        txt_tensanpham.Text = Convert.ToString(grv_danhsachsanpham.Rows(grv_danhsachsanpham.CurrentRow.Index).Cells(1).Value.ToString())
        txt_giasanpham.Text = Convert.ToString(grv_danhsachsanpham.Rows(grv_danhsachsanpham.CurrentRow.Index).Cells(2).Value.ToString())
        txt_soluong.Value = Convert.ToString(grv_danhsachsanpham.Rows(grv_danhsachsanpham.CurrentRow.Index).Cells(3).Value.ToString())
        txt_chitiet.Text = Convert.ToString(grv_danhsachsanpham.Rows(grv_danhsachsanpham.CurrentRow.Index).Cells(4).Value.ToString())
        laySP()
        btn_sua.Enabled = False
        grv_danhsachsanpham.Enabled = False
        btn_them.Text = "Cập nhật >"
        btn_clear_cancel.Text = "Hủy"
        kiemtraxoa()
        lbl_error.Text = "Đang sửa dữ liệu ..."
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        xoadulieu()
        kiemtraxoa()
        laysoluongsanpham()
        If grv_danhsachsanpham.RowCount() < 1 Then
            btn_sua.Enabled = False
            lbl_error.Text = "Đã hết dữ liệu :("
        End If
    End Sub

    Private Sub btn_clear_cancel_Click(sender As Object, e As EventArgs) Handles btn_clear_cancel.Click
        If btn_clear_cancel.Text = "Nhập lại" Then
            xoaform()
            layloaiSP()
            resetSP()
        ElseIf btn_clear_cancel.Text = "Hủy" Then
            xoaform()
            layloaiSP()
            resetSP()
            btn_sua.Enabled = True
            grv_danhsachsanpham.Enabled = True
            btn_clear_cancel.Text = "Nhập lại"
            btn_them.Text = "Thêm >"
        End If
        kiemtraxoa()
    End Sub

    Private Sub grv_loaisanpham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grv_loaisanpham.CellClick
        layid_loaiSP()
        layloaisanpham()
    End Sub

    '*************
    'Thiet lap
    '*************
    Sub xoadulieu()
        If MessageBox.Show("Bạn có muốn xóa dữ liệu không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim sql As New SqlDataAdapter("delete from CHI_TIET_HOA_DON where SAN_PHAM_Ma_san_pham = " & Convert.ToInt32(grv_danhsachsanpham.Rows(grv_danhsachsanpham.CurrentRow.Index).Cells(0).Value.ToString()) & "", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        '**************
        Dim sql1 As New SqlDataAdapter("delete from SAN_PHAM where Ma_san_pham = " & Convert.ToInt32(grv_danhsachsanpham.Rows(grv_danhsachsanpham.CurrentRow.Index).Cells(0).Value.ToString()) & "", Login.ketnoi)
        Dim tb1 As New DataTable
        Login.ketnoi.Open()
        sql1.Fill(tb1)
        Login.ketnoi.Close()
        resetSP()
        layloaiSP()
        grv_danhsachsanpham.Enabled = True
        btn_sua.Enabled = True
        btn_clear_cancel.Text = "Nhập lại"
        btn_them.Text = "Thêm >"
        xoaform()
        lbl_error.Text = "Xóa thành công dữ liệu"
    End Sub

    Sub kiemtraxoa()
        If btn_sua.Enabled = True Then
            btn_xoa.Enabled = False
        Else
            btn_xoa.Enabled = True
        End If
    End Sub

    Sub resetSP()
        Dim sql As New SqlDataAdapter("select Ma_san_pham as 'ID', Ten_san_pham as 'Sản phẩm', Don_gia as 'Đơn giá (VNĐ)', So_luong as 'Số lượng', Chi_tiet_san_pham as 'Chi tiết sản phẩm', LOAI_SAN_PHAM.Ten_loai as 'Loại sản phẩm' from SAN_PHAM inner join LOAI_SAN_PHAM on SAN_PHAM.LOAI_SAN_PHAM_Ma_loai = LOAI_SAN_PHAM.Ma_loai", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()

        grv_danhsachsanpham.DataSource = tb
    End Sub

    Sub layloaiSP()
        Dim sql2 As New SqlDataAdapter("select Ma_loai as 'ID', Ten_loai as 'Tên loại' from LOAI_SAN_PHAM", Login.ketnoi)
        Dim tb2 As New DataTable
        Login.ketnoi.Open()
        sql2.Fill(tb2)
        Login.ketnoi.Close()

        grv_loaisanpham.DataSource = tb2
    End Sub

    Sub xoaform()
        txt_tensanpham.Text = ""
        txt_giasanpham.Text = ""
        txt_soluong.Value = 0
        txt_chitiet.Text = ""
        txt_loaisanpham.Text = ""
    End Sub

    '*****Xoa loi cua form
    Sub clear_error()
        lbl_error.Text = ""
    End Sub

    Sub laysoluongsanpham()
        lbl_soluong.Text = "Danh sách có " & grv_danhsachsanpham.RowCount() & " sản phẩm"
    End Sub

    '******Lấy ID của danh sách loại sản phẩm đang chọn
    Dim ID_loaiSP As Integer
    Sub layid_loaiSP()
        ID_loaiSP = Convert.ToInt32(grv_loaisanpham.Rows(grv_loaisanpham.CurrentRow.Index).Cells(0).Value.ToString())
    End Sub

    Dim ID_SP As Integer
    Sub layid_SP()
        ID_SP = Convert.ToInt32(grv_danhsachsanpham.Rows(grv_danhsachsanpham.CurrentRow.Index).Cells(0).Value.ToString())
    End Sub

    Sub layloaisanpham()
        txt_loaisanpham.Text = Convert.ToString(grv_loaisanpham.Rows(grv_loaisanpham.CurrentRow.Index).Cells(1).Value.ToString())
    End Sub

    Sub laySP()
        txt_loaisanpham.Text = Convert.ToString(grv_danhsachsanpham.Rows(grv_danhsachsanpham.CurrentRow.Index).Cells(5).Value.ToString())
    End Sub

    Private Sub txt_tensanpham_TextChanged(sender As Object, e As EventArgs) Handles txt_tensanpham.TextChanged
        clear_error()
    End Sub

    Private Sub txt_giasanpham_TextChanged(sender As Object, e As EventArgs) Handles txt_giasanpham.TextChanged
        clear_error()
    End Sub

    Private Sub txt_giasanpham_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_giasanpham.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            lbl_error.Text = ""
            Exit Sub
        End If
        MessageBox.Show("Nhập sai định dạng tiền tệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        txt_giasanpham.Clear()
    End Sub
End Class