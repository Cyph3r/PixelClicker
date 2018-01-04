Imports System.IO
Imports PixelClickerGUI.Model

Namespace NEW_VIEW
    Public Class SaveAsProfile
        Private Sub SaveAsProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            txtName.Text = "New Name"
            txtDescription.Text = "New Description"
        End Sub

        Private Sub ButtonSaveProfile_Click(sender As Object, e As EventArgs) Handles ButtonSaveProfile.Click
            If String.IsNullOrEmpty(txtName.Text)
                MessageBox.Show("Profile name can't be empty.")
                Exit Sub
            ElseIf File.Exists($".\Profiles\{txtName.Text}.json") Then 
                MessageBox.Show("Profile name already exists")
                Exit Sub
            End If
            Try
                Dim newProfile As New Profile 
                newProfile.Description = txtDescription.Text
                newProfile.Name = txtName.Text
                newProfile.SaveProfile()

                Profile.SetCurrentProfile(newProfile)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Me.DialogResult = DialogResult.OK
        End Sub

        Private Sub ButtonProfileCancel_Click(sender As Object, e As EventArgs) Handles ButtonProfileCancel.Click
            Me.DialogResult = DialogResult.Cancel
        End Sub
    End Class
End NameSpace