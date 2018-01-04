Namespace NEW_VIEW
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class DebugControl
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
        Me.DebugPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.DebugPictureBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DebugPictureBox
        '
        Me.DebugPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DebugPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.DebugPictureBox.Name = "DebugPictureBox"
        Me.DebugPictureBox.Size = New System.Drawing.Size(766, 460)
        Me.DebugPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DebugPictureBox.TabIndex = 0
        Me.DebugPictureBox.TabStop = false
        '
        'DebugControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.DebugPictureBox)
        Me.Name = "DebugControl"
        Me.Size = New System.Drawing.Size(766, 460)
        CType(Me.DebugPictureBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents DebugPictureBox As PictureBox
    End Class
End NameSpace