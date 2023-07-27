using MediatR;
using RBTB_ServiceStrategy.Application.Responses.GetCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Requests.GetCollection
{
    public class GetCollectionSettingsRequest : IRequest<GetCollectionSettingsResponse>
    {
        public Guid IdStrategy { get; set; }
    }
}
