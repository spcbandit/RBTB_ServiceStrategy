using MediatR;
using RBTB_ServiceStrategy.Application.Responses.Delete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Requests.Delete
{
    public class DeleteStrategyRequest : IRequest<DeleteStrategyResponse>
    {
        public Guid IdStrategy { get; set; }
    }
}
