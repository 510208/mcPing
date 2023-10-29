Public Class frmMessageBox

    Public Sub newMsgbox(ByVal message As String, ByVal title As String)
        Me.Text = title
        Label1.Text = message
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Me.Close()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Me.Close()
    End Sub
End Class