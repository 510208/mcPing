Imports MaterialSkin
Imports System.Drawing.Text
Imports System.IO
Imports Newtonsoft.Json.Linq


Public Class Form1
    Const mcDefaultPort As Integer = 25565
    Public returnSis As JObject
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.AddFormToManage(frmMessageBox)
        SkinManager.AddFormToManage(frmReturnText)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green900, Accent.Green700, TextShade.WHITE)
        Dim pfc As New PrivateFontCollection
        pfc.AddFontFile(Application.StartupPath & "\fonts\jhenghei.ttf") 'Your font location, make sure the font is in "*.ttf" format
        txtPyPath.Text = $"C:\Users\{GetUserName()}\AppData\Local\Programs\Python\Python312\python.exe"
    End Sub

    Private Sub MaterialFloatingActionButton1_Click(sender As Object, e As EventArgs) Handles MaterialFloatingActionButton1.Click
        MaterialTabControl1.SelectedTab = MaterialTabControl1.TabPages(1)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPort.Text = mcDefaultPort.ToString
        txtUrl.Text = ""
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtPort.Text <> "" And txtUrl.Text <> "" Then
            btnStart.Enabled = False
            Dim returntext As String = MinecraftChecker.CheckServerStatus(txtUrl.Text, txtPyPath.Text, txtSearchMod.Text, txtPort.Text)

            ' 解析 JSON 字符串
            Dim returnSis As JObject = JObject.Parse(returntext)

            If returnSis.ContainsKey("error") Then
                ' 显示错误消息
                MsgBox(returnSis("error").ToString(), MsgBoxStyle.Critical, "錯誤")
            Else
                ' 显示另一个窗体
                frmReturnText.ShowDialog()
            End If

            btnStart.Enabled = True
        End If
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        OpenFileDialog1.ShowDialog()
        txtPyPath.Text = OpenFileDialog1.FileName

    End Sub

    Function GetUserName() As String
        If TypeOf My.User.CurrentPrincipal Is
          Security.Principal.WindowsPrincipal Then
            ' The application is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            ' The application is using custom authentication.
            Return My.User.Name
        End If
    End Function

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        OpenFileDialog2.ShowDialog()
        txtSearchMod.Text = OpenFileDialog2.FileName
    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs) Handles MaterialButton4.Click
        ' 检查文本框中是否有内容
        If txtLog.Text.Length > 0 Then
            Try

                SaveFileDialog1.ShowDialog()
                Dim filepath As String = SaveFileDialog1.FileName
                ' 写入文本框内容到指定的文件
                File.WriteAllText(filePath, txtLog.Text)
                frmMessageBox.newMsgbox("完成寫入", "寫入訊息")
            Catch ex As Exception
                MessageBox.Show($"写入文件时发生错误: {ex.Message}")
            End Try
        Else
            MessageBox.Show("文本框中无内容，无法写入到文件。")
        End If
    End Sub

    Sub log(text As String, Optional style As Long = 0)
        ' 根据需要更改样式处理
        ' 这里的样式字符串参数目前仅用作传入参数，可根据需要进行处理
        Dim typev As String = "[INFO]" ' 默认值 INFO
        Select Case style
            Case 0
                typev = "[INFO]"
            Case 1
                typev = "[CRICTAL]"
            Case 2
                typev = "[ERROR]"
            Case 3
                typev = "[WARNING]"
            Case Else
                typev = "[INFO]"
        End Select
        ' 追加当前日期时间和文本内容到txtLog.Text
        txtLog.Text = $"{txtLog.Text}{vbCrLf}{Now.ToString()} {typev} - {text}"
    End Sub
End Class
