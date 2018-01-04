Imports System.Runtime.InteropServices
Imports MaterialSkin
Imports PixelClickerGUI.Model

Namespace NEW_VIEW
    Public Class SettingsControl

        Private _colorSchemeIndex As Integer
        Private ReadOnly _globalSettings As GlobalSettings =  GlobalSettings.Settings

        Private Sub materialButton1_Click_1(sender As Object, e As EventArgs) Handles materialButton1.Click
            SwitchTheme(If(PixelClickerFormRedesign.MaterialSkinManager.Theme = MaterialSkinManager.Themes.DARK, MaterialSkinManager.Themes.LIGHT, MaterialSkinManager.Themes.DARK))
        End Sub

        Friend Shared Sub SwitchTheme(theme As MaterialSkinManager.Themes)
            PixelClickerFormRedesign.MaterialSkinManager.Theme = theme
           If(theme = MaterialSkinManager.Themes.DARK) Then
                PixelClickerFormRedesign.TaskListControl.TaskListView.BackColor = Color.FromArgb(51,51,51)
                PixelClickerFormRedesign.TaskListControl.TaskPanel.BackColor = Color.FromArgb(51,51,51)
                
                PixelClickerFormRedesign.DebugControl.BackColor = Color.FromArgb(51,51,51)

               ' PixelClickerFormRedesign.CommunityControl.BackColor = Color.FromArgb(51,51,51)
                PixelClickerFormRedesign.CommunityControl.TabPageProfile.BackColor = Color.FromArgb(51,51,51)
                PixelClickerFormRedesign.CommunityControl.ProfilePanel.BackColor = Color.FromArgb(51,51,51) 

                PixelClickerFormRedesign.EventControl.TabPageError.BackColor = Color.FromArgb(51,51,51)
                PixelClickerFormRedesign.EventControl.TabPageGeneral.BackColor = Color.FromArgb(51,51,51)

                PixelClickerFormRedesign.TaskEditControl.TabPageBot.BackColor = Color.FromArgb(51,51,51)
                PixelClickerFormRedesign.TaskEditControl.TabPageSearch.BackColor = Color.FromArgb(51,51,51)
                PixelClickerFormRedesign.TaskEditControl.TabPageColors.BackColor = Color.FromArgb(51,51,51)
                PixelClickerFormRedesign.TaskEditControl.PanelSaveCancel.BackColor = Color.FromArgb(51,51,51)
                PixelClickerFormRedesign.TaskEditControl.SearchListColors.BackColor = Color.FromArgb(51,51,51)

                PixelClickerFormRedesign.SettingsControl.TabPageGlobal.BackColor = Color.FromArgb(51,51,51)
                PixelClickerFormRedesign.SettingsControl.TabPageKeyboard.BackColor = Color.FromArgb(51,51,51)
                PixelClickerFormRedesign.SettingsControl.TabPageColorScheme.BackColor = Color.FromArgb(51,51,51)  
                PixelClickerFormRedesign.ContactUsControl.BackColor =  Color.FromArgb(51,51,51) 

                SaveAsProfile.PanelTxtDescription.BackColor = Color.FromArgb(51,51,51) 
                SaveAsProfile.PanelTxtProfileName.BackColor = Color.FromArgb(51,51,51) 
                SaveAsProfile.BackColor = Color.FromArgb(51,51,51) 


                PixelClickerFormRedesign.CommunityControl.ProfileList.BackColor = Color.FromArgb(51,51,51) 
            Else 
                PixelClickerFormRedesign.TaskListControl.TaskListView.BackColor = Color.White
                PixelClickerFormRedesign.TaskListControl.TaskPanel.BackColor = Color.White

                PixelClickerFormRedesign.DebugControl.BackColor = Color.White

                PixelClickerFormRedesign.CommunityControl.BackColor = Color.White
                PixelClickerFormRedesign.CommunityControl.TabPageProfile.BackColor = Color.White

                PixelClickerFormRedesign.EventControl.TabPageError.BackColor = Color.White
                PixelClickerFormRedesign.EventControl.TabPageGeneral.BackColor = Color.White
                
                PixelClickerFormRedesign.TaskEditControl.TabPageBot.BackColor = Color.White
                PixelClickerFormRedesign.TaskEditControl.TabPageSearch.BackColor = Color.White
                PixelClickerFormRedesign.TaskEditControl.TabPageColors.BackColor = Color.White
                PixelClickerFormRedesign.TaskEditControl.PanelSaveCancel.BackColor = Color.White
                PixelClickerFormRedesign.TaskEditControl.SearchListColors.BackColor = Color.White

                PixelClickerFormRedesign.SettingsControl.TabPageGlobal.BackColor = Color.White
                PixelClickerFormRedesign.SettingsControl.TabPageKeyboard.BackColor = Color.White
                PixelClickerFormRedesign.SettingsControl.TabPageColorScheme.BackColor = Color.White    
                PixelClickerFormRedesign.ContactUsControl.BackColor =  Color.White  
                SaveAsProfile.PanelTxtDescription.BackColor = Color.White  
                SaveAsProfile.PanelTxtProfileName.BackColor = Color.White  

                SaveAsProfile.BackColor = Color.White  
                PixelClickerFormRedesign.CommunityControl.ProfileList.BackColor = Color.White  
            End If
        End Sub

        Private Sub materialRaisedButton1_Click(sender As Object, e As EventArgs) Handles materialRaisedButton1.Click
            
            _colorSchemeIndex += 1
            If _colorSchemeIndex > 2 Then
	            _colorSchemeIndex = 0
            End If

            'These are just example color schemes
            Select Case _colorSchemeIndex
	            Case 0
		            PixelClickerFormRedesign.MaterialSkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
                    PixelClickerFormRedesign.PanelMainSelector.BackColor = Color.FromArgb(64,196,255)

                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotClickType.BackColor = Color.FromArgb(38,50,56)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotClickTypeDescription.BackColor = Color.FromArgb(38,50,56)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotType.BackColor = Color.FromArgb(38,50,56)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotTypeDescription.BackColor = Color.FromArgb(38,50,56)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotSettings.BackColor = Color.FromArgb(38,50,56)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotSettingsDescription.BackColor = Color.FromArgb(38,50,56)

                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchMethod.BackColor = Color.FromArgb(38,50,56)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchMethodDescription.BackColor = Color.FromArgb(38,50,56)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchArea.BackColor = Color.FromArgb(38,50,56)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchAreaDescription.BackColor = Color.FromArgb(38,50,56)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchAdvanced.BackColor = Color.FromArgb(38,50,56)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchAdvancedDescription.BackColor = Color.FromArgb(38,50,56)

                    PanelGlobalSettings.BackColor = Color.FromArgb(38,50,56)
                    PanelGlobalSettingsDescription.BackColor = Color.FromArgb(38,50,56)

                    SaveAsProfile.PanelProfileDescription.BackColor = Color.FromArgb(38,50,56)
                    SaveAsProfile.PanelProfileName.BackColor = Color.FromArgb(38,50,56)
		            Exit Select
	            Case 1
		            PixelClickerFormRedesign.MaterialSkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
                    PixelClickerFormRedesign.PanelMainSelector.BackColor = Color.FromArgb(255,64,129)

                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotClickType.BackColor = Color.FromArgb(48,63,159)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotClickTypeDescription.BackColor = Color.FromArgb(48,63,159)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotType.BackColor = Color.FromArgb(48,63,159)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotTypeDescription.BackColor = Color.FromArgb(48,63,159)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotSettings.BackColor = Color.FromArgb(48,63,159)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotSettingsDescription.BackColor = Color.FromArgb(48,63,159)

                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchMethod.BackColor = Color.FromArgb(48,63,159)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchMethodDescription.BackColor = Color.FromArgb(48,63,159)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchArea.BackColor = Color.FromArgb(48,63,159)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchAreaDescription.BackColor = Color.FromArgb(48,63,159)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchAdvanced.BackColor = Color.FromArgb(48,63,159)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchAdvancedDescription.BackColor = Color.FromArgb(48,63,159)

                    PanelGlobalSettings.BackColor = Color.FromArgb(48,63,159)
                    PanelGlobalSettingsDescription.BackColor = Color.FromArgb(48,63,159)

                    SaveAsProfile.PanelProfileDescription.BackColor = Color.FromArgb(48,63,159)
                    SaveAsProfile.PanelProfileName.BackColor = Color.FromArgb(48,63,159)
		            Exit Select
	            Case 2
		            PixelClickerFormRedesign.MaterialSkinManager.ColorScheme = New ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE)
                    PixelClickerFormRedesign.PanelMainSelector.BackColor = Color.FromArgb(255,138,128)

                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotClickType.BackColor = Color.FromArgb(56,142,60)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotClickTypeDescription.BackColor = Color.FromArgb(56,142,60)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotType.BackColor = Color.FromArgb(56,142,60)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotTypeDescription.BackColor = Color.FromArgb(56,142,60)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotSettings.BackColor = Color.FromArgb(56,142,60)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditBotSettingsDescription.BackColor = Color.FromArgb(56,142,60)

                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchMethod.BackColor = Color.FromArgb(56,142,60)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchMethodDescription.BackColor = Color.FromArgb(56,142,60)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchArea.BackColor = Color.FromArgb(56,142,60)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchAreaDescription.BackColor = Color.FromArgb(56,142,60)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchAdvanced.BackColor = Color.FromArgb(56,142,60)
                    PixelClickerFormRedesign.TaskEditControl.PanelEditSearchAdvancedDescription.BackColor = Color.FromArgb(56,142,60)

                    PanelGlobalSettings.BackColor = Color.FromArgb(56,142,60)
                    PanelGlobalSettingsDescription.BackColor = Color.FromArgb(56,142,60)

                    SaveAsProfile.PanelProfileDescription.BackColor = Color.FromArgb(56,142,60)
                    SaveAsProfile.PanelProfileName.BackColor = Color.FromArgb(56,142,60)
		            Exit Select
            End Select
        End Sub

        Public Sub SetSettings()
            CheckBoxDrawOnGame.Checked =  _globalSettings.DrawOnGame
            CheckBoxDebugMode.Checked = _globalSettings.Debug
            CheckBoxAlwaysOnTop.Checked = _globalSettings.TopMost
            TextBoxGameName.Text = _globalSettings.GameName
        End Sub
        Private Sub CheckBoxDrawOnGame_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDrawOnGame.CheckedChanged
            _globalSettings.DrawOnGame = CheckBoxDrawOnGame.Checked
            _globalSettings.SaveSetting()
        End Sub

        Private Sub CheckBoxDebugMode_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDebugMode.CheckedChanged
             _globalSettings.Debug = CheckBoxDebugMode.Checked
            _globalSettings.SaveSetting()
        End Sub

        Private Sub CheckBoxAlwaysOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAlwaysOnTop.CheckedChanged
            _globalSettings.TopMost = CheckBoxAlwaysOnTop.Checked
            PixelClickerFormRedesign.TopMost = GlobalSettings.Settings.TopMost
            _globalSettings.SaveSetting()
        End Sub

        Private Sub TextBoxGameName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxGameName.TextChanged
            If String.IsNullOrEmpty(TextBoxGameName.Text) Then Exit Sub
            _globalSettings.GameName = TextBoxGameName.Text
            _globalSettings.SaveSetting()
        End Sub
    End Class
End NameSpace