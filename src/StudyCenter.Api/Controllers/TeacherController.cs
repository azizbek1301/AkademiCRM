using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyCenter.Service.UseCases.Event.Command;
using StudyCenter.Service.UseCases.Event.Queries;
using StudyCenter.Service.UseCases.Teachers.Command;
using StudyCenter.Service.UseCases.Teachers.Queries;

namespace StudyCenter.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TeacherController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(CreateTeacherCommand command)
        {
            int response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var response = await _mediator.Send(new GetAllTeacherQuery());

            return Ok(response);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(UpdateTeacherCommand command)
        {
            int response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            int response = await _mediator.Send(new DeleteTeacherCommand() { Id = id });

            return Ok(response);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int id)
        {
            var response = await _mediator.Send(new GetTeacherByIdQuery() { Id = id });

            return Ok(response);
        }
    }
}
