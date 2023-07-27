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
    public class GetStrategyHandler : IRequestHandler<GetStrategyRequest, GetStrategyResponse>
    {
        private readonly IRepository<StrategyEntity> _repository;

        public GetStrategyHandler(IRepository<StrategyEntity> repository) =>
            _repository = repository;
        public async Task<GetStrategyResponse> Handle(GetStrategyRequest request, CancellationToken cancellationToken)
        {
            var selectedStrategy = _repository.FindById(request.IdStrategy);

            if (selectedStrategy == null)
            {
                return new GetStrategyResponse
                {
                    IsSuccess = false,
                    ErrorMessage = "Объекта с данным Id не существует"
                };
            }

            return new GetStrategyResponse
            {
                IsSuccess = true,
                CurrencyPair = selectedStrategy.CurrencyPair,
                Name = selectedStrategy.Name,
                StockMarket = selectedStrategy.StockMarket
            };
        }
    }
}
