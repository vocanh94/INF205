Public Class info

    Private Sub info_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Quantri.Enabled = True
    End Sub

    Private Sub info_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Quantri.Enabled = True
    End Sub
End Class