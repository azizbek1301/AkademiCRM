using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Teacher_Educations.Queries;

namespace StudyCenter.Service.UseCases.Teacher_Educations.Handler
{
    public class GetAllTeacher_EducationHandler : IRequestHandler<GatAllTeacher_EducationQuery, List<Teacher_Education>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllTeacher_EducationHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Teacher_Education>> Handle(GatAllTeacher_EducationQuery request, CancellationToken cancellationToken)
        {
            var teacherEdu = await _context.Teacher_Educations.ToListAsync(cancellationToken);
            return teacherEdu;
        }
    }
}
