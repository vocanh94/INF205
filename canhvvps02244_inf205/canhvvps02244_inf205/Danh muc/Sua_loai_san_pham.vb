Imports System.Data.SqlClient
Public Class Sua_loai_san_pham

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
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
            MessageBox.Show("Bạn phải nhập dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        '*********************
        Dim sql1 As New SqlDataAdapter("select * from LOAI_SAN_PHAM where Ten_loai = '" & txt_nhap.Text & "' and Ma_loai <> " & Convert.ToInt32(Loai_san_pham.txt_nhap.Text) & "", Login.ketnoi)
        Dim tb1 As New DataTable
        Login.ketnoi.Open()
        sql1.Fill(tb1)
        Login.ketnoi.Close()
        If tb1.Rows.Count() > 0 Then
            MessageBox.Show("Loại " & txt_nhap.Text & " đã tồn tại trong Cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_nhap.Focus()
            Exit Sub
        End If
        '************************
        Dim sql As New SqlDataAdapter("update LOAI_SAN_PHAM set Ten_loai = '" & txt_nhap.Text & "' where Ma_loai = '" & Convert.ToInt32(Loai_san_pham.txt_nhap.Text) & "'", Login.ketnoi)
        Dim tb As New DataTable
        Login.ketnoi.Open()
        sql.Fill(tb)
        Login.ketnoi.Close()
        Me.Close()
    End Sub

    Private Sub Sua_loai_san_pham_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Loai_san_pham.Enabled = True
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        Loai_san_pham.hienthi()
        Loai_san_pham.txt_nhap.Text = ""
        Loai_san_pham.lbl_thongbao.Text = "Sửa thành công :)"
    End Sub

    Private Sub Sua_loai_san_pham_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Loai_san_pham.Enabled = True
        '*********************
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*********************
        Loai_san_pham.hienthi()
        Loai_san_pham.txt_nhap.Text = ""
        Loai_san_pham.lbl_thongbao.Text = "Sửa thành công :)"
    End Sub

End Class