Imports BrightIdeasSoftware
Imports MaterialSkin
Imports PixelClickerGUI.Model

Namespace NEW_VIEW
    Public Class EventControl
        Private WithEvents _eventLog As New Model.EventLog

        Public Sub OnEventAdded(eventLog As Model.EventLog) Handles _eventLog.OnEventLog
            If String.IsNullOrEmpty(eventLog.ExceptionMessage) Then
                GeneralListView.AddObject(eventLog)
            Else
                ErrorLogListView.AddObject(eventLog)
            End If
        End Sub

        Private Sub SearchListColors_FormatCell(sender As Object, e As BrightIdeasSoftware.FormatRowEventArgs) Handles GeneralListView.FormatRow, ErrorLogListView.FormatRow
            Dim eventLog As Model.EventLog = DirectCast(e.Model, Model.EventLog)
            Dim list As ObjectListView = DirectCast(sender, ObjectListView)

            list.Items(e.RowIndex).SubItems(0).ForeColor = eventLog.GetEventLogColor()
        End Sub
    End Class
End NameSpace