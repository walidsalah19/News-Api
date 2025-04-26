using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.handler.ErrorHandler
{
    class ApiValidationErrorResponse : ApiResponse
    {
        public IEnumerable<string> Errors { get; set; }

        public ApiValidationErrorResponse() : base(400)
        {
            Errors = new List<string>();
        }
    }
}
