using System;
using System.Collections.Generic;
using System.Net;

namespace Synetec.Shared.Common
{
    public class AppException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }
        public List<string> Descriptions { get; set; }

        public AppException(string description, HttpStatusCode errorCode = HttpStatusCode.InternalServerError)
        {
            StatusCode = errorCode;
            Descriptions = new List<string>() { description };
        }

        public AppException(List<string> descriptions, HttpStatusCode errorCode = HttpStatusCode.InternalServerError)
        {
            StatusCode = errorCode;
            Descriptions = descriptions;
        }
    }
}
