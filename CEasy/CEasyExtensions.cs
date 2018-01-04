using System;
using System.Threading.Tasks;
using CEasy.Model;

namespace CEasy
{
    internal static class CEasyExtensions
    {
        public static async Task<bool> Request(this IRequest request)
        {
            return await request.EasyHttpHandler.OnRequest(request);
        }

        public static bool Response(this IRequest request)
        {
            return request.EasyHttpHandler.OnResponse(request.Response);
        }

        public static void IsValid(this IRequest request)
        {
            if (request.Uri == null)
                throw new Exception("URI IS REQUIRED");
            if (request.EasyHttpHandler == null)
                throw new Exception("VALIDATOR IS REQUIRED");
            if (request.Response == null)
                throw new Exception("POSTDOWNLOADINFORMATION IS REQUIRED");
        }
    }
}
