Imports MaterialSkin

Namespace NEW_VIEW
    Public Class ContactUsControl
        Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
            Dim webAddress As String = "https://discord.gg/UebUkHc"
            Process.Start(webAddress)
        End Sub

        Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
            Dim webAddress As String = "http://botoverwatch.com"
            Process.Start(webAddress)
        End Sub
    End Class
End NameSpace