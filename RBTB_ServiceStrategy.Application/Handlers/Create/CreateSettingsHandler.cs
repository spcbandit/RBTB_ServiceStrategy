using MediatR;
using RBTB_ServiceStrategy.Application.Abstractions;
using RBTB_ServiceStrategy.Application.Entities;
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
    public class CreateSettingsHandler : IRequestHandler<CreateSettingsRequest, CreateSettingsResponse>
    {
        private readonly IRepository<SettingsEntity> _repository;

        public CreateSettingsHandler(IRepository<SettingsEntity> repository) =>
            _repository = repository;

        async Task<CreateSettingsResponse> IRequestHandler<CreateSettingsRequest, CreateSettingsResponse>.Handle(CreateSettingsRequest request, 
            CancellationToken cancellationToken)
        {
            var newSettings = new SettingsEntity
            {
                Name = request.Name,
                IdStrategy = request.IdStrategy,
                Value = request.Value
            };

            _repository.Create(newSettings);

            var response = new CreateSettingsResponse
            {
                IsSuccess = true,
                IdSettings = newSettings.IdStrategy
            };

            return response;
        }

    }
}
