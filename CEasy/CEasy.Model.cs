using System;
using CEasy.Model;

namespace CEasy
{
    
    public partial class CEasy
    {
        protected readonly IRequest[] Requests;


        public CEasy(params IRequest[] requests)
        {
            Requests = requests;
        }
    }
}
