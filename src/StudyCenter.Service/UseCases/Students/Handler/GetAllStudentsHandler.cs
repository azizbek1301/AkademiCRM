using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Students.Queries;

namespace StudyCenter.Service.UseCases.Students.Handler
{
    public class GetAllStudentsHandler : IRequestHandler<GetAllStudentsQuery, List<Student>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllStudentsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var res=await _context.Students.ToListAsync(cancellationToken);
            return res;
        }
    }
}
