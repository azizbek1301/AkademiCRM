using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyCenter.Service.UseCases.Event.Command;
using StudyCenter.Service.UseCases.Event.Queries;
using StudyCenter.Service.UseCases.Subjects.Command;
using StudyCenter.Service.UseCases.Subjects.Queries;

namespace StudyCenter.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubjectController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(CreateSubjectsCommand command)
        {
            int response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var response = await _mediator.Send(new GetAllSubjectsQuery());

            return Ok(response);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(UpdateSubjectsCommand command)
        {
            int response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            int response = await _mediator.Send(new DeleteSubjectsCommand() { Id = id });

            return Ok(response);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int id)
        {
            var response = await _mediator.Send(new GetSubjectsByIdQuery() { Id = id });

            return Ok(response);
        }
    }
}
