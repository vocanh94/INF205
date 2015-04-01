Imports System.Data.SqlClient
Public Class Them
 
    Private Sub btn_thoat_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        Try
            Login.ketnoi.Open()
            Login.ketnoi.Close()
        Catch MySqlException As SqlException
            MessageBox.Show("Server có vẻ mệt, xin vui lòng vào lúc khác :(", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
        '*************************
        Dim sql_xacnhan As New SqlDataAdapter("select * from NGUOI_DUNG where Ten_dang_nhap = '" & txt_user.Text & "'", Login.ketnoi)
        Dim xacnhan As New DataTable
        Login.ketnoi.Open()
        sql_xacnhan.Fill(xacnhan)
        Login.ketnoi.Close()
        'Xoa loi truoc do
        lbl_error.Text = ""
        If txt_user.Text = "" And txt_pass.Text = "" And txt_name.Text = "'  Then" Then
            lbl_error.Text = "Bạn chưa nhập dữ liệu"
            txt_user.Focus()
        ElseIf txt_user.Text = "" Then
            lbl_error.Text = "Bạn chưa nhập tên đăng nhập"
            txt_user.Focus()
        ElseIf xacnhan.Rows.Count > 0 Then
            MessageBox.Show("Tên truy cập đã tồn tại :(", "Đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txt_pass.Text = "" Then
            lbl_error.Text = "Bạn chưa nhập mật khẩu"
            txt_pass.Focus()
        Else
            If txt_name.Text = "" Then
                txt_name.Text = "Null"
            End If
            'Kiem tra tai khoan nguoi dung
            
           
            'Them du lieu vao
            Dim sql As New SqlDataAdapter("insert into NGUOI_DUNG values ('" & txt_user.Text & "', '" & txt_pass.Text & "', '" & txt_name.Text & "')", Login.ketnoi)
            Dim tb As New DataTable
            Login.ketnoi.Open()
            sql.Fill(tb)
            MessageBox.Show("Nhập thành công :)", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearbox()
            Login.ketnoi.Close()
        End If
    End Sub

    Sub clearbox()
        txt_name.Text = ""
        txt_pass.Text = ""
        txt_user.Text = ""
        txt_user.Focus()
    End Sub

    Private Sub Them_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Nguoi_dung.btn_xem.PerformClick()
        Nguoi_dung.Enabled = True
    End Sub

    Private Sub Them_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Nguoi_dung.btn_xem.PerformClick()
        Nguoi_dung.Enabled = True
    End Sub
End Class