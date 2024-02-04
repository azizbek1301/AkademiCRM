using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyCenter.Service.UseCases.Event.Command;
using StudyCenter.Service.UseCases.Event.Queries;
using StudyCenter.Service.UseCases.School_Expences.Command;
using StudyCenter.Service.UseCases.School_Expences.Queries;

namespace StudyCenter.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SchoolExpenceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SchoolExpenceController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(CreateSchool_ExpenceCommand command)
        {
            int response = await _mediator.Send(command);

            return Ok(response);
        }
        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var response = await _mediator.Send(new GetAllSchool_ExtenceQuery());

            return Ok(response);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(UpdateSchool_ExtenceCommand command)
        {
            int response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            int response = await _mediator.Send(new DeleteSchool_ExtenceCommand() { Id = id });

            return Ok(response);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int id)
        {
            var response = await _mediator.Send(new GetSchool_ExtenceByIdQuery() { Id = id });

            return Ok(response);
        }
    }
}
