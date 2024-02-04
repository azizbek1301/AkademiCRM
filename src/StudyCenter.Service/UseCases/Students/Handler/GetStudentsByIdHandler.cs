using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Students.Queries;

namespace StudyCenter.Service.UseCases.Students.Handler
{
    public class GetStudentsByIdHandler : IRequestHandler<GetStudentsByIdQuery, Student>
    {
        private readonly IApplicationDbContext _context;

        public GetStudentsByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Student> Handle(GetStudentsByIdQuery request, CancellationToken cancellationToken)
        {
            var student=await _context.Students.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);
            if(student==null)
            {
                throw new Exception("Not Found");
            }
            
             return student;
        }
    }
}
