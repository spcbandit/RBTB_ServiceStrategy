using MediatR;
using RBTB_ServiceStrategy.Application.Abstractions;
using RBTB_ServiceStrategy.Application.Entities;
using RBTB_ServiceStrategy.Application.Requests.Delete;
using RBTB_ServiceStrategy.Application.Responses.Delete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Handlers.Delete
{
    public class DeleteSettingsHandler : IRequestHandler<DeleteSettingsRequest, DeleteSettingsResponse>
    {
        private readonly IRepository<SettingsEntity> _repository;

        public DeleteSettingsHandler(IRepository<SettingsEntity> repository) =>
            _repository = repository;

        public async Task<DeleteSettingsResponse> Handle(DeleteSettingsRequest request, CancellationToken cancellationToken)
        {
            var removableSettings = _repository.FindById(request.IdSettings);

            if (removableSettings == null)
            {
                return new DeleteSettingsResponse
                {
                    IsSuccess = false,
                    ErrorMessage = "Объект с данным Id не найден"
                };
            }

            _repository.Remove(removableSettings);

            return new DeleteSettingsResponse
            {
                IsSuccess = true
            };
        }
    }
}
