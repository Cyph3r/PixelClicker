Namespace Model
    Public Class TargetHistory
        Private _history As New Queue(Of ActionModel)(20)

        Public Function Count As Integer
            Return _history.Count
        End Function
        Public ReadOnly Property History(index As Integer) As ActionModel
            Get
                Return _history(index)
            End Get
        End Property

        Public Sub AddItem(newItem As ActionModel)
                _history.Enqueue(newItem)
        End Sub
    End Class
End Namespace
