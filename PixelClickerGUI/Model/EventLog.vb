Imports CEasy.Model
Imports CEasy.Types

Namespace Model
        Public Enum EventType
	        Debug
	        Success
	        Warning
	        Exception
        End Enum

    Public Class EventLog
        Public Shared Event OnEventLog(ByVal eventLog As Model.EventLog)

        Public Sub New()
        End Sub
        Public Sub New(eventType As EventType, Optional message As String = "", Optional [error] As Exception = Nothing)
			Me.TimeStamp = DateTime.Now
			Me.EventType = eventType
			Me.Message = message

			If Not [error] Is Nothing Then
				Me.ExceptionMessage = [error].Message
                
		        If  Not [error].StackTrace Is Nothing Then
			        Me.StackTrace = [error].StackTrace
		        End If
			End If


            RaiseEvent OnEventLog(Me)
		End Sub

		Public Function GetEventLogColor() As Color
			Select Case EventType
				Case EventType.Success
					Return Color.Green
				Case EventType.Warning
					Return Color.Yellow
				Case EventType.Exception
					Return Color.Red
				Case EventType.Debug
					Return Color.DarkGray
			End Select

			Return SystemColors.WindowText
		End Function

		Public Overrides Function ToString() As String
			If Not String.IsNullOrEmpty(ExceptionMessage) Then
				Return "Type: {EventType} TimeStamp: {TimeStamp} Message: {Message} Exception: {ExceptionMessage}"
			End If

			Return "Type: {EventType} TimeStamp: {TimeStamp} Message: {Message}"
		End Function

		Public ReadOnly Property EventType() As EventType
		Public ReadOnly Property TimeStamp() As DateTime
		Public ReadOnly Property Message() As String
		Public ReadOnly Property ExceptionMessage() As String
		Public ReadOnly Property StackTrace() As String
    End Class
End NameSpace