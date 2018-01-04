Imports MaterialSkin.Controls

Namespace NEW_VIEW
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class TaskListControl
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
        Me.TaskListView = New BrightIdeasSoftware.FastObjectListView()
        Me.ColumnTaskName = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ColumnHotkey = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ColumnFps = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ColumnLastHealthbarHeight = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.TaskPanel = New System.Windows.Forms.Panel()
        Me.ButtonDelete = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ButtonEdit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ButtonAdd = New MaterialSkin.Controls.MaterialFlatButton()
        CType(Me.TaskListView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TaskPanel.SuspendLayout
        Me.SuspendLayout
        '
        'TaskListView
        '
        Me.TaskListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.TaskListView.AllColumns.Add(Me.ColumnTaskName)
        Me.TaskListView.AllColumns.Add(Me.ColumnHotkey)
        Me.TaskListView.AllColumns.Add(Me.ColumnFps)
        Me.TaskListView.AllColumns.Add(Me.ColumnLastHealthbarHeight)
        Me.TaskListView.AlternateRowBackColor = System.Drawing.Color.Silver
        Me.TaskListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TaskListView.BackColor = System.Drawing.Color.White
        Me.TaskListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TaskListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.TaskListView.CellEditUseWholeCell = false
        Me.TaskListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnTaskName, Me.ColumnHotkey, Me.ColumnFps, Me.ColumnLastHealthbarHeight})
        Me.TaskListView.CopySelectionOnControlC = false
        Me.TaskListView.CopySelectionOnControlCUsesDragSource = false
        Me.TaskListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.TaskListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TaskListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195,Byte),Integer), CType(CType(196,Byte),Integer), CType(CType(197,Byte),Integer))
        Me.TaskListView.FullRowSelect = true
        Me.TaskListView.Location = New System.Drawing.Point(0, 0)
        Me.TaskListView.Name = "TaskListView"
        Me.TaskListView.ShowGroups = false
        Me.TaskListView.Size = New System.Drawing.Size(766, 406)
        Me.TaskListView.TabIndex = 1
        Me.TaskListView.UseCompatibleStateImageBehavior = false
        Me.TaskListView.View = System.Windows.Forms.View.Details
        Me.TaskListView.VirtualMode = true
        '
        'ColumnTaskName
        '
        Me.ColumnTaskName.AspectName = "BotName"
        Me.ColumnTaskName.Text = "Task Name"
        Me.ColumnTaskName.Width = 174
        '
        'ColumnHotkey
        '
        Me.ColumnHotkey.AspectName = "Hotkey"
        Me.ColumnHotkey.IsEditable = false
        Me.ColumnHotkey.Text = "Hotkey"
        Me.ColumnHotkey.Width = 142
        '
        'ColumnFps
        '
        Me.ColumnFps.AspectName = "LastFps"
        Me.ColumnFps.IsEditable = false
        Me.ColumnFps.Text = "Fps"
        Me.ColumnFps.Width = 115
        '
        'ColumnLastHealthbarHeight
        '
        Me.ColumnLastHealthbarHeight.AspectName = "LastHealthBarHeight"
        Me.ColumnLastHealthbarHeight.IsEditable = false
        Me.ColumnLastHealthbarHeight.Text = "Last Health Bar Height"
        Me.ColumnLastHealthbarHeight.Width = 210
        '
        'TaskPanel
        '
        Me.TaskPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TaskPanel.BackColor = System.Drawing.SystemColors.Control
        Me.TaskPanel.Controls.Add(Me.ButtonDelete)
        Me.TaskPanel.Controls.Add(Me.ButtonEdit)
        Me.TaskPanel.Controls.Add(Me.ButtonAdd)
        Me.TaskPanel.Location = New System.Drawing.Point(0, 408)
        Me.TaskPanel.Name = "TaskPanel"
        Me.TaskPanel.Size = New System.Drawing.Size(767, 52)
        Me.TaskPanel.TabIndex = 13
        '
        'ButtonDelete
        '
        Me.ButtonDelete.AutoSize = true
        Me.ButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonDelete.Depth = 0
        Me.ButtonDelete.Icon = Global.PixelClickerGUI.My.Resources.Resources.DeleteTask
        Me.ButtonDelete.Location = New System.Drawing.Point(88, 8)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ButtonDelete.MouseState = MaterialSkin.MouseState.HOVER
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Primary = false
        Me.ButtonDelete.Size = New System.Drawing.Size(97, 36)
        Me.ButtonDelete.TabIndex = 14
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = true
        '
        'ButtonEdit
        '
        Me.ButtonEdit.AutoSize = true
        Me.ButtonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonEdit.Depth = 0
        Me.ButtonEdit.Icon = Global.PixelClickerGUI.My.Resources.Resources.EditTask
        Me.ButtonEdit.Location = New System.Drawing.Point(193, 9)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ButtonEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Primary = false
        Me.ButtonEdit.Size = New System.Drawing.Size(78, 36)
        Me.ButtonEdit.TabIndex = 13
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = true
        '
        'ButtonAdd
        '
        Me.ButtonAdd.AutoSize = true
        Me.ButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonAdd.Depth = 0
        Me.ButtonAdd.Icon = Global.PixelClickerGUI.My.Resources.Resources.AddTask
        Me.ButtonAdd.Location = New System.Drawing.Point(4, 8)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ButtonAdd.MouseState = MaterialSkin.MouseState.HOVER
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Primary = false
        Me.ButtonAdd.Size = New System.Drawing.Size(76, 36)
        Me.ButtonAdd.TabIndex = 12
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = true
        '
        'TaskListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TaskPanel)
        Me.Controls.Add(Me.TaskListView)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "TaskListControl"
        Me.Size = New System.Drawing.Size(766, 460)
        CType(Me.TaskListView,System.ComponentModel.ISupportInitialize).EndInit
        Me.TaskPanel.ResumeLayout(false)
        Me.TaskPanel.PerformLayout
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents TaskListView As BrightIdeasSoftware.FastObjectListView
        Friend WithEvents ColumnTaskName As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ColumnHotkey As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ColumnFps As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ColumnLastHealthbarHeight As BrightIdeasSoftware.OLVColumn
        Friend WithEvents TaskPanel As Panel
        Friend WithEvents ButtonDelete As MaterialFlatButton
        Friend WithEvents ButtonEdit As MaterialFlatButton
        Friend WithEvents ButtonAdd As MaterialFlatButton
    End Class
End NameSpace