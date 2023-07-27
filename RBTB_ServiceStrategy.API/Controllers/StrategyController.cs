using MediatR;
using Microsoft.AspNetCore.Mvc;
using RBTB_ServiceStrategy.Application.Requests.Create;
using RBTB_ServiceStrategy.Application.Requests.Delete;
using RBTB_ServiceStrategy.Application.Requests.Get;
using RBTB_ServiceStrategy.Application.Requests.GetCollection;
using RBTB_ServiceStrategy.Application.Requests.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StrategyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StrategyController(IMediator mediator) =>
            _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> GetStrategies()
        {
            var collectionStrategies = await _mediator.Send(new GetCollectionSettingsRequest());

            return Ok(collectionStrategies);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetStrategy(Guid id)
        {
            var request = new GetStrategyRequest { IdStrategy = id };

            var selectedStrategy = await _mediator.Send(request);

            return selectedStrategy.IsSuccess
                ? Ok(selectedStrategy)
                : BadRequest(selectedStrategy);
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateStrategy([FromBody] UpdateStrategyRequest request)
        {
            var response = await _mediator.Send(request);

            return response.IsSuccess
                ? Ok(response)
                : BadRequest(response);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateStrategy([FromBody] CreateStrategyRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpDelete]
        [Route("remove")]
        public async Task<IActionResult> RemoveStrategy([FromBody] DeleteStrategyRequest request)
        {
            var response = await _mediator.Send(request);

            return response.IsSuccess
                ? Ok(response)
                : BadRequest(response);
        }
    }
}
