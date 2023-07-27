using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Responses.Get
{
    public class GetSettingsResponse : BaseResponse
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
