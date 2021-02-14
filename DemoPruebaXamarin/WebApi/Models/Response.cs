using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Response
    {
        public Response(string message, int status)
        {
            Message = message;
            Status = status;
        }

        public string Message { get; set; }
        public int Status { get; set; }

        public Response()
        {

        }
    }
}