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
    public class DeleteStrategyHandler : IRequestHandler<DeleteStrategyRequest, DeleteStrategyResponse>
    {
        private readonly IRepository<StrategyEntity> _repository;

        public DeleteStrategyHandler(IRepository<StrategyEntity> repository) =>
            _repository = repository;

        public async Task<DeleteStrategyResponse> Handle(DeleteStrategyRequest request, CancellationToken cancellationToken)
        {
            var removableStrategy = _repository.FindById(request.IdStrategy);

            if(removableStrategy == null)
            {
                return new DeleteStrategyResponse
                {
                    IsSuccess = false,
                    ErrorMessage = "Объект с данным Id не найден"
                };
            }

            _repository.Remove(removableStrategy);

            return new DeleteStrategyResponse
            {
                IsSuccess = true
            };
        }
    }
}
