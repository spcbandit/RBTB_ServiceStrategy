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
        private readonly IRepository<StrategyEntity> _strategy;

        public CreateSettingsHandler(IRepository<SettingsEntity> repository, IRepository<StrategyEntity> strategy) =>
            (_repository, _strategy) = (repository, strategy);

        async Task<CreateSettingsResponse> IRequestHandler<CreateSettingsRequest, CreateSettingsResponse>.Handle(CreateSettingsRequest request,
            CancellationToken cancellationToken)
        {
            if (_strategy.FindById(request.IdStrategy) == null)
            {
                return new CreateSettingsResponse
                {
                    IsSuccess = false,
                    ErrorMessage = "Стратегии с указанным Id не существует."
                };
            }

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
                IdSettings = newSettings.IdStrategy.ToString()
            };

            return response;
        }
    }
}
