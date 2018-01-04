Imports CEasy
Imports PixelClickerGUI.NEW_VIEW
Imports PixelClickerGUI.View

Namespace Controller
    Public Class License
        Private Shared _lastCheckTime As Date = Nothing
        Private Shared _licenseCheckInterval As Integer = 0
        Public Shared WithEvents LicenseUpdateManager As LicenseUpdateManager


        Friend Async Shared Sub CheckLicense()
            If _lastCheckTime = Nothing Then
                _lastCheckTime = Now()
                LicenseUpdateManager = New LicenseUpdateManager("http://license.botoverwatch.com/license.php",
                                                                 "Pixel Clicker", ProgramStateHandler.State.Version)
                _licenseCheckInterval = GetRandom(12, 30)
                Await LicenseCheck()
                Await UpdateCheck()
            Else
                Debug.WriteLine($"Last checked {Now().Subtract(_lastCheckTime).Minutes } minutes ago")
                If Now().Subtract(_lastCheckTime).Minutes >= _licenseCheckInterval Then
                    _lastCheckTime = Now()
                    _licenseCheckInterval = GetRandom(12, 30)
                    Await LicenseCheck()
                    Await UpdateCheck()
                End If
            End If
        End Sub

        Private Async Shared Function LicenseCheck() As Task(Of Boolean)
            Dim goodLicense As Boolean = Await LicenseUpdateManager.CheckLicense()
            Dim voted As Boolean = LicenseUpdateManager.RemoteVersionResponse.voted

            If Not Voted Then
                Dim creationDate 
                If Date.TryParse(LicenseUpdateManager.RemoteVersionResponse.created, creationDate) Then
                    Dim days As Integer = Now().Subtract(creationDate).days
                    If days > 2 Then
                        Dim poller As New Poller
                        If poller.ShowDialog() = DialogResult.OK Then
                            LicenseUpdateManager.voted = poller.voted
                            LicenseUpdateManager.willpay = poller.willpay
                            LicenseUpdateManager.suggestedprice = poller.suggestedprice
                            LicenseUpdateManager.email = poller.email

                            Await LicenseUpdateManager.CheckLicense()
                        End If
                    End If
                End If
            End If


            If Not goodLicense Then
                Debug.WriteLine("BAD LICENSE!!!" & vbLf)
                End
            Else
                Debug.WriteLine("GOOD LICENSE!!!" & vbLf)
            End If

            Return True
        End Function

        Private Async Shared Function UpdateCheck() As Task(Of Boolean)
            If LicenseUpdateManager.UpdateAvaliable Then
                If Not Await LicenseUpdateManager.Update() Then
                    Debug.WriteLine("Failed to update!" & vbLf)
                Else
                    Debug.WriteLine("Updated!" & vbLf)
                    Process.Start(".\PixelClicker.exe")
                    End
                End If
            Else
                Debug.WriteLine("No Update!" & vbLf)
            End If
            Return True
        End Function

        Private Shared Sub OnEventLogAdded(sender As Object, eventLog As CEasy.Model.EventLog) _
            Handles LicenseUpdateManager.EventLogAdded
            Debug.WriteLine(eventLog.ToString() + vbLf)
        End Sub

        Public Shared Function GetRandom(ByVal min As Integer, ByVal max As Integer) As Integer
            Static generator As System.Random = New System.Random()
            Return generator.Next(Min, Max)
        End Function
    End Class
End Namespace