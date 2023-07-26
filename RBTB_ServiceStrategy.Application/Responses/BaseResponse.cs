using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Responses
{
    internal class BaseResponse
    {
        public bool IsSuccess { get; set; }

        public string ErrorMessage { get; set; }
    }
}
