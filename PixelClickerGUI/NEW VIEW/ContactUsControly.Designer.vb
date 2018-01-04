Namespace NEW_VIEW
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ContactUsControl
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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = true
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(3, 12)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(67, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Website:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = true
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(3, 44)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(65, 19)
        Me.MaterialLabel2.TabIndex = 1
        Me.MaterialLabel2.Text = "Discord:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = true
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(76, 18)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(126, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = true
        Me.LinkLabel1.Text = "http://botoverwatch.com"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = true
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(74, 48)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(145, 13)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = true
        Me.LinkLabel2.Text = "https://discord.gg/UebUkHc"
        '
        'ContactUsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "ContactUsControl"
        Me.Size = New System.Drawing.Size(748, 478)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

        Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
        Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
        Friend WithEvents LinkLabel1 As LinkLabel
        Friend WithEvents LinkLabel2 As LinkLabel
    End Class
End NameSpace