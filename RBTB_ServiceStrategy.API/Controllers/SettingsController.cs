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
    public class SettingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SettingsController(IMediator mediator) =>
            _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> GetSettings()
        {
            var collectionSettings = await _mediator.Send(new GetCollectionSettingsRequest());

            return Ok(collectionSettings);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetSetting(Guid id)
        {
            var request = new GetSettingsRequest { IdSettings = id };

            var selectedSettings = await _mediator.Send(request);

            return selectedSettings.IsSuccess
                ? Ok(selectedSettings)
                : BadRequest(selectedSettings);
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateSettings([FromBody] UpdateSettingsRequest request)
        {
            var response = await _mediator.Send(request);

            return response.IsSuccess
                ? Ok(response)
                : BadRequest(response);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateSettings([FromBody] CreateSettingsRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpDelete]
        [Route("remove")]
        public async Task<IActionResult> RemoveSettings([FromBody] DeleteSettingsRequest request)
        {
            var response = await _mediator.Send(request);

            return response.IsSuccess
                ? Ok(response)
                : BadRequest(response);
        }
    }
}
