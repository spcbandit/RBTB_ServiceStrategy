using MediatR;
using RBTB_ServiceStrategy.Application.Requests.Create;
using RBTB_ServiceStrategy.Application.Responses.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Handlers.Create
{
    public class CreateSettingsHadler : IRequestHandler<CreateSettingsRequest, CreateSettingsResponse>
    { 
        private readonly Create

        Task<CreateSettingsResponse> IRequestHandler<CreateSettingsRequest, CreateSettingsResponse>.Handle(CreateSettingsRequest request, CancellationToken cancellationToken)
        {
            
        }
    }
}
