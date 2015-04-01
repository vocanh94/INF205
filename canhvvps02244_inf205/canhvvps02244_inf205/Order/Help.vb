
Public Class Help

    Private Sub Help_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Quantri.Enabled = True
    End Sub

    Private Sub Help_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Quantri.Enabled = True
    End Sub

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class