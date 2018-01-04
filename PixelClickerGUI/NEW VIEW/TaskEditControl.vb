Imports System.Text
Imports Newtonsoft.Json
Imports PixelClickerGUI.Controller
Imports PixelClickerGUI.Model
Imports PixelClickerGUI.Types

Namespace NEW_VIEW
    Public Class TaskEditControl
        Private _task As Model.Task
        Private _newTask As Boolean 
        Public Sub SetTask(ByRef task As Model.Task, newTask As boolean)
            SearchListColors.Items.Clear()
            _task = task
            _newTask = newTask

            RadioButtonAim.Enabled = _newTask
            RadioButtonTrigger.Enabled = _newTask

           'Setup UI with the taskPProperty that was passed 
            txtSearchAreaWidth.Text = _task.SearchArea.Width
            txtSearchAreaHeight.Text = _task.SearchArea.Height
            txtTaskName.Text = _task.BotName
            txtXOffset.Text = _task.XOffset
            txtYOffset.Text = _task.YOffset
            txtHotkey.Text = _task.Hotkey.ToString()
            txtHotkey.Tag = _task.Hotkey
            txtMouseMoveSpeed.Text = _task.AimBotMoveSpeed
            txtAntiShake.Text = _task.AntiShake
            CheckBoxUsePremadeShades.Checked = _task.UsePremadeShades
            txtLineChecks.Text = _task.LineChecks
            txtHitChance.Text = _task.HitChance
            txtSkipPixel.Text = _task.SkipPixel
            txtMaxHealthbarHeight.Text = task.MaximumHealthBarHeight
            txtRedStrength.Text = task.RedStrength
            txtGreenStrength.Text = task.GreenStrength
            txtBlueStrength.Text = task.BlueStrength

            If _task.SearchMethod = SearchMethod.MiddleOfScreen Then
                RadioButtonMiddleOfScreen.Checked = True
            ElseIf _task.SearchMethod = SearchMethod.CursorPosition Then 
                RadioButtonCursorPosition.Checked = True
            End If

            If _task.Click = Types.Click.NoClick Then
                RadioButtonNoClick.Checked = True
            ElseIf _task.Click = Types.Click.HoldClick Then
                RadioButtonHoldClick.Checked = True
            ElseIf _task.Click = Types.Click.SingleClick Then
                RadioButtonSingleClick.Checked = True
            End If

            If _task.Bot = Bot.Middle Then
                RadioButtonAim.Checked = True
            ElseIf _task.Bot = Bot.Radar Then
                RadioButtonTrigger.Checked = True
            End If

            SearchListColors.ShowGroups = False
            SearchListColors.AddObjects(_task.SearchColors.ToList())
            'Setup UI with the taskPProperty that was passed 
        End Sub
        Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
            PixelClickerFormRedesign.MaterialDivider2.Controls.Clear()
            PixelClickerFormRedesign.MaterialDivider2.Controls.Add(PixelClickerFormRedesign.TaskListControl)
             Dim searchTypeRButton As RadioButton =
                    flowAimType.Controls.OfType (Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
            Dim mouseSettingsRButton As RadioButton =
                    flowClickType.Controls.OfType (Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)

            Dim searchMethodRButton As RadioButton =
                    flowSearchMethod.Controls.OfType (Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)

            _task.BotName = txtTaskName.Text
            _task.SearchArea = New Size(Integer.Parse(txtSearchAreaWidth.Text), Integer.Parse(txtSearchAreaHeight.Text))
            _task.Bot = Integer.Parse(searchTypeRButton.Tag)
            _task.Click = Integer.Parse(mouseSettingsRButton.Tag)
            _task.SearchMethod = Integer.Parse(searchMethodRButton.Tag)


            If _task.SearchMethod = 0 Then
                _task.SearchPos = New Point(My.Computer.Screen.Bounds.Width/2, My.Computer.Screen.Bounds.Height/2)
            End If

            _task.Hotkey = txtHotkey.Tag
            _task.UsePremadeShades = CheckBoxUsePremadeShades.Checked

            Dim skipPixel As Integer
            If Integer.TryParse(txtSkipPixel.Text, skipPixel) Then
                If skipPixel = -1 OrElse skipPixel Mod 4 = 0 Then
                    _task.SkipPixel = skipPixel
                Else
                    _task.SkipPixel = -1
                End If
            End If

            Dim antiShake As Double
            If Double.TryParse(txtAntiShake.Text, antiShake) Then
                _task.AntiShake = antiShake
            End If

            Dim xOffset As Integer
            If Integer.TryParse(txtXOffset.Text, xOffset) Then
                _task.XOffset = xOffset
            End If

            Dim yOffset As Integer
            If Integer.TryParse(txtYOffset.Text, yOffset) Then
                _task.YOffset = yOffset
            End If

            Dim mouseMoveSpeed As Integer
            If Integer.TryParse(txtMouseMoveSpeed.Text, mouseMoveSpeed) Then
                _task.AimBotMoveSpeed = mouseMoveSpeed
            End If

            Dim hitChance As Double
            If Double.TryParse(txtHitChance.Text, hitChance) Then
                _task.HitChance = hitChance
            End If

            Dim maxHealthbarHeight As Double
            If Integer.TryParse(txtMaxHealthbarHeight.Text, maxHealthbarHeight) Then
                _task.MaximumHealthBarHeight = maxHealthbarHeight
            End If

            Dim redStrength As Double
            If Integer.TryParse(txtRedStrength.Text, redStrength) Then
                _task.RedStrength = redStrength
            End If
            Dim greenStrengh As Double
            If Integer.TryParse(txtGreenStrength.Text, greenStrengh) Then
                 _task.GreenStrength = greenStrengh
            End If
            Dim blueStrength As Double
            If Integer.TryParse(txtBlueStrength.Text, blueStrength) Then
                 _task.BlueStrength = blueStrength
            End If
 
            Dim lineChecks As Integer
            If Integer.TryParse(txtLineChecks.Text, lineChecks) Then
                If lineChecks > 360 Then
                    _task.LineChecks = 360
                ElseIf lineChecks < 0 Then
                    _task.LineChecks = 60
                Else
                    _task.LineChecks = lineChecks
                End If
            End If

            If _newTask
                ProgramStateHandler.AddTask(_task)
                ProgramStateHandler.ProcessTask(_task)
                PixelClickerFormRedesign.TaskListControl.TaskListView.AddObject(_task)
            End If

            PixelClickerFormRedesign.CommunityControl.LoadProfiles()
            Profile.GetCurrentProfile.SaveProfile()
        End Sub
        Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
            PixelClickerFormRedesign.MaterialDivider2.Controls.Clear()
            PixelClickerFormRedesign.MaterialDivider2.Controls.Add(PixelClickerFormRedesign.TaskListControl)
        End Sub

        Private Sub GEyeDropper1_SelectedColorChanged(sender As Object, CurrColor As Color) Handles GEyeDropper1.SelectedColorChanged
            Dim colorProperty As New ColorModel()
            colorProperty.SearchColor = CurrColor.ToArgb
            _task.SearchColors.Add(colorProperty)
            SearchListColors.AddObject(colorProperty)
        End Sub

        Private Sub btn_Click(sender As Object, e As EventArgs) Handles ButtonDeleteSelected.Click
            For Each colorMod As ColorModel In SearchListColors.SelectedObjects
                _task.SearchColors.Remove(colorMod)
                SearchListColors.RemoveObject(colorMod)
            Next
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
        Private Sub txtHotkey_KeyPress(sender As Object, e As KeyEventArgs) Handles txtHotkey.KeyDown
            txtHotkey.Text = e.KeyCode.ToString()
            txtHotkey.Tag = e.KeyCode
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

            txtAntiShake.Visible = not RadioButtonTrigger.Checked
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
            _task.MoveMouse = RadioButtonAim.Checked
            RadioButtonNoClick.Checked = RadioButtonAim.Checked
            RadioButtonSingleClick.Visible = Not RadioButtonAim.Checked
            RadioButtonHoldClick.Visible = Not RadioButtonAim.Checked
            LabelLineChecks.Visible = Not RadioButtonAim.Checked
            txtLineChecks.Visible = Not RadioButtonAim.Checked
            LabelHitChance.Visible = Not RadioButtonAim.Checked
            txtHitChance.Visible = Not RadioButtonAim.Checked
        End Sub
        Private Sub SearchListColors_FormatCell(sender As Object, e As BrightIdeasSoftware.FormatRowEventArgs) _
            Handles SearchListColors.FormatRow
            Dim colorModel As ColorModel = DirectCast(e.Model, ColorModel)

            SearchListColors.Items(e.RowIndex).BackColor = Color.FromArgb(colorModel.SearchColor)
        End Sub

        Private Sub SearchListColors_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchListColors.KeyUp
           If e.Control AndAlso e.KeyCode = keys.C AndAlso SearchListColors.SelectedObjects.Count > 0 Then
                Dim stringBuilder As New StringBuilder
                stringBuilder.Append(JsonConvert.SerializeObject(SearchListColors.SelectedObjects, Formatting.Indented))
                Clipboard.SetText(stringBuilder.ToString())
            ElseIf e.Control AndAlso e.KeyCode = keys.V Then
                Try
                    Dim settings As New JsonSerializerSettings()
                    settings.MissingMemberHandling = MissingMemberHandling.Error
                    Dim taskArray = JsonConvert.DeserializeObject(Of List(Of ColorModel))(Clipboard.GetText(), settings)
                    
                    For Each col As ColorModel In taskArray
                        _task.SearchColors.Add(col)
                    Next

                    SearchListColors.AddObjects(taskArray.ToArray())
                    Profile.GetCurrentProfile.SaveProfile()
                Catch
                End Try
            End If
        End Sub
    End Class
End NameSpace