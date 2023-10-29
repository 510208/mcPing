<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnStatusChecker = New MaterialSkin.Controls.MaterialButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.crdInfo = New MaterialSkin.Controls.MaterialCard()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.crdInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStatusChecker
        '
        Me.btnStatusChecker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStatusChecker.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnStatusChecker.Depth = 0
        Me.btnStatusChecker.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnStatusChecker.HighEmphasis = True
        Me.btnStatusChecker.Icon = Nothing
        Me.btnStatusChecker.Location = New System.Drawing.Point(535, 253)
        Me.btnStatusChecker.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.btnStatusChecker.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnStatusChecker.Name = "btnStatusChecker"
        Me.btnStatusChecker.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnStatusChecker.Size = New System.Drawing.Size(162, 36)
        Me.btnStatusChecker.TabIndex = 0
        Me.btnStatusChecker.Text = "檢查伺服器狀態(&C)"
        Me.btnStatusChecker.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnStatusChecker.UseAccentColor = False
        Me.btnStatusChecker.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "home-1-svgrepo-com.png")
        Me.ImageList1.Images.SetKeyName(1, "question-square-svgrepo-com.png")
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl1.ImageList = Me.ImageList1
        Me.MaterialTabControl1.Location = New System.Drawing.Point(3, 85)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(699, 297)
        Me.MaterialTabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.TabPage1.Controls.Add(Me.crdInfo)
        Me.TabPage1.ImageKey = "home-1-svgrepo-com.png"
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(691, 254)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.ImageKey = "question-square-svgrepo-com.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(691, 254)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'crdInfo
        '
        Me.crdInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.crdInfo.Controls.Add(Me.LinkLabel1)
        Me.crdInfo.Controls.Add(Me.Label2)
        Me.crdInfo.Controls.Add(Me.Label1)
        Me.crdInfo.Controls.Add(Me.PictureBox1)
        Me.crdInfo.Depth = 0
        Me.crdInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.crdInfo.Location = New System.Drawing.Point(7, 7)
        Me.crdInfo.Margin = New System.Windows.Forms.Padding(14)
        Me.crdInfo.MouseState = MaterialSkin.MouseState.HOVER
        Me.crdInfo.Name = "crdInfo"
        Me.crdInfo.Padding = New System.Windows.Forms.Padding(14)
        Me.crdInfo.Size = New System.Drawing.Size(320, 100)
        Me.crdInfo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mcPing.My.Resources.Resources.github
        Me.PictureBox1.Location = New System.Drawing.Point(17, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "設計者"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(93, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "510208"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(96, 70)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(70, 16)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "前往Github"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(705, 386)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.btnStatusChecker)
        Me.DrawerShowIconsWhenHidden = True
        Me.DrawerTabControl = Me.MaterialTabControl1
        Me.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(3, 85, 3, 4)
        Me.Text = "Minecraft Server Status Check Prog"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.crdInfo.ResumeLayout(False)
        Me.crdInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStatusChecker As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents crdInfo As MaterialSkin.Controls.MaterialCard
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
End Class
