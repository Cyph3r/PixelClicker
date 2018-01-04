using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using CEasy.Model;
using CEasy.Types;
using EventLog = CEasy.Model.EventLog;

namespace CEasy
{
    public interface IEasyHttpHandler
    {
        Task<bool> OnRequest(IRequest request);
        bool OnResponse(IResponse response);
    }

    public class CEasyHandler : IEasyHttpHandler
    {
        public virtual async Task<bool> OnRequest(IRequest request)
        {
            try
            {
                var postData = request.PostData.ReadAsStringAsync().Result;
                using (HttpClient httpClient = new HttpClient())
                using (HttpResponseMessage responseMessage = await httpClient.GetAsync($"{request.Uri}?{postData}"))
                {
                    request.Response.Value = await responseMessage.Content.ReadAsStringAsync();
                    request.EventLog = new EventLog(Event.Success, $"Requesting from: {request.Uri}");

                    return true;
                }
            }
            catch (Exception ex)
            {
                request.EventLog = new EventLog(Event.Exception, $"Requesting from: {request.Uri}", ex);
                return false;
            }
        }

        public virtual bool OnResponse(IResponse response)
        {
            throw new NotImplementedException();
        }
    }
}
