Imports MaterialSkin.Controls

Namespace NEW_VIEW
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PixelClickerFormRedesign
        Inherits MaterialForm

        'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PixelClickerFormRedesign))
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider3 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton4 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton5 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialDivider4 = New MaterialSkin.Controls.MaterialDivider()
        Me.mStartStop = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.LabelSelectedTask = New MaterialSkin.Controls.MaterialLabel()
        Me.LabelSelectedProfile = New MaterialSkin.Controls.MaterialLabel()
        Me.LabelOnlineUsersCount = New MaterialSkin.Controls.MaterialLabel()
        Me.LabelOnlineUsers = New MaterialSkin.Controls.MaterialLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonCommunity = New MaterialSkin.Controls.MaterialFlatButton()
        Me.PanelMainSelector = New System.Windows.Forms.Panel()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider5 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider6 = New MaterialSkin.Controls.MaterialDivider()
        Me.LabelVersion = New MaterialSkin.Controls.MaterialLabel()
        Me.refreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.stopStartTaskTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TopPanel.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider2.BackColor = System.Drawing.Color.Transparent
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(145, 135)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(639, 459)
        Me.MaterialDivider2.TabIndex = 3
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Location = New System.Drawing.Point(12, 127)
        Me.MaterialDivider3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(780, 2)
        Me.MaterialDivider3.TabIndex = 4
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = true
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(23, 6)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = false
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(64, 36)
        Me.MaterialFlatButton1.TabIndex = 5
        Me.MaterialFlatButton1.Text = "TASKS"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = true
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = true
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.Icon = Nothing
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(23, 54)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = false
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(65, 36)
        Me.MaterialFlatButton2.TabIndex = 6
        Me.MaterialFlatButton2.Text = "DEBUG"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = true
        '
        'MaterialFlatButton4
        '
        Me.MaterialFlatButton4.AutoSize = true
        Me.MaterialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton4.Depth = 0
        Me.MaterialFlatButton4.Icon = Nothing
        Me.MaterialFlatButton4.Location = New System.Drawing.Point(13, 150)
        Me.MaterialFlatButton4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton4.Name = "MaterialFlatButton4"
        Me.MaterialFlatButton4.Primary = false
        Me.MaterialFlatButton4.Size = New System.Drawing.Size(85, 36)
        Me.MaterialFlatButton4.TabIndex = 8
        Me.MaterialFlatButton4.Text = "SETTINGS"
        Me.MaterialFlatButton4.UseVisualStyleBackColor = true
        '
        'MaterialFlatButton5
        '
        Me.MaterialFlatButton5.AutoSize = true
        Me.MaterialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton5.Depth = 0
        Me.MaterialFlatButton5.Icon = Nothing
        Me.MaterialFlatButton5.Location = New System.Drawing.Point(3, 198)
        Me.MaterialFlatButton5.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton5.Name = "MaterialFlatButton5"
        Me.MaterialFlatButton5.Primary = false
        Me.MaterialFlatButton5.Size = New System.Drawing.Size(105, 36)
        Me.MaterialFlatButton5.TabIndex = 9
        Me.MaterialFlatButton5.Text = "CONTACT US"
        Me.MaterialFlatButton5.UseVisualStyleBackColor = true
        '
        'MaterialDivider4
        '
        Me.MaterialDivider4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider4.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider4.Depth = 0
        Me.MaterialDivider4.Location = New System.Drawing.Point(137, 129)
        Me.MaterialDivider4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider4.Name = "MaterialDivider4"
        Me.MaterialDivider4.Size = New System.Drawing.Size(2, 472)
        Me.MaterialDivider4.TabIndex = 10
        Me.MaterialDivider4.Text = "MaterialDivider4"
        '
        'mStartStop
        '
        Me.mStartStop.AutoSize = true
        Me.mStartStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mStartStop.Depth = 0
        Me.mStartStop.Icon = Global.PixelClickerGUI.My.Resources.Resources.StartTask
        Me.mStartStop.Location = New System.Drawing.Point(4, 9)
        Me.mStartStop.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.mStartStop.MouseState = MaterialSkin.MouseState.HOVER
        Me.mStartStop.Name = "mStartStop"
        Me.mStartStop.Primary = false
        Me.mStartStop.Size = New System.Drawing.Size(92, 36)
        Me.mStartStop.TabIndex = 11
        Me.mStartStop.Text = "Start"
        Me.mStartStop.UseVisualStyleBackColor = true
        '
        'TopPanel
        '
        Me.TopPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TopPanel.Controls.Add(Me.LabelSelectedTask)
        Me.TopPanel.Controls.Add(Me.LabelSelectedProfile)
        Me.TopPanel.Controls.Add(Me.LabelOnlineUsersCount)
        Me.TopPanel.Controls.Add(Me.LabelOnlineUsers)
        Me.TopPanel.Controls.Add(Me.mStartStop)
        Me.TopPanel.Location = New System.Drawing.Point(12, 69)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(780, 52)
        Me.TopPanel.TabIndex = 12
        '
        'LabelSelectedTask
        '
        Me.LabelSelectedTask.AutoSize = true
        Me.LabelSelectedTask.Depth = 0
        Me.LabelSelectedTask.Font = New System.Drawing.Font("Roboto", 11!)
        Me.LabelSelectedTask.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.LabelSelectedTask.Location = New System.Drawing.Point(129, 27)
        Me.LabelSelectedTask.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelSelectedTask.Name = "LabelSelectedTask"
        Me.LabelSelectedTask.Size = New System.Drawing.Size(108, 19)
        Me.LabelSelectedTask.TabIndex = 15
        Me.LabelSelectedTask.Tag = "Selected Task: {0}"
        Me.LabelSelectedTask.Text = "Selected Task:"
        '
        'LabelSelectedProfile
        '
        Me.LabelSelectedProfile.AutoSize = true
        Me.LabelSelectedProfile.Depth = 0
        Me.LabelSelectedProfile.Font = New System.Drawing.Font("Roboto", 11!)
        Me.LabelSelectedProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.LabelSelectedProfile.Location = New System.Drawing.Point(129, 7)
        Me.LabelSelectedProfile.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelSelectedProfile.Name = "LabelSelectedProfile"
        Me.LabelSelectedProfile.Size = New System.Drawing.Size(61, 19)
        Me.LabelSelectedProfile.TabIndex = 14
        Me.LabelSelectedProfile.Tag = "Profile: {0}"
        Me.LabelSelectedProfile.Text = "Profile: "
        '
        'LabelOnlineUsersCount
        '
        Me.LabelOnlineUsersCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LabelOnlineUsersCount.AutoSize = true
        Me.LabelOnlineUsersCount.Depth = 0
        Me.LabelOnlineUsersCount.Font = New System.Drawing.Font("Roboto", 11!)
        Me.LabelOnlineUsersCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.LabelOnlineUsersCount.Location = New System.Drawing.Point(742, 9)
        Me.LabelOnlineUsersCount.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelOnlineUsersCount.Name = "LabelOnlineUsersCount"
        Me.LabelOnlineUsersCount.Size = New System.Drawing.Size(33, 19)
        Me.LabelOnlineUsersCount.TabIndex = 13
        Me.LabelOnlineUsersCount.Text = "100"
        Me.LabelOnlineUsersCount.Visible = false
        '
        'LabelOnlineUsers
        '
        Me.LabelOnlineUsers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LabelOnlineUsers.AutoSize = true
        Me.LabelOnlineUsers.Depth = 0
        Me.LabelOnlineUsers.Font = New System.Drawing.Font("Roboto", 11!)
        Me.LabelOnlineUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.LabelOnlineUsers.Location = New System.Drawing.Point(638, 9)
        Me.LabelOnlineUsers.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelOnlineUsers.Name = "LabelOnlineUsers"
        Me.LabelOnlineUsers.Size = New System.Drawing.Size(98, 19)
        Me.LabelOnlineUsers.TabIndex = 12
        Me.LabelOnlineUsers.Text = "Online Users:"
        Me.LabelOnlineUsers.Visible = false
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ButtonCommunity)
        Me.Panel1.Controls.Add(Me.PanelMainSelector)
        Me.Panel1.Controls.Add(Me.MaterialFlatButton1)
        Me.Panel1.Controls.Add(Me.MaterialFlatButton2)
        Me.Panel1.Controls.Add(Me.MaterialFlatButton5)
        Me.Panel1.Controls.Add(Me.MaterialFlatButton4)
        Me.Panel1.Location = New System.Drawing.Point(20, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(111, 459)
        Me.Panel1.TabIndex = 13
        '
        'ButtonCommunity
        '
        Me.ButtonCommunity.AutoSize = true
        Me.ButtonCommunity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonCommunity.Depth = 0
        Me.ButtonCommunity.Icon = Nothing
        Me.ButtonCommunity.Location = New System.Drawing.Point(14, 102)
        Me.ButtonCommunity.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ButtonCommunity.MouseState = MaterialSkin.MouseState.HOVER
        Me.ButtonCommunity.Name = "ButtonCommunity"
        Me.ButtonCommunity.Primary = false
        Me.ButtonCommunity.Size = New System.Drawing.Size(83, 36)
        Me.ButtonCommunity.TabIndex = 18
        Me.ButtonCommunity.Text = "PROFILES"
        Me.ButtonCommunity.UseVisualStyleBackColor = true
        '
        'PanelMainSelector
        '
        Me.PanelMainSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.PanelMainSelector.Location = New System.Drawing.Point(109, 6)
        Me.PanelMainSelector.Name = "PanelMainSelector"
        Me.PanelMainSelector.Size = New System.Drawing.Size(2, 36)
        Me.PanelMainSelector.TabIndex = 17
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(12, 600)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(780, 2)
        Me.MaterialDivider1.TabIndex = 14
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialDivider5
        '
        Me.MaterialDivider5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider5.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider5.Depth = 0
        Me.MaterialDivider5.Location = New System.Drawing.Point(790, 129)
        Me.MaterialDivider5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider5.Name = "MaterialDivider5"
        Me.MaterialDivider5.Size = New System.Drawing.Size(2, 472)
        Me.MaterialDivider5.TabIndex = 15
        Me.MaterialDivider5.Text = "MaterialDivider5"
        '
        'MaterialDivider6
        '
        Me.MaterialDivider6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider6.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider6.Depth = 0
        Me.MaterialDivider6.Location = New System.Drawing.Point(12, 129)
        Me.MaterialDivider6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider6.Name = "MaterialDivider6"
        Me.MaterialDivider6.Size = New System.Drawing.Size(2, 472)
        Me.MaterialDivider6.TabIndex = 16
        Me.MaterialDivider6.Text = "MaterialDivider6"
        '
        'LabelVersion
        '
        Me.LabelVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.LabelVersion.AutoSize = true
        Me.LabelVersion.Depth = 0
        Me.LabelVersion.Font = New System.Drawing.Font("Roboto", 11!)
        Me.LabelVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.LabelVersion.Location = New System.Drawing.Point(9, 608)
        Me.LabelVersion.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(113, 19)
        Me.LabelVersion.TabIndex = 17
        Me.LabelVersion.Text = "Version: 1.0.2.1"
        '
        'refreshTimer
        '
        Me.refreshTimer.Enabled = true
        Me.refreshTimer.Interval = 1000
        '
        'stopStartTaskTimer
        '
        Me.stopStartTaskTimer.Enabled = true
        Me.stopStartTaskTimer.Interval = 200
        '
        'PixelClickerFormRedesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 630)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.MaterialDivider6)
        Me.Controls.Add(Me.MaterialDivider5)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.MaterialDivider4)
        Me.Controls.Add(Me.MaterialDivider3)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "PixelClickerFormRedesign"
        Me.Text = "Pixel Clicker"
        Me.TopPanel.ResumeLayout(false)
        Me.TopPanel.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
        Friend WithEvents MaterialDivider2 As MaterialDivider
        Friend WithEvents MaterialDivider3 As MaterialDivider
        Friend WithEvents MaterialFlatButton1 As MaterialFlatButton
        Friend WithEvents MaterialFlatButton2 As MaterialFlatButton
        Friend WithEvents MaterialFlatButton4 As MaterialFlatButton
        Friend WithEvents MaterialFlatButton5 As MaterialFlatButton
        Friend WithEvents MaterialDivider4 As MaterialDivider
        Friend WithEvents mStartStop As MaterialFlatButton
        Friend WithEvents TopPanel As Panel
        Friend WithEvents Panel1 As Panel
        Friend WithEvents MaterialDivider1 As MaterialDivider
        Friend WithEvents MaterialDivider5 As MaterialDivider
        Friend WithEvents MaterialDivider6 As MaterialDivider
        Friend WithEvents PanelMainSelector As Panel
        Friend WithEvents ButtonCommunity As MaterialFlatButton
        Friend WithEvents LabelVersion As MaterialLabel
        Friend WithEvents LabelOnlineUsersCount As MaterialLabel
        Friend WithEvents LabelOnlineUsers As MaterialLabel
        Friend WithEvents refreshTimer As Timer
        Friend WithEvents stopStartTaskTimer As Timer
        Friend WithEvents LabelSelectedTask As MaterialLabel
        Friend WithEvents LabelSelectedProfile As MaterialLabel
    End Class
End NameSpace