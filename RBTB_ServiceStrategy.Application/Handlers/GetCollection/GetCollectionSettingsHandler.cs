using MediatR;
using RBTB_ServiceStrategy.Application.Abstractions;
using RBTB_ServiceStrategy.Application.Entities;
using RBTB_ServiceStrategy.Application.Requests.GetCollection;
using RBTB_ServiceStrategy.Application.Responses.GetCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Handlers.Get
{
    public class GetCollectionSettingsHandler : IRequestHandler<GetCollectionSettingsRequest, GetCollectionSettingsResponse>
    {
        private readonly IRepository<SettingsEntity> _repository;

        public GetCollectionSettingsHandler(IRepository<SettingsEntity> repository) =>
            _repository = repository;

        public async Task<GetCollectionSettingsResponse> Handle(GetCollectionSettingsRequest request, CancellationToken cancellationToken)
        {
            var settingsCollection = _repository.Get()
                .Where(p => p.IdStrategy == request.IdStrategy)
                .Select(p => new GetCollectionSettingsId
                {
                    IdSettings = p.Id
                });

            return new GetCollectionSettingsResponse
            {
                IsSuccess = true,
                Settings = settingsCollection
            };
        }
    }
}
