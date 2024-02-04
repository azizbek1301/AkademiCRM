using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyCenter.Domain.Models;
using StudyCenter.Service.UseCases.Admins.Commands;
using StudyCenter.Service.UseCases.Admins.Queries;

namespace StudyCenter.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(CreateAdminCommand model)
        {
            int response = await _mediator.Send(model);
            return Ok(response);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var respons = await _mediator.Send(new GetAllAdminQuery());
            return Ok(respons);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(UpdateAdminCommand command)
        {
            int respons = await _mediator.Send(command);
            return Ok(respons);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int adminId)
        {
            int response = await _mediator.Send(new DeleteAdminCommand() { AdminId = adminId });

            return Ok(response);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int adminId)
        {
            Admin admin = await _mediator.Send(new GetAdminByIdQuery() { AdminId = adminId });

            return Ok(admin);
        }
    }
}
