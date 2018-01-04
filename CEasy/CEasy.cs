using System;
using System.Threading.Tasks;
using CEasy.Model;
using CEasy.Types;

namespace CEasy
{
    public partial class CEasy
    {
        protected virtual async Task<bool> DoRequests(IRequest request)
        {

            var validateDownloadInformation = ValidateDownloadInformation(request);
            if (!validateDownloadInformation) return false;

            var requestSuccess = await request.Request();

                OnEventLogAdded(request.EventLog);

            if (!requestSuccess) return false;

            var responseSuccess = request.Response();

            OnEventLogAdded(request.Response.EventLog);

            if (!responseSuccess) return false;

            return true;
        }


        private bool ValidateDownloadInformation(IRequest request)
        {
            try
            {
                request.IsValid();
                return true;
            }
            catch (Exception ex)
            {
                EventLog eventLog = new EventLog(Event.Exception, "Invalid download information", ex);
                OnEventLogAdded(eventLog);
            }

            return false;
        }
    }
}
