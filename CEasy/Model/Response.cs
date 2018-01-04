namespace CEasy.Model
{
    public interface IResponse
    {
        EventLog EventLog { get; set; }
        string Value { get; set; }
        IRequest Request { get; set; }
    }

    public class Response : IResponse
    {
        public Response() { }
        public Response(EventLog eventLog, string value)
        {
            this.EventLog = eventLog;
            this.Value = value;
        }

        public EventLog EventLog { get;  set; }
        public string Value { get;  set; }
        public IRequest Request { get; set; }
}
}
