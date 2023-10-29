Imports Newtonsoft.Json

Public Class MinecraftChecker
    Public Shared Function CheckServerStatus(host As String, Optional corePath As String = "pingMC.py", Optional port As Integer = 25565) As String
        Dim processInfo As New ProcessStartInfo()
        processInfo.FileName = "python" ' 假設 Python 已經添加到系統路徑中
        processInfo.Arguments = $"{corePath} " & host & " " & port
        processInfo.UseShellExecute = False
        processInfo.RedirectStandardOutput = True
        processInfo.CreateNoWindow = True

        Dim process As Process = Process.Start(processInfo)
        Dim output As String = process.StandardOutput.ReadToEnd()

        process.WaitForExit()

        Return ConvertToJSON(output)
    End Function

    Private Shared Function ConvertToJSON(output As String) As String
        Dim result As New Dictionary(Of String, Object)()

        If Not String.IsNullOrEmpty(output) Then
            ' 在此處，您可以根據 Python 腳本的輸出結構將其轉換為 JSON 格式
            ' 假設 output 是一個字符串形式的 JSON 數據
            result("output") = output
        Else
            result("error") = "未能獲取伺服器狀態"
        End If

        Return JsonConvert.SerializeObject(result)
    End Function
End Class
