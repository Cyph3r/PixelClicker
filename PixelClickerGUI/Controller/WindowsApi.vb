Imports System.Runtime.InteropServices
Imports System.Text

Namespace Controller
    Public Class WindowsApi
        <DllImport("user32.dll", EntryPoint:="GetWindowLong")> Public Shared Function GetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
        End Function

        <DllImport("user32.dll", EntryPoint:="SetWindowLong")> Public Shared Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
        End Function

        Friend Declare Sub MouseEvent Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
        Friend Declare Function GetAsyncKeyState Lib "user32"(ByVal vkey As Keys) As Short
        Friend Declare Auto Function GetCursorPos Lib "User32.dll" (ByRef lpPoint As Point) As Integer

        Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
        Private Declare Auto Function GetWindowText Lib "user32" (ByVal hWnd As System.IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
        Public Shared Function GetCaption() As String
            Dim Caption As New System.Text.StringBuilder(256)
            Dim hWnd As IntPtr = GetForegroundWindow()
            GetWindowText(hWnd, Caption, Caption.Capacity)
            Return Caption.ToString()
        End Function


    End Class
End NameSpace