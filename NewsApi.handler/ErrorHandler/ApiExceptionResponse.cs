﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.handler.ErrorHandler
{
    class ApiExceptionResponse : ApiResponse
    {
        public string? Details { get; set; }
        public ApiExceptionResponse(int statusCode, string? message = null,string?details=null) : base(statusCode, message)
        {
            this.Details = details;
        }
    }
}
