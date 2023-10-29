<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnText
    Inherits MaterialSkin.Controls.MaterialForm

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.returntext = New MaterialSkin.Controls.MaterialListView()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.key = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.content = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'returntext
        '
        Me.returntext.AutoSizeTable = False
        Me.returntext.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.returntext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.returntext.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.key, Me.content})
        Me.returntext.Depth = 0
        Me.returntext.FullRowSelect = True
        Me.returntext.HideSelection = False
        Me.returntext.Location = New System.Drawing.Point(7, 68)
        Me.returntext.MinimumSize = New System.Drawing.Size(200, 100)
        Me.returntext.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.returntext.MouseState = MaterialSkin.MouseState.OUT
        Me.returntext.Name = "returntext"
        Me.returntext.OwnerDraw = True
        Me.returntext.Size = New System.Drawing.Size(548, 187)
        Me.returntext.TabIndex = 0
        Me.returntext.UseCompatibleStateImageBehavior = False
        Me.returntext.View = System.Windows.Forms.View.Details
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(472, 264)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(83, 36)
        Me.MaterialButton1.TabIndex = 1
        Me.MaterialButton1.Text = "確定(&O)"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 22.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "狀態：未知"
        '
        'key
        '
        Me.key.Text = "鍵"
        Me.key.Width = 150
        '
        'content
        '
        Me.content.Text = "值"
        Me.content.Width = 500
        '
        'frmReturnText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 309)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaterialButton1)
        Me.Controls.Add(Me.returntext)
        Me.Name = "frmReturnText"
        Me.Text = "回傳值"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents returntext As MaterialSkin.Controls.MaterialListView
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label1 As Label
    Friend WithEvents key As ColumnHeader
    Friend WithEvents content As ColumnHeader
End Class
