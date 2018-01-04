Imports PixelClickerGUI.Model
Imports PixelClickerGUI.Types

Namespace View
    Public Class TaskWizardForm
        Public Task As Model.Task
        Private _translation As Translation = Translation.Instance()


        Public Sub New(ByRef task As Model.Task, Optional newTask As Types.Task = Types.Task.EditTask)
            ' This call is required by the designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.

            If newTask = Types.Task.NewTask Then
                'Icon = My.Resources.AddTaskICON
            Else
                rbFirst.Enabled = False
                RadioButtonAim.Enabled = false
                RadioButtonTrigger.Enabled = false
            End If

            Me.Task = task
        End Sub

        Private Sub TaskWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.Text = _translation.FormTaskWizard
            GroupBoxBotType.Text = _translation.GroupBoxBotType
            GroupBoxColors.Text = _translation.GroupBoxColors
            GroupBoxSearchSettings.Text = _translation.GroupBoxSearchSettings
            CheckBoxDrawOnGame.Text = _translation.CheckBoxDrawOnGame
            CheckBoxDebugMode.Text = _translation.CheckBoxDebugMode
            CheckBoxUsePremadeShades.Text = _translation.CheckBoxUsePremadeShades
            LabelAimBotMoveSpeed.Text = _translation.LabelAimBotMoveSpeed
            LabelAimXOffset.Text = _translation.LabelAimXOffset
            LabelAimYOffset.Text = _translation.LabelAimYOffset
            LabelAntiShake.Text = _translation.LabelAntiShake
            LabelDragMe.Text = _translation.LabelDragMe
            LabelHitChance.Text = _translation.LabelHitChance
            LabelHotkey.Text = _translation.LabelHotkey
            LabelLineChecks.Text = _translation.LabelLineChecks
            LabelSearchAreaWidth.Text = _translation.LabelSearchAreaWidth
            LabelSearchAreaHeight.Text = _translation.LabelSearchAreaHeight
            RadioButtonTrigger.Text = _translation.RadioButtonTrigger
            RadioButtonAim.Text = _translation.RadioButtonAim
            RadioButtonHoldClick.Text = _translation.RadioButtonHoldClick
            RadioButtonNoClick.Text = _translation.RadioButtonNoClick
            RadioButtonSingleClick.Text = _translation.RadioButtonSingleClick
            ColumnColor.Text = _translation.ColumnColor
            ColumnShadeVariation.Text = _translation.ColumnShadeVariation
            ButtonCancel.Text = _translation.ButtonCancel
            ButtonDeleteSelected.Text = _translation.ButtonDeleteSelected
            ButtonOk.Text = _translation.ButtonOk

            'Setup UI with the taskPProperty that was passed 
            txtSearchAreaWidth.Text = Task.SearchArea.Width
            txtSearchAreaHeight.Text = Task.SearchArea.Height
            txtTaskName.Text = Task.BotName
            txtXOffset.Text = Task.XOffset
            txtYOffset.Text = Task.YOffset
            txtHotkey.Text = Task.Hotkey.ToString()
            txtHotkey.Tag = Task.Hotkey
            ckAutoMouseMove.Checked = Task.MoveMouse
            txtMouseMoveSpeed.Text = Task.AimBotMoveSpeed
            AntiShake.Value = Task.AntiShake
            CheckBoxDebugMode.Checked = Task.Debug
            'CheckBoxDrawOnGame.Checked = Task.DrawOnGame
            CheckBoxUsePremadeShades.Checked = Task.UsePremadeShades
            txtLineChecks.Text = task.LineChecks
            txtHitChance.Text = Task.HitChance

            If Task.Click = Types.Click.NoClick Then
                RadioButtonNoClick.Checked = True
            ElseIf Task.Click = Types.Click.HoldClick Then
                RadioButtonHoldClick.Checked = True
            ElseIf Task.Click = Types.Click.SingleClick Then
                RadioButtonSingleClick.Checked = True
            End If

            If Task.Bot = Bot.First Then
                rbFirst.Checked = True
            ElseIf Task.Bot = Bot.Middle Then
                RadioButtonAim.Checked = True
            ElseIf Task.Bot = Bot.Radar Then
                RadioButtonTrigger.Checked = True
            End If
            SearchListColors.ShowGroups = False
            SearchListColors.AddObjects(Task.SearchColors.ToList())
            'Setup UI with the taskPProperty that was passed 
        End Sub

        Private Sub GEyeDropper1_SelectedColorChanged(sender As Object, currColor As Color) _
            Handles GEyeDropper1.SelectedColorChanged
            Dim colorProperty As New ColorModel()
            colorProperty.SearchColor = CurrColor.ToArgb
            Task.SearchColors.Add(colorProperty)
            SearchListColors.AddObject(colorProperty)
        End Sub

        Private Sub objectListView1_FormatCell(sender As Object, e As BrightIdeasSoftware.FormatRowEventArgs) _
            Handles SearchListColors.FormatRow
            Dim colorModel As ColorModel = DirectCast(e.Model, ColorModel)

            SearchListColors.Items(e.RowIndex).BackColor = Color.FromArgb(colorModel.SearchColor)
        End Sub

        Private Sub btn_Click(sender As Object, e As EventArgs) Handles ButtonDeleteSelected.Click
            For Each colorMod As ColorModel In SearchListColors.SelectedObjects
                Task.SearchColors.Remove(colorMod)
                SearchListColors.RemoveObject(colorMod)
            Next
        End Sub

        Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
            Dim searchTypeRButton As RadioButton =
                    flowSearchType.Controls.OfType (Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
            Dim mouseSettingsRButton As RadioButton =
                    flowMouseSettings.Controls.OfType (Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
            Task.BotName = txtTaskName.Text
            Task.SearchArea = New Size(Integer.Parse(txtSearchAreaWidth.Text), Integer.Parse(txtSearchAreaHeight.Text))
            Task.Bot = Integer.Parse(searchTypeRButton.Tag)
            Task.Click = Integer.Parse(mouseSettingsRButton.Tag)
            Task.MoveMouse = ckAutoMouseMove.Checked
            Task.Hotkey = txtHotkey.Tag


            Task.AntiShake = AntiShake.Value

            Dim xOffset As Integer
            If Integer.TryParse(txtXOffset.Text, xOffset) Then
                Task.XOffset = xOffset
            End If

            Dim yOffset As Integer
            If Integer.TryParse(txtYOffset.Text, yOffset) Then
                Task.YOffset = yOffset
            End If

            Dim mouseMoveSpeed As Integer
            If Integer.TryParse(txtMouseMoveSpeed.Text, mouseMoveSpeed) Then
                Task.AimBotMoveSpeed = mouseMoveSpeed
            End If

            Dim hitChance As Double
            If Double.TryParse(txtHitChance.Text, hitChance) Then
                Task.HitChance = hitChance
            End If

            Dim lineChecks As Integer
            If Integer.TryParse(txtLineChecks.Text, lineChecks) Then
                If lineChecks > 360 Then
                    Task.LineChecks = 360
                ElseIf lineChecks < 0 Then
                    Task.LineChecks = 60
                Else
                    Task.LineChecks = lineChecks
                End If
            End If

            DialogResult = DialogResult.OK
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
            DialogResult = DialogResult.Cancel
        End Sub

        Private Sub ckDrawOnGame_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDrawOnGame.CheckedChanged
            'Task.DrawOnGame = CheckBoxDrawOnGame.Checked
        End Sub

        Private Sub ckDebug_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDebugMode.CheckedChanged
            Task.Debug = CheckBoxDebugMode.Checked
        End Sub

        Private Sub txtHotkey_KeyPress(sender As Object, e As KeyEventArgs) Handles txtHotkey.KeyDown
            txtHotkey.Text = e.KeyCode.ToString()
            txtHotkey.Tag = e.KeyCode
        End Sub

        Private Sub txtHotkey_MouseClick(sender As Object, e As MouseEventArgs) Handles txtHotkey.MouseDown
            Select Case e.Button
                Case MouseButtons.Left
                    If txtHotkey.Text = "None" Then
                        txtHotkey.Text = Keys.LButton.ToString()
                        txtHotkey.Tag = Keys.LButton
                    Else
                        txtHotkey.Text = "None"
                        txtHotkey.Tag = 0
                    End If
                Case MouseButtons.Right
                    txtHotkey.Text = Keys.RButton.ToString()
                    txtHotkey.Tag = Keys.RButton
                Case MouseButtons.Middle
                    txtHotkey.Text = Keys.MButton.ToString()
                    txtHotkey.Tag = Keys.MButton
                Case MouseButtons.XButton1
                    txtHotkey.Text = Keys.XButton1.ToString()
                    txtHotkey.Tag = Keys.XButton1
                Case MouseButtons.XButton2
                    txtHotkey.Text = Keys.XButton2.ToString()
                    txtHotkey.Tag = Keys.XButton2
            End Select
        End Sub

        Private Sub ckAutoMouseMove_CheckedChanged(sender As Object, e As EventArgs) _
            Handles ckAutoMouseMove.CheckedChanged
            txtMouseMoveSpeed.Visible = ckAutoMouseMove.Checked
        End Sub

        Private Sub rbRadar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTrigger.CheckedChanged
            If Not (RadioButtonSingleClick.Checked Or RadioButtonHoldClick.Checked) Then RadioButtonSingleClick.Checked = True
            RadioButtonSingleClick.Enabled = RadioButtonTrigger.Checked
            RadioButtonHoldClick.Enabled = RadioButtonTrigger.Checked

            LabelLineChecks.Visible = RadioButtonTrigger.Checked
            txtLineChecks.Visible = RadioButtonTrigger.Checked

            LabelHitChance.Visible = RadioButtonTrigger.Checked
            txtHitChance.Visible = RadioButtonTrigger.Checked

            txtYOffset.Visible = not RadioButtonTrigger.Checked
            LabelAimYOffset.Visible = not RadioButtonTrigger.Checked

            AntiShake.Visible = not RadioButtonTrigger.Checked
            LabelAntiShake.Visible = not RadioButtonTrigger.Checked

            LabelAimBotMoveSpeed.Visible = not RadioButtonTrigger.Checked
            txtMouseMoveSpeed.Visible = not RadioButtonTrigger.Checked

            txtXOffset.Visible = not RadioButtonTrigger.Checked
            LabelAimXOffset.Visible = not RadioButtonTrigger.Checked

            txtYOffset.Visible = not RadioButtonTrigger.Checked
            LabelAimYOffset.Visible = not RadioButtonTrigger.Checked

            RadioButtonNoClick.Checked = Not RadioButtonTrigger.Checked
            RadioButtonNoClick.Visible = Not RadioButtonTrigger.Checked
        End Sub

        Private Sub rbMiddle_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAim.CheckedChanged
            ckAutoMouseMove.Checked = RadioButtonAim.Checked
            RadioButtonNoClick.Checked = RadioButtonAim.Checked
            RadioButtonSingleClick.Visible = Not RadioButtonAim.Checked
            RadioButtonHoldClick.Visible = Not RadioButtonAim.Checked
            LabelLineChecks.Visible = Not RadioButtonAim.Checked
            txtLineChecks.Visible = Not RadioButtonAim.Checked
            LabelHitChance.Visible = Not RadioButtonAim.Checked
            txtHitChance.Visible = Not RadioButtonAim.Checked
        End Sub
        Private Sub txtXOffset_TextChanged(sender As Object, e As EventArgs) Handles txtXOffset.TextChanged
            Dim xOffset As Integer
            If Not Integer.TryParse(txtXOffset.Text, xOffset) Then
                txtXOffset.Text = Task.XOffset
            End If
        End Sub

        Private Sub txtYOffset_TextChanged(sender As Object, e As EventArgs) Handles txtYOffset.TextChanged
            Dim yOffset As Integer
            If Not Integer.TryParse(txtYOffset.Text, yOffset) Then
                txtYOffset.Text = Task.YOffset
            End If
        End Sub

        Private Sub txtMouseMoveSpeed_TextChanged(sender As Object, e As EventArgs) _
            Handles txtMouseMoveSpeed.TextChanged
            Dim mouseMoveSpeed As Integer
            If Not Integer.TryParse(txtMouseMoveSpeed.Text, mouseMoveSpeed) Then
                txtMouseMoveSpeed.Text = Task.AimBotMoveSpeed
            End If
        End Sub

        Private Sub ckUsePremadeShades_CheckedChanged(sender As Object, e As EventArgs) _
            Handles CheckBoxUsePremadeShades.CheckedChanged
            Task.UsePremadeShades = CheckBoxUsePremadeShades.Checked
        End Sub

        Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles AntiShake.ValueChanged

        End Sub
    End Class
End NameSpace