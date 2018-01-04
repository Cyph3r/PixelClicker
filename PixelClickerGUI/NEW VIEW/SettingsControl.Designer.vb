Namespace NEW_VIEW
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SettingsControl
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPageGlobal = New System.Windows.Forms.TabPage()
        Me.PanelGlobal = New System.Windows.Forms.Panel()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBoxDebugMode = New MaterialSkin.Controls.MaterialCheckBox()
        Me.CheckBoxDrawOnGame = New MaterialSkin.Controls.MaterialCheckBox()
        Me.TextBoxGameName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.LabelHotkey = New MaterialSkin.Controls.MaterialLabel()
        Me.CheckBoxAlwaysOnTop = New MaterialSkin.Controls.MaterialCheckBox()
        Me.PanelGlobalSettings = New System.Windows.Forms.Panel()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider3 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider4 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider36 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider37 = New MaterialSkin.Controls.MaterialDivider()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.PanelGlobalSettingsDescription = New System.Windows.Forms.Panel()
        Me.MaterialDivider38 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider39 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider40 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider41 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider42 = New MaterialSkin.Controls.MaterialDivider()
        Me.TabPageKeyboard = New System.Windows.Forms.TabPage()
        Me.PanelKeyboard = New System.Windows.Forms.Panel()
        Me.TabPageColorScheme = New System.Windows.Forms.TabPage()
        Me.materialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.materialButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialTabControl1.SuspendLayout
        Me.TabPageGlobal.SuspendLayout
        Me.PanelGlobal.SuspendLayout
        CType(Me.SplitContainer4,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer4.Panel1.SuspendLayout
        Me.SplitContainer4.Panel2.SuspendLayout
        Me.SplitContainer4.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.Panel21.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.PanelGlobalSettings.SuspendLayout
        Me.Panel23.SuspendLayout
        Me.PanelGlobalSettingsDescription.SuspendLayout
        Me.TabPageKeyboard.SuspendLayout
        Me.TabPageColorScheme.SuspendLayout
        Me.SuspendLayout
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(748, 30)
        Me.MaterialTabSelector1.TabIndex = 1
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.MaterialTabControl1.Controls.Add(Me.TabPageGlobal)
        Me.MaterialTabControl1.Controls.Add(Me.TabPageKeyboard)
        Me.MaterialTabControl1.Controls.Add(Me.TabPageColorScheme)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 29)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(748, 449)
        Me.MaterialTabControl1.TabIndex = 0
        '
        'TabPageGlobal
        '
        Me.TabPageGlobal.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageGlobal.Controls.Add(Me.PanelGlobal)
        Me.TabPageGlobal.ForeColor = System.Drawing.SystemColors.Control
        Me.TabPageGlobal.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGlobal.Name = "TabPageGlobal"
        Me.TabPageGlobal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGlobal.Size = New System.Drawing.Size(740, 423)
        Me.TabPageGlobal.TabIndex = 0
        Me.TabPageGlobal.Text = "Global"
        '
        'PanelGlobal
        '
        Me.PanelGlobal.AutoScroll = true
        Me.PanelGlobal.Controls.Add(Me.SplitContainer4)
        Me.PanelGlobal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGlobal.Location = New System.Drawing.Point(3, 3)
        Me.PanelGlobal.Name = "PanelGlobal"
        Me.PanelGlobal.Size = New System.Drawing.Size(734, 417)
        Me.PanelGlobal.TabIndex = 4
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.Panel23)
        Me.SplitContainer4.Size = New System.Drawing.Size(734, 417)
        Me.SplitContainer4.SplitterDistance = 248
        Me.SplitContainer4.TabIndex = 40
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel21)
        Me.Panel1.Controls.Add(Me.PanelGlobalSettings)
        Me.Panel1.Controls.Add(Me.MaterialDivider3)
        Me.Panel1.Controls.Add(Me.MaterialDivider4)
        Me.Panel1.Controls.Add(Me.MaterialDivider36)
        Me.Panel1.Controls.Add(Me.MaterialDivider37)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 417)
        Me.Panel1.TabIndex = 36
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel21.Location = New System.Drawing.Point(2, 39)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(244, 376)
        Me.Panel21.TabIndex = 35
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116!))
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBoxDebugMode, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBoxDrawOnGame, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxGameName, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelHotkey, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBoxAlwaysOnTop, 2, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(246, 109)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'CheckBoxDebugMode
        '
        Me.CheckBoxDebugMode.AutoSize = true
        Me.CheckBoxDebugMode.Depth = 0
        Me.CheckBoxDebugMode.Font = New System.Drawing.Font("Roboto", 10!)
        Me.CheckBoxDebugMode.Location = New System.Drawing.Point(0, 69)
        Me.CheckBoxDebugMode.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxDebugMode.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CheckBoxDebugMode.MouseState = MaterialSkin.MouseState.HOVER
        Me.CheckBoxDebugMode.Name = "CheckBoxDebugMode"
        Me.CheckBoxDebugMode.Ripple = true
        Me.CheckBoxDebugMode.Size = New System.Drawing.Size(103, 20)
        Me.CheckBoxDebugMode.TabIndex = 1
        Me.CheckBoxDebugMode.Text = "Debug Mode"
        Me.CheckBoxDebugMode.UseVisualStyleBackColor = true
        '
        'CheckBoxDrawOnGame
        '
        Me.CheckBoxDrawOnGame.AutoSize = true
        Me.CheckBoxDrawOnGame.Depth = 0
        Me.CheckBoxDrawOnGame.Font = New System.Drawing.Font("Roboto", 10!)
        Me.CheckBoxDrawOnGame.Location = New System.Drawing.Point(0, 29)
        Me.CheckBoxDrawOnGame.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxDrawOnGame.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CheckBoxDrawOnGame.MouseState = MaterialSkin.MouseState.HOVER
        Me.CheckBoxDrawOnGame.Name = "CheckBoxDrawOnGame"
        Me.CheckBoxDrawOnGame.Ripple = true
        Me.CheckBoxDrawOnGame.Size = New System.Drawing.Size(116, 20)
        Me.CheckBoxDrawOnGame.TabIndex = 0
        Me.CheckBoxDrawOnGame.Text = "Draw On Game"
        Me.CheckBoxDrawOnGame.UseVisualStyleBackColor = true
        '
        'TextBoxGameName
        '
        Me.TextBoxGameName.Depth = 0
        Me.TextBoxGameName.Hint = ""
        Me.TextBoxGameName.Location = New System.Drawing.Point(133, 3)
        Me.TextBoxGameName.MaxLength = 32767
        Me.TextBoxGameName.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBoxGameName.Name = "TextBoxGameName"
        Me.TextBoxGameName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxGameName.SelectedText = ""
        Me.TextBoxGameName.SelectionLength = 0
        Me.TextBoxGameName.SelectionStart = 0
        Me.TextBoxGameName.Size = New System.Drawing.Size(110, 23)
        Me.TextBoxGameName.TabIndex = 2
        Me.TextBoxGameName.TabStop = false
        Me.TextBoxGameName.UseSystemPasswordChar = false
        '
        'LabelHotkey
        '
        Me.LabelHotkey.AutoSize = true
        Me.LabelHotkey.Depth = 0
        Me.LabelHotkey.Font = New System.Drawing.Font("Roboto", 11!)
        Me.LabelHotkey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.LabelHotkey.Location = New System.Drawing.Point(3, 0)
        Me.LabelHotkey.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelHotkey.Name = "LabelHotkey"
        Me.LabelHotkey.Size = New System.Drawing.Size(96, 19)
        Me.LabelHotkey.TabIndex = 30
        Me.LabelHotkey.Text = "Game Name:"
        '
        'CheckBoxAlwaysOnTop
        '
        Me.CheckBoxAlwaysOnTop.AutoSize = true
        Me.CheckBoxAlwaysOnTop.Depth = 0
        Me.CheckBoxAlwaysOnTop.Font = New System.Drawing.Font("Roboto", 10!)
        Me.CheckBoxAlwaysOnTop.Location = New System.Drawing.Point(0, 49)
        Me.CheckBoxAlwaysOnTop.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxAlwaysOnTop.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CheckBoxAlwaysOnTop.MouseState = MaterialSkin.MouseState.HOVER
        Me.CheckBoxAlwaysOnTop.Name = "CheckBoxAlwaysOnTop"
        Me.CheckBoxAlwaysOnTop.Ripple = true
        Me.CheckBoxAlwaysOnTop.Size = New System.Drawing.Size(117, 20)
        Me.CheckBoxAlwaysOnTop.TabIndex = 3
        Me.CheckBoxAlwaysOnTop.Text = "Always On Top"
        Me.CheckBoxAlwaysOnTop.UseVisualStyleBackColor = true
        '
        'PanelGlobalSettings
        '
        Me.PanelGlobalSettings.Controls.Add(Me.MaterialDivider1)
        Me.PanelGlobalSettings.Controls.Add(Me.MaterialLabel3)
        Me.PanelGlobalSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelGlobalSettings.Location = New System.Drawing.Point(2, 2)
        Me.PanelGlobalSettings.Name = "PanelGlobalSettings"
        Me.PanelGlobalSettings.Size = New System.Drawing.Size(244, 37)
        Me.PanelGlobalSettings.TabIndex = 34
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 35)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(244, 2)
        Me.MaterialDivider1.TabIndex = 32
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = true
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(0, 9)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(64, 19)
        Me.MaterialLabel3.TabIndex = 28
        Me.MaterialLabel3.Text = "Settings"
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaterialDivider3.Location = New System.Drawing.Point(246, 2)
        Me.MaterialDivider3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(2, 413)
        Me.MaterialDivider3.TabIndex = 33
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'MaterialDivider4
        '
        Me.MaterialDivider4.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider4.Depth = 0
        Me.MaterialDivider4.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialDivider4.Location = New System.Drawing.Point(2, 0)
        Me.MaterialDivider4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider4.Name = "MaterialDivider4"
        Me.MaterialDivider4.Size = New System.Drawing.Size(246, 2)
        Me.MaterialDivider4.TabIndex = 32
        Me.MaterialDivider4.Text = "MaterialDivider4"
        '
        'MaterialDivider36
        '
        Me.MaterialDivider36.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider36.Depth = 0
        Me.MaterialDivider36.Dock = System.Windows.Forms.DockStyle.Left
        Me.MaterialDivider36.Location = New System.Drawing.Point(0, 0)
        Me.MaterialDivider36.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider36.Name = "MaterialDivider36"
        Me.MaterialDivider36.Size = New System.Drawing.Size(2, 415)
        Me.MaterialDivider36.TabIndex = 30
        Me.MaterialDivider36.Text = "MaterialDivider36"
        '
        'MaterialDivider37
        '
        Me.MaterialDivider37.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider37.Depth = 0
        Me.MaterialDivider37.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialDivider37.Location = New System.Drawing.Point(0, 415)
        Me.MaterialDivider37.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider37.Name = "MaterialDivider37"
        Me.MaterialDivider37.Size = New System.Drawing.Size(248, 2)
        Me.MaterialDivider37.TabIndex = 31
        Me.MaterialDivider37.Text = "MaterialDivider37"
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.Panel24)
        Me.Panel23.Controls.Add(Me.PanelGlobalSettingsDescription)
        Me.Panel23.Controls.Add(Me.MaterialDivider39)
        Me.Panel23.Controls.Add(Me.MaterialDivider40)
        Me.Panel23.Controls.Add(Me.MaterialDivider41)
        Me.Panel23.Controls.Add(Me.MaterialDivider42)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel23.Location = New System.Drawing.Point(0, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(482, 417)
        Me.Panel23.TabIndex = 36
        '
        'Panel24
        '
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel24.Location = New System.Drawing.Point(2, 39)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(478, 376)
        Me.Panel24.TabIndex = 35
        '
        'PanelGlobalSettingsDescription
        '
        Me.PanelGlobalSettingsDescription.Controls.Add(Me.MaterialDivider38)
        Me.PanelGlobalSettingsDescription.Controls.Add(Me.MaterialLabel4)
        Me.PanelGlobalSettingsDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelGlobalSettingsDescription.Location = New System.Drawing.Point(2, 2)
        Me.PanelGlobalSettingsDescription.Name = "PanelGlobalSettingsDescription"
        Me.PanelGlobalSettingsDescription.Size = New System.Drawing.Size(478, 37)
        Me.PanelGlobalSettingsDescription.TabIndex = 34
        '
        'MaterialDivider38
        '
        Me.MaterialDivider38.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider38.Depth = 0
        Me.MaterialDivider38.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialDivider38.Location = New System.Drawing.Point(0, 35)
        Me.MaterialDivider38.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider38.Name = "MaterialDivider38"
        Me.MaterialDivider38.Size = New System.Drawing.Size(478, 2)
        Me.MaterialDivider38.TabIndex = 32
        Me.MaterialDivider38.Text = "MaterialDivider38"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = true
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(0, 9)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(86, 19)
        Me.MaterialLabel4.TabIndex = 28
        Me.MaterialLabel4.Text = "Description"
        '
        'MaterialDivider39
        '
        Me.MaterialDivider39.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider39.Depth = 0
        Me.MaterialDivider39.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaterialDivider39.Location = New System.Drawing.Point(480, 2)
        Me.MaterialDivider39.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider39.Name = "MaterialDivider39"
        Me.MaterialDivider39.Size = New System.Drawing.Size(2, 413)
        Me.MaterialDivider39.TabIndex = 33
        Me.MaterialDivider39.Text = "MaterialDivider39"
        '
        'MaterialDivider40
        '
        Me.MaterialDivider40.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider40.Depth = 0
        Me.MaterialDivider40.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialDivider40.Location = New System.Drawing.Point(2, 0)
        Me.MaterialDivider40.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider40.Name = "MaterialDivider40"
        Me.MaterialDivider40.Size = New System.Drawing.Size(480, 2)
        Me.MaterialDivider40.TabIndex = 32
        Me.MaterialDivider40.Text = "MaterialDivider40"
        '
        'MaterialDivider41
        '
        Me.MaterialDivider41.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider41.Depth = 0
        Me.MaterialDivider41.Dock = System.Windows.Forms.DockStyle.Left
        Me.MaterialDivider41.Location = New System.Drawing.Point(0, 0)
        Me.MaterialDivider41.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider41.Name = "MaterialDivider41"
        Me.MaterialDivider41.Size = New System.Drawing.Size(2, 415)
        Me.MaterialDivider41.TabIndex = 30
        Me.MaterialDivider41.Text = "MaterialDivider41"
        '
        'MaterialDivider42
        '
        Me.MaterialDivider42.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider42.Depth = 0
        Me.MaterialDivider42.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialDivider42.Location = New System.Drawing.Point(0, 415)
        Me.MaterialDivider42.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider42.Name = "MaterialDivider42"
        Me.MaterialDivider42.Size = New System.Drawing.Size(482, 2)
        Me.MaterialDivider42.TabIndex = 31
        Me.MaterialDivider42.Text = "MaterialDivider42"
        '
        'TabPageKeyboard
        '
        Me.TabPageKeyboard.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageKeyboard.Controls.Add(Me.PanelKeyboard)
        Me.TabPageKeyboard.Location = New System.Drawing.Point(4, 22)
        Me.TabPageKeyboard.Name = "TabPageKeyboard"
        Me.TabPageKeyboard.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageKeyboard.Size = New System.Drawing.Size(740, 423)
        Me.TabPageKeyboard.TabIndex = 1
        Me.TabPageKeyboard.Text = "Keyboard"
        '
        'PanelKeyboard
        '
        Me.PanelKeyboard.AutoScroll = true
        Me.PanelKeyboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKeyboard.Location = New System.Drawing.Point(3, 3)
        Me.PanelKeyboard.Name = "PanelKeyboard"
        Me.PanelKeyboard.Size = New System.Drawing.Size(734, 417)
        Me.PanelKeyboard.TabIndex = 0
        '
        'TabPageColorScheme
        '
        Me.TabPageColorScheme.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageColorScheme.Controls.Add(Me.materialRaisedButton1)
        Me.TabPageColorScheme.Controls.Add(Me.materialButton1)
        Me.TabPageColorScheme.Location = New System.Drawing.Point(4, 22)
        Me.TabPageColorScheme.Name = "TabPageColorScheme"
        Me.TabPageColorScheme.Size = New System.Drawing.Size(740, 423)
        Me.TabPageColorScheme.TabIndex = 3
        Me.TabPageColorScheme.Text = "Color Scheme"
        '
        'materialRaisedButton1
        '
        Me.materialRaisedButton1.AutoSize = true
        Me.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.materialRaisedButton1.Depth = 0
        Me.materialRaisedButton1.Icon = Nothing
        Me.materialRaisedButton1.Location = New System.Drawing.Point(1, 5)
        Me.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialRaisedButton1.Name = "materialRaisedButton1"
        Me.materialRaisedButton1.Primary = true
        Me.materialRaisedButton1.Size = New System.Drawing.Size(181, 36)
        Me.materialRaisedButton1.TabIndex = 23
        Me.materialRaisedButton1.Text = "Change color scheme"
        Me.materialRaisedButton1.UseVisualStyleBackColor = true
        '
        'materialButton1
        '
        Me.materialButton1.AutoSize = true
        Me.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.materialButton1.Depth = 0
        Me.materialButton1.Icon = Nothing
        Me.materialButton1.Location = New System.Drawing.Point(1, 47)
        Me.materialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialButton1.Name = "materialButton1"
        Me.materialButton1.Primary = true
        Me.materialButton1.Size = New System.Drawing.Size(125, 36)
        Me.materialButton1.TabIndex = 22
        Me.materialButton1.Text = "Change Theme"
        Me.materialButton1.UseVisualStyleBackColor = true
        Me.materialButton1.Visible = false
        '
        'SettingsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "SettingsControl"
        Me.Size = New System.Drawing.Size(748, 478)
        Me.MaterialTabControl1.ResumeLayout(false)
        Me.TabPageGlobal.ResumeLayout(false)
        Me.PanelGlobal.ResumeLayout(false)
        Me.SplitContainer4.Panel1.ResumeLayout(false)
        Me.SplitContainer4.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer4,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer4.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel21.ResumeLayout(false)
        Me.Panel21.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.PanelGlobalSettings.ResumeLayout(false)
        Me.PanelGlobalSettings.PerformLayout
        Me.Panel23.ResumeLayout(false)
        Me.PanelGlobalSettingsDescription.ResumeLayout(false)
        Me.PanelGlobalSettingsDescription.PerformLayout
        Me.TabPageKeyboard.ResumeLayout(false)
        Me.TabPageColorScheme.ResumeLayout(false)
        Me.TabPageColorScheme.PerformLayout
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
        Friend WithEvents TabPageGlobal As TabPage
        Friend WithEvents TabPageKeyboard As TabPage
        Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
        Friend WithEvents TabPageColorScheme As TabPage
        Private WithEvents materialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
        Private WithEvents materialButton1 As MaterialSkin.Controls.MaterialRaisedButton
        Friend WithEvents CheckBoxDebugMode As MaterialSkin.Controls.MaterialCheckBox
        Friend WithEvents TextBoxGameName As MaterialSkin.Controls.MaterialSingleLineTextField
        Friend WithEvents CheckBoxAlwaysOnTop As MaterialSkin.Controls.MaterialCheckBox
        Friend WithEvents PanelGlobal As Panel
        Friend WithEvents PanelKeyboard As Panel
        Friend WithEvents SplitContainer4 As SplitContainer
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Panel21 As Panel
        Friend WithEvents PanelGlobalSettings As Panel
        Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
        Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
        Friend WithEvents MaterialDivider3 As MaterialSkin.Controls.MaterialDivider
        Friend WithEvents MaterialDivider4 As MaterialSkin.Controls.MaterialDivider
        Friend WithEvents MaterialDivider36 As MaterialSkin.Controls.MaterialDivider
        Friend WithEvents MaterialDivider37 As MaterialSkin.Controls.MaterialDivider
        Friend WithEvents Panel23 As Panel
        Friend WithEvents Panel24 As Panel
        Friend WithEvents PanelGlobalSettingsDescription As Panel
        Friend WithEvents MaterialDivider38 As MaterialSkin.Controls.MaterialDivider
        Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
        Friend WithEvents MaterialDivider39 As MaterialSkin.Controls.MaterialDivider
        Friend WithEvents MaterialDivider40 As MaterialSkin.Controls.MaterialDivider
        Friend WithEvents MaterialDivider41 As MaterialSkin.Controls.MaterialDivider
        Friend WithEvents MaterialDivider42 As MaterialSkin.Controls.MaterialDivider
        Friend WithEvents LabelHotkey As MaterialSkin.Controls.MaterialLabel
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents CheckBoxDrawOnGame As MaterialSkin.Controls.MaterialCheckBox
    End Class
End NameSpace