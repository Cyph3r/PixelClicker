Imports MaterialSkin.Controls

Namespace View
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PixelClickerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PixelClickerForm))
        Me.pbProgress = New System.Windows.Forms.PictureBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MainListView = New BrightIdeasSoftware.FastObjectListView()
        Me.ColumnBotName = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ColumnHotkey = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ColumnFps = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ColumnSearchArea = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ColumnDebug = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.refreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.stopStartTaskTimer = New System.Windows.Forms.Timer(Me.components)
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.LabelStartStop = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mStartStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.mNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.JoinDiscordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenu = New System.Windows.Forms.MenuStrip()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        CType(Me.pbProgress,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        CType(Me.MainListView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.statusStrip.SuspendLayout
        Me.mMenu.SuspendLayout
        Me.ToolStripContainer1.ContentPanel.SuspendLayout
        Me.ToolStripContainer1.SuspendLayout
        Me.SuspendLayout
        '
        'pbProgress
        '
        Me.pbProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer))
        Me.pbProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbProgress.Location = New System.Drawing.Point(0, 0)
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(372, 237)
        Me.pbProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProgress.TabIndex = 6
        Me.pbProgress.TabStop = false
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 118)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MainListView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pbProgress)
        Me.SplitContainer1.Size = New System.Drawing.Size(372, 465)
        Me.SplitContainer1.SplitterDistance = 224
        Me.SplitContainer1.TabIndex = 7
        '
        'MainListView
        '
        Me.MainListView.AllColumns.Add(Me.ColumnBotName)
        Me.MainListView.AllColumns.Add(Me.ColumnHotkey)
        Me.MainListView.AllColumns.Add(Me.ColumnFps)
        Me.MainListView.AllColumns.Add(Me.ColumnSearchArea)
        Me.MainListView.AllColumns.Add(Me.ColumnDebug)
        Me.MainListView.AlternateRowBackColor = System.Drawing.Color.Silver
        Me.MainListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(54,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(62,Byte),Integer))
        Me.MainListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.MainListView.CellEditUseWholeCell = false
        Me.MainListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnBotName, Me.ColumnHotkey, Me.ColumnFps, Me.ColumnSearchArea, Me.ColumnDebug})
        Me.MainListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.MainListView.FullRowSelect = true
        Me.MainListView.Location = New System.Drawing.Point(0, 0)
        Me.MainListView.Name = "MainListView"
        Me.MainListView.ShowGroups = false
        Me.MainListView.Size = New System.Drawing.Size(372, 224)
        Me.MainListView.TabIndex = 0
        Me.MainListView.UseCompatibleStateImageBehavior = false
        Me.MainListView.View = System.Windows.Forms.View.Details
        Me.MainListView.VirtualMode = true
        '
        'ColumnBotName
        '
        Me.ColumnBotName.AspectName = "BotName"
        Me.ColumnBotName.Text = "ColumnBotName"
        Me.ColumnBotName.Width = 72
        '
        'ColumnHotkey
        '
        Me.ColumnHotkey.AspectName = "Hotkey"
        Me.ColumnHotkey.IsEditable = false
        Me.ColumnHotkey.Text = "ColumnHotkey"
        Me.ColumnHotkey.Width = 64
        '
        'ColumnFps
        '
        Me.ColumnFps.AspectName = "LastFps"
        Me.ColumnFps.IsEditable = false
        Me.ColumnFps.Text = "ColumnFps"
        Me.ColumnFps.Width = 35
        '
        'ColumnSearchArea
        '
        Me.ColumnSearchArea.AspectName = "SearchArea"
        Me.ColumnSearchArea.IsEditable = false
        Me.ColumnSearchArea.Text = "ColumnSearchArea"
        Me.ColumnSearchArea.Width = 140
        '
        'ColumnDebug
        '
        Me.ColumnDebug.AspectName = "Debug"
        Me.ColumnDebug.Text = "ColumnDebug"
        Me.ColumnDebug.Width = 54
        '
        'refreshTimer
        '
        Me.refreshTimer.Enabled = true
        Me.refreshTimer.Interval = 1000
        '
        'stopStartTaskTimer
        '
        Me.stopStartTaskTimer.Enabled = true
        '
        'statusStrip
        '
        Me.statusStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(50,Byte),Integer), CType(CType(56,Byte),Integer))
        Me.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelStartStop})
        Me.statusStrip.Location = New System.Drawing.Point(0, 583)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(372, 22)
        Me.statusStrip.SizingGrip = false
        Me.statusStrip.TabIndex = 8
        '
        'LabelStartStop
        '
        Me.LabelStartStop.Name = "LabelStartStop"
        Me.LabelStartStop.Size = New System.Drawing.Size(148, 17)
        Me.LabelStartStop.Text = "LabelStart \ LabelStop[F12]"
        '
        'mStartStop
        '
        Me.mStartStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mStartStop.ForeColor = System.Drawing.Color.Black
        Me.mStartStop.Image = Global.PixelClickerGUI.My.Resources.Resources.StartTask
        Me.mStartStop.Name = "mStartStop"
        Me.mStartStop.Size = New System.Drawing.Size(60, 53)
        Me.mStartStop.ToolTipText = "[F12]"
        '
        'mNew
        '
        Me.mNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.mNew.Image = Global.PixelClickerGUI.My.Resources.Resources.AddTask
        Me.mNew.Name = "mNew"
        Me.mNew.Size = New System.Drawing.Size(60, 53)
        Me.mNew.Text = "New"
        '
        'mDelete
        '
        Me.mDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mDelete.Enabled = false
        Me.mDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.mDelete.Image = Global.PixelClickerGUI.My.Resources.Resources.DeleteTask
        Me.mDelete.Name = "mDelete"
        Me.mDelete.Size = New System.Drawing.Size(60, 53)
        Me.mDelete.Text = "Delete"
        '
        'mEdit
        '
        Me.mEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mEdit.Enabled = false
        Me.mEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.mEdit.Image = Global.PixelClickerGUI.My.Resources.Resources.EditTask
        Me.mEdit.Name = "mEdit"
        Me.mEdit.Size = New System.Drawing.Size(60, 53)
        Me.mEdit.Text = "Edit"
        '
        'JoinDiscordToolStripMenuItem
        '
        Me.JoinDiscordToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.JoinDiscordToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.JoinDiscordToolStripMenuItem.Image = Global.PixelClickerGUI.My.Resources.Resources.Discord
        Me.JoinDiscordToolStripMenuItem.Name = "JoinDiscordToolStripMenuItem"
        Me.JoinDiscordToolStripMenuItem.Size = New System.Drawing.Size(60, 53)
        Me.JoinDiscordToolStripMenuItem.Text = "Discord"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DonateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.DonateToolStripMenuItem.Image = Global.PixelClickerGUI.My.Resources.Resources.Donate
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(60, 53)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'mMenu
        '
        Me.mMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer))
        Me.mMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mMenu.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.mMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mStartStop, Me.mNew, Me.mDelete, Me.mEdit, Me.JoinDiscordToolStripMenuItem, Me.DonateToolStripMenuItem})
        Me.mMenu.Location = New System.Drawing.Point(0, 0)
        Me.mMenu.Name = "mMenu"
        Me.mMenu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mMenu.Size = New System.Drawing.Size(372, 57)
        Me.mMenu.TabIndex = 3
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.mMenu)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(372, 57)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 61)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(372, 57)
        Me.ToolStripContainer1.TabIndex = 9
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'PixelClickerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 605)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.SplitContainer1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "PixelClickerForm"
        Me.Text = "Pixel Clicker"
        CType(Me.pbProgress,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        CType(Me.MainListView,System.ComponentModel.ISupportInitialize).EndInit
        Me.statusStrip.ResumeLayout(false)
        Me.statusStrip.PerformLayout
        Me.mMenu.ResumeLayout(false)
        Me.mMenu.PerformLayout
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(false)
        Me.ToolStripContainer1.ContentPanel.PerformLayout
        Me.ToolStripContainer1.ResumeLayout(false)
        Me.ToolStripContainer1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
        Friend WithEvents pbProgress As PictureBox
        Friend WithEvents SplitContainer1 As SplitContainer
        Friend WithEvents MainListView As BrightIdeasSoftware.FastObjectListView
        Friend WithEvents ColumnBotName As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ColumnSearchArea As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ColumnHotkey As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ColumnFps As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ColumnDebug As BrightIdeasSoftware.OLVColumn
        Friend WithEvents refreshTimer As Timer
        Friend WithEvents stopStartTaskTimer As Timer
        Friend WithEvents statusStrip As StatusStrip
        Friend WithEvents LabelStartStop As ToolStripStatusLabel
        Friend WithEvents mStartStop As ToolStripMenuItem
        Friend WithEvents mNew As ToolStripMenuItem
        Friend WithEvents mDelete As ToolStripMenuItem
        Friend WithEvents mEdit As ToolStripMenuItem
        Friend WithEvents JoinDiscordToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents mMenu As MenuStrip
        Friend WithEvents ToolStripContainer1 As ToolStripContainer
    End Class
End NameSpace