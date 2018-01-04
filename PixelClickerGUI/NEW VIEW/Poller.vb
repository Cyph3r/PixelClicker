Imports System.IO
Imports System.Net.Http
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports PixelClickerGUI.Model

Namespace NEW_VIEW
    Public Class Poller
        Public willpay As Boolean = False
        Public suggestedprice As Double = 0.00
        public voted As Boolean = False
        Public email As String

        Private Shared ReadOnly RegexCsrf As New Regex("<input type=""hidden"" name=""_csrf"" value=""(.*)"" />")
        Private Const EmailInitial As String = "http://email-checker.net/"
        Private Const EmailCheck As String = "http://email-checker.net/check"
        Public sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

            checkBoxWillPay.Checked = True
        End Sub
        Private Sub checkBoxWillPay_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxWillPay.CheckedChanged
            If Not checkBoxWillPay.Checked Then
                txtSuggestedPrice.Text = 0.00
            Else 
                 txtSuggestedPrice.Text = 15.00
            End If

            txtSuggestedPrice.Enabled = checkBoxWillPay.Checked
            willpay = checkBoxWillPay.Checked
        End Sub
        Public Function IsValidEmail(emailaddress As String) As Boolean
	        Try
		        Dim m As New MailAddress(emailaddress)

		        Return True
	        Catch generatedExceptionName As FormatException
		        Return False
	        End Try
        End Function
        Private Async Sub  ButtonVote_Click(sender As Object, e As EventArgs) Handles ButtonVote.Click
               If willpay Then
                  If Double.TryParse(txtSuggestedPrice.Text, Me.suggestedPrice) Then
                    If suggestedPrice > 0 Then
                        Me.suggestedprice = suggestedPrice
                    Else
                        MessageBox.Show(Me, "Please enter a value greater than 0 if you are willing to pay!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else
                    MessageBox.Show(Me, "Please enter a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            If String.IsNullOrEmpty(txtEmail.Text) OrElse Not IsValidEmail(txtEmail.Text)  Then
                MessageBox.Show(Me, "Please enter a valid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf  txtEmail.Text.Length > 100 Then
                MessageBox.Show(Me, "Please enter an email address less than 100 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim client As New HttpClient

            Dim crsf As String = Await GetCsrfTask(client)
            If Not  String.IsNullOrEmpty(crsf) Then
                Dim goodEmail As Boolean = Await CheckEmail(client, txtEmail.Text, crsf)

                If Not goodEmail Then
                    MessageBox.Show(Me, "Please enter a valid email address!  You only have 5 tries until you're locked out for an hour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            email = txtEmail.Text
            voted = True
            DialogResult = DialogResult.OK
        End Sub
        Friend Shared Async Function GetCsrfTask(client As HttpClient) As Task(Of String)
	        Try
		        Using httpResponseMessage = Await client.GetAsync(EmailInitial)
			        If httpResponseMessage.IsSuccessStatusCode Then
				        Dim result = Await httpResponseMessage.Content.ReadAsStringAsync()
				        Dim match = RegexCsrf.Match(result)

				        If match.Success Then
					        Return match.Groups(1).Value
				        End If
			        End If

                    Return ""
		        End Using
	        Catch ex As Exception
		        Return ""
	        End Try
        End Function

        Friend Shared Async Function CheckEmail(client As HttpClient, email As String, csrf As String) As Task(Of Boolean)
	        Try
		        Dim keyValuePairArray = New KeyValuePair(Of String, String)(1) {
                    New KeyValuePair(Of String, String)("email", email),
                    New KeyValuePair(Of String, String)("_csrf", csrf)
                }
		        Dim urlEncodedContent = New FormUrlEncodedContent(keyValuePairArray)

		        If Not client.DefaultRequestHeaders.Contains("Referer") Then
			        client.DefaultRequestHeaders.Add("Referer", "http://email-checker.net/")
		        End If

		        Using responseMessage = Await client.PostAsync(EmailCheck, urlEncodedContent)
				    Dim results As String = await responseMessage.Content.ReadAsStringAsync()

                    Return results.Contains($"<h2><span class=" & Chr(34) & "green" & Chr(34) & ">Valid.</span> <small></small></h2>")
		        End Using
	        Catch ex As Exception
                Return False
	        End Try
        End Function
    End Class
End NameSpace