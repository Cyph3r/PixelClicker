Namespace NEW_VIEW
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class EventControl
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
        Dim HeaderStateStyle4 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle()
        Dim HeaderStateStyle5 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle()
        Dim HeaderStateStyle6 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPageGeneral = New System.Windows.Forms.TabPage()
        Me.GeneralListView = New BrightIdeasSoftware.ObjectListView()
        Me.TabPageError = New System.Windows.Forms.TabPage()
        Me.ErrorLogListView = New BrightIdeasSoftware.ObjectListView()
        Me.HeaderFormatStyle1 = New BrightIdeasSoftware.HeaderFormatStyle()
        Me.ColumnTimeStamp = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ColumnMessage = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.ColumnEventType = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.MaterialTabControl1.SuspendLayout
        Me.TabPageGeneral.SuspendLayout
        CType(Me.GeneralListView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPageError.SuspendLayout
        CType(Me.ErrorLogListView,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.MaterialTabControl1.Controls.Add(Me.TabPageGeneral)
        Me.MaterialTabControl1.Controls.Add(Me.TabPageError)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 29)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(748, 449)
        Me.MaterialTabControl1.TabIndex = 0
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageGeneral.Controls.Add(Me.GeneralListView)
        Me.TabPageGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGeneral.Size = New System.Drawing.Size(740, 423)
        Me.TabPageGeneral.TabIndex = 1
        Me.TabPageGeneral.Text = "General"
        '
        'GeneralListView
        '
        Me.GeneralListView.AllColumns.Add(Me.ColumnTimeStamp)
        Me.GeneralListView.AllColumns.Add(Me.ColumnEventType)
        Me.GeneralListView.AllColumns.Add(Me.ColumnMessage)
        Me.GeneralListView.CellEditUseWholeCell = false
        Me.GeneralListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnTimeStamp, Me.ColumnEventType, Me.ColumnMessage})
        Me.GeneralListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.GeneralListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GeneralListView.Location = New System.Drawing.Point(3, 3)
        Me.GeneralListView.Name = "GeneralListView"
        Me.GeneralListView.Size = New System.Drawing.Size(734, 417)
        Me.GeneralListView.TabIndex = 0
        Me.GeneralListView.UseCompatibleStateImageBehavior = false
        Me.GeneralListView.View = System.Windows.Forms.View.Details
        '
        'TabPageError
        '
        Me.TabPageError.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageError.Controls.Add(Me.ErrorLogListView)
        Me.TabPageError.Location = New System.Drawing.Point(4, 22)
        Me.TabPageError.Name = "TabPageError"
        Me.TabPageError.Size = New System.Drawing.Size(740, 423)
        Me.TabPageError.TabIndex = 2
        Me.TabPageError.Text = "Error"
        '
        'ErrorLogListView
        '
        Me.ErrorLogListView.CellEditUseWholeCell = false
        Me.ErrorLogListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.ErrorLogListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorLogListView.Location = New System.Drawing.Point(0, 0)
        Me.ErrorLogListView.Name = "ErrorLogListView"
        Me.ErrorLogListView.Size = New System.Drawing.Size(740, 423)
        Me.ErrorLogListView.TabIndex = 1
        Me.ErrorLogListView.UseCompatibleStateImageBehavior = false
        Me.ErrorLogListView.View = System.Windows.Forms.View.Details
        '
        'HeaderFormatStyle1
        '
        Me.HeaderFormatStyle1.Hot = HeaderStateStyle4
        Me.HeaderFormatStyle1.Normal = HeaderStateStyle5
        Me.HeaderFormatStyle1.Pressed = HeaderStateStyle6
        '
        'ColumnTimeStamp
        '
        Me.ColumnTimeStamp.AspectName = "TimeStamp"
        Me.ColumnTimeStamp.Text = "Time Stamp"
        Me.ColumnTimeStamp.Width = 106
        '
        'ColumnMessage
        '
        Me.ColumnMessage.AspectName = "Message"
        Me.ColumnMessage.Text = "Message"
        '
        'ColumnEventType
        '
        Me.ColumnEventType.AspectName = "EventType"
        Me.ColumnEventType.Text = "Event Type"
        Me.ColumnEventType.Width = 144
        '
        'EventControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Name = "EventControl"
        Me.Size = New System.Drawing.Size(748, 478)
        Me.MaterialTabControl1.ResumeLayout(false)
        Me.TabPageGeneral.ResumeLayout(false)
        CType(Me.GeneralListView,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPageError.ResumeLayout(false)
        CType(Me.ErrorLogListView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
        Friend WithEvents TabPageGeneral As TabPage
        Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
        Friend WithEvents TabPageError As TabPage
        Friend WithEvents HeaderFormatStyle1 As BrightIdeasSoftware.HeaderFormatStyle
        Friend WithEvents GeneralListView As BrightIdeasSoftware.ObjectListView
        Friend WithEvents ErrorLogListView As BrightIdeasSoftware.ObjectListView
        Friend WithEvents ColumnTimeStamp As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ColumnMessage As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ColumnEventType As BrightIdeasSoftware.OLVColumn
    End Class
End NameSpace