using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ApiCoreEF.Model
{
    public class Response
    {
        public Response()
        {
            this.Message = string.Empty;
        }

        public Response(HttpStatusCode _erroCode, string _statusCode)
        {
            this.StatusCode = _erroCode;
            this.Message = _statusCode;
        }

        public HttpStatusCode StatusCode { get; set; }

        public string Message { get; set; }

    }
}
