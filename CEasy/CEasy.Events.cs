using System;
using CEasy.Model;

namespace CEasy
{
    public partial class CEasy
    {
        public delegate void CEasyEvent(object sender, EventLog eventLog);
        public event CEasyEvent EventLogAdded;

        protected void OnEventLogAdded(EventLog eventlog)
        {
            EventLogAdded?.Invoke(this, eventlog);
        }
    }
}
