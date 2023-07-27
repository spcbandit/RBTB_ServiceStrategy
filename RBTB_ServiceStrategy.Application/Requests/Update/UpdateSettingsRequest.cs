using MediatR;
using RBTB_ServiceStrategy.Application.Responses.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Requests.Update
{
    public class UpdateSettingsRequest : IRequest<UpdateSettingsResponse>
    {
        public Guid IdSettings { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
