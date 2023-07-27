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
    public class UpdateStrategyHandler : IRequestHandler<UpdateStrategyRequest, UpdateStrategyResponse>
    {
        private readonly IRepository<StrategyEntity> _repository;

        public UpdateStrategyHandler(IRepository<StrategyEntity> repository) =>
            _repository = repository;

        public async Task<UpdateStrategyResponse> Handle(UpdateStrategyRequest request, CancellationToken cancellationToken)
        {
            var selectedStrategy = _repository.FindById(request.IdStrategy);
            if (selectedStrategy == null)
            {
                return new UpdateStrategyResponse
                {
                    IsSuccess = false,
                    ErrorMessage = "Объект с данным Id не найден"
                };
            }
            if (request.Name != null)
                selectedStrategy.Name = request.Name;
            if (request.CurrencyPair != null)
                selectedStrategy.CurrencyPair = request.CurrencyPair;
            if (request.StockMarket != null)
                selectedStrategy.StockMarket= request.StockMarket;

            _repository.Update(selectedStrategy);

            return new UpdateStrategyResponse
            {
                IsSuccess = true
            };
        }
    }
}
