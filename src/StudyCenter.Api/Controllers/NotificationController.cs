using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyCenter.Service.UseCases.Event.Command;
using StudyCenter.Service.UseCases.Event.Queries;
using StudyCenter.Service.UseCases.Notification.Command;
using StudyCenter.Service.UseCases.Notification.Queries;

namespace StudyCenter.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotificationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(CreateNotificationCommand command)
        {
            int response = await _mediator.Send(command);

            return Ok(response);
        }
        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var response = await _mediator.Send(new GetAllNotificationQuery());

            return Ok(response);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(UpdateNotificationCommand command)
        {
            int response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            int response = await _mediator.Send(new DeleteNotificationCommand() { Id = id });

            return Ok(response);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int id)
        {
            var response = await _mediator.Send(new GetNotificationByIdQuery() { Id = id });

            return Ok(response);
        }
    }
}
