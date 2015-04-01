Imports System.Data.SqlClient
Public Class Loai_san_pham

    Private Sub Loai_san_pham_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Quantri.Show()
    End Sub

    Private Sub Loai_san_pham_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Quantri.Show()
    End Sub

    Private Sub Loai_san_pham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        hienthi()
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
        If txt_nhap.Text = "" Then
            lbl_thongbao.Text = " Bạn chưa nhập tên"
            txt_nhap.Focus()
            Exit Sub
        End If
        '''''''''''''''''''''''''''''
        Dim sql1 As New SqlDataAdapter("select * from LOAI_SAN_PHAM where Ten_loai = '" & txt_nhap.Text & "'", Login.ketnoi)
        Dim tb1 As New DataTable
        Login.ketnoi.Open()
        sql1.Fill(tb1)
        Login.ketnoi.Close()
        If tb1.Rows.Count() > 0 Then
            lbl_thongbao.Text = "Loại " & txt_nhap.Text & " đã tồn tại trong Cơ sở dữ liệu."
            txt_nhap.Focus()
            Exit Sub
        End If
        '''''''''''''''''''''''''''''
        Dim sql As New SqlDataAdapter("insert into LOAI_SAN_PHAM values ('" & txt_nhap.Text & "')", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        lbl_thongbao.Text = ""
        hienthi()
        txt_nhap.Text = ""
        btn_xoa.Enabled = True
        btn_sua.Enabled = True
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
        If MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        '*********************
        Dim sql As New SqlDataAdapter("select * from LOAI_SAN_PHAM", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        If tb.Rows.Count() < 1 Then
            hienthi()
            btn_xoa.Enabled = False
            txt_nhap.Focus()
            Exit Sub
        End If
        '*********************
        layID()
        '*********************
        Dim database_sanpham As New SqlDataAdapter("select * from SAN_PHAM where LOAI_SAN_PHAM_Ma_loai = " & ID_loaisanpham & "", Login.ketnoi)
        Dim bang As New DataTable
        Login.ketnoi.Open()
        database_sanpham.Fill(bang)
        Login.ketnoi.Close()
        Dim demdong As Integer = bang.Rows.Count()
        Dim x As Integer = 0
        Dim masanpham As Integer = 0
        Do While x < demdong
            masanpham = Convert.ToInt32(bang.Rows(x).Item(0).ToString())
            Dim CSDL As New SqlDataAdapter("delete from CHI_TIET_HOA_DON where SAN_PHAM_Ma_san_pham = " & masanpham & "", Login.ketnoi)
            Dim tb0 As New DataTable
            Login.ketnoi.Open()
            CSDL.Fill(tb0)
            Login.ketnoi.Close()
            x = x + 1
        Loop
        '*********************
        Dim y As Integer = 0
        masanpham = 0
        Do While y < demdong
            masanpham = Convert.ToInt32(bang.Rows(y).Item(0).ToString())
            '*******Delete Hoa don
            Dim CSDL As New SqlDataAdapter("delete from SAN_PHAM where Ma_san_pham = " & masanpham & "", Login.ketnoi)
            Dim tb1 As New DataTable
            Login.ketnoi.Open()
            CSDL.Fill(tb1)
            Login.ketnoi.Close()
            y = y + 1
        Loop
        '*********************
        Dim sql2 As New SqlDataAdapter("delete from LOAI_SAN_PHAM where Ma_loai = " & ID_loaisanpham & "", Login.ketnoi)
        Dim tb2 As New DataTable
        Login.ketnoi.Open()
        sql2.Fill(tb2)
        Login.ketnoi.Close()
        lbl_thongbao.Text = "Xóa thành công !"
        hienthi()
    End Sub
    '**********************************
    Dim ID_loaisanpham As Integer = 0

    Sub layID()
        ID_loaisanpham = Convert.ToInt32(grv_hienthi.Rows(grv_hienthi.CurrentRow.Index).Cells(0).Value.ToString())
    End Sub

    Sub hienthi()
        Dim sql As New SqlDataAdapter("select Ma_loai as 'ID', Ten_loai as 'Loại sản phẩm' from LOAI_SAN_PHAM", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        grv_hienthi.DataSource = tb
        If tb.Rows.Count() < 1 Then
            lbl_error.Text = "Không có dữ liệu :("
            lbl_thongbao.Text = ""
            btn_xoa.Enabled = False
            btn_sua.Enabled = False
            Exit Sub
        End If

        lbl_error.Text = "Số lượng loại sản phẩm là: " & grv_hienthi.RowCount() & " loại."
    End Sub

    Public layten As String
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
        layID()
        Dim sql As New SqlDataAdapter("select Ten_loai from LOAI_SAN_PHAM where Ma_loai = " & ID_loaisanpham & "", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        layten = Convert.ToString(tb.Rows(0).Item(0).ToString())
        txt_nhap.Text = ID_loaisanpham
        Sua_loai_san_pham.Show()
        Sua_loai_san_pham.txt_nhap.Text = layten
        Sua_loai_san_pham.txt_nhap.Focus()
        Me.Enabled = False
    End Sub
End Class