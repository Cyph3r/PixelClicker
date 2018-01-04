Imports ColorPickerLib
Imports MaterialSkin.Controls

Namespace View

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class TaskWizardForm
        Inherits MaterialForm

        'Form overrides dispose to clean up the component list.
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

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskWizardForm))
        Me.LabelSearchAreaWidth = New System.Windows.Forms.Label()
        Me.txtSearchAreaWidth = New System.Windows.Forms.TextBox()
        Me.LabelAimXOffset = New System.Windows.Forms.Label()
        Me.txtXOffset = New System.Windows.Forms.TextBox()
        Me.LabelAimYOffset = New System.Windows.Forms.Label()
        Me.txtYOffset = New System.Windows.Forms.TextBox()
        Me.GroupBoxSearchSettings = New System.Windows.Forms.GroupBox()
        Me.flowMouseSettings = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelHotkey = New System.Windows.Forms.Label()
        Me.txtHotkey = New System.Windows.Forms.TextBox()
        Me.LabelSearchAreaHeight = New System.Windows.Forms.Label()
        Me.txtSearchAreaHeight = New System.Windows.Forms.TextBox()
        Me.LabelAimBotMoveSpeed = New System.Windows.Forms.Label()
        Me.txtMouseMoveSpeed = New System.Windows.Forms.TextBox()
        Me.LabelAntiShake = New System.Windows.Forms.Label()
        Me.AntiShake = New System.Windows.Forms.NumericUpDown()
        Me.LabelLineChecks = New System.Windows.Forms.Label()
        Me.txtLineChecks = New System.Windows.Forms.TextBox()
        Me.LabelHitChance = New System.Windows.Forms.Label()
        Me.txtHitChance = New System.Windows.Forms.TextBox()
        Me.RadioButtonNoClick = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHoldClick = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSingleClick = New System.Windows.Forms.RadioButton()
        Me.GroupBoxColors = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GEyeDropper1 = New ColorPickerLib.gEyeDropper()
        Me.LabelDragMe = New System.Windows.Forms.Label()
        Me.CheckBoxUsePremadeShades = New System.Windows.Forms.CheckBox()
        Me.ButtonDeleteSelected = New System.Windows.Forms.Button()
        Me.SearchListColors = New BrightIdeasSoftware.ObjectListView()
        Me.ColumnColor = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ColumnShadeVariation = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.CheckBoxDebugMode = New System.Windows.Forms.CheckBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.GroupBoxBotType = New System.Windows.Forms.GroupBox()
        Me.flowSearchType = New System.Windows.Forms.FlowLayoutPanel()
        Me.RadioButtonAim = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTrigger = New System.Windows.Forms.RadioButton()
        Me.rbFirst = New System.Windows.Forms.RadioButton()
        Me.ckAutoMouseMove = New System.Windows.Forms.CheckBox()
        Me.txtTaskName = New System.Windows.Forms.TextBox()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.CheckBoxDrawOnGame = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBoxSearchSettings.SuspendLayout
        Me.flowMouseSettings.SuspendLayout
        CType(Me.AntiShake,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBoxColors.SuspendLayout
        Me.FlowLayoutPanel1.SuspendLayout
        CType(Me.SearchListColors,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBoxBotType.SuspendLayout
        Me.flowSearchType.SuspendLayout
        Me.FlowLayoutPanel2.SuspendLayout
        Me.SuspendLayout
        '
        'LabelSearchAreaWidth
        '
        Me.LabelSearchAreaWidth.AutoSize = true
        Me.LabelSearchAreaWidth.Location = New System.Drawing.Point(3, 39)
        Me.LabelSearchAreaWidth.Name = "LabelSearchAreaWidth"
        Me.LabelSearchAreaWidth.Size = New System.Drawing.Size(117, 13)
        Me.LabelSearchAreaWidth.TabIndex = 19
        Me.LabelSearchAreaWidth.Text = "LabelSearchAreaWidth"
        '
        'txtSearchAreaWidth
        '
        Me.txtSearchAreaWidth.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.txtSearchAreaWidth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.txtSearchAreaWidth.Location = New System.Drawing.Point(3, 55)
        Me.txtSearchAreaWidth.Name = "txtSearchAreaWidth"
        Me.txtSearchAreaWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchAreaWidth.TabIndex = 7
        '
        'LabelAimXOffset
        '
        Me.LabelAimXOffset.AutoSize = true
        Me.LabelAimXOffset.Location = New System.Drawing.Point(129, 0)
        Me.LabelAimXOffset.Name = "LabelAimXOffset"
        Me.LabelAimXOffset.Size = New System.Drawing.Size(85, 13)
        Me.LabelAimXOffset.TabIndex = 17
        Me.LabelAimXOffset.Text = "LabelAimXOffset"
        '
        'txtXOffset
        '
        Me.txtXOffset.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.txtXOffset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.txtXOffset.Location = New System.Drawing.Point(129, 16)
        Me.txtXOffset.Name = "txtXOffset"
        Me.txtXOffset.Size = New System.Drawing.Size(100, 20)
        Me.txtXOffset.TabIndex = 9
        '
        'LabelAimYOffset
        '
        Me.LabelAimYOffset.AutoSize = true
        Me.LabelAimYOffset.Location = New System.Drawing.Point(129, 39)
        Me.LabelAimYOffset.Name = "LabelAimYOffset"
        Me.LabelAimYOffset.Size = New System.Drawing.Size(85, 13)
        Me.LabelAimYOffset.TabIndex = 18
        Me.LabelAimYOffset.Text = "LabelAimYOffset"
        '
        'txtYOffset
        '
        Me.txtYOffset.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.txtYOffset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.txtYOffset.Location = New System.Drawing.Point(129, 55)
        Me.txtYOffset.Name = "txtYOffset"
        Me.txtYOffset.Size = New System.Drawing.Size(100, 20)
        Me.txtYOffset.TabIndex = 10
        '
        'GroupBoxSearchSettings
        '
        Me.GroupBoxSearchSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSearchSettings.Controls.Add(Me.flowMouseSettings)
        Me.GroupBoxSearchSettings.Location = New System.Drawing.Point(12, 151)
        Me.GroupBoxSearchSettings.Name = "GroupBoxSearchSettings"
        Me.GroupBoxSearchSettings.Size = New System.Drawing.Size(502, 147)
        Me.GroupBoxSearchSettings.TabIndex = 1
        Me.GroupBoxSearchSettings.TabStop = false
        Me.GroupBoxSearchSettings.Text = "GroupBoxSearchSettings"
        '
        'flowMouseSettings
        '
        Me.flowMouseSettings.Controls.Add(Me.LabelHotkey)
        Me.flowMouseSettings.Controls.Add(Me.txtHotkey)
        Me.flowMouseSettings.Controls.Add(Me.LabelSearchAreaWidth)
        Me.flowMouseSettings.Controls.Add(Me.txtSearchAreaWidth)
        Me.flowMouseSettings.Controls.Add(Me.LabelSearchAreaHeight)
        Me.flowMouseSettings.Controls.Add(Me.txtSearchAreaHeight)
        Me.flowMouseSettings.Controls.Add(Me.LabelAimXOffset)
        Me.flowMouseSettings.Controls.Add(Me.txtXOffset)
        Me.flowMouseSettings.Controls.Add(Me.LabelAimYOffset)
        Me.flowMouseSettings.Controls.Add(Me.txtYOffset)
        Me.flowMouseSettings.Controls.Add(Me.LabelAimBotMoveSpeed)
        Me.flowMouseSettings.Controls.Add(Me.txtMouseMoveSpeed)
        Me.flowMouseSettings.Controls.Add(Me.LabelAntiShake)
        Me.flowMouseSettings.Controls.Add(Me.AntiShake)
        Me.flowMouseSettings.Controls.Add(Me.LabelLineChecks)
        Me.flowMouseSettings.Controls.Add(Me.txtLineChecks)
        Me.flowMouseSettings.Controls.Add(Me.LabelHitChance)
        Me.flowMouseSettings.Controls.Add(Me.txtHitChance)
        Me.flowMouseSettings.Controls.Add(Me.RadioButtonNoClick)
        Me.flowMouseSettings.Controls.Add(Me.RadioButtonHoldClick)
        Me.flowMouseSettings.Controls.Add(Me.RadioButtonSingleClick)
        Me.flowMouseSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowMouseSettings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowMouseSettings.Location = New System.Drawing.Point(3, 16)
        Me.flowMouseSettings.Name = "flowMouseSettings"
        Me.flowMouseSettings.Size = New System.Drawing.Size(496, 128)
        Me.flowMouseSettings.TabIndex = 19
        '
        'LabelHotkey
        '
        Me.LabelHotkey.AutoSize = true
        Me.LabelHotkey.Location = New System.Drawing.Point(3, 0)
        Me.LabelHotkey.Name = "LabelHotkey"
        Me.LabelHotkey.Size = New System.Drawing.Size(67, 13)
        Me.LabelHotkey.TabIndex = 6
        Me.LabelHotkey.Text = "LabelHotkey"
        '
        'txtHotkey
        '
        Me.txtHotkey.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.txtHotkey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.txtHotkey.Location = New System.Drawing.Point(3, 16)
        Me.txtHotkey.Name = "txtHotkey"
        Me.txtHotkey.ReadOnly = true
        Me.txtHotkey.ShortcutsEnabled = false
        Me.txtHotkey.Size = New System.Drawing.Size(100, 20)
        Me.txtHotkey.TabIndex = 6
        '
        'LabelSearchAreaHeight
        '
        Me.LabelSearchAreaHeight.AutoSize = true
        Me.LabelSearchAreaHeight.Location = New System.Drawing.Point(3, 78)
        Me.LabelSearchAreaHeight.Name = "LabelSearchAreaHeight"
        Me.LabelSearchAreaHeight.Size = New System.Drawing.Size(120, 13)
        Me.LabelSearchAreaHeight.TabIndex = 21
        Me.LabelSearchAreaHeight.Text = "LabelSearchAreaHeight"
        '
        'txtSearchAreaHeight
        '
        Me.txtSearchAreaHeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.txtSearchAreaHeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.txtSearchAreaHeight.Location = New System.Drawing.Point(3, 94)
        Me.txtSearchAreaHeight.Name = "txtSearchAreaHeight"
        Me.txtSearchAreaHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchAreaHeight.TabIndex = 8
        '
        'LabelAimBotMoveSpeed
        '
        Me.LabelAimBotMoveSpeed.AutoSize = true
        Me.LabelAimBotMoveSpeed.Location = New System.Drawing.Point(129, 78)
        Me.LabelAimBotMoveSpeed.Name = "LabelAimBotMoveSpeed"
        Me.LabelAimBotMoveSpeed.Size = New System.Drawing.Size(124, 13)
        Me.LabelAimBotMoveSpeed.TabIndex = 16
        Me.LabelAimBotMoveSpeed.Text = "LabelAimBotMoveSpeed"
        '
        'txtMouseMoveSpeed
        '
        Me.txtMouseMoveSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.txtMouseMoveSpeed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.txtMouseMoveSpeed.Location = New System.Drawing.Point(129, 94)
        Me.txtMouseMoveSpeed.Name = "txtMouseMoveSpeed"
        Me.txtMouseMoveSpeed.Size = New System.Drawing.Size(100, 20)
        Me.txtMouseMoveSpeed.TabIndex = 11
        '
        'LabelAntiShake
        '
        Me.LabelAntiShake.AutoSize = true
        Me.LabelAntiShake.Location = New System.Drawing.Point(259, 0)
        Me.LabelAntiShake.Name = "LabelAntiShake"
        Me.LabelAntiShake.Size = New System.Drawing.Size(82, 13)
        Me.LabelAntiShake.TabIndex = 18
        Me.LabelAntiShake.Text = "LabelAntiShake"
        '
        'AntiShake
        '
        Me.AntiShake.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.AntiShake.DecimalPlaces = 2
        Me.AntiShake.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.AntiShake.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.AntiShake.Location = New System.Drawing.Point(259, 16)
        Me.AntiShake.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AntiShake.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.AntiShake.Name = "AntiShake"
        Me.AntiShake.Size = New System.Drawing.Size(100, 20)
        Me.AntiShake.TabIndex = 26
        Me.AntiShake.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'LabelLineChecks
        '
        Me.LabelLineChecks.AutoSize = true
        Me.LabelLineChecks.Location = New System.Drawing.Point(259, 39)
        Me.LabelLineChecks.Name = "LabelLineChecks"
        Me.LabelLineChecks.Size = New System.Drawing.Size(89, 13)
        Me.LabelLineChecks.TabIndex = 23
        Me.LabelLineChecks.Text = "LabelLineChecks"
        '
        'txtLineChecks
        '
        Me.txtLineChecks.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.txtLineChecks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.txtLineChecks.Location = New System.Drawing.Point(259, 55)
        Me.txtLineChecks.Name = "txtLineChecks"
        Me.txtLineChecks.Size = New System.Drawing.Size(100, 20)
        Me.txtLineChecks.TabIndex = 13
        '
        'LabelHitChance
        '
        Me.LabelHitChance.AutoSize = true
        Me.LabelHitChance.Location = New System.Drawing.Point(259, 78)
        Me.LabelHitChance.Name = "LabelHitChance"
        Me.LabelHitChance.Size = New System.Drawing.Size(83, 13)
        Me.LabelHitChance.TabIndex = 25
        Me.LabelHitChance.Text = "LabelHitChance"
        '
        'txtHitChance
        '
        Me.txtHitChance.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.txtHitChance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.txtHitChance.Location = New System.Drawing.Point(259, 94)
        Me.txtHitChance.Name = "txtHitChance"
        Me.txtHitChance.Size = New System.Drawing.Size(100, 20)
        Me.txtHitChance.TabIndex = 14
        '
        'RadioButtonNoClick
        '
        Me.RadioButtonNoClick.AutoSize = true
        Me.RadioButtonNoClick.Location = New System.Drawing.Point(365, 3)
        Me.RadioButtonNoClick.Name = "RadioButtonNoClick"
        Me.RadioButtonNoClick.Size = New System.Drawing.Size(121, 17)
        Me.RadioButtonNoClick.TabIndex = 15
        Me.RadioButtonNoClick.TabStop = true
        Me.RadioButtonNoClick.Tag = "0"
        Me.RadioButtonNoClick.Text = "RadioButtonNoClick"
        Me.RadioButtonNoClick.UseVisualStyleBackColor = true
        '
        'RadioButtonHoldClick
        '
        Me.RadioButtonHoldClick.AutoSize = true
        Me.RadioButtonHoldClick.Location = New System.Drawing.Point(365, 26)
        Me.RadioButtonHoldClick.Name = "RadioButtonHoldClick"
        Me.RadioButtonHoldClick.Size = New System.Drawing.Size(129, 17)
        Me.RadioButtonHoldClick.TabIndex = 16
        Me.RadioButtonHoldClick.TabStop = true
        Me.RadioButtonHoldClick.Tag = "1"
        Me.RadioButtonHoldClick.Text = "RadioButtonHoldClick"
        Me.RadioButtonHoldClick.UseVisualStyleBackColor = true
        '
        'RadioButtonSingleClick
        '
        Me.RadioButtonSingleClick.AutoSize = true
        Me.RadioButtonSingleClick.Location = New System.Drawing.Point(365, 49)
        Me.RadioButtonSingleClick.Name = "RadioButtonSingleClick"
        Me.RadioButtonSingleClick.Size = New System.Drawing.Size(136, 17)
        Me.RadioButtonSingleClick.TabIndex = 17
        Me.RadioButtonSingleClick.TabStop = true
        Me.RadioButtonSingleClick.Tag = "2"
        Me.RadioButtonSingleClick.Text = "RadioButtonSingleClick"
        Me.RadioButtonSingleClick.UseVisualStyleBackColor = true
        '
        'GroupBoxColors
        '
        Me.GroupBoxColors.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBoxColors.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBoxColors.Location = New System.Drawing.Point(12, 304)
        Me.GroupBoxColors.Name = "GroupBoxColors"
        Me.GroupBoxColors.Size = New System.Drawing.Size(502, 193)
        Me.GroupBoxColors.TabIndex = 2
        Me.GroupBoxColors.TabStop = false
        Me.GroupBoxColors.Text = "GroupBoxColors"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.GEyeDropper1)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelDragMe)
        Me.FlowLayoutPanel1.Controls.Add(Me.CheckBoxUsePremadeShades)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonDeleteSelected)
        Me.FlowLayoutPanel1.Controls.Add(Me.SearchListColors)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(496, 174)
        Me.FlowLayoutPanel1.TabIndex = 21
        '
        'GEyeDropper1
        '
        Me.GEyeDropper1.BackColor = System.Drawing.Color.Transparent
        Me.GEyeDropper1.BorderColor = System.Drawing.Color.Blue
        Me.GEyeDropper1.ButtonColor = System.Drawing.Color.White
        Me.GEyeDropper1.Location = New System.Drawing.Point(3, 3)
        Me.GEyeDropper1.Name = "GEyeDropper1"
        Me.GEyeDropper1.SelectedColor = System.Drawing.Color.Empty
        Me.GEyeDropper1.ShowSelectedSwatch = true
        Me.GEyeDropper1.Size = New System.Drawing.Size(22, 22)
        Me.GEyeDropper1.TabIndex = 4
        Me.GEyeDropper1.ZoomLevel = ColorPickerLib.gEyeDropper.eZoomLevel.Level2
        Me.GEyeDropper1.ZoomWindowType = ColorPickerLib.gEyeDropper.eZoomWindowType.ShowOnCursor
        '
        'LabelDragMe
        '
        Me.LabelDragMe.AutoSize = true
        Me.LabelDragMe.Location = New System.Drawing.Point(31, 0)
        Me.LabelDragMe.Name = "LabelDragMe"
        Me.LabelDragMe.Size = New System.Drawing.Size(71, 13)
        Me.LabelDragMe.TabIndex = 6
        Me.LabelDragMe.Text = "LabelDragMe"
        '
        'CheckBoxUsePremadeShades
        '
        Me.CheckBoxUsePremadeShades.AutoSize = true
        Me.CheckBoxUsePremadeShades.Location = New System.Drawing.Point(108, 3)
        Me.CheckBoxUsePremadeShades.Name = "CheckBoxUsePremadeShades"
        Me.CheckBoxUsePremadeShades.Size = New System.Drawing.Size(172, 17)
        Me.CheckBoxUsePremadeShades.TabIndex = 18
        Me.CheckBoxUsePremadeShades.Text = "CheckBoxUsePremadeShades"
        Me.CheckBoxUsePremadeShades.UseVisualStyleBackColor = true
        '
        'ButtonDeleteSelected
        '
        Me.ButtonDeleteSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeleteSelected.Location = New System.Drawing.Point(286, 3)
        Me.ButtonDeleteSelected.Name = "ButtonDeleteSelected"
        Me.ButtonDeleteSelected.Size = New System.Drawing.Size(96, 22)
        Me.ButtonDeleteSelected.TabIndex = 19
        Me.ButtonDeleteSelected.Text = "ButtonDeleteSelected"
        Me.ButtonDeleteSelected.UseVisualStyleBackColor = true
        '
        'SearchListColors
        '
        Me.SearchListColors.AllColumns.Add(Me.ColumnColor)
        Me.SearchListColors.AllColumns.Add(Me.ColumnShadeVariation)
        Me.SearchListColors.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SearchListColors.BackColor = System.Drawing.Color.FromArgb(CType(CType(54,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(62,Byte),Integer))
        Me.SearchListColors.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.SearchListColors.CellEditUseWholeCell = false
        Me.SearchListColors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnColor, Me.ColumnShadeVariation})
        Me.SearchListColors.Cursor = System.Windows.Forms.Cursors.Default
        Me.SearchListColors.ForeColor = System.Drawing.Color.White
        Me.SearchListColors.Location = New System.Drawing.Point(3, 31)
        Me.SearchListColors.Name = "SearchListColors"
        Me.SearchListColors.Size = New System.Drawing.Size(544, 180)
        Me.SearchListColors.TabIndex = 20
        Me.SearchListColors.UseCompatibleStateImageBehavior = false
        Me.SearchListColors.View = System.Windows.Forms.View.Details
        '
        'ColumnColor
        '
        Me.ColumnColor.AspectName = "SearchColor"
        Me.ColumnColor.Text = "ColumnColor"
        Me.ColumnColor.Width = 128
        '
        'ColumnShadeVariation
        '
        Me.ColumnShadeVariation.AspectName = "ShadeVariation"
        Me.ColumnShadeVariation.Text = "ColumnShadeVariation"
        Me.ColumnShadeVariation.Width = 128
        '
        'CheckBoxDebugMode
        '
        Me.CheckBoxDebugMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.CheckBoxDebugMode.AutoSize = true
        Me.CheckBoxDebugMode.Location = New System.Drawing.Point(368, 2)
        Me.CheckBoxDebugMode.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxDebugMode.Name = "CheckBoxDebugMode"
        Me.CheckBoxDebugMode.Size = New System.Drawing.Size(134, 17)
        Me.CheckBoxDebugMode.TabIndex = 2
        Me.CheckBoxDebugMode.Text = "CheckBoxDebugMode"
        Me.CheckBoxDebugMode.UseVisualStyleBackColor = true
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Location = New System.Drawing.Point(437, 503)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 22
        Me.ButtonCancel.Text = "ButtonCancel"
        Me.ButtonCancel.UseVisualStyleBackColor = true
        '
        'GroupBoxBotType
        '
        Me.GroupBoxBotType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBoxBotType.Controls.Add(Me.flowSearchType)
        Me.GroupBoxBotType.Controls.Add(Me.ckAutoMouseMove)
        Me.GroupBoxBotType.Location = New System.Drawing.Point(12, 101)
        Me.GroupBoxBotType.Name = "GroupBoxBotType"
        Me.GroupBoxBotType.Size = New System.Drawing.Size(502, 47)
        Me.GroupBoxBotType.TabIndex = 15
        Me.GroupBoxBotType.TabStop = false
        Me.GroupBoxBotType.Text = "GroupBoxBotType"
        '
        'flowSearchType
        '
        Me.flowSearchType.Controls.Add(Me.RadioButtonAim)
        Me.flowSearchType.Controls.Add(Me.RadioButtonTrigger)
        Me.flowSearchType.Controls.Add(Me.rbFirst)
        Me.flowSearchType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowSearchType.Location = New System.Drawing.Point(3, 16)
        Me.flowSearchType.Name = "flowSearchType"
        Me.flowSearchType.Size = New System.Drawing.Size(496, 28)
        Me.flowSearchType.TabIndex = 15
        '
        'RadioButtonAim
        '
        Me.RadioButtonAim.AutoSize = true
        Me.RadioButtonAim.Location = New System.Drawing.Point(3, 3)
        Me.RadioButtonAim.Name = "RadioButtonAim"
        Me.RadioButtonAim.Size = New System.Drawing.Size(101, 17)
        Me.RadioButtonAim.TabIndex = 3
        Me.RadioButtonAim.TabStop = true
        Me.RadioButtonAim.Tag = "1"
        Me.RadioButtonAim.Text = "RadioButtonAim"
        Me.RadioButtonAim.UseVisualStyleBackColor = true
        '
        'RadioButtonTrigger
        '
        Me.RadioButtonTrigger.AutoSize = true
        Me.RadioButtonTrigger.Location = New System.Drawing.Point(110, 3)
        Me.RadioButtonTrigger.Name = "RadioButtonTrigger"
        Me.RadioButtonTrigger.Size = New System.Drawing.Size(117, 17)
        Me.RadioButtonTrigger.TabIndex = 4
        Me.RadioButtonTrigger.TabStop = true
        Me.RadioButtonTrigger.Tag = "2"
        Me.RadioButtonTrigger.Text = "RadioButtonTrigger"
        Me.RadioButtonTrigger.UseVisualStyleBackColor = true
        '
        'rbFirst
        '
        Me.rbFirst.AutoSize = true
        Me.rbFirst.Enabled = false
        Me.rbFirst.Location = New System.Drawing.Point(233, 3)
        Me.rbFirst.Name = "rbFirst"
        Me.rbFirst.Size = New System.Drawing.Size(77, 17)
        Me.rbFirst.TabIndex = 5
        Me.rbFirst.TabStop = true
        Me.rbFirst.Tag = "0"
        Me.rbFirst.Text = "First Found"
        Me.rbFirst.UseVisualStyleBackColor = true
        Me.rbFirst.Visible = false
        '
        'ckAutoMouseMove
        '
        Me.ckAutoMouseMove.AutoSize = true
        Me.ckAutoMouseMove.Enabled = false
        Me.ckAutoMouseMove.Location = New System.Drawing.Point(6, 110)
        Me.ckAutoMouseMove.Name = "ckAutoMouseMove"
        Me.ckAutoMouseMove.Size = New System.Drawing.Size(88, 17)
        Me.ckAutoMouseMove.TabIndex = 14
        Me.ckAutoMouseMove.Text = "Move Mouse"
        Me.ckAutoMouseMove.UseVisualStyleBackColor = true
        Me.ckAutoMouseMove.Visible = false
        '
        'txtTaskName
        '
        Me.txtTaskName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtTaskName.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.txtTaskName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.txtTaskName.Location = New System.Drawing.Point(3, 3)
        Me.txtTaskName.Name = "txtTaskName"
        Me.txtTaskName.Size = New System.Drawing.Size(214, 20)
        Me.txtTaskName.TabIndex = 0
        '
        'ButtonOk
        '
        Me.ButtonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOk.Location = New System.Drawing.Point(356, 503)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOk.TabIndex = 21
        Me.ButtonOk.Text = "ButtonOk"
        Me.ButtonOk.UseVisualStyleBackColor = true
        '
        'CheckBoxDrawOnGame
        '
        Me.CheckBoxDrawOnGame.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.CheckBoxDrawOnGame.AutoSize = true
        Me.CheckBoxDrawOnGame.Location = New System.Drawing.Point(222, 2)
        Me.CheckBoxDrawOnGame.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxDrawOnGame.Name = "CheckBoxDrawOnGame"
        Me.CheckBoxDrawOnGame.Size = New System.Drawing.Size(142, 17)
        Me.CheckBoxDrawOnGame.TabIndex = 1
        Me.CheckBoxDrawOnGame.Text = "CheckBoxDrawOnGame"
        Me.CheckBoxDrawOnGame.UseVisualStyleBackColor = true
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.Controls.Add(Me.txtTaskName)
        Me.FlowLayoutPanel2.Controls.Add(Me.CheckBoxDrawOnGame)
        Me.FlowLayoutPanel2.Controls.Add(Me.CheckBoxDebugMode)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(12, 68)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(504, 27)
        Me.FlowLayoutPanel2.TabIndex = 23
        '
        'TaskWizardForm
        '
        Me.AcceptButton = Me.ButtonOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer))
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(537, 555)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.GroupBoxSearchSettings)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.GroupBoxColors)
        Me.Controls.Add(Me.GroupBoxBotType)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(537, 555)
        Me.Name = "TaskWizardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormTaskWizard"
        Me.GroupBoxSearchSettings.ResumeLayout(false)
        Me.flowMouseSettings.ResumeLayout(false)
        Me.flowMouseSettings.PerformLayout
        CType(Me.AntiShake,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBoxColors.ResumeLayout(false)
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.FlowLayoutPanel1.PerformLayout
        CType(Me.SearchListColors,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBoxBotType.ResumeLayout(false)
        Me.GroupBoxBotType.PerformLayout
        Me.flowSearchType.ResumeLayout(false)
        Me.flowSearchType.PerformLayout
        Me.FlowLayoutPanel2.ResumeLayout(false)
        Me.FlowLayoutPanel2.PerformLayout
        Me.ResumeLayout(false)

End Sub
        Friend WithEvents GroupBoxSearchSettings As GroupBox
        Friend WithEvents GroupBoxColors As GroupBox
        Friend WithEvents ButtonCancel As Button
        Friend WithEvents txtSearchAreaWidth As TextBox
        Friend WithEvents txtYOffset As TextBox
        Friend WithEvents txtXOffset As TextBox
        Friend WithEvents txtHotkey As TextBox
        Friend WithEvents LabelHotkey As Label
        Friend WithEvents RadioButtonSingleClick As RadioButton
        Friend WithEvents RadioButtonHoldClick As RadioButton
        Friend WithEvents GroupBoxBotType As GroupBox
        Friend WithEvents rbFirst As RadioButton
        Friend WithEvents RadioButtonAim As RadioButton
        Friend WithEvents RadioButtonTrigger As RadioButton
        Friend WithEvents txtTaskName As TextBox
        Friend WithEvents GEyeDropper1 As gEyeDropper
        Friend WithEvents gcpToolStripForeColor As ColorPickerLib.gColorPicker = New ColorPickerLib.gColorPicker
        Friend WithEvents ButtonDeleteSelected As Button
        Friend WithEvents CheckBoxDebugMode As CheckBox
        Friend WithEvents RadioButtonNoClick As RadioButton
        Friend WithEvents txtMouseMoveSpeed As TextBox
        Friend WithEvents LabelSearchAreaWidth As Label
        Friend WithEvents LabelAimYOffset As Label
        Friend WithEvents LabelAimXOffset As Label
        Friend WithEvents LabelAimBotMoveSpeed As Label
        Friend WithEvents ckAutoMouseMove As CheckBox
        Friend WithEvents flowMouseSettings As FlowLayoutPanel
        Friend WithEvents LabelAntiShake As Label
        Friend WithEvents flowSearchType As FlowLayoutPanel
        Friend WithEvents LabelDragMe As Label
        Friend WithEvents ButtonOk As Button
        Friend WithEvents LabelSearchAreaHeight As Label
        Friend WithEvents txtSearchAreaHeight As TextBox
        Friend WithEvents CheckBoxDrawOnGame As CheckBox
        Friend WithEvents CheckBoxUsePremadeShades As CheckBox
        Friend WithEvents LabelLineChecks As Label
        Friend WithEvents txtLineChecks As TextBox
        Friend WithEvents LabelHitChance As Label
        Friend WithEvents txtHitChance As TextBox
        Friend WithEvents SearchListColors As BrightIdeasSoftware.ObjectListView
        Friend WithEvents ColumnColor As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ColumnShadeVariation As BrightIdeasSoftware.OLVColumn
        Friend WithEvents AntiShake As NumericUpDown
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    End Class
End NameSpace