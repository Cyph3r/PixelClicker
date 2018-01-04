using System;
using System.Drawing;
using CEasy.Types;

namespace CEasy.Model
{
    public interface IEventLog
    {
        Event EventType { get; }
        DateTime TimeStamp { get; }
        string Message { get; }
        string ExceptionMessage { get; }
        string StackTrace { get; }
    }

    public class EventLog : IEventLog
    {
        public EventLog(Event eventType, string message = "", Exception error = null)
        {
            this.TimeStamp = DateTime.Now;
            this.EventType = eventType;
            this.Message = message;

            if (error == null) return;
            this.ExceptionMessage = error.Message;

            if (error.StackTrace == null) return;
            this.StackTrace = error.StackTrace;
        }

        public Color GetEventLogColor()
        {
            switch (EventType)
            {
                case Event.Success:
                    return Color.Green;
                case Event.Warning:
                    return Color.Yellow;
                case Event.Exception:
                    return Color.Red;
                case Event.Debug:
                    return Color.DarkGray;
            }

            return SystemColors.WindowText;
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(ExceptionMessage))
            {
                return $"Type: {EventType} TimeStamp: {TimeStamp} Message: {Message} Exception: {ExceptionMessage}";
            }

            return $"Type: {EventType} TimeStamp: {TimeStamp} Message: {Message}";
        }

        public Event EventType { get; }
        public DateTime TimeStamp { get; }
        public string Message { get; }
        public string ExceptionMessage { get; }
        public string StackTrace { get; }
    }
}
