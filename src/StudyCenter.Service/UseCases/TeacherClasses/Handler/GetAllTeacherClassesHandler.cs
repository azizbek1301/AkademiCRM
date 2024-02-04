using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.TeacherClasses.Queries;

namespace StudyCenter.Service.UseCases.TeacherClasses.Handler
{
    public class GetAllTeacherClassesHandler : IRequestHandler<GetAllTeacherClassesQuery, List<TeacherClass>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllTeacherClassesHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TeacherClass>> Handle(GetAllTeacherClassesQuery request, CancellationToken cancellationToken)
        {
            var teacherStudent = await _context.TeacherClasses.ToListAsync(cancellationToken);

            if (teacherStudent.Count() == 0)
                throw new Exception("Not Found");
            return teacherStudent;
        }
    }
}
