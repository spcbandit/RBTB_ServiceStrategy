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
    public class GetCollectionStrategyHandler : IRequestHandler<GetCollectionStrategyRequest, GetCollectionStrategyResponse>
    {
        private readonly IRepository<StrategyEntity> _repository;

        public GetCollectionStrategyHandler(IRepository<StrategyEntity> repository) =>
            _repository = repository;
        public async Task<GetCollectionStrategyResponse> Handle(GetCollectionStrategyRequest request, CancellationToken cancellationToken)
        {
            var strategiesCollection = _repository.Get()
                .Select(p => new GetCollectionStrategyId
                {
                    IdStrategy = p.Id
                });

            return new GetCollectionStrategyResponse
            {
                IsSuccess = true,
                Strategies = strategiesCollection
            };
        }
    }
}
