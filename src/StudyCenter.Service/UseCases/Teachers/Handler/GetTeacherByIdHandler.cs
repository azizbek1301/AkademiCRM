using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Teachers.Queries;

namespace StudyCenter.Service.UseCases.Teachers.Handler
{
    public class GetTeacherByIdHandler : IRequestHandler<GetTeacherByIdQuery, Teacher>
    {
        private readonly IApplicationDbContext _context;

        public GetTeacherByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Teacher> Handle(GetTeacherByIdQuery request, CancellationToken cancellationToken)
        {
            var teacher=await _context.Teachers.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);
            if (teacher == null)
                throw new Exception("Not Found");
            return teacher;
        }
    }
}
