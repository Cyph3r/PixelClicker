Imports MaterialSkin.Controls

Namespace NEW_VIEW

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Poller
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Poller))
        Me.ButtonVote = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtSuggestedPrice = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.labelSuggestedPrice = New MaterialSkin.Controls.MaterialLabel()
        Me.checkBoxWillPay = New MaterialSkin.Controls.MaterialCheckBox()
        Me.txtEmail = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout
        '
        'ButtonVote
        '
        Me.ButtonVote.AutoSize = true
        Me.ButtonVote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonVote.Depth = 0
        Me.ButtonVote.Icon = Nothing
        Me.ButtonVote.Location = New System.Drawing.Point(242, 180)
        Me.ButtonVote.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ButtonVote.MouseState = MaterialSkin.MouseState.HOVER
        Me.ButtonVote.Name = "ButtonVote"
        Me.ButtonVote.Primary = false
        Me.ButtonVote.Size = New System.Drawing.Size(55, 36)
        Me.ButtonVote.TabIndex = 42
        Me.ButtonVote.Text = "Vote"
        Me.ButtonVote.UseVisualStyleBackColor = true
        '
        'txtSuggestedPrice
        '
        Me.txtSuggestedPrice.Depth = 0
        Me.txtSuggestedPrice.Hint = ""
        Me.txtSuggestedPrice.Location = New System.Drawing.Point(196, 131)
        Me.txtSuggestedPrice.MaxLength = 32767
        Me.txtSuggestedPrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtSuggestedPrice.Name = "txtSuggestedPrice"
        Me.txtSuggestedPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSuggestedPrice.SelectedText = ""
        Me.txtSuggestedPrice.SelectionLength = 0
        Me.txtSuggestedPrice.SelectionStart = 0
        Me.txtSuggestedPrice.Size = New System.Drawing.Size(104, 23)
        Me.txtSuggestedPrice.TabIndex = 43
        Me.txtSuggestedPrice.TabStop = false
        Me.txtSuggestedPrice.UseSystemPasswordChar = false
        '
        'labelSuggestedPrice
        '
        Me.labelSuggestedPrice.AutoSize = true
        Me.labelSuggestedPrice.Depth = 0
        Me.labelSuggestedPrice.Font = New System.Drawing.Font("Roboto", 11!)
        Me.labelSuggestedPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.labelSuggestedPrice.Location = New System.Drawing.Point(11, 135)
        Me.labelSuggestedPrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.labelSuggestedPrice.Name = "labelSuggestedPrice"
        Me.labelSuggestedPrice.Size = New System.Drawing.Size(179, 19)
        Me.labelSuggestedPrice.TabIndex = 44
        Me.labelSuggestedPrice.Text = "Monthly Suggested Price:"
        '
        'checkBoxWillPay
        '
        Me.checkBoxWillPay.AutoSize = true
        Me.checkBoxWillPay.Depth = 0
        Me.checkBoxWillPay.Font = New System.Drawing.Font("Roboto", 10!)
        Me.checkBoxWillPay.Location = New System.Drawing.Point(9, 98)
        Me.checkBoxWillPay.Margin = New System.Windows.Forms.Padding(0)
        Me.checkBoxWillPay.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.checkBoxWillPay.MouseState = MaterialSkin.MouseState.HOVER
        Me.checkBoxWillPay.Name = "checkBoxWillPay"
        Me.checkBoxWillPay.Ripple = true
        Me.checkBoxWillPay.Size = New System.Drawing.Size(227, 30)
        Me.checkBoxWillPay.TabIndex = 45
        Me.checkBoxWillPay.Text = "Would you pay for Pixel Clicker?"
        Me.checkBoxWillPay.UseVisualStyleBackColor = true
        '
        'txtEmail
        '
        Me.txtEmail.Depth = 0
        Me.txtEmail.Hint = ""
        Me.txtEmail.Location = New System.Drawing.Point(68, 72)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.Size = New System.Drawing.Size(231, 23)
        Me.txtEmail.TabIndex = 46
        Me.txtEmail.TabStop = false
        Me.txtEmail.UseSystemPasswordChar = false
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = true
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(11, 76)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(51, 19)
        Me.MaterialLabel1.TabIndex = 47
        Me.MaterialLabel1.Text = "Email:"
        '
        'Poller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51,Byte),Integer), CType(CType(51,Byte),Integer), CType(CType(51,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(310, 225)
        Me.ControlBox = false
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.txtSuggestedPrice)
        Me.Controls.Add(Me.checkBoxWillPay)
        Me.Controls.Add(Me.labelSuggestedPrice)
        Me.Controls.Add(Me.ButtonVote)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Poller"
        Me.ShowIcon = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "YOU MUST VOTE TO CONTINUE!!!"
        Me.TopMost = true
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
        Friend WithEvents ButtonVote As MaterialFlatButton
        Friend WithEvents txtSuggestedPrice As MaterialSingleLineTextField
        Friend WithEvents labelSuggestedPrice As MaterialLabel
        Friend WithEvents checkBoxWillPay As MaterialCheckBox
        Friend WithEvents txtEmail As MaterialSingleLineTextField
        Friend WithEvents MaterialLabel1 As MaterialLabel
    End Class
End NameSpace