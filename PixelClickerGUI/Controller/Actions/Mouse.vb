
Imports System.Runtime.InteropServices
Imports PixelClickerGUI.Model

Namespace Controller.Actions
    Public Class Mouse
        Public Function Move(moveToX As Integer, moveToY As Integer, moveSpeed As Integer) As Boolean
                Dim movingX As Integer
                Dim movingY As Integer
               
	            If moveToX Then
		            If Math.Abs(moveToX) < moveSpeed Then
			            movingX = moveToX
		            Else
			            movingX = moveSpeed
                        If moveToX < 0 Then movingX *= -1
		            End If
	            End If

	      	    If  moveToY Then
		            If Math.Abs(moveToY) < moveSpeed Then
			            movingY = moveToY
		            Else
			            movingY = moveSpeed
                        If moveToY < 0 Then movingY *= -1
		            End If
	            End If

            WindowsApi.MouseEvent(1, movingX, movingY, 0, 0)
	        Return True
        End Function

        Public Sub LeftClickDown()
            WindowsApi.MouseEvent(&H2, 0, 0, 0, 0)
        End Sub
        Public Sub LeftClickUp()
            WindowsApi.MouseEvent(&H4, 0, 0, 0, 0)
        End Sub


    End Class
End NameSpace