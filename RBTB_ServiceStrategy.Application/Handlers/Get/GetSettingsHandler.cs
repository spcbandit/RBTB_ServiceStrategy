using MediatR;
using RBTB_ServiceStrategy.Application.Abstractions;
using RBTB_ServiceStrategy.Application.Entities;
using RBTB_ServiceStrategy.Application.Requests.Get;
using RBTB_ServiceStrategy.Application.Responses.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Handlers.Get
{
    public class GetSettingsHandler : IRequestHandler<GetSettingsRequest, GetSettingsResponse>
    {
        private readonly IRepository<SettingsEntity> _repository;

        public GetSettingsHandler(IRepository<SettingsEntity> repository) =>
            _repository = repository;
        public async Task<GetSettingsResponse> Handle(GetSettingsRequest request, CancellationToken cancellationToken)
        {
            var selectedSettings = _repository.FindById(request.IdSettings);

            if (selectedSettings == null)
            {
                return new GetSettingsResponse
                {
                    IsSuccess = false,
                    ErrorMessage = "Объекта с данным Id не существует"
                };
            }

            return new GetSettingsResponse
            {
                IsSuccess = true,
                Name = selectedSettings.Name,
                Value = selectedSettings.Value
            };
        }
    }
}
