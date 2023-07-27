using MediatR;
using RBTB_ServiceStrategy.Application.Responses.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Requests.Get
{
    public class GetStrategyRequest : IRequest<GetStrategyResponse>
    {
        public Guid IdStrategy { get; set; }
    }
}
