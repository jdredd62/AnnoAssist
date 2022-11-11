Public Class Ueber
    Private Sub B_Ueber_close_Click(sender As Object, e As EventArgs) Handles B_Ueber_close.Click
        Me.Close()
    End Sub

    Private Sub L_Ueber_Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles L_Ueber_Link.LinkClicked
        Process.Start("https://github.com/jdredd62/AnnoAssist")
    End Sub
End Class