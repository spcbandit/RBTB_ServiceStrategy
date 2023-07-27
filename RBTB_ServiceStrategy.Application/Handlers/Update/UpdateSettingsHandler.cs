using MediatR;
using RBTB_ServiceStrategy.Application.Abstractions;
using RBTB_ServiceStrategy.Application.Entities;
using RBTB_ServiceStrategy.Application.Requests.Update;
using RBTB_ServiceStrategy.Application.Responses.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Handlers.Update
{
    public class UpdateSettingsHandler : IRequestHandler<UpdateSettingsRequest, UpdateSettingsResponse>
    {
        private readonly IRepository<SettingsEntity> _repository;

        public UpdateSettingsHandler(IRepository<SettingsEntity> repository) =>
            _repository = repository;

        public async Task<UpdateSettingsResponse> Handle(UpdateSettingsRequest request, CancellationToken cancellationToken)
        {
            var selectedObj = _repository.FindById(request.IdSettings);
            if (selectedObj == null)
            {
                return new UpdateSettingsResponse
                {
                    IsSuccess = false,
                    ErrorMessage = "Объект с данным Id не найден"
                };
            }
            if (request.Name != null)
                selectedObj.Name = request.Name;
            if(request.Value != null)
                selectedObj.Value = request.Value;

            _repository.Update(selectedObj);

            return new UpdateSettingsResponse
            {
                IsSuccess = true
            };
        }
    }
}
