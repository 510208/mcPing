Imports MaterialSkin

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green900, Accent.Green700, TextShade.WHITE)
        ChangeGlobalFont(New Font("Arial", 10)) ' 設置為 Arial 字型，大小為 10
    End Sub
    Private Sub ChangeGlobalFont(newFont As Font)
        For Each control As Control In Me.Controls
            UpdateControlFont(control, newFont)
        Next
    End Sub

    Private Sub UpdateControlFont(control As Control, newFont As Font)
        control.Font = newFont

        ' 如果控制項包含子控制項，遞歸地將字型設定應用於所有子控制項
        If control.Controls.Count > 0 Then
            For Each childControl As Control In control.Controls
                UpdateControlFont(childControl, newFont)
            Next
        End If
    End Sub
End Class
