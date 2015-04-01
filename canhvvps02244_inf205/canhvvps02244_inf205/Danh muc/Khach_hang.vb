Imports System.Data.SqlClient
Public Class Khach_hang

    Private Sub Khach_hang_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Quantri.Show()
    End Sub

    Private Sub Khach_hang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Quantri.Show()
    End Sub

    Private Sub Khach_hang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Sua.Enabled = False
        btn_Xoa.Enabled = False
        btn_Them.Enabled = False
        grb_1.Enabled = False
        grb_2.Enabled = False
        grb_3.Enabled = False
    End Sub

    Private Sub btn_Xem_Click(sender As Object, e As EventArgs) Handles btn_Xem.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        Dim sql As New SqlDataAdapter("select * from KHACH_HANG", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        If tb.Rows.Count > 0 Then
        Else
            lbl_soluongkhachhang.Text = "Không có khách hàng trong tài khoản"
            grb_2.Text = "Không có dữ liệu"
            MessageBox.Show("Không có dữ liệu :(", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_Them.Enabled = True
            Exit Sub
        End If
        ID_nguoidung = 0
        laydanhsach()
        laydulieu()
        layhoadon()
        lbl_soluongkhachhang.Text = "Số lượng khách hàng là: " & tb.Rows.Count() & ""
        txt_Tenkhachhang.Focus()
        btn_Sua.Enabled = True
        btn_Xoa.Enabled = True
        grb_1.Enabled = True
        grb_2.Enabled = True
        grb_3.Enabled = True
        btn_Them.Enabled = True

    End Sub

    Sub refesh()
        layID()
        laydanhsach()
        laydulieu()
        layhoadon()
    End Sub
    Dim ID_nguoidung As Integer = 0

    Sub layID()
        ID_nguoidung = Convert.ToInt32(grv_Danhsachkhachhang.Rows(grv_Danhsachkhachhang.CurrentRow.Index).Cells(0).Value.ToString())
        lbl_error.Text = ""
    End Sub

    Sub laydanhsach()
        Dim sql As New SqlDataAdapter("select Ma_khach_hang as 'ID', Ten_khach_hang as 'Tên khách hàng', Sdt as 'Số điện thoại', Dia_chi as 'Địa chỉ' from KHACH_HANG", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        grv_Danhsachkhachhang.DataSource = tb
    End Sub
    Sub laydulieu()
        Dim sql As New SqlDataAdapter("select * from KHACH_HANG where Ma_khach_hang	= " & ID_nguoidung & "", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        '***************
        txt_Tenkhachhang.DataBindings.Clear()
        txt_Tenkhachhang.DataBindings.Add("text", grv_Danhsachkhachhang.DataSource, "Tên khách hàng")
        '***************
        txt_Sodienthoai.DataBindings.Clear()
        txt_Sodienthoai.DataBindings.Add("text", grv_Danhsachkhachhang.DataSource, "Số điện thoại")
        '***************
        txt_Diachi.DataBindings.Clear()
        txt_Diachi.DataBindings.Add("text", grv_Danhsachkhachhang.DataSource, "Địa chỉ")
        '***************
    End Sub

    Sub layhoadon()
        Dim sql As New SqlDataAdapter("select Ma_hoa_don as 'ID', Ngay_lap as 'Ngày lập hóa đơn' from HOA_DON inner join KHACH_HANG on HOA_DON.KHACH_HANG_Ma_khach_hang = Khach_hang.Ma_khach_hang where KHACH_HANG.Ma_khach_hang = " & ID_nguoidung & "", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        grv_Danhsachhoadon.DataSource = tb
        grb_2.Text = "Số hóa đơn của " & txt_Tenkhachhang.Text & " là: " & grv_Danhsachhoadon.RowCount() & ""
    End Sub

    Private Sub grv_Danhsachkhachhang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grv_Danhsachkhachhang.CellClick
        layID()
        laydulieu()
        layhoadon()
    End Sub

    Sub kiemtraten()
        Dim sql_xacnhan As New SqlDataAdapter("select * from KHACH_HANG where Ten_khach_hang = '" & txt_Tenkhachhang.Text & "' and Ma_khach_hang <> " & ID_nguoidung & "", Login.ketnoi)
        Dim xacnhan As New DataTable
        Login.ketnoi.Open()
        sql_xacnhan.Fill(xacnhan)
        Login.ketnoi.Close()
        If xacnhan.Rows.Count > 0 Then
            MessageBox.Show("Tên khách hàng đã tồn tại :(", "Đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Tenkhachhang.Focus()
            Exit Sub
        Else
            suanguoidung()
            laydanhsach()
            laydulieu()
            layhoadon()
            lbl_error.Text = "Sửa thành công :)"
        End If
    End Sub

    Sub suanguoidung()
        Dim sql As New SqlDataAdapter("update KHACH_HANG set Ten_khach_hang ='" & txt_Tenkhachhang.Text & "', Sdt='" & txt_Sodienthoai.Text & "', Dia_Chi ='" & txt_Diachi.Text & "' where Ma_khach_hang = " & ID_nguoidung.ToString & "", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
    End Sub

    Private Sub btn_Sua_Click(sender As Object, e As EventArgs) Handles btn_Sua.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        layID()
        If txt_Tenkhachhang.Text = "" And txt_Sodienthoai.Text = "" And txt_Diachi.Text = "" Then
            MessageBox.Show("Bạn chưa nhập gì cả :(", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txt_Tenkhachhang.Text = "" Then
            lbl_error.Text = "Bạn chưa nhập tên khách hàng"
        Else
            If txt_Sodienthoai.Text = "" Then
                txt_Sodienthoai.Text = "Null"
            End If

            If txt_Diachi.Text = "" Then
                txt_Diachi.Text = "Null"
            End If
        End If
            kiemtraten()
    End Sub

    Private Sub btn_Xoa_Click(sender As Object, e As EventArgs) Handles btn_Xoa.Click
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        If grv_Danhsachkhachhang.RowCount() = 0 Then
            Exit Sub
        ElseIf MessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        layID()
        'vong lap
        Dim demdong As Integer = grv_Danhsachhoadon.RowCount()
        'Vong lap xoa het du lieu lien quan den Chi tiet hoa don
        Dim x As Integer = 0
        Dim mahoadon As Integer = 0
        Do While x < demdong
            mahoadon = Convert.ToInt32(grv_Danhsachhoadon.Rows(x).Cells(0).Value.ToString())
            '*******Delete chi tiet hoa don
            Dim CSDL As New SqlDataAdapter("delete from CHI_TIET_HOA_DON where HOA_DON_Ma_hoa_don = " & mahoadon & "", Login.ketnoi)
            Dim tb As New DataTable
            Login.ketnoi.Open()
            CSDL.Fill(tb)
            Login.ketnoi.Close()

            x = x + 1
        Loop
        'Vong lap xoa het du lieu lien quan den Hoa don
        Dim y As Integer = 0
        Dim IDhoadon As Integer = 0
        Do While y < demdong
            IDhoadon = Convert.ToInt32(grv_Danhsachhoadon.Rows(y).Cells(0).Value.ToString())
            '*******Delete Hoa don
            Dim CSDL As New SqlDataAdapter("delete from HOA_DON where Ma_hoa_don = " & IDhoadon & "", Login.ketnoi)
            Dim tb As New DataTable
            Login.ketnoi.Open()
            CSDL.Fill(tb)
            Login.ketnoi.Close()

            y = y + 1
        Loop
        '**************
        Dim sql As New SqlDataAdapter("delete from KHACH_HANG where Ma_khach_hang = " & ID_nguoidung & "", Login.ketnoi)
        Dim bang As New DataTable
        Login.ketnoi.Open()
        sql.Fill(bang)
        Login.ketnoi.Close()
        '**********
        Dim sql2 As New SqlDataAdapter("select Ma_khach_hang as 'ID', Ten_khach_hang as 'Tên khách hàng', Sdt as 'Số điện thoại', Dia_chi as 'Địa chỉ' from KHACH_HANG", Login.ketnoi)
        Dim bang2 As New DataTable
        Login.ketnoi.Open()
        sql2.Fill(bang2)
        Login.ketnoi.Close()
        If bang2.Rows.Count() < 1 Then
            grv_Danhsachkhachhang.DataSource = bang2
            grb_1.Enabled = False
            grb_2.Enabled = False
            grb_3.Enabled = False
            btn_Sua.Enabled = False
            btn_Xoa.Enabled = False
            laydanhsach()
            laydulieu()
            layhoadon()
            MessageBox.Show("Đã hết dữ liệu người dùng :(", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.None)
            Exit Sub
        Else
            refesh()
        End If
    End Sub

    Private Sub btn_Them_Click(sender As Object, e As EventArgs) Handles btn_Them.Click
        Them_khach_hang.Show()
        Me.Enabled = False
    End Sub

    Private Sub txt_Sodienthoai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Sodienthoai.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            lbl_error.Text = ""
            Exit Sub
        End If
        lbl_error.Text = "Bạn phải nhập số điện thoại"
        txt_Sodienthoai.Clear()
    End Sub


    Private Sub grv_Danhsachkhachhang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grv_Danhsachkhachhang.CellContentClick

    End Sub
End Class