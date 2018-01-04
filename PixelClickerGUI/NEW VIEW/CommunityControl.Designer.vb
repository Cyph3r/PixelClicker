Namespace NEW_VIEW
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CommunityControl
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
        Me.TabPageProfile = New System.Windows.Forms.TabPage()
        Me.ProfileList = New BrightIdeasSoftware.ObjectListView()
        Me.ColumnSource = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ColumnName = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ColumnDescription = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ColumnTaskCount = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ButtonLoad = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ProfilePanel = New System.Windows.Forms.Panel()
        Me.ButtonSaveAsProfile = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ButtonDelete = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialTabControl1.SuspendLayout
        Me.TabPageProfile.SuspendLayout
        CType(Me.ProfileList,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ProfilePanel.SuspendLayout
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
        Me.MaterialTabControl1.Controls.Add(Me.TabPageProfile)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 29)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(748, 395)
        Me.MaterialTabControl1.TabIndex = 0
        '
        'TabPageProfile
        '
        Me.TabPageProfile.BackColor = System.Drawing.Color.Transparent
        Me.TabPageProfile.Controls.Add(Me.ProfileList)
        Me.TabPageProfile.Location = New System.Drawing.Point(4, 22)
        Me.TabPageProfile.Name = "TabPageProfile"
        Me.TabPageProfile.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageProfile.Size = New System.Drawing.Size(740, 369)
        Me.TabPageProfile.TabIndex = 1
        Me.TabPageProfile.Text = "Profile"
        '
        'ProfileList
        '
        Me.ProfileList.AllColumns.Add(Me.ColumnSource)
        Me.ProfileList.AllColumns.Add(Me.ColumnName)
        Me.ProfileList.AllColumns.Add(Me.ColumnDescription)
        Me.ProfileList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ProfileList.BackColor = System.Drawing.Color.FromArgb(CType(CType(54,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(62,Byte),Integer))
        Me.ProfileList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProfileList.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.ProfileList.CellEditUseWholeCell = false
        Me.ProfileList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnSource, Me.ColumnName, Me.ColumnDescription})
        Me.ProfileList.CopySelectionOnControlC = false
        Me.ProfileList.CopySelectionOnControlCUsesDragSource = false
        Me.ProfileList.Cursor = System.Windows.Forms.Cursors.Default
        Me.ProfileList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ProfileList.ForeColor = System.Drawing.Color.White
        Me.ProfileList.FullRowSelect = true
        Me.ProfileList.Location = New System.Drawing.Point(0, 0)
        Me.ProfileList.Name = "ProfileList"
        Me.ProfileList.ShowGroups = false
        Me.ProfileList.Size = New System.Drawing.Size(737, 366)
        Me.ProfileList.TabIndex = 21
        Me.ProfileList.UseCompatibleStateImageBehavior = false
        Me.ProfileList.View = System.Windows.Forms.View.Details
        '
        'ColumnSource
        '
        Me.ColumnSource.AspectName = "Source"
        Me.ColumnSource.IsEditable = false
        Me.ColumnSource.Text = "Source"
        Me.ColumnSource.Width = 264
        '
        'ColumnName
        '
        Me.ColumnName.AspectName = "Name"
        Me.ColumnName.Text = "Name"
        Me.ColumnName.Width = 128
        '
        'ColumnDescription
        '
        Me.ColumnDescription.AspectName = "Description"
        Me.ColumnDescription.Text = "Description"
        Me.ColumnDescription.Width = 336
        '
        'ColumnTaskCount
        '
        Me.ColumnTaskCount.AspectName = "TaskList.Count"
        Me.ColumnTaskCount.DisplayIndex = 2
        Me.ColumnTaskCount.Text = "Task Count"
        Me.ColumnTaskCount.Width = 132
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonLoad.AutoSize = true
        Me.ButtonLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonLoad.Depth = 0
        Me.ButtonLoad.Icon = Nothing
        Me.ButtonLoad.Location = New System.Drawing.Point(615, 8)
        Me.ButtonLoad.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ButtonLoad.MouseState = MaterialSkin.MouseState.HOVER
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Primary = false
        Me.ButtonLoad.Size = New System.Drawing.Size(125, 36)
        Me.ButtonLoad.TabIndex = 22
        Me.ButtonLoad.Text = "Load Selected"
        Me.ButtonLoad.UseVisualStyleBackColor = true
        '
        'ProfilePanel
        '
        Me.ProfilePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ProfilePanel.BackColor = System.Drawing.SystemColors.Control
        Me.ProfilePanel.Controls.Add(Me.ButtonSaveAsProfile)
        Me.ProfilePanel.Controls.Add(Me.ButtonLoad)
        Me.ProfilePanel.Controls.Add(Me.ButtonDelete)
        Me.ProfilePanel.Location = New System.Drawing.Point(0, 426)
        Me.ProfilePanel.Name = "ProfilePanel"
        Me.ProfilePanel.Size = New System.Drawing.Size(748, 52)
        Me.ProfilePanel.TabIndex = 23
        '
        'ButtonSaveAsProfile
        '
        Me.ButtonSaveAsProfile.AutoSize = true
        Me.ButtonSaveAsProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonSaveAsProfile.Depth = 0
        Me.ButtonSaveAsProfile.Icon = Global.PixelClickerGUI.My.Resources.Resources.AddTask
        Me.ButtonSaveAsProfile.Location = New System.Drawing.Point(4, 8)
        Me.ButtonSaveAsProfile.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ButtonSaveAsProfile.MouseState = MaterialSkin.MouseState.HOVER
        Me.ButtonSaveAsProfile.Name = "ButtonSaveAsProfile"
        Me.ButtonSaveAsProfile.Primary = false
        Me.ButtonSaveAsProfile.Size = New System.Drawing.Size(76, 36)
        Me.ButtonSaveAsProfile.TabIndex = 23
        Me.ButtonSaveAsProfile.Text = "Add"
        Me.ButtonSaveAsProfile.UseVisualStyleBackColor = true
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
        'CommunityControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ProfilePanel)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Name = "CommunityControl"
        Me.Size = New System.Drawing.Size(748, 478)
        Me.MaterialTabControl1.ResumeLayout(false)
        Me.TabPageProfile.ResumeLayout(false)
        CType(Me.ProfileList,System.ComponentModel.ISupportInitialize).EndInit
        Me.ProfilePanel.ResumeLayout(false)
        Me.ProfilePanel.PerformLayout
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
        Friend WithEvents TabPageProfile As TabPage
        Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
        Friend WithEvents ButtonLoad As MaterialSkin.Controls.MaterialFlatButton
        Friend WithEvents ProfileList As BrightIdeasSoftware.ObjectListView
        Friend WithEvents ColumnName As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ColumnSource As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ProfilePanel As Panel
        Friend WithEvents ButtonDelete As MaterialSkin.Controls.MaterialFlatButton
        Friend WithEvents ColumnTaskCount As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ButtonSaveAsProfile As MaterialSkin.Controls.MaterialFlatButton
        Friend WithEvents ColumnDescription As BrightIdeasSoftware.OLVColumn
    End Class
End NameSpace