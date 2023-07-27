using MediatR;
using RBTB_ServiceStrategy.Application.Abstractions;
using RBTB_ServiceStrategy.Application.Entities;
using RBTB_ServiceStrategy.Application.Requests.Create;
using RBTB_ServiceStrategy.Application.Responses.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Handlers.Create
{
    public class CreateStrategyHandler : IRequestHandler<CreateStrategyRequest, CreateStrategyResponse>
    {
        private readonly IRepository<StrategyEntity> _repository;

        public CreateStrategyHandler(IRepository<StrategyEntity> repository) =>
            _repository = repository;

        async Task<CreateStrategyResponse> IRequestHandler<CreateStrategyRequest, CreateStrategyResponse>.Handle(CreateStrategyRequest request, 
            CancellationToken cancellationToken)
        {
            var newStrategy = new StrategyEntity
            {
                CurrencyPair = request.CurrencyPair,
                Name = request.Name,
                StockMarket = request.StockMarket
            };

            _repository.Create(newStrategy);

            var response = new CreateStrategyResponse
            {
                IsSuccess = true,
                IdStrategy = newStrategy.Id
            };

            return response;
        }
    }
}
