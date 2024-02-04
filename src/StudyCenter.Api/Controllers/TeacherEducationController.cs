using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyCenter.Service.UseCases.Event.Command;
using StudyCenter.Service.UseCases.Event.Queries;
using StudyCenter.Service.UseCases.Teacher_Educations.Command;
using StudyCenter.Service.UseCases.Teacher_Educations.Queries;

namespace StudyCenter.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeacherEducationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TeacherEducationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(CreateTeacher_EducationCommand command)
        {
            int response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var response = await _mediator.Send(new GatAllTeacher_EducationQuery());

            return Ok(response);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(UpdateTeacher_EducationCommand command)
        {
            int response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            int response = await _mediator.Send(new DeleteTeacher_EducationCommand() { Id = id });

            return Ok(response);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int id)
        {
            var response = await _mediator.Send(new GetTeacher_EducationByIdQuery() { Id = id });

            return Ok(response);
        }
    }
}
