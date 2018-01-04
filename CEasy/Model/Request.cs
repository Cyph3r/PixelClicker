using System;
using System.Collections.Generic;
using System.Net.Http;

namespace CEasy.Model
{
    public interface IRequest
    {
        Uri Uri { get; set; }
        IResponse Response { get; }
        FormUrlEncodedContent PostData { get;}
        IEasyHttpHandler EasyHttpHandler { get; }
        EventLog EventLog { get; set; }
    }

    public class Request : IRequest
    {
        public Request(){}
        public Request(Uri uri,
            FormUrlEncodedContent postData = null,
            IEasyHttpHandler easyHttpHandler = null)
        {

            this.Uri = uri;
            this.PostData = postData;
            this.EasyHttpHandler = easyHttpHandler ?? new CEasyHandler();
            this.Response = new Response {Request = this};
        }

        public Uri Uri { get; set; }
        public FormUrlEncodedContent PostData { get; set; }
        public IResponse Response { get; set; } = null;
        public EventLog EventLog { get; set; }
        public IEasyHttpHandler EasyHttpHandler { get; set; } = null;
    }
}
