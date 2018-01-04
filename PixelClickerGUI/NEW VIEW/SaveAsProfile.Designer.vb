Imports MaterialSkin.Controls

Namespace NEW_VIEW

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SaveAsProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaveAsProfile))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PanelTxtProfileName = New System.Windows.Forms.Panel()
        Me.PanelProfileName = New System.Windows.Forms.Panel()
        Me.MaterialDivider8 = New MaterialSkin.Controls.MaterialDivider()
        Me.LabelProfileName = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider17 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider18 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider19 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider20 = New MaterialSkin.Controls.MaterialDivider()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelTxtDescription = New System.Windows.Forms.Panel()
        Me.PanelProfileDescription = New System.Windows.Forms.Panel()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.LabelProfileDescription = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider3 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider4 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider5 = New MaterialSkin.Controls.MaterialDivider()
        Me.ButtonSaveProfile = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ButtonProfileCancel = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtDescription = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Panel6.SuspendLayout
        Me.PanelTxtProfileName.SuspendLayout
        Me.PanelProfileName.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.PanelTxtDescription.SuspendLayout
        Me.PanelProfileDescription.SuspendLayout
        Me.SuspendLayout
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.PanelTxtProfileName)
        Me.Panel6.Controls.Add(Me.PanelProfileName)
        Me.Panel6.Controls.Add(Me.MaterialDivider17)
        Me.Panel6.Controls.Add(Me.MaterialDivider18)
        Me.Panel6.Controls.Add(Me.MaterialDivider19)
        Me.Panel6.Controls.Add(Me.MaterialDivider20)
        Me.Panel6.Location = New System.Drawing.Point(1, 65)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(562, 75)
        Me.Panel6.TabIndex = 39
        '
        'PanelTxtProfileName
        '
        Me.PanelTxtProfileName.Controls.Add(Me.txtName)
        Me.PanelTxtProfileName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTxtProfileName.Location = New System.Drawing.Point(2, 39)
        Me.PanelTxtProfileName.Name = "PanelTxtProfileName"
        Me.PanelTxtProfileName.Size = New System.Drawing.Size(558, 34)
        Me.PanelTxtProfileName.TabIndex = 35
        '
        'PanelProfileName
        '
        Me.PanelProfileName.Controls.Add(Me.MaterialDivider8)
        Me.PanelProfileName.Controls.Add(Me.LabelProfileName)
        Me.PanelProfileName.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelProfileName.Location = New System.Drawing.Point(2, 2)
        Me.PanelProfileName.Name = "PanelProfileName"
        Me.PanelProfileName.Size = New System.Drawing.Size(558, 37)
        Me.PanelProfileName.TabIndex = 34
        '
        'MaterialDivider8
        '
        Me.MaterialDivider8.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider8.Depth = 0
        Me.MaterialDivider8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialDivider8.Location = New System.Drawing.Point(0, 35)
        Me.MaterialDivider8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider8.Name = "MaterialDivider8"
        Me.MaterialDivider8.Size = New System.Drawing.Size(558, 2)
        Me.MaterialDivider8.TabIndex = 32
        Me.MaterialDivider8.Text = "MaterialDivider8"
        '
        'LabelProfileName
        '
        Me.LabelProfileName.AutoSize = true
        Me.LabelProfileName.Depth = 0
        Me.LabelProfileName.Font = New System.Drawing.Font("Roboto", 11!)
        Me.LabelProfileName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.LabelProfileName.Location = New System.Drawing.Point(6, 9)
        Me.LabelProfileName.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelProfileName.Name = "LabelProfileName"
        Me.LabelProfileName.Size = New System.Drawing.Size(97, 19)
        Me.LabelProfileName.TabIndex = 28
        Me.LabelProfileName.Text = "Profile Name"
        '
        'MaterialDivider17
        '
        Me.MaterialDivider17.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider17.Depth = 0
        Me.MaterialDivider17.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaterialDivider17.Location = New System.Drawing.Point(560, 2)
        Me.MaterialDivider17.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider17.Name = "MaterialDivider17"
        Me.MaterialDivider17.Size = New System.Drawing.Size(2, 71)
        Me.MaterialDivider17.TabIndex = 33
        Me.MaterialDivider17.Text = "MaterialDivider17"
        '
        'MaterialDivider18
        '
        Me.MaterialDivider18.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider18.Depth = 0
        Me.MaterialDivider18.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialDivider18.Location = New System.Drawing.Point(2, 0)
        Me.MaterialDivider18.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider18.Name = "MaterialDivider18"
        Me.MaterialDivider18.Size = New System.Drawing.Size(560, 2)
        Me.MaterialDivider18.TabIndex = 32
        Me.MaterialDivider18.Text = "MaterialDivider18"
        '
        'MaterialDivider19
        '
        Me.MaterialDivider19.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider19.Depth = 0
        Me.MaterialDivider19.Dock = System.Windows.Forms.DockStyle.Left
        Me.MaterialDivider19.Location = New System.Drawing.Point(0, 0)
        Me.MaterialDivider19.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider19.Name = "MaterialDivider19"
        Me.MaterialDivider19.Size = New System.Drawing.Size(2, 73)
        Me.MaterialDivider19.TabIndex = 30
        Me.MaterialDivider19.Text = "MaterialDivider19"
        '
        'MaterialDivider20
        '
        Me.MaterialDivider20.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider20.Depth = 0
        Me.MaterialDivider20.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialDivider20.Location = New System.Drawing.Point(0, 73)
        Me.MaterialDivider20.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider20.Name = "MaterialDivider20"
        Me.MaterialDivider20.Size = New System.Drawing.Size(562, 2)
        Me.MaterialDivider20.TabIndex = 31
        Me.MaterialDivider20.Text = "MaterialDivider20"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelTxtDescription)
        Me.Panel1.Controls.Add(Me.PanelProfileDescription)
        Me.Panel1.Controls.Add(Me.MaterialDivider2)
        Me.Panel1.Controls.Add(Me.MaterialDivider3)
        Me.Panel1.Controls.Add(Me.MaterialDivider4)
        Me.Panel1.Controls.Add(Me.MaterialDivider5)
        Me.Panel1.Location = New System.Drawing.Point(1, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(562, 129)
        Me.Panel1.TabIndex = 40
        '
        'PanelTxtDescription
        '
        Me.PanelTxtDescription.Controls.Add(Me.txtDescription)
        Me.PanelTxtDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTxtDescription.Location = New System.Drawing.Point(2, 39)
        Me.PanelTxtDescription.Name = "PanelTxtDescription"
        Me.PanelTxtDescription.Size = New System.Drawing.Size(558, 88)
        Me.PanelTxtDescription.TabIndex = 35
        '
        'PanelProfileDescription
        '
        Me.PanelProfileDescription.Controls.Add(Me.MaterialDivider1)
        Me.PanelProfileDescription.Controls.Add(Me.LabelProfileDescription)
        Me.PanelProfileDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelProfileDescription.Location = New System.Drawing.Point(2, 2)
        Me.PanelProfileDescription.Name = "PanelProfileDescription"
        Me.PanelProfileDescription.Size = New System.Drawing.Size(558, 37)
        Me.PanelProfileDescription.TabIndex = 34
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 35)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(558, 2)
        Me.MaterialDivider1.TabIndex = 32
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'LabelProfileDescription
        '
        Me.LabelProfileDescription.AutoSize = true
        Me.LabelProfileDescription.Depth = 0
        Me.LabelProfileDescription.Font = New System.Drawing.Font("Roboto", 11!)
        Me.LabelProfileDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.LabelProfileDescription.Location = New System.Drawing.Point(6, 9)
        Me.LabelProfileDescription.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelProfileDescription.Name = "LabelProfileDescription"
        Me.LabelProfileDescription.Size = New System.Drawing.Size(86, 19)
        Me.LabelProfileDescription.TabIndex = 28
        Me.LabelProfileDescription.Text = "Description"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaterialDivider2.Location = New System.Drawing.Point(560, 2)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(2, 125)
        Me.MaterialDivider2.TabIndex = 33
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialDivider3.Location = New System.Drawing.Point(2, 0)
        Me.MaterialDivider3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(560, 2)
        Me.MaterialDivider3.TabIndex = 32
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'MaterialDivider4
        '
        Me.MaterialDivider4.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider4.Depth = 0
        Me.MaterialDivider4.Dock = System.Windows.Forms.DockStyle.Left
        Me.MaterialDivider4.Location = New System.Drawing.Point(0, 0)
        Me.MaterialDivider4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider4.Name = "MaterialDivider4"
        Me.MaterialDivider4.Size = New System.Drawing.Size(2, 127)
        Me.MaterialDivider4.TabIndex = 30
        Me.MaterialDivider4.Text = "MaterialDivider4"
        '
        'MaterialDivider5
        '
        Me.MaterialDivider5.BackColor = System.Drawing.Color.FromArgb(CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer), CType(CType(76,Byte),Integer))
        Me.MaterialDivider5.Depth = 0
        Me.MaterialDivider5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialDivider5.Location = New System.Drawing.Point(0, 127)
        Me.MaterialDivider5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider5.Name = "MaterialDivider5"
        Me.MaterialDivider5.Size = New System.Drawing.Size(562, 2)
        Me.MaterialDivider5.TabIndex = 31
        Me.MaterialDivider5.Text = "MaterialDivider5"
        '
        'ButtonSaveProfile
        '
        Me.ButtonSaveProfile.AutoSize = true
        Me.ButtonSaveProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonSaveProfile.Depth = 0
        Me.ButtonSaveProfile.Icon = Nothing
        Me.ButtonSaveProfile.Location = New System.Drawing.Point(425, 284)
        Me.ButtonSaveProfile.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ButtonSaveProfile.MouseState = MaterialSkin.MouseState.HOVER
        Me.ButtonSaveProfile.Name = "ButtonSaveProfile"
        Me.ButtonSaveProfile.Primary = false
        Me.ButtonSaveProfile.Size = New System.Drawing.Size(55, 36)
        Me.ButtonSaveProfile.TabIndex = 42
        Me.ButtonSaveProfile.Text = "Save"
        Me.ButtonSaveProfile.UseVisualStyleBackColor = true
        '
        'ButtonProfileCancel
        '
        Me.ButtonProfileCancel.AutoSize = true
        Me.ButtonProfileCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonProfileCancel.Depth = 0
        Me.ButtonProfileCancel.Icon = Nothing
        Me.ButtonProfileCancel.Location = New System.Drawing.Point(488, 284)
        Me.ButtonProfileCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ButtonProfileCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.ButtonProfileCancel.Name = "ButtonProfileCancel"
        Me.ButtonProfileCancel.Primary = false
        Me.ButtonProfileCancel.Size = New System.Drawing.Size(73, 36)
        Me.ButtonProfileCancel.TabIndex = 43
        Me.ButtonProfileCancel.Text = "Cancel"
        Me.ButtonProfileCancel.UseVisualStyleBackColor = true
        '
        'txtName
        '
        Me.txtName.Depth = 0
        Me.txtName.Hint = ""
        Me.txtName.Location = New System.Drawing.Point(3, 6)
        Me.txtName.MaxLength = 32767
        Me.txtName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.Size = New System.Drawing.Size(554, 23)
        Me.txtName.TabIndex = 42
        Me.txtName.TabStop = false
        Me.txtName.UseSystemPasswordChar = false
        '
        'txtDescription
        '
        Me.txtDescription.Depth = 0
        Me.txtDescription.Hint = ""
        Me.txtDescription.Location = New System.Drawing.Point(2, 6)
        Me.txtDescription.MaxLength = 32767
        Me.txtDescription.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.SelectionLength = 0
        Me.txtDescription.SelectionStart = 0
        Me.txtDescription.Size = New System.Drawing.Size(554, 23)
        Me.txtDescription.TabIndex = 43
        Me.txtDescription.TabStop = false
        Me.txtDescription.UseSystemPasswordChar = false
        '
        'SaveAsProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 329)
        Me.ControlBox = false
        Me.Controls.Add(Me.ButtonProfileCancel)
        Me.Controls.Add(Me.ButtonSaveProfile)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(568, 563)
        Me.MinimumSize = New System.Drawing.Size(568, 329)
        Me.Name = "SaveAsProfile"
        Me.ShowIcon = false
        Me.Text = "Save Profile"
        Me.TopMost = true
        Me.Panel6.ResumeLayout(false)
        Me.PanelTxtProfileName.ResumeLayout(false)
        Me.PanelProfileName.ResumeLayout(false)
        Me.PanelProfileName.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.PanelTxtDescription.ResumeLayout(false)
        Me.PanelProfileDescription.ResumeLayout(false)
        Me.PanelProfileDescription.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

        Friend WithEvents Panel6 As Panel
        Friend WithEvents PanelTxtProfileName As Panel
        Friend WithEvents PanelProfileName As Panel
        Friend WithEvents MaterialDivider8 As MaterialDivider
        Friend WithEvents LabelProfileName As MaterialLabel
        Friend WithEvents MaterialDivider17 As MaterialDivider
        Friend WithEvents MaterialDivider18 As MaterialDivider
        Friend WithEvents MaterialDivider19 As MaterialDivider
        Friend WithEvents MaterialDivider20 As MaterialDivider
        Friend WithEvents Panel1 As Panel
        Friend WithEvents PanelTxtDescription As Panel
        Friend WithEvents PanelProfileDescription As Panel
        Friend WithEvents MaterialDivider1 As MaterialDivider
        Friend WithEvents LabelProfileDescription As MaterialLabel
        Friend WithEvents MaterialDivider2 As MaterialDivider
        Friend WithEvents MaterialDivider3 As MaterialDivider
        Friend WithEvents MaterialDivider4 As MaterialDivider
        Friend WithEvents MaterialDivider5 As MaterialDivider
        Friend WithEvents ButtonSaveProfile As MaterialFlatButton
        Friend WithEvents ButtonProfileCancel As MaterialFlatButton
        Friend WithEvents txtName As MaterialSingleLineTextField
        Friend WithEvents txtDescription As MaterialSingleLineTextField
    End Class
End NameSpace