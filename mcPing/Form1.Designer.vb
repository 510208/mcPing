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
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.crdInfo = New MaterialSkin.Controls.MaterialCard()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnReset = New MaterialSkin.Controls.MaterialButton()
        Me.btnStart = New MaterialSkin.Controls.MaterialButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPort = New MaterialSkin.Controls.MaterialTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUrl = New MaterialSkin.Controls.MaterialTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Me.txtSearchMod = New MaterialSkin.Controls.MaterialTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.txtPyPath = New MaterialSkin.Controls.MaterialTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtLog = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.MaterialFloatingActionButton1 = New MaterialSkin.Controls.MaterialFloatingActionButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaterialButton3 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton4 = New MaterialSkin.Controls.MaterialButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MaterialCard1.SuspendLayout()
        Me.crdInfo.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ImageList1.Images.SetKeyName(0, "question-square-svgrepo-com.png")
        Me.ImageList1.Images.SetKeyName(1, "play-svgrepo-com.png")
        Me.ImageList1.Images.SetKeyName(2, "home-1-svgrepo-com (1).png")
        Me.ImageList1.Images.SetKeyName(3, "settings-minimalistic-svgrepo-com.png")
        Me.ImageList1.Images.SetKeyName(4, "document-text-svgrepo-com.png")
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage4)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl1.ImageList = Me.ImageList1
        Me.MaterialTabControl1.Location = New System.Drawing.Point(3, 85)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(731, 224)
        Me.MaterialTabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.TabPage1.Controls.Add(Me.MaterialCard1)
        Me.TabPage1.Controls.Add(Me.crdInfo)
        Me.TabPage1.ImageKey = "home-1-svgrepo-com (1).png"
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(723, 181)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "首頁"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.MaterialFloatingActionButton1)
        Me.MaterialCard1.Controls.Add(Me.Label3)
        Me.MaterialCard1.Controls.Add(Me.Label4)
        Me.MaterialCard1.Controls.Add(Me.PictureBox2)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(336, 7)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(320, 100)
        Me.MaterialCard1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(91, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 39)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "開始測試"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "入門"
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
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(91, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "510208"
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnReset)
        Me.TabPage2.Controls.Add(Me.btnStart)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtPort)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtUrl)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.ImageKey = "play-svgrepo-com.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(723, 181)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "啟動Ping"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnReset.Depth = 0
        Me.btnReset.HighEmphasis = True
        Me.btnReset.Icon = Nothing
        Me.btnReset.Location = New System.Drawing.Point(450, 129)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnReset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnReset.Name = "btnReset"
        Me.btnReset.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnReset.Size = New System.Drawing.Size(82, 36)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "重設(&R)"
        Me.btnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnReset.UseAccentColor = False
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnStart.Depth = 0
        Me.btnStart.HighEmphasis = True
        Me.btnStart.Icon = Nothing
        Me.btnStart.Location = New System.Drawing.Point(540, 129)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnStart.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnStart.Name = "btnStart"
        Me.btnStart.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnStart.Size = New System.Drawing.Size(114, 36)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "開始測試(&S)"
        Me.btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnStart.UseAccentColor = False
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(235, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "(Minecraft預設端口號：25565)"
        '
        'txtPort
        '
        Me.txtPort.AnimateReadOnly = False
        Me.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPort.Depth = 0
        Me.txtPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtPort.LeadingIcon = Nothing
        Me.txtPort.Location = New System.Drawing.Point(134, 66)
        Me.txtPort.MaxLength = 50
        Me.txtPort.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPort.Multiline = False
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(95, 50)
        Me.txtPort.TabIndex = 4
        Me.txtPort.Text = "25565"
        Me.txtPort.TrailingIcon = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "測試端口號(&P)："
        '
        'txtUrl
        '
        Me.txtUrl.AnimateReadOnly = False
        Me.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUrl.Depth = 0
        Me.txtUrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtUrl.LeadingIcon = Nothing
        Me.txtUrl.Location = New System.Drawing.Point(134, 6)
        Me.txtUrl.MaxLength = 50
        Me.txtUrl.MouseState = MaterialSkin.MouseState.OUT
        Me.txtUrl.Multiline = False
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(520, 50)
        Me.txtUrl.TabIndex = 2
        Me.txtUrl.Text = ""
        Me.txtUrl.TrailingIcon = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "測試主機位置(&U)："
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.MaterialButton2)
        Me.TabPage3.Controls.Add(Me.txtSearchMod)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.MaterialButton1)
        Me.TabPage3.Controls.Add(Me.txtPyPath)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.ImageKey = "settings-minimalistic-svgrepo-com.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(723, 181)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "設定"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'MaterialButton2
        '
        Me.MaterialButton2.AutoSize = False
        Me.MaterialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton2.Depth = 0
        Me.MaterialButton2.HighEmphasis = True
        Me.MaterialButton2.Icon = Nothing
        Me.MaterialButton2.Location = New System.Drawing.Point(604, 60)
        Me.MaterialButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton2.Name = "MaterialButton2"
        Me.MaterialButton2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton2.Size = New System.Drawing.Size(50, 50)
        Me.MaterialButton2.TabIndex = 8
        Me.MaterialButton2.Text = "..."
        Me.MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton2.UseAccentColor = False
        Me.MaterialButton2.UseVisualStyleBackColor = True
        '
        'txtSearchMod
        '
        Me.txtSearchMod.AnimateReadOnly = False
        Me.txtSearchMod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchMod.Depth = 0
        Me.txtSearchMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtSearchMod.LeadingIcon = Nothing
        Me.txtSearchMod.Location = New System.Drawing.Point(134, 60)
        Me.txtSearchMod.MaxLength = 50
        Me.txtSearchMod.MouseState = MaterialSkin.MouseState.OUT
        Me.txtSearchMod.Multiline = False
        Me.txtSearchMod.Name = "txtSearchMod"
        Me.txtSearchMod.Size = New System.Drawing.Size(463, 50)
        Me.txtSearchMod.TabIndex = 7
        Me.txtSearchMod.Text = ""
        Me.txtSearchMod.TrailingIcon = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "查詢模組路徑(&S)："
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSize = False
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(604, 6)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(50, 50)
        Me.MaterialButton1.TabIndex = 5
        Me.MaterialButton1.Text = "..."
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'txtPyPath
        '
        Me.txtPyPath.AnimateReadOnly = False
        Me.txtPyPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPyPath.Depth = 0
        Me.txtPyPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPyPath.LeadingIcon = Nothing
        Me.txtPyPath.Location = New System.Drawing.Point(134, 6)
        Me.txtPyPath.MaxLength = 50
        Me.txtPyPath.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPyPath.Multiline = False
        Me.txtPyPath.Name = "txtPyPath"
        Me.txtPyPath.Size = New System.Drawing.Size(463, 50)
        Me.txtPyPath.TabIndex = 4
        Me.txtPyPath.Text = ""
        Me.txtPyPath.TrailingIcon = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Python呼叫路徑(&P)："
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.MaterialButton4)
        Me.TabPage4.Controls.Add(Me.MaterialButton3)
        Me.TabPage4.Controls.Add(Me.txtLog)
        Me.TabPage4.ImageKey = "document-text-svgrepo-com.png"
        Me.TabPage4.Location = New System.Drawing.Point(4, 39)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(723, 181)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "記錄檔"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.AnimateReadOnly = False
        Me.txtLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtLog.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLog.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLog.Depth = 0
        Me.txtLog.HideSelection = True
        Me.txtLog.Location = New System.Drawing.Point(6, 6)
        Me.txtLog.MaxLength = 32767
        Me.txtLog.MouseState = MaterialSkin.MouseState.OUT
        Me.txtLog.Name = "txtLog"
        Me.txtLog.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLog.ReadOnly = False
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLog.SelectedText = ""
        Me.txtLog.SelectionLength = 0
        Me.txtLog.SelectionStart = 0
        Me.txtLog.ShortcutsEnabled = True
        Me.txtLog.Size = New System.Drawing.Size(591, 159)
        Me.txtLog.TabIndex = 2
        Me.txtLog.TabStop = False
        Me.txtLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLog.UseSystemPasswordChar = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Python Runner (python.exe)|python.exe"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        Me.OpenFileDialog2.Filter = "Python Script (*.py)|*.py"
        '
        'MaterialFloatingActionButton1
        '
        Me.MaterialFloatingActionButton1.BackColor = System.Drawing.Color.White
        Me.MaterialFloatingActionButton1.Depth = 0
        Me.MaterialFloatingActionButton1.Icon = Global.mcPing.My.Resources.Resources.play_svgrepo_com__1_
        Me.MaterialFloatingActionButton1.Location = New System.Drawing.Point(259, 22)
        Me.MaterialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFloatingActionButton1.Name = "MaterialFloatingActionButton1"
        Me.MaterialFloatingActionButton1.Size = New System.Drawing.Size(56, 56)
        Me.MaterialFloatingActionButton1.TabIndex = 4
        Me.MaterialFloatingActionButton1.Text = "MaterialFloatingActionButton1"
        Me.MaterialFloatingActionButton1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.mcPing.My.Resources.Resources.play_svgrepo_com__1_
        Me.PictureBox2.Location = New System.Drawing.Point(17, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
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
        'MaterialButton3
        '
        Me.MaterialButton3.AutoSize = False
        Me.MaterialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton3.Depth = 0
        Me.MaterialButton3.HighEmphasis = True
        Me.MaterialButton3.Icon = Nothing
        Me.MaterialButton3.Location = New System.Drawing.Point(604, 6)
        Me.MaterialButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton3.Name = "MaterialButton3"
        Me.MaterialButton3.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton3.Size = New System.Drawing.Size(50, 50)
        Me.MaterialButton3.TabIndex = 6
        Me.MaterialButton3.Text = "Copy"
        Me.MaterialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton3.UseAccentColor = False
        Me.MaterialButton3.UseVisualStyleBackColor = True
        '
        'MaterialButton4
        '
        Me.MaterialButton4.AutoSize = False
        Me.MaterialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton4.Depth = 0
        Me.MaterialButton4.HighEmphasis = True
        Me.MaterialButton4.Icon = Nothing
        Me.MaterialButton4.Location = New System.Drawing.Point(604, 65)
        Me.MaterialButton4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton4.Name = "MaterialButton4"
        Me.MaterialButton4.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton4.Size = New System.Drawing.Size(50, 50)
        Me.MaterialButton4.TabIndex = 7
        Me.MaterialButton4.Text = "Save"
        Me.MaterialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton4.UseAccentColor = False
        Me.MaterialButton4.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "txt檔案 (*.txt)|*.txt"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(737, 313)
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
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.crdInfo.ResumeLayout(False)
        Me.crdInfo.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MaterialFloatingActionButton1 As MaterialSkin.Controls.MaterialFloatingActionButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUrl As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtPort As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnReset As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnStart As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtPyPath As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtSearchMod As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txtLog As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents MaterialButton4 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton3 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
