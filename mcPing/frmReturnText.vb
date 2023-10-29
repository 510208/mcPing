Imports Newtonsoft.Json.Linq


Public Class frmReturnText
    Dim returnsis = Form1.returnSis
    Private Sub frmReturnText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 检查 returnSis 是否为空
        If returnsis IsNot Nothing Then
            ' 遍历 returnSis 中的 JSON 键值对，并添加到 ListView 中
            For Each pair As KeyValuePair(Of String, JToken) In returnsis
                Dim item As New ListViewItem(pair.Key)
                item.SubItems.Add(pair.Value.ToString())
                returntext.Items.Add(item)
            Next
        Else
            MsgBox("取值為N/A", MsgBoxStyle.Critical, "錯誤")
        End If
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Me.Close()
    End Sub
End Class
